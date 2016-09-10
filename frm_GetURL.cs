using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace mediaDownloader
{
    public partial class frm_GetURL : Form
    {
        private bool requestedRestart = false; 
        private bool focusedAutoPasted = false; //Prevent pasting the same URL twice
        private bool closeEntirePlugin = true; //Close entire plugin if user has requested close.

        private Process rg3Process;
        private bool isError = false;
        private string outputLog = "";
        private string runningArgument = "";

        private ContextMenuStrip overflowMenu = new ContextMenuStrip(); //For the Overflow Menu button
       
        public frm_GetURL()
        {
            InitializeComponent();
            this.AcceptButton = but_NextStage;
            initMBCustom();

            if (pluginInstance.config.ontop)
                this.TopMost = true;
        }

        private void but_ContStage_Click(object sender, EventArgs e)
        {
            //Lock the controls whilst the media is querying
            but_Previous.Enabled = false;
            grp_Info.Visible = false;
            grp_loadingbar.Visible = true;
            but_ContStage.Enabled = false;
            txt_MediaURL.Enabled = false;
            but_MoreOptions.Enabled = false;

            if (!ParseURL.TryNormalizeYoutubeUrl(txt_MediaURL.Text, out pluginInstance.details.url)) //If Invalid URL
            {
                MessageBox.Show(this, "There was an error normalizing the URL." + Environment.NewLine + "Please check your entry", "Plugin Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                stageReset();
                return;
            }
            else
            {
                but_ContStage.Visible = false;
                findTitle();
            }
        }

        private void stageReset() //Restart this stage by unlocking all controls and restoring default values
        {
            grp_VidDetails.Visible = false;
            pic_Thumb.Image = Properties.Resources.ajaxLoad;
            grp_loadingbar.Visible = false;
            but_ContStage.Enabled = true;
            but_MoreOptions.Enabled = true;
            txt_MediaURL.Enabled = true;
            but_Previous.Enabled = true;
            but_Reset.Visible = false;
            but_NextStage.Visible = false;
            outputLog = "";

            if (bk_UseRG3.IsBusy)
            {
                requestedRestart = true;
                bk_UseRG3.CancelAsync();
            }

            but_ContStage.Visible = true;
        }
        
        private void setThumbnailPicture(string thumbURL)
        {
            //TODO: Add Timeout
            try
            {
                pic_Thumb.Load(thumbURL);
                pluginInstance.details.cachedThumb = pic_Thumb.Image; //Store the image for future use.

            }
            catch
            {
                MessageBox.Show(this, "Error loading Media Thumbnail!", "Plugin Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void but_NextStage_Click(object sender, EventArgs e)
        {
            pluginInstance.details.cropSelected = false; //Init
            closeEntirePlugin = false;
            pluginInstance.gotoSaveFile();
        }

        private void but_Reset_Click(object sender, EventArgs e)
        { 
            stageReset();
        }

        private void but_MoreOptions_Click(object sender, EventArgs e) //Overflow menu (incase shortcut keys aren't working)
        {
            overflowMenu.Items.Clear();
            overflowMenu.Items.Add("Paste from clipboard", null, mnu_PasteClipBoard);

            overflowMenu.Show(but_MoreOptions, 0, but_MoreOptions.Height);
        }

        private void mnu_PasteClipBoard(object sender, EventArgs e) //Event-Handler for paste from clipboard button
        {
            txt_MediaURL.Text = Clipboard.GetText();
        }

        private void txt_MediaURL_Leave(object sender, EventArgs e)
        {
            if (txt_MediaURL.Text == "")
            { txt_MediaURL.Text = "Insert URL Here..."; }
        }

        private void txt_MediaURL_Enter(object sender, EventArgs e)
        {
            if (txt_MediaURL.Text == "Insert URL Here...")
            { txt_MediaURL.Text = ""; }
        }

        private void loadURLFromClipboard()
        {
            if (pluginInstance.config.autoPasteURL && !focusedAutoPasted)
            {
                string compareString = Clipboard.GetText();
                if (compareString.Contains("youtube"))
                {
                    focusedAutoPasted = true;
                    txt_MediaURL.Text = Clipboard.GetText();
                    trm_AutoPressButton.Enabled = true;

                    if (!pluginInstance.config.clipboardMessageShown)
                    {
                        MessageBox.Show("Media Downloader: A valid media URL was in your clipboard and has automatically been pasted\nYou can turn this function off in the plugin settings\n" +
                            "This message will not show again.", "Plugin Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pluginInstance.config.clipboardMessageShown = true;
                        pluginInstance.config.saveSettings(pluginInstance.config, true);
                    }
                    
                }

            }
        }

        private void but_Previous_Click(object sender, EventArgs e)
        {
            pluginInstance.gotoSplashScreen(false);
            closeEntirePlugin = false;
            this.Close();
        }

        private void frm_GetURL_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bk_UseRG3.IsBusy)
                bk_UseRG3.CancelAsync(); 

            if (closeEntirePlugin == true)
                pluginInstance.closeApplication(); 
        }

        private void throwRG3Error()
        {
            MessageBox.Show(this, "There was an error retrieving the Media Information.\nPlease check the link is still active and available in your country?\n" +
                     "Alternatively please contact Cyano with the following output:\n\n" + outputLog, "Plugin Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            but_Reset.Visible = true;
            grp_loadingbar.Visible = false;
        }

        private void findTitle()
        {
            runningArgument = " --get-title";
            lbl_Process.Text = "Retrieving Media Details...";
            bk_UseRG3.RunWorkerAsync();
        }

        private void findThumbnail()
        {
            runningArgument = " --get-thumbnail";
            lbl_Process.Text = "Getting Thumbnail URL...";
            bk_UseRG3.RunWorkerAsync();
        }

        private void findBestAudioFormat()
        {
            runningArgument = " -f bestaudio --get-format";
            lbl_Process.Text = "Searching Audio Formats...";
            bk_UseRG3.RunWorkerAsync();
        }

        private void completeRG3Tasks()
        {
            pluginInstance.details.title = lbl_VideoTitle.Text;
            grp_VidDetails.Visible = true;
            grp_loadingbar.Visible = false;
            but_ContStage.Enabled = false;
            but_Reset.Visible = true;
            but_Previous.Enabled = true;
            but_NextStage.Visible = true;
            but_NextStage.Select();
            but_NextStage.Focus();
        }


        private void bk_UseRG3_DoWork(object sender, DoWorkEventArgs e)
        {
            try {
                rg3Process = new Process();
                rg3Process.StartInfo.UseShellExecute = false;
                rg3Process.StartInfo.RedirectStandardOutput = true;
                rg3Process.StartInfo.RedirectStandardError = true;
                rg3Process.EnableRaisingEvents = true;
                rg3Process.StartInfo.CreateNoWindow = true;

                rg3Process.ErrorDataReceived += rg3Process_DataReceived;
                rg3Process.OutputDataReceived += rg3Process_DataReceived;

                rg3Process.StartInfo.FileName = pluginInstance.config.rg3Path;

                string sm = "\"";
                string args = sm + txt_MediaURL.Text + sm + pluginInstance.config.rg3Args + runningArgument;
                Debug.Print(args);

                rg3Process.StartInfo.Arguments = (args);

                //Start and wait for process exit.
                rg3Process.Start();
                rg3Process.BeginErrorReadLine();
                rg3Process.BeginOutputReadLine();

                rg3Process.WaitForExit();
            }
            catch
            {
                throwRG3Error();
            }
        }

        private void rg3Process_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
                outputLog = e.Data;
        }

        private void rg3ProcessError_DataReceived(object sender, DataReceivedEventArgs e)
        {
            isError = true;

            if (e.Data != null)
                outputLog = e.Data;
        }

        private void bk_UseRG3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled && requestedRestart) //So the user can complete this stage more than once.
            {
                requestedRestart = false;
                bk_UseRG3.RunWorkerAsync();
            }

            if (isError || runningArgument.Contains("ERROR:"))
                throwRG3Error();
            else
            {
                if (runningArgument.Contains("title"))
                {
                    Debug.Write(outputLog);
                    lbl_VideoTitle.Text = outputLog;
                    findThumbnail();
                }
                else if (runningArgument.Contains("thumbnail"))
                {
                    Debug.Write(outputLog);
                    setThumbnailPicture(outputLog);
                    findBestAudioFormat();
                }
                else if (runningArgument.Contains("format"))
                {
                    Debug.Write(outputLog);
                    lbl_FormatNumber.Text = "Format Selected: " + outputLog;
                    try {
                        pluginInstance.details.formatCode = Convert.ToInt32(outputLog.Substring(0, outputLog.IndexOf(' ')));
                        completeRG3Tasks();
                    }
                    catch
                    {
                        throwRG3Error();
                    }
                }
            }
        }

        private void frm_GetURL_Enter(object sender, EventArgs e)
        {
            loadURLFromClipboard();
        }

        private void frm_GetURL_Activated(object sender, EventArgs e)
        {
            loadURLFromClipboard();
        }

        private void trm_AutoPressButton_Tick(object sender, EventArgs e)
        {
            if (txt_MediaURL.Text != "Insert URL Here...")
            {
                but_ContStage.PerformClick();
            }
            trm_AutoPressButton.Enabled = false;

        }
    }
}
