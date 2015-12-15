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
        
        public frm_SaveFile()
        {
            InitializeComponent();
        }


        public void firstStart() //First time form instanced, load default values and settings
        {
            cbo_Folder.Items.Add(config.mainFolderPath); //Add the main folder path from settings
            cbo_Folder.Text = config.mainFolderPath;

            if (config.useSameValueBitRateOnConversion)
            {
                //If Use Same BitRate on Conversion is true in settings, then add the format bitrate to this
                cbo_SetBitRate.Items.Add(pluginInstance.details.audioBitRate);
                cbo_SetBitRate.Text = Convert.ToString(pluginInstance.details.audioBitRate);
            }
            else
            {
                cbo_SetBitRate.Text = Convert.ToString(config.defaultBitRate);
            }

            //Radio Buttons for Adding Media To MB
            if (config.addToMBInbox == false && config.addToMBLibrary == false)
            { rdo_None.Checked = true; } //Neither will be selected
            else
            {
                rdo_Inbox.Checked = config.addToMBInbox;
                rdo_Library.Checked = config.addToMBLibrary;
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

            if (config.extractAudio) //If Extracting rather than converting
            {
                if (!config.m4aMake) //If making an not making m4a file, then use the format code media format.
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

            if (config.autoTagInfo) //If autotagging from filename is enabled in options, perform the function
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

        private void but_Reset_Click(object sender, EventArgs e)
        {
            //Reset back to form load
            txt_Tag_Title.Text = "";
            txt_Tag_Artist.Text = "";
            txt_Tag_Album.Text = "";
            pluginInstance.details.cropSelected = false;
            updateCropButton();

            firstStart(); //Rerun the instance of this form
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

        private void frm_SaveFile_Load(object sender, EventArgs e)
        {

        }
    }

}
