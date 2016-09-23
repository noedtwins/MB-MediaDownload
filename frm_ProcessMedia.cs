using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using System.Net;

namespace mediaDownloader
{
    public partial class frm_ProcessMedia : Form
    {
        private Downloader mDownloader;
        private Process ffmpegConvert;
        private Process rg3Process;

        private const string sm = "\"";
        private bool doingThings = false;
        private bool requestedCancel = false;
        private bool downloadCompleted = false;
        private string outputRG3 = "";

        public frm_ProcessMedia()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.lbl_Title.Parent = pic_Top;
            this.pic_ICO.Parent = pic_Top;

            if (pluginInstance.config.ontop)
                this.TopMost = true;
        }

        public void runStages()
        {
            addLog("Cyano Media Downloader - Version: " + Program.versionCode + " Setting Version: " + pluginInstance.config.loadedVersion, false);
            addLog("New Task Initialized at " + DateTime.Now, true);
            process_Stage1();
        }

        private void addLog(string Text, bool addDashLineAfter = false)
        {
            if (txt_ConvLog.TextLength > 30000)
                txt_ConvLog.Clear();

            txt_ConvLog.Text = txt_ConvLog.Text + Text + Environment.NewLine;
            if (addDashLineAfter)
            { txt_ConvLog.Text = txt_ConvLog.Text + "-------------------------------" + Environment.NewLine; }

            txt_ConvLog.SelectionStart = txt_ConvLog.TextLength;
            txt_ConvLog.ScrollToCaret();

        }

        private void describeStage(int stageNumber, string description, string LargeHeading = "Please Wait")
        {
            lbl_Stage.Text = "Stage " + stageNumber + " of 5";
            lbl_Desc.Text = description;
            lbl_LargeHeading.Text = LargeHeading;
        }

        private void throwErrorForm(Exception eSend)
        {
            MessageBox.Show(this, "An error occured downloading the video.\nThe error has been dumped into the log TextBox.", "Plugin Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            lbl_Stage.Text = "Error Occurred";
            lbl_Desc.Text = "Please see log below!";
            lbl_LargeHeading.Text = "Failed :(";
            this.Text = "Media Download Plugin: Process Media Failed!";


            doingThings = false;
            pic_INILOAD.Visible = false;
            grp_Download.Visible = false;
            lbl_DownloadETA.Visible = false;
            lbl_ManProg.Visible = false;
            pic_INILOAD.Visible = false;
            prg_Main.Visible = false;
            if (eSend != null)
                txt_ConvLog.Text = txt_ConvLog.Text + Environment.NewLine + eSend.Message;
            else
                txt_ConvLog.Text = txt_ConvLog.Text + Environment.NewLine + " <Unknown Error>";

            txt_ConvLog.SelectionStart = txt_ConvLog.TextLength;
            txt_ConvLog.ScrollToCaret();

        }

        private void but_Finish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region stage1
        private void process_Stage1()
        {
            addLog("Begin Stage 1: Initial Stages", false);
            addLog("URL: " + pluginInstance.details.url);
            describeStage(1, "Finding Download URL...");

            pic_INILOAD.Visible = true;
            prg_Main.Visible = false;
            lbl_ManProg.Visible = false;

            try
            {
                findDownloadURL();
            }
            catch (Exception e)
            {
                throwErrorForm(e);
            }

            addLog("Stage 1 Complete...", true);
        }

        #endregion

        #region stage2

        private void process_Stage2()
        {
            doingThings = true;
            addLog("Begin Stage 2: Download Original File");
            addLog("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            addLog("WARNING - THE URL BELOW MAY CONTAIN YOUR IP ADDRESS!");
            addLog("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");

            addLog("Output Value: " + outputRG3, true);
            describeStage(2, "Downloading Original File...");
            pic_INILOAD.Visible = false;
            prg_Main.Visible = true;
            lbl_ManProg.Visible = true;

            pluginInstance.details.downloadPath = (pluginInstance.details.downloadPath + @"\" + pluginInstance.details.fileName);
            pluginInstance.details.fullTempPath = (pluginInstance.details.downloadPath + ".tmp");

            addLog("Temporary File Path : " + pluginInstance.details.fullTempPath);
            addLog("Creating New Downloader Object...");
            addLog(" Information: GUISmoothing is forced enabled in this version!");

            mDownloader = new Downloader(outputRG3, pluginInstance.details.fullTempPath);

            mDownloader.DownloadProgressChanged += (asend, args) => bkWork_DownloadVideo.ReportProgress(Convert.ToInt32(args.ProgressPercentage),
              new ProgressEventArgs(args.ProgressPercentage, args.copiedBytes, args.contentLength, args.timeStart));

            addLog("Starting bkWork_DownloadVideo");
            grp_Download.Visible = true;
            lbl_DownloadETA.Visible = true;
            bkWork_DownloadVideo.RunWorkerAsync();
        }

        private void findDownloadURL()
        {
            addLog("Finding Download URL using RG3...");
            addLog("Starting bkWork_GetURLRG3");

            bkWork_GetURLRG3.RunWorkerAsync();

        }

        private void bkWork_GetURLRG3_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                addLog("", true);
                addLog("Preparing RG3 Youtube-DL Process", true);

                rg3Process = new Process();
                rg3Process.StartInfo.UseShellExecute = false;
                rg3Process.StartInfo.RedirectStandardOutput = true;
                rg3Process.StartInfo.RedirectStandardError = true;
                rg3Process.EnableRaisingEvents = true;
                rg3Process.StartInfo.CreateNoWindow = true;

                rg3Process.ErrorDataReceived += rg3Process_DataReceived;
                rg3Process.OutputDataReceived += rg3Process_DataReceived;

                rg3Process.StartInfo.FileName = pluginInstance.config.rg3Path;
                addLog("RG3 Process Path: " + rg3Process.StartInfo.FileName);

                string args = sm + pluginInstance.details.url + sm + pluginInstance.config.rg3Args + " -f " + pluginInstance.details.formatCode + " --get-url";
                rg3Process.StartInfo.Arguments = (args);
                addLog("Process Arguments Set:" + rg3Process.StartInfo.Arguments.ToString(), true);

                //Start and wait for process exit.
                rg3Process.Start();

                addLog("Process Started!");
                addLog("Waiting for process to end before continuing...");
                addLog("Process Information. PID:" + rg3Process.Id);

                rg3Process.BeginErrorReadLine();
                rg3Process.BeginOutputReadLine();

                rg3Process.WaitForExit();

            }
            catch (Exception ex)
            {
                throwErrorForm(ex);
            }
        }

        private void rg3Process_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                outputRG3 = e.Data;
                addLog(e.Data);

            }
        }

        private void bkWork_GetURLRG3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (requestedCancel)
            {
                try
                {
                    addLog("Requested Cancel");
                    rg3Process.Close();
                }
                catch { }
                return;
            }

            process_Stage2();
        }


        private void bkWork_DownloadVideo_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                mDownloader.Execute();
                downloadCompleted = true;
            }
            catch (WebException ex)
            {
                var response = (HttpWebResponse)ex.Response;

                if (response.StatusCode == HttpStatusCode.Forbidden)
                    handle403Error(ex);
                else
                {
                    addLog("Web Exception!");
                    throwErrorForm(ex);
                    downloadCompleted = false;
                }
            }
            catch (Exception ex)
            {
                throwErrorForm(ex);
                downloadCompleted = false; ;
            }
        }
        
        private void bkWork_DownloadVideo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressEventArgs realArgs = (ProgressEventArgs)e.UserState;
            int progress = Convert.ToInt32(realArgs.ProgressPercentage);
            this.prg_Main.Value = progress;
            lbl_ManProg.Text = progress + "%";
            lbl_TRate.Text = "Transfer Rate: " + realArgs.transferRate.ToString();
            lbl_DownloadETA.Text = "Estimated Time Remaining: " + realArgs.valOfEta();
            lbl_Size.Text = "Recieved: " + realArgs.formated_Recieved() + " of " + realArgs.formated_TotalGet();
        }

        private void bkWork_DownloadVideo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            grp_Download.Visible = false;
            lbl_DownloadETA.Visible = false;

            if (downloadCompleted == true)
            {
                addLog("Download Completed!", true);
                addLog("bkWork_DownloadVideo Ended");
                lbl_ManProg.Visible = false;

                if (pluginInstance.details.addMBMode == "video")
                { processStage3_video(); }
                else
                { processStage3_audio(); }

            }
        }


        #endregion

        private void handle403Error(WebException exception)
        {
            //TODO: IMPROVE MESSAGE
            addLog("", true);
            addLog("Download Failed... HTTP Response: 403");
            addLog("The signature algorithm has likely changed. Falling Back To RG3 Downloader...");
            FallBackRG3Download();


        }

        private void FallBackRG3Download()
        {
            addLog("", true);
            addLog("Preparing RG3 Youtube-DL Process For Download", true);
            bkWork_RG3Download.RunWorkerAsync();           
        }


        private void bkWork_RG3Download_DoWork(object sender, DoWorkEventArgs e)
        {
            rg3Process = new Process();
            rg3Process.StartInfo.UseShellExecute = false;
            rg3Process.StartInfo.RedirectStandardOutput = true;
            rg3Process.StartInfo.RedirectStandardError = true;
            rg3Process.EnableRaisingEvents = true;
            rg3Process.StartInfo.CreateNoWindow = true;

            rg3Process.ErrorDataReceived += rg3Process_DataReceived;
            rg3Process.OutputDataReceived += rg3Process_DataReceived;

            rg3Process.StartInfo.FileName = pluginInstance.config.rg3Path;
            addLog("RG3 Process Path: " + rg3Process.StartInfo.FileName);

            string args = sm + pluginInstance.details.url + sm + pluginInstance.config.rg3Args + " -f " + pluginInstance.details.formatCode + " -o " +
                sm + pluginInstance.details.fullTempPath + sm;
            rg3Process.StartInfo.Arguments = (args);
            addLog("Process Arguments Set:" + rg3Process.StartInfo.Arguments.ToString(), true);
            prg_Main.Visible = false;
            lbl_ManProg.Text = "--";
            lbl_DownloadETA.Visible = true;
            lbl_DownloadETA.Text = "RG3 Download Fallback... See Log for Progress";
            pic_INILOAD.Visible = true;

            //Start and wait for process exit.
            rg3Process.Start();

            addLog("Process Started!");
            addLog("Waiting for process to end before continuing...");
            addLog("Process Information. PID:" + rg3Process.Id);

            rg3Process.BeginErrorReadLine();
            rg3Process.BeginOutputReadLine();

            rg3Process.WaitForExit();
            downloadCompleted = true;
        }

        private void bkWork_RG3Download_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            grp_Download.Visible = false;
            lbl_DownloadETA.Visible = false;

            if (downloadCompleted == true)
            {
                addLog("Download Completed!", true);
                addLog("bkWork_RG3Download Ended");
                lbl_ManProg.Visible = false;

                if (pluginInstance.details.addMBMode == "video")
                { processStage3_video(); }
                else
                { processStage3_audio(); }

            }
        }

        #region stage3
        private void processStage3_audio()
        {
            addLog("Begin Stage 3: Extract Audio");

            string describeExtractType;
            prg_Main.Value = 0;
            pic_INILOAD.Visible = true;
            prg_Main.Visible = false;

            addLog("Config: extractAudioStream=" + pluginInstance.config.extractAudio);
            if (pluginInstance.config.extractAudio)
                describeExtractType = "Extracting audio stream...";
            else
                describeExtractType = "Converting File Format...";

            describeStage(3, describeExtractType);
            addLog("Starting bkWork_ConvertVideo");
            bkWork_ConvertVideo.RunWorkerAsync();
        }

        private void processStage3_video()
        {
            addLog("Begin Stage 3: Video Conversion Mode");

            describeStage(3, "Moving Files...");
            prg_Main.Visible = false;
            lbl_ManProg.Visible = false;
            pic_INILOAD.Visible = true;

            try
            {
                addLog("Video Conversion Mode.");
                pluginInstance.details.downloadPath = (pluginInstance.details.downloadPath + @"\" + pluginInstance.details.fileName);
                addLog("Computed DownloadPath: " + pluginInstance.details.downloadPath);
                System.IO.File.Move(pluginInstance.details.fullTempPath, pluginInstance.details.downloadPath);
                //mLogic.API.Library_AddFileToLibrary(fullMainPath, Plugin.LibraryCategory.Inbox);
                addLog("System.IO.File.Move(" + pluginInstance.details.fullTempPath + " , " + pluginInstance.details.downloadPath + ")");
                addLog("Stage 3 Completed!");

                processFinish();
            }
            catch (Exception e)
            { throwErrorForm(e); }
        }

        private void bkWork_ConvertVideo_DoWork(object sender, DoWorkEventArgs e)
        {
            if (requestedCancel)
            {
                e.Cancel = true;
                return;
            }

            try
            {
                addLog("New Conversion Task" + DateTime.Now);
                ffmpegConvert = new Process();

                if (pluginInstance.config.ffmpegOutput == "Console")
                {
                    ffmpegConvert.StartInfo.CreateNoWindow = false;
                }    
                else if (pluginInstance.config.ffmpegOutput == "Pipe")
                {
                    ffmpegConvert.StartInfo.UseShellExecute = false;
                    ffmpegConvert.StartInfo.RedirectStandardOutput = true;
                    ffmpegConvert.StartInfo.RedirectStandardError = true;
                    ffmpegConvert.EnableRaisingEvents = true;
                    ffmpegConvert.StartInfo.CreateNoWindow = true;

                    ffmpegConvert.ErrorDataReceived += ffmpegOutput_DataReceived;
                    ffmpegConvert.OutputDataReceived += ffmpegOutput_DataReceived;
                }
                else
                {
                    ffmpegConvert.StartInfo.UseShellExecute = false;
                    ffmpegConvert.StartInfo.CreateNoWindow = true;
                }


                ffmpegConvert.StartInfo.FileName = pluginInstance.config.ffmpegPath;
                addLog("FFMPEG Process Path: " + ffmpegConvert.StartInfo.FileName);

                if (pluginInstance.config.extractAudio)
                {
                    if (pluginInstance.details.cropSelected)
                    {
                        addLog("[INFO] Extract Audio TRUE. Crop Selected TRUE", true);
                        ffmpegConvert.StartInfo.Arguments = (" -i " + sm + pluginInstance.details.fullTempPath + sm + " -vn -y -ss " +
                            pluginInstance.details.startTime + " -to " + pluginInstance.details.endTime + " -acodec copy " + sm + pluginInstance.details.downloadPath + sm);
                    }
                    else
                    {
                        addLog("[INFO] Extract Audio TRUE. Crop Selected FALSE", true);
                        ffmpegConvert.StartInfo.Arguments = (" -i " + sm + pluginInstance.details.fullTempPath + sm + " -vn -y -acodec copy " +
                            sm + pluginInstance.details.downloadPath + sm);
                    }
                }
                else
                {
                    if (pluginInstance.details.cropSelected)
                    {
                        addLog("[INFO] Extract Audio FALSE. Crop Selected TRUE", true);
                        ffmpegConvert.StartInfo.Arguments = (" -i " + sm + pluginInstance.details.fullTempPath + sm + " -vn -y -ss " +
                            pluginInstance.details.startTime + " -to " + pluginInstance.details.endTime +
                            " -f mp3 -ab " + pluginInstance.details.convertToBitRate + "k " + sm + pluginInstance.details.downloadPath + sm);
                    }
                    else
                    {
                        addLog("[INFO] Extract Audio FALSE. Crop Selected FALSE", true);
                        ffmpegConvert.StartInfo.Arguments = (" -i " + sm + pluginInstance.details.fullTempPath + sm + " -vn -y -f mp3 -ab " +
                            pluginInstance.details.convertToBitRate + "k " + sm + pluginInstance.details.downloadPath + sm);
                    }
                }

                addLog("Process Arguments Set:" + ffmpegConvert.StartInfo.Arguments.ToString(), true);
                addLog("Temporary Path" + pluginInstance.details.fullTempPath);
                addLog("Download Path: " + pluginInstance.details.downloadPath, true);

                //Start and wait for process exit.
                ffmpegConvert.Start();
                if (pluginInstance.config.ffmpegOutput == "Pipe")
                {
                    ffmpegConvert.BeginErrorReadLine();
                    ffmpegConvert.BeginOutputReadLine();
                }
                addLog("Process Started!");
                addLog("Waiting for process to end before continuing...");
                addLog("Process Information. PID:" + ffmpegConvert.Id);
               
                ffmpegConvert.WaitForExit();
            }

            catch (Exception ex)
            {
                throwErrorForm(ex);
            }
        }

        private void ffmpegOutput_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
                addLog(e.Data);
        }



        private void bkWork_ConvertVideo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (requestedCancel)
            {
                try
                {
                    addLog("Requested Cancel");
                    ffmpegConvert.Close();
                }
                catch { }
                return;
            }

            if (System.IO.File.Exists(pluginInstance.details.downloadPath)) //If file exists, conversion exists otherwise not.
            {
                addLog("Process Exited - Conversion Finished");
                addLog("Stage 3 Completed!", true);
                processStage4();
            }
            else
            {
                addLog(pluginInstance.details.downloadPath + " does not exist - Conversion Failed, Process canceled!");
                throwErrorForm(e.Error);

            }
        }
        #endregion

        #region stage4
        private void processStage4()
        {
            describeStage(4, "Tagging File MetaData...");
            addLog("Begin Stage 4: Tag Metadata");
            try
            {
                addLog("Using TagLib To Tag Files...");
                TagLib.File tagFile = TagLib.File.Create(pluginInstance.details.downloadPath);
                addLog("Field Title. Value:" + pluginInstance.details.titleTag);
                tagFile.Tag.Title = pluginInstance.details.titleTag;

                addLog("Field Artist (Performers). Value: " + pluginInstance.details.artistTag);
                string[] artist = { pluginInstance.details.artistTag };
                tagFile.Tag.Performers = artist;

                addLog("Field Album. Value: " + pluginInstance.details.albumTag);
                tagFile.Tag.Album = pluginInstance.details.albumTag;

                addLog("Config: addTagComment=" + pluginInstance.config.addComment);

                if (pluginInstance.config.addComment)
                {
                    string buildTagComment = "";
                    if (pluginInstance.config.addCTagPlugInfo)
                    { buildTagComment = buildTagComment + "Converted using Media Download Plugin. By Cyano" + Environment.NewLine; }
                    if (pluginInstance.config.addCTagDateTime)
                    { buildTagComment = buildTagComment + DateTime.Now + Environment.NewLine; }
                    if (pluginInstance.config.addCTagSource)
                    { buildTagComment = buildTagComment + pluginInstance.details.url + Environment.NewLine; }
                    if (pluginInstance.config.addCTagCustomText)
                    { buildTagComment = buildTagComment + pluginInstance.config.addCTagCustomTextVal + Environment.NewLine; }

                    addLog("Field Comment. Value: " + buildTagComment);
                    tagFile.Tag.Comment = buildTagComment;
                }
                tagFile.Save();
                addLog("Saving Tagged File ");
                processStage5();

            }

            catch (Exception e)
            { throwErrorForm(e); }

        }
        #endregion

        #region stage5
        private void processStage5()
        {
            describeStage(5, "Finalizing Stages...");
            addLog("Stage 5: Finalizing Stages.");
            try
            {
                doingThings = false;

                addLog("Config: preventDeleteTempFiles=" + pluginInstance.config.preventDelTempFiles);

                if (!pluginInstance.config.preventDelTempFiles)
                {
                    addLog("Delete File: " + pluginInstance.details.fullTempPath);
                    System.IO.File.Delete(pluginInstance.details.fullTempPath);
                    addLog("File Deleted Successfully!");
                }

                addToMB();
                addLog("Stage 5 Ended!", true);
                processFinish();

            }
            catch (Exception e)
            {
                throwErrorForm(e);

            }
        }

        private void addToMB()
        {
            if (Program.isStandaloneMode)
            {
                addLog("MusicBee API unavailable");
                return;
            }

            try
            {
                if (pluginInstance.details.moveTo == moveType.inbox)
                {
                    addLog("Adding to MusicBee: Inbox (API)");
                    pluginInstance.getAPI().getInterface().Library_AddFileToLibrary(pluginInstance.details.downloadPath, MusicBeePlugin.Plugin.LibraryCategory.Inbox);
                    pluginInstance.getAPI().getInterface().MB_RefreshPanels();
                }
                if (pluginInstance.details.moveTo == moveType.library)
                {
                    addLog("Adding to MusicBee: Library (API)");
                    pluginInstance.getAPI().getInterface().Library_AddFileToLibrary(pluginInstance.details.downloadPath, MusicBeePlugin.Plugin.LibraryCategory.Music);
                    pluginInstance.getAPI().getInterface().MB_RefreshPanels();
                }
                if (pluginInstance.details.moveTo == moveType.none)
                {
                    addLog("File not added to MusicBee.");
                    return;
                }
            }

            catch (Exception e)
            {
                addLog("Failed to interact with MusicBee API! Error Dump: " + e);
            }
        }

        #endregion


        #region stageFinish

        private void processFinish()
        {
            addLog("Task Completed. At " + DateTime.Now);
            but_ConvertAgain.Visible = true;
            lbl_ManProg.Visible = false;
            pic_INILOAD.Visible = false;
            but_Finish.Text = "Exit Plugin";
            describeStage(99, "Click the button below to convert another video\n or exit the plugin.", "File Completed!");
            lbl_Stage.Text = "File Completed!";
            this.Text = "Media Download Plugin: Process Finished!";

            if (pluginInstance.config.autoClosePlugin)
            {
                this.Close();
                MessageBox.Show("Media Downloader Plugin downloaded & converted the media file successfully!", "Plugin Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        private void frm_ProcessMedia_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (doingThings && but_Finish.Text == "Cancel")
            {
                DialogResult confirmCancel = MessageBox.Show(this, "Are you sure you want to cancel?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmCancel == DialogResult.Yes)
                {

                    try
                    {
                        mDownloader.DownloadProgressChanged += (asend, args) => args.Cancel = true;
                        requestedCancel = true;
                        bkWork_DownloadVideo.CancelAsync();
                    }
                    catch { }
                    try
                    {
                        requestedCancel = true;
                        bkWork_ConvertVideo.CancelAsync();
                        ffmpegConvert.Kill();
                    }
                    catch { }

                }
                else
                {
                    e.Cancel = true;
                    return;
                }

            }
            pluginInstance.closeApplication();
            this.Dispose();
        }

        private void but_ConvertAgain_Click(object sender, EventArgs e)
        {
            pluginInstance.reloadPlugin();
            this.Dispose();
        }

    }
}
