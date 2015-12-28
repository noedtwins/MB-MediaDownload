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
    public partial class frm_TagModify : Form
    {
        private string fullTag;


        public frm_TagModify()
        {
            InitializeComponent();
            lbl_Title.Parent = pic_Top;
            pic_ICO.Parent = pic_Top;
            cbo_tag.Text = "Comment";
            loadControlSettings();
        }

        private void loadControlSettings()
        {
            chk_PlugInfo.Checked = pluginInstance.config.addCTagPlugInfo;
            chk_Date.Checked = pluginInstance.config.addCTagDateTime;
            chk_URL.Checked = pluginInstance.config.addCTagSource;
            chk_SendCustom.Checked = pluginInstance.config.addCTagCustomText;
            txt_CustomComment.Text = pluginInstance.config.addCTagCustomTextVal;
            refreshTag();

        }

        private void chk_PlugInfo_CheckedChanged(object sender, EventArgs e)
        {
            refreshTag();
        }

        private void chk_Date_CheckedChanged(object sender, EventArgs e)
        {
            refreshTag();
        }

        private void chk_URL_CheckedChanged(object sender, EventArgs e)
        {
            refreshTag();
        }

        private void chk_SendCustom_CheckedChanged(object sender, EventArgs e)
        {
            txt_CustomComment.Enabled = chk_SendCustom.Enabled;
            refreshTag();
        }

        private void refreshTag()
        {
            fullTag = "";
            txt_CommentPreview.Text = "";
            if (chk_PlugInfo.Checked)
            { addText("Converted using YT Download Plugin. By Cyano", "Converted using YT Download Plugin. By Cyano."); }
            if (chk_Date.Checked)
            { addText(Convert.ToString(DateTime.Now), "[Prop:Date]"); }
            if (chk_URL.Checked)
            { addText(@"http://www.youtube.com/watch?v=kffacxfA7G4", "[Prop:src_URL]"); }
            if (chk_SendCustom.Checked)
            { addText(txt_CustomComment.Text, txt_CustomComment.Text); }
        }

        private void addText(string TextPreview, string fullTagText)
        {
            fullTag = fullTag + fullTagText;
            if (txt_CommentPreview.Text == "")
            { txt_CommentPreview.Text = txt_CommentPreview.Text + TextPreview; }
            else
            { txt_CommentPreview.Text = txt_CommentPreview.Text + Environment.NewLine + TextPreview; }
        }

        private void txt_CustomComment_TextChanged(object sender, EventArgs e)
        {
            refreshTag();
        }

        private void frm_TagModify_Load(object sender, EventArgs e)
        {
            txt_CustomComment.Enabled = chk_SendCustom.Enabled;
        }

        private void but_NextStage_Click(object sender, EventArgs e)
        {
            int result = 0;
            foreach (char c in txt_CommentPreview.Text)
            { result++; }

            pluginInstance.config.addCTagPlugInfo = chk_PlugInfo.Checked;
            pluginInstance.config.addCTagDateTime = chk_Date.Checked;
            pluginInstance.config.addCTagSource = chk_URL.Checked;
            pluginInstance.config.addCTagCustomText = chk_SendCustom.Checked;
            pluginInstance.config.addCTagCustomTextVal = txt_CustomComment.Text;

            pluginInstance.config.saveSettings(pluginInstance.config);
            this.Close();
        }

        private void but_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
