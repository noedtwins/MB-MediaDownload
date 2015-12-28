using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mediaDownloader
{
    public partial class frm_Settings : Form
    {
        private frm_TagModify tagFrm;


        public frm_Settings()
        {
            InitializeComponent();
            settingsToControls();
            this.lbl_Title.Parent = pic_Top;
            this.pic_ICO.Parent = pic_Top;

        }

        private void settingsToControls()
        {
            txt_TempPath.Text = pluginInstance.config.tempFolder;
            txt_DefaultPath.Text = pluginInstance.config.mainFolder;
            chk_Comment.Checked = pluginInstance.config.addComment;
            chk_AutoPaste.Checked = pluginInstance.config.autoPasteURL;
            chk_AutoTag.Checked = pluginInstance.config.autoTagInfo;
            chk_Window.Checked = pluginInstance.config.displayConsole;
            chk_AutoClose.Checked = pluginInstance.config.autoClosePlugin;
            txt_FFMpegPath.Text = pluginInstance.config.ffmpegPath;
            chk_ExtractAudio.Checked = pluginInstance.config.extractAudio;
            chk_HideTagWarn.Checked = pluginInstance.config.hideTagMessage;
            chk_SeperateDir.Checked = pluginInstance.config.useTempFolder;
            chk_AdvFeatures.Checked = pluginInstance.config.testFeature;
            chk_DelTemp.Checked = pluginInstance.config.preventDelTempFiles;
            chk_Smoothing.Checked = pluginInstance.config.smoothing;
            txt_OverrideSignature.Text = pluginInstance.config.manualDecipherOperataion;
            //comboBox1 - TODO Add Library Type
            chk_Legacy.Checked = pluginInstance.config.useMBLegacy;
            chk_useModifiedLibrary.Checked = pluginInstance.config.useUnModifiedYTVersion;

            lbl_SettingVersion.Text = "Setting File Version: " + pluginInstance.config.loadedVersion + " || Match Setting: " + pluginInstance.config.SETTINGVERSION;

            if (pluginInstance.config.sameValBitRateAsVideo)
                cbo_BitRate.Text = "Use Same Audio Bitrate as the video";
            else
                cbo_BitRate.Text = Convert.ToString(pluginInstance.config.bitRate);

            if (!pluginInstance.config.addInbox && !pluginInstance.config.addLibrary)
                rdo_None.Checked = true;
            else
            {
                rdo_Inbox.Checked = pluginInstance.config.addInbox;
                rdo_Music.Checked = pluginInstance.config.addLibrary;
            }

            moveTempCntrlBox(chk_SeperateDir.Checked);

        }

        private bool checkValidPaths()
        {
            try
            {
                bool allValid;
                allValid = System.IO.Directory.Exists(txt_DefaultPath.Text);
                allValid = System.IO.Directory.Exists(txt_TempPath.Text);

                if (System.IO.File.Exists(txt_FFMpegPath.Text) == false)
                {
                    MessageBox.Show("Invalid FFmpeg file", "Plugin Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    allValid = false;
                }

                return allValid;
            }
            catch
            { return false; }

        }

        private void moveTempCntrlBox(bool isTempEnabled)
        {
            if (isTempEnabled)
            {
                pnl_VisCntrl.Location = new Point(3, 101);
            }
            else
            {
                pnl_VisCntrl.Location = new Point(3, 65);
            }

        }

        private void but_NextStage_Click(object sender, EventArgs e)
        {
            if (checkValidPaths() == false)
            {
                MessageBox.Show("One of more path fields are invalid. Please check the inputs and try again", "Plugin Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //Error Occured leave this routine
            }

            pluginInstance.config.tempFolder = txt_TempPath.Text;
            pluginInstance.config.mainFolder = txt_DefaultPath.Text;
            pluginInstance.config.ffmpegPath = txt_FFMpegPath.Text;
            pluginInstance.config.displayConsole = chk_Window.Checked;
            pluginInstance.config.addComment = chk_Comment.Checked;
            pluginInstance.config.autoClosePlugin = chk_AutoClose.Checked;
            pluginInstance.config.hideTagMessage = chk_HideTagWarn.Checked;
            pluginInstance.config.autoPasteURL = chk_AutoPaste.Checked;
            pluginInstance.config.autoTagInfo = chk_AutoTag.Checked;
            pluginInstance.config.useTempFolder = chk_SeperateDir.Checked;
            pluginInstance.config.preventDelTempFiles = chk_DelTemp.Checked;
            pluginInstance.config.testFeature = chk_AdvFeatures.Checked;
            pluginInstance.config.smoothing = chk_Smoothing.Checked;
            pluginInstance.config.addInbox = rdo_Inbox.Checked;
            pluginInstance.config.addLibrary = rdo_Music.Checked;
            pluginInstance.config.extractAudio = chk_ExtractAudio.Checked;
            pluginInstance.config.manualDecipherOperataion = txt_OverrideSignature.Text;
            //comboBox1 - TODO Add Library Type
            pluginInstance.config.useMBLegacy = chk_Legacy.Checked;
            pluginInstance.config.useUnModifiedYTVersion = chk_useModifiedLibrary.Checked;


            if (cbo_BitRate.Text == "Use Same Audio Bitrate as the video")
               pluginInstance.config.sameValBitRateAsVideo = true;
            else
            {
                pluginInstance.config.bitRate = Convert.ToInt32(cbo_BitRate.Text);
                pluginInstance.config.sameValBitRateAsVideo = false;
            }

            pluginInstance.config.saveSettings(pluginInstance.config);
            pluginInstance.clearInstance();
            this.Close();

        }

        private void but_DefaultBrowse_Click(object sender, EventArgs e)
        {
            fldr_MainBrowse.ShowDialog();
            txt_DefaultPath.Text = fldr_MainBrowse.SelectedPath;
        }

        private void but_TempBrowse_Click(object sender, EventArgs e)
        {
            fldr_MainBrowse.ShowDialog();
            txt_TempPath.Text = fldr_MainBrowse.SelectedPath;
        }

        private void but_BrowseFFMpeg_Click(object sender, EventArgs e)
        {
            DialogResult getResult = dlg_OpenFile.ShowDialog();
            if (getResult == DialogResult.OK)
            { txt_FFMpegPath.Text = dlg_OpenFile.FileName; }    
        }

        private void chk_Comment_CheckedChanged(object sender, EventArgs e)
        {
            but_TagEditor.Enabled = chk_Comment.Checked;
        }

        private void chk_SeperateDir_CheckedChanged(object sender, EventArgs e)
        {
            moveTempCntrlBox(chk_SeperateDir.Checked);

        }

        private void frm_Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { tagFrm.Close(); }
            catch { }

            pluginInstance.gotoSplashScreen(true);
        }

        private void chk_AutoClose_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void but_TagEditor_Click(object sender, EventArgs e)
        {
            tagFrm = new frm_TagModify();
            tagFrm.Show();
        }
    }
}
