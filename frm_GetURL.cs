using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YoutubeExtractor;

namespace mediaDownloader
{
    public partial class frm_GetURL : Form
    {
        private bool mMessageDisplayed; //Has the Invalid Format alredy been displayed. Obsolete?
        private int mSelectedFormat = -1; //Selected Format in the list (-1 is null/error)
        private bool requestedRestart = false; 
        private bool focusedAutoPasted = false; //Prevent pasting the same URL twice
        private bool closeEntirePlugin = true; //Close entire plugin if user has requested close.


        private ContextMenuStrip overflowMenu = new ContextMenuStrip(); //For the Overflow Menu button
       
        public frm_GetURL()
        {
            InitializeComponent();
            this.lbl_Title.Parent = pic_Top;
            this.pic_ICO.Parent = pic_Top;
        }

        public Boolean checkForValidURL(String checkURL) //Checks if the URL is Valid
        {
            try
            {
                if (DownloadUrlResolver.TryNormalizeYoutubeUrl(txt_MediaURL.Text, out pluginInstance.details.url))
                   return true;
               else
                   return false; 
            }
            catch
            {          
                return false;
            }
        }

        private void stageReset() //Restart this stage by unlocking all controls and restoring default values
        {
            mSelectedFormat = -1;
            grp_VidDetails.Visible = false;
            pic_Thumb.Image = Properties.Resources.ajaxLoad;
            pic_InfLoad.Visible = false;
            but_ContStage.Enabled = true;
            but_MoreOptions.Enabled = true;
            txt_MediaURL.Enabled = true;
            but_Previous.Enabled = true;
            but_Reset.Visible = false;
            but_NextStage.Visible = false;

            if (bk_QueryFormats.IsBusy)
            {
                requestedRestart = true;
                bk_QueryFormats.CancelAsync();
                flow_DownRdoButtons.Controls.Clear();
            }

            flow_DownRdoButtons.Controls.Clear();
            but_ContStage.Visible = true;

        }


        private void but_ContStage_Click(object sender, EventArgs e)
        {
            //Lock the controls whilst the media is querying
            but_Previous.Enabled = false;
            grp_Info.Visible = false;
            pic_InfLoad.Visible = true;
            but_ContStage.Enabled = false;
            txt_MediaURL.Enabled = false;
            but_MoreOptions.Enabled = false;

            if (!checkForValidURL(txt_MediaURL.Text)) //If Invalid URL
            {
                MessageBox.Show("There was an error normalizing the URL." + Environment.NewLine + "Please check your entry", "Plugin Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                stageReset();
                return;
            }
            else
            {
                but_ContStage.Visible = false;
                bk_QueryFormats.RunWorkerAsync(); //Get list of valid formats in another thread.
             }
        }

        private void bk_QueryFormats_DoWork(object sender, DoWorkEventArgs e)
        {
            //Get a list of formats avaliable to download.
            pluginInstance.details.results = DownloadUrlResolver.GetDownloadUrls(txt_MediaURL.Text);
        }

        private void bk_QueryFormats_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            addValidFormatsToPanel(); //Add the list of formats to the panel.

            if (e.Cancelled && requestedRestart) //So the user can complete this stage more than once.
            {
                requestedRestart = false;
                bk_QueryFormats.RunWorkerAsync();
            }

            but_Previous.Enabled = true;    

        }

        private void addValidFormatsToPanel() //Adds all the valid formats to a list
        {
            int curSelection = 0;
            int amountOfFormats = countAmountValidFormats(); //Count how many valid formats there are.

            if (amountOfFormats == 0) //If zero formats.
            {
                displayNoFormatMsg();
                return;
            }

            RadioButton highestQualityRadioButton = null;

            foreach (VideoInfo item in pluginInstance.details.results)
            {

                if (item.AdaptiveType == AdaptiveType.None &&
                    item.VideoType != VideoType.Unknown && item.VideoType != VideoType.WebM) //Only supported formats to add

                {
                    pluginInstance.details.title = item.Title;
                    RadioButton selButton = new RadioButton(); //New Control for each format

                    selButton.Name = "rdo_But_" + item.FormatCode;
                    selButton.Text = "Video Type: " + item.VideoType + " || Video Resolution: " + item.Resolution + " || Audio BitRate: " +
                        item.AudioBitrate + " || Audio Extension: " + item.AudioType;

                    selButton.Width = 462; //NOTE: Should be auto fill?
                    selButton.Click += new EventHandler(formatRdoClick); //Add Click Handler

                    flow_DownRdoButtons.Controls.Add(selButton); //Add Control to flow layout

                    if (highestQualityRadioButton == null) //Auto-Select the Highest Quality Format
                        highestQualityRadioButton = selButton;

                    curSelection++; //Increment ID for RadioButton

                }
            }

            displayFormatControls(highestQualityRadioButton);
        }

        private int countAmountValidFormats() //Count how many VALID formats have been found
        {
            int validFound = 0;
            try
            {
                foreach (VideoInfo theVideoInfo in pluginInstance.details.results) 
                {
                    if (theVideoInfo.AdaptiveType == AdaptiveType.None &&
                        theVideoInfo.VideoType != VideoType.Unknown && theVideoInfo.VideoType != VideoType.WebM) //Ignore Invalid Formats.
                    { validFound++; }

                }

                lbl_FormatCount.Text = "Discovered Valid Formats: " + validFound;
                return validFound;
            }

            catch
            { return 0; }
        }

        private void displayNoFormatMsg() //Display No Formats Avaliable Format
        {
            //TODO: Add better debug message
            if (!mMessageDisplayed)
            {
                mMessageDisplayed = true;
                MessageBox.Show("No formats found for this media." + Environment.NewLine + "Is the link still active in your country?" + Environment.NewLine +
                     "Post link on plugin forum page if you are still having errors", "Plugin Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                but_Reset.Visible = true;
                pic_InfLoad.Visible = false;
                return;
            }
            else { return; }
        }


        private void formatRdoClick(object sender, EventArgs e) //Event-Handler when the user selects another format
        {
            RadioButton clickedButton = (RadioButton)sender; //Identify which radiobutton clicked]
            clickedButton.Checked = true;

            string rdoFormatCode;
            rdoFormatCode = clickedButton.Name.Substring(8); //Removes first 8 characters
            mSelectedFormat = Convert.ToInt32(rdoFormatCode); //This leave the format number.

        }

        private void displayFormatControls(RadioButton highestQuality = null)
        {
            getThumbPic();
            lbl_VideoTitle.Text = pluginInstance.details.title;
            grp_VidDetails.Enabled = true;
            grp_VidDetails.Visible = true;
            pic_InfLoad.Visible = false;
            flow_DownRdoButtons.Visible = true;
            but_Reset.Visible = true;
            but_NextStage.Visible = true;

            if (highestQuality != null) //Auto select the highest quality format
                formatRdoClick(highestQuality, null);
        }

        private string getVidIDFromURL()
        { 
            int vChar = pluginInstance.details.url.IndexOf("v="); //Normalized URL have v=, get position of that
            pluginInstance.details.mediaID = pluginInstance.details.url.Substring(vChar + 2); //Get the ID by removing all chars and including v=

            return pluginInstance.details.mediaID;
        }


        private void getThumbPic()
        {
            //TODO: Add Timeout
            try
            {
                pic_Thumb.Load("http://img.youtube.com/vi/" + getVidIDFromURL() + "/1.jpg"); //Thumbnail of video.
                pluginInstance.details.cachedThumb = pic_Thumb.Image; //STore the image for future stage.

            }
            catch
            {
                MessageBox.Show("Error occured retrieveing Media Information and/or Media Artwork", "Plugin Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void but_NextStage_Click(object sender, EventArgs e)
        {
            if (mSelectedFormat == -1) //No Format Selected
            {
                MessageBox.Show("Please select one video formats in the list", "Plugin Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            //Narrow down to one format as selected by the user
            pluginInstance.details.selectedResult = pluginInstance.details.results.First(info => info.FormatCode == mSelectedFormat);
            pluginInstance.details.audioBitRate = pluginInstance.details.selectedResult.AudioBitrate;
            pluginInstance.details.audioFormat = pluginInstance.details.selectedResult.AudioType;
            pluginInstance.details.selectedResolution = Convert.ToString(pluginInstance.details.selectedResult.Resolution);
            pluginInstance.details.formatCode = mSelectedFormat;

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
        { txt_MediaURL.Text = Clipboard.GetText(); }

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

        private void frm_GetURL_Activated(object sender, EventArgs e)
        {
            if (pluginInstance.config.autoPasteURL && !focusedAutoPasted)
            {
                string compareString = Clipboard.GetText();
                if (compareString.Contains("youtube"))
                {
                    focusedAutoPasted = true;
                    txt_MediaURL.Text = Clipboard.GetText();

                    if (!pluginInstance.config.clipboardMessageShown)
                    {
                        MessageBox.Show("Media Downloader: A valid media URL was in your clipboard and has automatically been pasted\nYou can turn this function off in the plugin settings\n" +
                            "This message will not show again.", "Plugin Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pluginInstance.config.clipboardMessageShown = true;
                        pluginInstance.config.saveSettings(pluginInstance.config, true);
                    }


                    but_ContStage.PerformClick();

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
            if (bk_QueryFormats.IsBusy)
            { bk_QueryFormats.CancelAsync(); }

            if (closeEntirePlugin == true)
            { pluginInstance.closeApplication(); }
        }
    }
}
