using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using YoutubeExtractor;

namespace mediaDownloader
{
    public partial class frm_SaveFile : Form
    {

        private bool mVideoMode = false;
        private bool closeEntirePlugin = true; //Close entire plugin if user has requested close.


        public frm_SaveFile()
        {
            InitializeComponent();
            initMBCustom();
            this.lbl_Title.Parent = pic_Top;
            this.pic_ICO.Parent = pic_Top;
        }


        public void firstStart() //First time form instanced, load default values and settings
        {
            cbo_Folder.Items.Add(pluginInstance.config.mainFolder); //Add the main folder path from settings
            cbo_Folder.Text = pluginInstance.config.mainFolder;

            updateCropButton();

            if (pluginInstance.config.sameValBitRateAsVideo)
            {
                //If Use Same BitRate on Conversion is true in settings, then add the format bitrate to this
                cbo_SetBitRate.Items.Add(pluginInstance.details.audioBitRate);
                cbo_SetBitRate.Text = Convert.ToString(pluginInstance.details.audioBitRate);
            }
            else
            {
                cbo_SetBitRate.Text = Convert.ToString(pluginInstance.config.bitRate);
            }

            //Radio Buttons for Adding Media To MB
            if (pluginInstance.config.addInbox == false && pluginInstance.config.addLibrary == false)
            { rdo_None.Checked = true; } //Neither will be selected
            else
            {
                rdo_Inbox.Checked = pluginInstance.config.addInbox;
                rdo_Library.Checked = pluginInstance.config.addLibrary;
            }

            if (Program.isStandaloneMode)
            {
                rdo_Inbox.Enabled = false;
                rdo_Library.Enabled = false;
                rdo_Video.Enabled = false;
                rdo_None.Checked = true;
            }


            this.ActiveControl = txt_Tag_Title; //Set Focus on Title Tag TextBox
            loadDetailsFromMedia();
        }

        public void loadDetailsFromMedia()
        {
            lbl_VideoTitle.Text = pluginInstance.details.title;
            lbl_FormatStatus.Text = "Resolution: " + pluginInstance.details.selectedResolution + 
                " || " + "Format Code " + pluginInstance.details.formatCode;
            pic_VidThumb.Image = pluginInstance.details.cachedThumb;

            txt_FileName.Text = autotag.removeSpecialCharactersFromFileName(pluginInstance.details.title); //Store the file name as title without special characters.

            if (pluginInstance.config.extractAudio) //If Extracting rather than converting
            {
                if (!pluginInstance.config.m4aMake) //If making an not making m4a file, then use the format code media format.
                { txt_FileName.Text = txt_FileName.Text + pluginInstance.details.audioFormat; } //TOOD: This obsolete surely?
                else //Otherwise use a m4a file
                {
                    if (pluginInstance.details.audioFormat == AudioType.Aac) //If its aac -> we're making m4a instead
                    { 
                        cbo_SelectFileFormat.Text = "m4a";
                    }
                    else { txt_FileName.Text = txt_FileName.Text + pluginInstance.details.audioFormat; } //Otherwise use media format (AAC)
                }
                
                //Setup form to display to user we're extracting rather than converting..
                lbl_Convert.Text = "Extract At Bitrate: " + Convert.ToString(pluginInstance.details.audioBitRate) + " kbps";
                cbo_SetBitRate.Visible = false;
                lbl_Prefix.Visible = false;
            }
            else //Else... We're converting the video.
            {
                lbl_Convert.Text = "MP3 Conversion BitRate: ";
                cbo_SetBitRate.Visible = true;
                lbl_Prefix.Visible = true;
                cbo_SelectFileFormat.Text = "mp3";
            }

            if (mVideoMode) //If the user wants the video not a audio file (no extracting or converting)
            {
                cbo_SelectFileFormat.Text = pluginInstance.details.selectedResult.VideoExtension; //Use the video extension
                lbl_Convert.Text = "Video Resolution: " + Convert.ToString(pluginInstance.details.selectedResolution);
                cbo_SetBitRate.Visible = false;
                lbl_Prefix.Visible = false;
            }

            if (pluginInstance.config.autoTagInfo) //If autotagging from filename is enabled in options, perform the function
            {
                autotag.autoTagInfo holder;
                holder =  autotag.performAutoTag(pluginInstance.details.title); //Regex autotag
                txt_Tag_Title.Text = holder.attemptTitle;
                txt_Tag_Artist.Text = holder.attemptArtist; //Set The Textboxes to the found strings.
            }
        }

        private void pic_Artwork_Click(object sender, EventArgs e)
        {
            //TODO: Add select artwork.
            MessageBox.Show("Setting Artwork unavailable. Tasked for a future release!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void but_Browse_Click(object sender, EventArgs e)
        {
            //TODO: Add recent folders (10)
            //BUGTOFIX: Add's Multiple times in the combo box.

            string tempHold = cbo_Folder.Text;
            fldr_BrowseSelection.ShowDialog();
            cbo_Folder.Items.Add(fldr_BrowseSelection.SelectedPath);
            cbo_Folder.Text = fldr_BrowseSelection.SelectedPath;

            if (cbo_Folder.Text == "")
            {
                cbo_Folder.Text = tempHold;
            }

        }

        private void rdo_Video_CheckedChanged(object sender, EventArgs e)
        {
            //If user has selected video mode
           // grp_VidDownload.Visible = rdo_Video.Checked; //TODO: Add tHis
            mVideoMode = rdo_Video.Checked;
            loadDetailsFromMedia();
        }

        private void but_Swap_Click(object sender, EventArgs e)
        {
            //Swap the value of artist and title tag around
            string txtHolder = txt_Tag_Title.Text;
            txt_Tag_Title.Text = txt_Tag_Artist.Text;
            txt_Tag_Artist.Text = txtHolder;

        }

        public void updateCropButton()
        {
            //If Crop Value has changed
            if (pluginInstance.details.cropSelected)
            {
                but_Crop.Text = "Crop Content (YES)";
            }
            else
            {
                but_Crop.Text = "Crop Content (NO)";
            }
        }


        private bool checkValidPath() //Check if the selected folder is valid to be used
        {
            try
            { return (System.IO.Directory.Exists(cbo_Folder.Text)); }
            catch
            { return false; }
        }

        private Boolean prepareStep()
        {

            if (checkValidPath() == false) //Check the folder selected is valid.
            {
                MessageBox.Show("Invaid path selected. Please confirm the directory you have selected exists.", "Plugin Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; ; //Error occured, Exit method.
            }

            if (rdo_Video.Checked == true)
                pluginInstance.details.videoMode = true;

            //////////////
            ///Tagging///
            ////////////
            if ((txt_Tag_Album.Text == "" || txt_Tag_Artist.Text == "" || txt_Tag_Title.Text == "") &&
                !pluginInstance.config.hideTagMessage && !rdo_Video.Checked)
            {
                DialogResult confirmNoTag = MessageBox.Show("You have left one or more tags fields blank, Continue without tagging?",
                    "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmNoTag == System.Windows.Forms.DialogResult.No)
                {
                    return false;  //User pressed no, exit method so user can enter them.
                }

            }

            ///////////////////////
            ///Music Bee Addition//
            ///////////////////////
            if (rdo_None.Checked == true)
            { pluginInstance.details.moveTo = moveType.none; }
            if (rdo_Inbox.Checked)
            { pluginInstance.details.moveTo = moveType.inbox; }
            if (rdo_Library.Checked)
            { pluginInstance.details.moveTo = moveType.library; }


            pluginInstance.details.titleTag = txt_Tag_Title.Text;
            pluginInstance.details.albumTag = txt_Tag_Album.Text;
            pluginInstance.details.artistTag = txt_Tag_Artist.Text;
            setFileLoc(txt_FileName.Text + "." + cbo_SelectFileFormat.Text, pluginInstance.config.tempFolder, cbo_Folder.Text);

            pluginInstance.details.audioBitRate = Convert.ToInt32(cbo_SetBitRate.Text);

            return true;
        }

        public void setFileLoc(string filename, string tempPath, string downloadPath)
        {
            pluginInstance.details.fileName = filename;
            pluginInstance.details.downloadPath = downloadPath;
            pluginInstance.details.fullTempPath = tempPath;
        }



        private void but_NextStage_Click(object sender, EventArgs e)
        {
            if (prepareStep())
            {
                pluginInstance.startProcess();
            }
            else
            {
                return;
            }
        }

        private void grp_FrmButtons_Enter(object sender, EventArgs e)
        {

        }

        private void but_PreviousStage_Click(object sender, EventArgs e)
        {
            but_Reset.PerformClick();
            pluginInstance.gotoCatchURL();

        }

        private void but_Reset_Click_1(object sender, EventArgs e)
        {
            //Reset back to form load
            txt_Tag_Title.Text = "";
            txt_Tag_Artist.Text = "";
            txt_Tag_Album.Text = "";
            pluginInstance.details.cropSelected = false;
            updateCropButton();

            firstStart(); //Rerun the instance of this form
        }

        private void frm_SaveFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeEntirePlugin == true)
            {
                pluginInstance.closeApplication();

            }
        }

        private void but_Crop_Click(object sender, EventArgs e)
        {
            pluginInstance.gotoCropContent();
        }

        private void but_Swap_Click_1(object sender, EventArgs e)
        {
            String tempHold = txt_Tag_Title.Text;
            txt_Tag_Title.Text = txt_Tag_Artist.Text;
            txt_Tag_Artist.Text = tempHold;
        }
    }

}
