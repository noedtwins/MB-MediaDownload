using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using YoutubeExtractor;
using System.Threading.Tasks;
using System.Threading;

namespace MusicBeePlugin
{

    public partial class frm_StartPage : Form
    {
        private bool mMessageDisplayed = false;
        private bool focusedAutoPasted = false;
        private int mSelectedFormat = -1; //If -1, throw error. From YoutubeExtractor
        private string mUrlNormalised = "nothing"; //YouTubeExtractor Normalised URL
        private ContextMenuStrip overflowMenu = new ContextMenuStrip();

        private bool requestedRestart = false; //Obsolete?
        private bool mClosePlugin = true;
        private bool errorCaused = false;

        private PluginLogic mLogic;

        public bool normalmode = true;

        
        public frm_StartPage(PluginLogic pLogic)
        {
            mLogic = pLogic;
            InitializeComponent();
            InitCustomControls(pLogic.API);
            
         }

        public URLType checkURL()
        {
            try
            {
                if (DownloadUrlResolver.TryNormalizeYoutubeUrl(txt_MediaURL.Text, out mUrlNormalised))
                {
                    return URLType.Youtube;
                }

                if (txt_MediaURL.Text.Contains("soundcloud")) //MAKE BETTER SOUNDCLOUD HANDLER
                {
                    return URLType.Soundcloud;
                }

                return URLType.Invalid;
            }
            catch
            {
                MessageBox.Show("Miscellaneous Error (209)");
                return URLType.Invalid;
            }
        }

        private void but_ContStage_Click(object sender, EventArgs e)
        {
            but_Previous.Enabled = false;
            grp_Info.Visible = false;
            mLogic.video.mediaType = checkURL();
            if (mLogic.video.mediaType == URLType.Invalid)
            {
                MessageBox.Show("There was an error normalizing the URL." + Environment.NewLine + "Please check your entry", "Plugin Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                but_Previous.Enabled = true;
                return;
            }

            mLogic.video.downloadURL = txt_MediaURL.Text;
            but_ContStage.Visible = false;
            pnl_AvaFormat.Visible = true;
            txt_MediaURL.Enabled = false;

            lbl_DecodeInfo.Text = "Attempting to retrieve a http stream..." + Environment.NewLine + "This may take a few seconds";

            bkWork_GetDetails.RunWorkerAsync();


        }

        private void bkWork_GetDetails_DoWork(object sender, DoWorkEventArgs e)
        {
            if (mLogic.video.mediaType == URLType.Youtube)
            {
                mLogic.results = DownloadUrlResolver.GetDownloadUrls(txt_MediaURL.Text);
            }
            else if (mLogic.video.mediaType == URLType.Soundcloud)
            {
                try
                {
                    System.Net.WebClient c = new System.Net.WebClient(); //legacy check?
                    mLogic.video.resolveJSON_SC_URL(txt_MediaURL.Text, mLogic.soundcloudClientID);

                    var data = c.DownloadString(mLogic.video.JSONDataURL);
                    mLogic.video.soundcloudData = Newtonsoft.Json.Linq.JObject.Parse(data);
                }
                catch
                {
                    MessageBox.Show("Unknown Error. Soundcloud Exception Line: 108", "Information", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);        
                    errorCaused = true;
                }
            }

        }

        private void bkWork_GetDetails_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            if (mLogic.video.mediaType == URLType.Youtube)
            { 
                addValidTopanel();
                getThumbPic();
            }

            if (mLogic.video.mediaType == URLType.Soundcloud)
            { addSoundCloud(); }

            but_Previous.Enabled = true;
            if (e.Cancelled && requestedRestart) //So the user can complete this stage more than once.
            {
                requestedRestart = false;
                bkWork_GetDetails.RunWorkerAsync();
            }
        }

        private int findValidFormats()
        {
            int validFound = 0;
            try
            {
                foreach (VideoInfo theVideoInfo in mLogic.results) //each found format (YouTubeExtractor)
                {
                    if (theVideoInfo.AdaptiveType == AdaptiveType.None &&
                        theVideoInfo.VideoType != VideoType.Unknown && theVideoInfo.VideoType != VideoType.WebM) //Unsupported formats here.
                    { validFound++; }

                    //AUDIO ADAPTIVE TYPE - ADD SETTING
                    if (theVideoInfo.AdaptiveType == AdaptiveType.Audio && theVideoInfo.AudioType == AudioType.Aac)
                    { validFound++; }
                }

                lbl_FormatCount.Text = "Discovered Valid Formats: " + validFound;
                return validFound;
            }

            catch
            { return 0; }

        }

        private void addValidTopanel()
        {
            int curSelection = 0;
            int foundFormats = findValidFormats();

            flow_DownRdoButtons.Controls.Clear(); //Obsolete?

            if (foundFormats == 0) //If zero formats.
            { 
                displayNoFormatMsg();
                return;

            }

            RadioButton highestQualityRdo = null;

            foreach (VideoInfo item in mLogic.results)
            {

                
                if (item.AdaptiveType == AdaptiveType.None &&
                    item.VideoType != VideoType.Unknown && item.VideoType != VideoType.WebM) //Unsupported Formats (changed apt type to =!?)
                
                {
                    lbl_VideoTitle.Text = item.Title;
                    RadioButton selButton = new RadioButton();
                    selButton.Name = "rdo_But_" + item.FormatCode;
                    selButton.Text = "Video Type: " + item.VideoType + " || Video Resolution: " + item.Resolution + " || Audio BitRate: " +
                        item.AudioBitrate + " || Audio Extension: " + item.AudioType;
                    selButton.Width = 462; //NOTE: Should be auto fill?
                    selButton.Click += new EventHandler(formatRdoClick);
                    flow_DownRdoButtons.Controls.Add(selButton);
                    if (highestQualityRdo == null)
                    { highestQualityRdo = selButton; }

                    curSelection++;

                }

                //AUDIO ONLY ADAPATIVE TYPES
                if (item.AdaptiveType == AdaptiveType.Audio && item.AudioType == AudioType.Aac)
                {
                    RadioButton selButton = new RadioButton();
                    selButton.Name = "rdo_But_" + item.FormatCode;
                    selButton.Text = "[AUDIO ONLY] BitRate: " + item.AudioBitrate + " Audio Extension: " + item.AudioType;
                    selButton.ForeColor = Color.DarkCyan;
                    selButton.Width = 462;
                    selButton.Click += new EventHandler(formatRdoClick);
                    flow_DownRdoButtons.Controls.Add(selButton);
                    curSelection++;
                }

            }
        
            //Handle form controls to show the buttons.
            grp_VidDetails.Visible = true;
            pic_INILOAD.Visible = false;
            flow_DownRdoButtons.Visible = true;
            but_Reset.Visible = true;

            but_NextStage.Visible = true;

            if (mLogic.settings.selectHighest)
            { highestQualityRdo.PerformClick(); } //WARN FEATURE NO LONG IMPLEMENTED

        }

        private void displayNoFormatMsg()
        {
            if (!mMessageDisplayed)
            {
                mMessageDisplayed = true;
                MessageBox.Show("No formats Found for this video." + Environment.NewLine + "Is the link still active/available in your country?" + Environment.NewLine +
                     "Post link on plugin forum page if you are still encountering errors", "Plugin Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                but_Reset.Visible = true;
                pic_INILOAD.Visible = false;
                return;
            }
            else { return; }
        }

        private void formatRdoClick(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;

            string rdoFormatCode;
            rdoFormatCode = clickedButton.Name.Substring(8); //Removes first 8 characters
            
            if (clickedButton.Text.Contains("Mobile")) //TODO: Improve
            {
                grp_ShowMsg.Visible = true;
                lbl_MsgInfo.Text = "Audio Quality Warning: The selected format will be low quality";
            }
            else { 
                if (!lbl_MsgInfo.Text.Contains("Information"))
                { grp_ShowMsg.Visible = false; }
            }

            mSelectedFormat = Convert.ToInt32(rdoFormatCode);

        }

        private string getVidIDFromURL()
        {
            //This uses YouTubeExtractor normalised URL.
            int vChar = mUrlNormalised.IndexOf("v="); //Normalized URL have v=, get position of that
            mUrlNormalised = mUrlNormalised.Substring(vChar + 2); //Get the ID by removing all chars and including v=

            return mUrlNormalised;
        }
        private void addSoundCloud()
        {
            if (errorCaused)
            {
                errorCaused = false;
                but_Reset_Click(null, EventArgs.Empty);
                return;
            }
            
            //TODO Soundcloud
            grp_VidDetails.Visible = true;
            pic_INILOAD.Visible = false;
            flow_DownRdoButtons.Visible = true;
            but_Reset.Visible = true;
            //but_NextStage.Visible = true;
            pnl_SCDownload.Visible = true;
        
            if (Convert.ToString(mLogic.video.soundcloudData["downloadable"]) == "True")
            {
                but_NextStage.Visible = true;
                but_NextStage.Enabled = true;
                pic_SCLoad.Visible = false;
                lbl_DecodeInfo.Visible = false
                    ;
                lbl_SCInfo.Text = "The uploader has allowed downloads." + Environment.NewLine + "Press Next To Continue";
                string trackID = Convert.ToString(mLogic.video.soundcloudData["id"]);
                mLogic.video.downloadURL = string.Format(@"https://api.soundcloud.com/tracks/{0}/download?client_id={1}", trackID, 
                    mLogic.soundcloudClientID);
                mSelectedFormat = 9999;
                getThumbPic();

            }
            else
            {
                
                but_NextStage.Visible = true;
                but_NextStage.Enabled = false;
                lbl_SCInfo.Text = "The uploader has disallowed downloads." + Environment.NewLine + "Manually extracting URL";
                pic_SCLoad.Visible = true;
                lbl_DecodeInfo.Visible = true;
                getCustomSCURL();
                getThumbPic();
                
            }

        }

        private void getCustomSCURL()
        {
             string trackID = Convert.ToString(mLogic.video.soundcloudData["id"]);

             string streams = string.Format(@"http://api.soundcloud.com/i1/tracks/{0}/streams?client_id={1}&secret_token=None", trackID, 
                 soundcloudAPI.privateClient);
             try
             {
                 System.Net.WebClient c = new System.Net.WebClient(); //legacy check?

                 var data = c.DownloadString(streams);
                 Newtonsoft.Json.Linq.JObject avaStreams = Newtonsoft.Json.Linq.JObject.Parse(data);

                 IList<string> keys = avaStreams.Properties().Select(p => p.Name).ToList();

                 string streamURL = "";

                 foreach (var item in keys)
                 {
                     if (item.StartsWith("http"))
                     {
                         streamURL = Convert.ToString(avaStreams[item]);
                     }
                 }

                 if (streamURL == "")
                 {
                     lbl_DecodeInfo.Text = "No Valid HTTP Stream Found. Please try another link";
                     pic_SCLoad.Visible = false;
                 }
                 else
                 {
                     lbl_DecodeInfo.Text = "Valid HTTP Stream Found, Press Next to Continue";
                     but_NextStage.Visible = true;
                     but_NextStage.Enabled = true;
                     pic_SCLoad.Visible = false;

                     mLogic.video.downloadURL = streamURL;
                     mSelectedFormat = 8888;                     
                 }


             }
             catch
             {
                 but_Reset_Click(null, EventArgs.Empty);
                 MessageBox.Show("Error 332 - Malformed Soundcloud URL", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);                 
             }


        }

        private void getThumbPic()
        {
            //Todo: Add Error Hander & Timeout
            try
            {
                if (mLogic.video.mediaType == URLType.Youtube)
                {
                    pic_Thumb.Load("http://img.youtube.com/vi/" + getVidIDFromURL() + "/1.jpg"); //Thumbnail of video. 
                }
                else if (mLogic.video.mediaType == URLType.Soundcloud)
                {

                    lbl_VideoTitle.Text = Convert.ToString(mLogic.video.soundcloudData["title"]);
                    lbl_FormatCount.Text = Convert.ToString(mLogic.video.soundcloudData["uri"]);
                    pic_Thumb.Load(Convert.ToString(mLogic.video.soundcloudData["artwork_url"]));
                }
                mLogic.video.ytThumb = pic_Thumb.Image;
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
            else
            {
                if (mSelectedFormat == 139 || mSelectedFormat == 140 || mSelectedFormat == 141)
                {
                    mLogic.video.mediaType = URLType.YoutubeAdapative;
                    mLogic.singleResult = mLogic.results.First(info => info.FormatCode == mSelectedFormat);
                    mLogic.video.audioBitRate = mLogic.singleResult.AudioBitrate;
                    mLogic.video.audioFormat = "m4a";
                    mLogic.video.selectedRes = "[AUDIO ONLY]";
                }

                if (mLogic.video.mediaType == URLType.Youtube)
                {
                    mLogic.video.mediaType = URLType.Youtube;
                    mLogic.singleResult = mLogic.results.First(info => info.FormatCode == mSelectedFormat);

                    mLogic.video.audioBitRate = mLogic.singleResult.AudioBitrate;
                    mLogic.video.audioFormat = mLogic.singleResult.AudioExtension;
                    mLogic.video.selectedRes = Convert.ToString(mLogic.singleResult.Resolution);

                }


                if (mLogic.video.mediaType == URLType.Soundcloud)
                {
                    mLogic.video.mediaType = URLType.Soundcloud;
                    mLogic.video.audioFormat = "mp3";
                }
                

                mLogic.video.videoTitle = lbl_VideoTitle.Text;
                mLogic.video.formatCode = mSelectedFormat;

                mClosePlugin = false;
                mLogic.moveFowardScreen(this);

                this.Visible = false; //Remains Invisible if need to go back (disposed by frm_SaveFile)
            }
        }


        private void but_Reset_Click(object sender, EventArgs e)
        {
            //Clear Objects, Make Panel Invisible, Unlock TextBox

            mSelectedFormat = -1;
            mLogic.results = null;
            grp_Info.Visible = true;

            pic_Thumb.Image = Properties.Resources.ajaxLoad;
            pnl_AvaFormat.Visible = false;
            grp_VidDetails.Visible = false;
            txt_MediaURL.Enabled = true;
            txt_MediaURL.Text = "Insert URL Here...";
            pic_INILOAD.Visible = true;
            mMessageDisplayed = false;
            but_Reset.Visible = false;
            but_NextStage.Visible = false;
            grp_ShowMsg.Visible = false;
            mLogic.video.cropSelected = false;

            if (bkWork_GetDetails.IsBusy)
            {
                requestedRestart = true;
                bkWork_GetDetails.CancelAsync();
                flow_DownRdoButtons.Controls.Clear();
            }

            flow_DownRdoButtons.Controls.Clear();
            but_ContStage.Visible = true;

        }

        private void but_PasteFromClipboard_Click(object sender, EventArgs e)
        {
            overflowMenu.Items.Clear();
            overflowMenu.Items.Add("Paste from clipboard", null, mnu_PasteClipBoard);
            overflowMenu.Items.Add("Get URL from Steven's Web Plugin", null, mnu_WebPlugin);

            overflowMenu.Show(but_MoreOptions, 0, but_MoreOptions.Height);

        }

        private void mnu_PasteClipBoard(object sender, EventArgs e)
        { txt_MediaURL.Text = Clipboard.GetText(); }

        public void mnu_WebPlugin(object sender, EventArgs e)
        {
            string tempHolder = txt_MediaURL.Text;
            txt_MediaURL.Text = mLogic.getURLFromStevenPlugin();
            if (txt_MediaURL.Text != "")
            { but_ContStage.PerformClick(); }
            else 
            {
                string compareString = Clipboard.GetText();
                if (compareString.Contains("youtube"))
                {
                    txt_MediaURL.Text = Clipboard.GetText();
                    grp_ShowMsg.Visible = true;
                    lbl_MsgInfo.Text = "Information: The URL has been pasted for you. Change In Plugin Settings";
                    but_ContStage.PerformClick();
                }
                else
                {

                    mClosePlugin = true;
                    txt_MediaURL.Text = "Insert URL Here...";
                    if (sender == null) { this.Close(); }
                }
            }
        }

        private void frm_StartPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bkWork_GetDetails.IsBusy)
            { bkWork_GetDetails.CancelAsync(); }

            if (mClosePlugin == true)
            { mLogic.closeEntirePlugin();  }
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

        private void frm_StartPage_Load(object sender, EventArgs e)
        {
            if (mLogic.settings.autoPasteURL && normalmode)
            {
                string compareString = Clipboard.GetText();
                if (compareString.Contains("youtube")  || compareString.Contains("soundcloud"))
                {
                    txt_MediaURL.Text = Clipboard.GetText();
                    grp_ShowMsg.Visible = true;
                    lbl_MsgInfo.Text = "Information: The URL has been pasted for you. Change In Plugin Settings";
                    but_ContStage.PerformClick();
                }

            }
        }

        private void but_Previous_Click(object sender, EventArgs e)
        {
            string resetHolder = txt_MediaURL.Text;
            mClosePlugin = false;
            mLogic.showSplashScreen();
            but_Reset.PerformClick();
            grp_ShowMsg.Visible = false;
            txt_MediaURL.Text = resetHolder;
            this.Hide();
        }

        private void frm_StartPage_Activated(object sender, EventArgs e)
        {
            if (mLogic.settings.autoPasteURL && !focusedAutoPasted && normalmode)
            {
                string compareString = Clipboard.GetText();
                if (compareString.Contains("youtube") || compareString.Contains("soundcloud"))
                {
                    focusedAutoPasted = true;
                    txt_MediaURL.Text = Clipboard.GetText();
                    grp_ShowMsg.Visible = true;
                    lbl_MsgInfo.Text = "Information: The URL has been pasted for you. Change In Plugin Settings";
                    but_ContStage.PerformClick();
                }

            }
        }
    }

}
