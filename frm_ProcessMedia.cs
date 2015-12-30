using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YoutubeExtractor;
using TagLib;

namespace mediaDownloader
{
    public partial class frm_ProcessMedia : Form
    {
        private VideoDownloader mVideoDownloader;
        private Process ffmpegConvert;

        private const string sm = "\"";
        private bool doingThings = false;
        private bool requestedCancel = false;
        private string oldOperations = "";
        private Boolean oldRequiredDecipher = false;
        private bool downloadCompleted = false;


        public frm_ProcessMedia()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            this.lbl_Title.Parent = pic_Top;
            this.pic_ICO.Parent = pic_Top;
        }

        public void runStages()
        {
            process_Stage1();           

        }


        private void addLog(string Text, bool addDashLineAfter = false)
        {
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
            MessageBox.Show("An error occured downloading the video; The error has been dumped into the log TextBox.", "Plugin Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            lbl_Stage.Text = "Error Occurred";
            lbl_Desc.Text  = "Please see log below!";
            lbl_LargeHeading.Text = "?";


            doingThings = false;
            pic_INILOAD.Visible = false;
            grp_Download.Visible = false;
            lbl_DownloadETA.Visible = false;
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
            addLog("Cyano Media Downloader - Version: " + Program.versionCode + " Setting Version: " + pluginInstance.config.loadedVersion, false);
            addLog("New Task Initialized at " + DateTime.Now, true);
            addLog("Begin Stage 1: Initial Stages", false);
            addLog("URL: " + pluginInstance.details.url);


            oldRequiredDecipher = YoutubeExtractor.Decipherer.wasDecrypted;
            oldOperations = YoutubeExtractor.Decipherer.theOperationsToDo;

            if (pluginInstance.details.selectedResult.RequiresDecryption)
            {
                addLog("Signature incorrect - Deciphering Media URL...");
                DownloadUrlResolver.DecryptDownloadUrl(pluginInstance.details.selectedResult); //TODO: Run in async
                addLog("Operations: " + Decipherer.theOperationsToDo);
            }
            else
                addLog("Signature is correct, deciphering not required ");

            YoutubeExtractor.Decipherer.wasDecrypted = false;
            YoutubeExtractor.Decipherer.theOperationsToDo = "null";

            addLog("Stage 1 Complete...", true);
            tmr_DelayStage2.Enabled = true;

        }
        #endregion

        #region stage2

        private void process_Stage2()
        {
            doingThings = true;
            addLog("Begin Stage 2: Download Original File");
            describeStage(2, "Downloading Original File");

            try
            {


                if (pluginInstance.config.useTempFolder)
                {
                    pluginInstance.details.fullTempPath = (pluginInstance.config.tempFolder + @"\" + 
                        pluginInstance.details.fileName + pluginInstance.details.selectedResult.VideoExtension + ".tmp");
                    addLog("Config: UseTempFolder=True; Computed Temp File: " + pluginInstance.details.fullTempPath);
                }
                else
                {
                    pluginInstance.details.fullTempPath = (pluginInstance.details.downloadPath + @"\" + 
                        pluginInstance.details.fileName + pluginInstance.details.selectedResult.VideoExtension + ".tmp");
                    
                    addLog("Config: UseTempFolder=False; Computed Temp File: " + pluginInstance.details.fullTempPath);
                }

                pluginInstance.details.downloadPath = (pluginInstance.details.downloadPath + @"\" +
                        pluginInstance.details.fileName);


                addLog("Creating New VideoDownloader; Config: guiSmoothing=" + pluginInstance.config.smoothing);
                mVideoDownloader = new VideoDownloader(pluginInstance.details.selectedResult, 
                    pluginInstance.details.fullTempPath, pluginInstance.config.smoothing);

                mVideoDownloader.DownloadProgressChanged += (asend, args) => bkWork_DownloadVideo.ReportProgress(Convert.ToInt32(args.ProgressPercentage),
                  new ProgressEventArgs(args.ProgressPercentage, args.copiedBytes, args.contentLength, args.timeStart));

                addLog("Starting bkWork_DownloadVideo");
                grp_Download.Visible = true;
                lbl_DownloadETA.Visible = true;
                bkWork_DownloadVideo.RunWorkerAsync();

            }
            catch (Exception e)
            {
                throwErrorForm(e);
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
            grp_Download.Visible = false;
            lbl_DownloadETA.Visible = false;
            lbl_DownloadETA.Visible = false;
        }

        private void bkWork_DownloadVideo_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                mVideoDownloader.Execute();
                downloadCompleted = true;
            }
            catch (Exception ex)
            {
                throwErrorForm(ex);
                downloadCompleted = false; ;
            }
        }

        #endregion

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
                describeExtractType = "Converting File Format";

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
                addLog("Config: displayConsoleWindow=" + pluginInstance.config.displayConsole);
                ffmpegConvert = new Process();

                ffmpegConvert.StartInfo.UseShellExecute = true;
                ffmpegConvert.StartInfo.CreateNoWindow = pluginInstance.config.displayConsole;

                if (pluginInstance.config.displayConsole)
                     ffmpegConvert.StartInfo.WindowStyle = ProcessWindowStyle.Maximized; 
                else
                    ffmpegConvert.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                ffmpegConvert.StartInfo.FileName = pluginInstance.config.ffmpegPath;
                addLog("FFMPEG Process Path: " + ffmpegConvert.StartInfo.FileName);

                if (pluginInstance.config.extractAudio)
                {
                    if (pluginInstance.details.cropSelected)
                    {
                        addLog("[INFO] Extract Audio TRUE. Crop Selected TRUE", true);
                        ffmpegConvert.StartInfo.Arguments = (" -i " + sm + pluginInstance.details.fullTempPath + sm + " -vn -y -ss " + 
                            pluginInstance.details.startTime + " -to " + pluginInstance.details.endTime + " -acodec copy " + sm + pluginInstance.details.downloadPath+ sm);
                    }
                    else
                    {
                        addLog("[INFO] Extract Audio TRUE. Crop Selected FALSE", true);
                        ffmpegConvert.StartInfo.Arguments = (" -i " + sm + pluginInstance.details.fullTempPath + sm + " -vn -y -acodec copy " + 
                            sm + pluginInstance.details.downloadPath+ sm);
                    }
                }
                else
                {
                    if (pluginInstance.details.cropSelected)
                    {
                        addLog("[INFO] Extract Audio FALSE. Crop Selected TRUE", true);
                        ffmpegConvert.StartInfo.Arguments = (" -i " + sm + pluginInstance.details.fullTempPath + sm + " -vn -y -ss " + 
                            pluginInstance.details.startTime + " -to " + pluginInstance.details.endTime +
                            " -f mp3 -ab " + pluginInstance.config.bitRate + "k " + sm + pluginInstance.details.downloadPath + sm);
                    }
                    else
                    {
                        addLog("[INFO] Extract Audio FALSE. Crop Selected FALSE", true);
                        ffmpegConvert.StartInfo.Arguments = (" -i " + sm + pluginInstance.details.fullTempPath + sm + " -vn -y -f mp3 -ab " +
                            pluginInstance.config.bitRate + "k " + sm + pluginInstance.details.downloadPath + sm);
                    }
                }

                addLog("Process Arguments Set:" + ffmpegConvert.StartInfo.Arguments.ToString(), true);
                addLog("Temporary Path" + pluginInstance.details.fullTempPath);
                addLog("Download Path: " + pluginInstance.details.downloadPath, true);

                //Start and wait for process exit.
                ffmpegConvert.Start();
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
                addLog("Stage 3 Completed!");
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
                addLog("Stage 4 Ended.", true);
                tmr_DelayStage4.Enabled = true;
             //   processStage5();

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
                addLog("Stage 5 Ended!",true);
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

            try {
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

            if (pluginInstance.config.autoClosePlugin)
                this.Close(); 
        }
        #endregion

        private void tmr_DelayStage2_Tick(object sender, EventArgs e)
        {
            process_Stage2();
            tmr_DelayStage2.Enabled = false;

        }
        
        private void tmr_DelayStage4_Tick_1(object sender, EventArgs e)
        {
            processStage5();
            tmr_DelayStage4.Enabled = false;

        }

        private void frm_ProcessMedia_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (doingThings && but_Finish.Text == "Cancel")
            {
                DialogResult confirmCancel = MessageBox.Show("Are you sure you want to cancel?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmCancel == DialogResult.Yes)
                {

                    try
                    {
                        mVideoDownloader.DownloadProgressChanged += (asend, args) => args.Cancel = true;
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
