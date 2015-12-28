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
    public partial class frm_StartInstance : Form
    {
        public frm_StartInstance()
        {
            InitializeComponent();
            lbl_Version.Text = "Plugin Version: " + Program.versionCode;
           
        }

        private void but_NextStage_Click(object sender, EventArgs e)
        {
            //TODO: Add Terms & Conditions Boolean Value

            pluginInstance.gotoCatchURL();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void chk_AcceptTerms_CheckStateChanged(object sender, EventArgs e)
        {
            but_NextStage.Enabled = chk_AcceptTerms.Checked;

        }

        private void lbl_Terms_Click(object sender, EventArgs e)
        {

        }

        private void grp_Lic_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
