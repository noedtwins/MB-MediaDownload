using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mediaDownloader
{
    public partial class frm_Settings : Form
    {
        private frm_TagModify tagFrm;
        private Boolean justSaved = false;


        public frm_Settings()
        {
            InitializeComponent();
            this.AcceptButton = but_NextStage;
            initMBCustom();
            settingsToControls();

            if (pluginInstance.config.ontop)
                this.TopMost = true;
        }

        private void settingsToControls()
        {
            txt_DefaultPath.Text = pluginInstance.config.mainFolder;
            chk_Comment.Checked = pluginInstance.config.addComment;
            chk_AutoPaste.Checked = pluginInstance.config.autoPasteURL;
            chk_AutoTag.Checked = pluginInstance.config.autoTagInfo;
            chk_AutoClose.Checked = pluginInstance.config.autoClosePlugin;
            txt_FFMpegPath.Text = pluginInstance.config.ffmpegPath;
            chk_ExtractAudio.Checked = pluginInstance.config.extractAudio;
            chk_HideTagWarn.Checked = pluginInstance.config.hideTagMessage;
            chk_AdvFeatures.Checked = pluginInstance.config.testFeature;
            chk_DelTemp.Checked = pluginInstance.config.preventDelTempFiles;
            txt_rg3Args.Text = pluginInstance.config.rg3Args;
            txt_rg3Loc.Text = pluginInstance.config.rg3Path;
            rdo_TopAlways.Checked = pluginInstance.config.ontop;
            chk_SkipSplash.Checked = pluginInstance.config.skipSplash;
            chk_MultipleInstances.Checked = pluginInstance.config.multipleinstances;
            lbl_SettingVersion.Text = "Setting File Version: " + pluginInstance.config.loadedVersion + " || Match Setting: " + pluginInstance.config.SETTINGVERSION;
            cbo_BitRate.Text = Convert.ToString(pluginInstance.config.bitRate);

            if (pluginInstance.config.overwriteMode == "warn")
                rdo_Warn.Checked = true;
            else
                rdo_NoWarn.Checked = true;

            if (!pluginInstance.config.addInbox && !pluginInstance.config.addLibrary)
                rdo_None.Checked = true;
            else
            {
                rdo_Inbox.Checked = pluginInstance.config.addInbox;
                rdo_Music.Checked = pluginInstance.config.addLibrary;
            }

            if (pluginInstance.config.ffmpegOutput == "Pipe")
                rdo_FFMPEGPipe.Checked = true;
            else if (pluginInstance.config.ffmpegOutput == "Console")
                rdo_ShowConsole.Checked = true;
            else
                rdo_NoFFMPEGOutput.Checked = true;
        }

        private bool checkValidPaths()
        {
            try
            {
                bool allValid;
                allValid = System.IO.Directory.Exists(txt_DefaultPath.Text);

                if (System.IO.File.Exists(txt_FFMpegPath.Text) == false)
                {
                    MessageBox.Show(this, "The selected FFMPEG File is invalid. Please check you have selected the correct path!", "Plugin Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    allValid = false;
                }

                if (System.IO.File.Exists(txt_rg3Loc.Text) == false)
                {
                    MessageBox.Show(this, "The selected RG3 File is invalid. Please check you have selected the correct path!!", "Plugin Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    allValid = false;

                }

                return allValid;
            }
            catch
            { return false; }

        }

        private void but_NextStage_Click(object sender, EventArgs e)
        {
            if (checkValidPaths() == false)
            {
                MessageBox.Show(this, "One of more path fields are invalid. Please check the inputs and try again", "Plugin Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //Error Occured leave this routine
            }

            pluginInstance.config.mainFolder = txt_DefaultPath.Text;
            pluginInstance.config.ffmpegPath = txt_FFMpegPath.Text;
            pluginInstance.config.addComment = chk_Comment.Checked;
            pluginInstance.config.autoClosePlugin = chk_AutoClose.Checked;
            pluginInstance.config.hideTagMessage = chk_HideTagWarn.Checked;
            pluginInstance.config.autoPasteURL = chk_AutoPaste.Checked;
            pluginInstance.config.autoTagInfo = chk_AutoTag.Checked;
            pluginInstance.config.preventDelTempFiles = chk_DelTemp.Checked;
            pluginInstance.config.testFeature = chk_AdvFeatures.Checked;
            pluginInstance.config.addInbox = rdo_Inbox.Checked;
            pluginInstance.config.addLibrary = rdo_Music.Checked;
            pluginInstance.config.extractAudio = chk_ExtractAudio.Checked;
            pluginInstance.config.rg3Args = txt_rg3Args.Text;
            pluginInstance.config.rg3Path = txt_rg3Loc.Text;
            pluginInstance.config.bitRate = Convert.ToInt32(cbo_BitRate.Text);
            pluginInstance.config.ontop = rdo_TopAlways.Checked;
            pluginInstance.config.skipSplash = chk_SkipSplash.Checked;
            pluginInstance.config.multipleinstances = chk_MultipleInstances.Checked;

            if (rdo_FFMPEGPipe.Checked)
                pluginInstance.config.ffmpegOutput = "Pipe";
            else if (rdo_ShowConsole.Checked)
                pluginInstance.config.ffmpegOutput = "Console";
            else
                pluginInstance.config.ffmpegOutput = "None";

            if (rdo_Warn.Checked)
                pluginInstance.config.overwriteMode = "warn";
            if (rdo_NoWarn.Checked)
                pluginInstance.config.overwriteMode = "nowarn";

            pluginInstance.config.saveSettings(pluginInstance.config);
            justSaved = true;
            this.Close();

        }

        private void but_DefaultBrowse_Click(object sender, EventArgs e)
        {
            fldr_MainBrowse.ShowDialog();
            txt_DefaultPath.Text = fldr_MainBrowse.SelectedPath;
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

        private void frm_Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { tagFrm.Close(); }
            catch { }
            
            if (justSaved)
            {
                justSaved = false;
                pluginInstance.reloadPlugin();
                this.Dispose();
            }
            else
                pluginInstance.gotoSplashScreen(true);
        }
        
        private void but_TagEditor_Click(object sender, EventArgs e)
        {
            tagFrm = new frm_TagModify();
            tagFrm.Show();
        }

        private void but_Restore_Click(object sender, EventArgs e)
        {
            pluginInstance.config.loadDefaultSettings();

            pluginInstance.config.saveSettings(pluginInstance.config);
            pluginInstance.clearInstance();
            justSaved = true;
            this.Close();
        }

        private void but_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chk_ViewArgs_CheckedChanged(object sender, EventArgs e)
        {
            txt_rg3Args.Enabled = chk_ViewArgs.Checked;
        }

        private void but_browserg3_Click(object sender, EventArgs e)
        {
            DialogResult getResult = dlg_OpenFile.ShowDialog();
            if (getResult == DialogResult.OK)
            { txt_rg3Loc.Text = dlg_OpenFile.FileName; }
        }

        private void frm_Settings_Load(object sender, EventArgs e)
        {
            txt_rg3Args.Enabled = false;
        }

        private void but_Update_Click(object sender, EventArgs e)
        {
            DialogResult update = MessageBox.Show(this, "This function was start the RG3 Update Tool - It will connect to a GitHub Server to download the latest version\nMusicBee may need to be ran as Administrator for this function" +
                " to succeed\n\n Are you sure you wish to continue?", "Plugin Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (update == DialogResult.Yes)
            {
                try
                {
                    Process rg3Process = new Process();
                    rg3Process.StartInfo.UseShellExecute = true;
                    rg3Process.StartInfo.CreateNoWindow = false;
                    rg3Process.StartInfo.FileName = txt_rg3Loc.Text;
                    rg3Process.StartInfo.Arguments = (" -U");
                    rg3Process.Start();
                    rg3Process.WaitForExit();
                }
                catch
                {
                    MessageBox.Show(this, "Failed to launch the process!", "Plugin Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
