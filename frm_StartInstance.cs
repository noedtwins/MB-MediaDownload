﻿using System;
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
    public partial class frm_StartInstance : Form
    {

        public Boolean ignoreCheckChange = false;

        public frm_StartInstance()
        {
            InitializeComponent();
            this.AcceptButton = but_NextStage;
            this.lbl_Title.Parent = pic_Top;
            this.pic_ICO.Parent = pic_Top;
            lbl_Version.Text = "Plugin Version: " + Program.versionCode;
            this.Visible = false;
        }

        private void but_NextStage_Click(object sender, EventArgs e)
        {
            pluginInstance.gotoCatchURL();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!ignoreCheckChange)
            {
                pluginInstance.config.termsAccepted = chk_AcceptTerms.Checked;
                pluginInstance.config.saveSettings(pluginInstance.config, true);
            }

        }

        private void chk_AcceptTerms_CheckStateChanged(object sender, EventArgs e)
        {
            but_NextStage.Enabled = chk_AcceptTerms.Checked;

        }

        public void but_Settings_Click(object sender, EventArgs e)
        {
            pluginInstance.showSettingsForm();
        }

        private void frm_StartInstance_FormClosing(object sender, FormClosingEventArgs e)
        {
            pluginInstance.closeApplication();
        }

        public void updateTermsBox()
        {
            but_NextStage.Focus();

            ignoreCheckChange = true;
            chk_AcceptTerms.Checked = pluginInstance.config.termsAccepted;
            ignoreCheckChange = false;

        }

        private void frm_StartInstance_Load(object sender, EventArgs e)
        {
            updateTermsBox();
        }
    }
}
