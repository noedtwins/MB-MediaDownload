namespace mediaDownloader
{
    partial class frm_TagModify
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TagModify));
            this.txt_CustomComment = new System.Windows.Forms.TextBox();
            this.chk_SendCustom = new System.Windows.Forms.CheckBox();
            this.chk_URL = new System.Windows.Forms.CheckBox();
            this.chk_Date = new System.Windows.Forms.CheckBox();
            this.chk_PlugInfo = new System.Windows.Forms.CheckBox();
            this.txt_CommentPreview = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grp_Tag = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.but_Close = new System.Windows.Forms.Button();
            this.but_NextStage = new System.Windows.Forms.Button();
            this.grp_FrmButtons = new System.Windows.Forms.GroupBox();
            this.cbo_tag = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pic_TopLine = new System.Windows.Forms.PictureBox();
            this.pic_ICO = new System.Windows.Forms.PictureBox();
            this.pic_Top = new System.Windows.Forms.PictureBox();
            this.grp_Tag.SuspendLayout();
            this.grp_FrmButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TopLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ICO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Top)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_CustomComment
            // 
            this.txt_CustomComment.Enabled = false;
            this.txt_CustomComment.Location = new System.Drawing.Point(114, 182);
            this.txt_CustomComment.MaxLength = 46;
            this.txt_CustomComment.Name = "txt_CustomComment";
            this.txt_CustomComment.Size = new System.Drawing.Size(322, 20);
            this.txt_CustomComment.TabIndex = 16;
            this.txt_CustomComment.TextChanged += new System.EventHandler(this.txt_CustomComment_TextChanged);
            // 
            // chk_SendCustom
            // 
            this.chk_SendCustom.AutoSize = true;
            this.chk_SendCustom.Location = new System.Drawing.Point(8, 184);
            this.chk_SendCustom.Name = "chk_SendCustom";
            this.chk_SendCustom.Size = new System.Drawing.Size(110, 17);
            this.chk_SendCustom.TabIndex = 15;
            this.chk_SendCustom.Text = "Add Custom Text:";
            this.chk_SendCustom.UseVisualStyleBackColor = true;
            this.chk_SendCustom.CheckedChanged += new System.EventHandler(this.chk_SendCustom_CheckedChanged);
            // 
            // chk_URL
            // 
            this.chk_URL.AutoSize = true;
            this.chk_URL.Location = new System.Drawing.Point(8, 161);
            this.chk_URL.Name = "chk_URL";
            this.chk_URL.Size = new System.Drawing.Size(123, 17);
            this.chk_URL.TabIndex = 14;
            this.chk_URL.Text = "Include Source URL";
            this.chk_URL.UseVisualStyleBackColor = true;
            this.chk_URL.CheckedChanged += new System.EventHandler(this.chk_URL_CheckedChanged);
            // 
            // chk_Date
            // 
            this.chk_Date.AutoSize = true;
            this.chk_Date.Location = new System.Drawing.Point(8, 138);
            this.chk_Date.Name = "chk_Date";
            this.chk_Date.Size = new System.Drawing.Size(178, 17);
            this.chk_Date.TabIndex = 13;
            this.chk_Date.Text = "Include Conversion Date && Time";
            this.chk_Date.UseVisualStyleBackColor = true;
            this.chk_Date.CheckedChanged += new System.EventHandler(this.chk_Date_CheckedChanged);
            // 
            // chk_PlugInfo
            // 
            this.chk_PlugInfo.AutoSize = true;
            this.chk_PlugInfo.Location = new System.Drawing.Point(8, 115);
            this.chk_PlugInfo.Name = "chk_PlugInfo";
            this.chk_PlugInfo.Size = new System.Drawing.Size(227, 17);
            this.chk_PlugInfo.TabIndex = 12;
            this.chk_PlugInfo.Text = "Include Plugin Information in comment field";
            this.chk_PlugInfo.UseVisualStyleBackColor = true;
            this.chk_PlugInfo.CheckedChanged += new System.EventHandler(this.chk_PlugInfo_CheckedChanged);
            // 
            // txt_CommentPreview
            // 
            this.txt_CommentPreview.Enabled = false;
            this.txt_CommentPreview.Location = new System.Drawing.Point(8, 51);
            this.txt_CommentPreview.Multiline = true;
            this.txt_CommentPreview.Name = "txt_CommentPreview";
            this.txt_CommentPreview.Size = new System.Drawing.Size(428, 61);
            this.txt_CommentPreview.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Comment Tag";
            // 
            // grp_Tag
            // 
            this.grp_Tag.Controls.Add(this.txt_CustomComment);
            this.grp_Tag.Controls.Add(this.chk_SendCustom);
            this.grp_Tag.Controls.Add(this.chk_URL);
            this.grp_Tag.Controls.Add(this.chk_Date);
            this.grp_Tag.Controls.Add(this.chk_PlugInfo);
            this.grp_Tag.Controls.Add(this.txt_CommentPreview);
            this.grp_Tag.Controls.Add(this.label4);
            this.grp_Tag.Controls.Add(this.label3);
            this.grp_Tag.Location = new System.Drawing.Point(5, 102);
            this.grp_Tag.Name = "grp_Tag";
            this.grp_Tag.Size = new System.Drawing.Size(443, 211);
            this.grp_Tag.TabIndex = 37;
            this.grp_Tag.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Preview";
            // 
            // but_Close
            // 
            this.but_Close.Location = new System.Drawing.Point(19, 11);
            this.but_Close.Name = "but_Close";
            this.but_Close.Size = new System.Drawing.Size(112, 30);
            this.but_Close.TabIndex = 11;
            this.but_Close.Text = "Cancel";
            this.but_Close.UseVisualStyleBackColor = true;
            this.but_Close.Click += new System.EventHandler(this.but_Close_Click);
            // 
            // but_NextStage
            // 
            this.but_NextStage.Location = new System.Drawing.Point(138, 11);
            this.but_NextStage.Name = "but_NextStage";
            this.but_NextStage.Size = new System.Drawing.Size(118, 30);
            this.but_NextStage.TabIndex = 9;
            this.but_NextStage.Text = "Apply";
            this.but_NextStage.UseVisualStyleBackColor = true;
            this.but_NextStage.Click += new System.EventHandler(this.but_NextStage_Click);
            // 
            // grp_FrmButtons
            // 
            this.grp_FrmButtons.Controls.Add(this.but_Close);
            this.grp_FrmButtons.Controls.Add(this.but_NextStage);
            this.grp_FrmButtons.Location = new System.Drawing.Point(98, 316);
            this.grp_FrmButtons.Name = "grp_FrmButtons";
            this.grp_FrmButtons.Size = new System.Drawing.Size(278, 46);
            this.grp_FrmButtons.TabIndex = 36;
            this.grp_FrmButtons.TabStop = false;
            // 
            // cbo_tag
            // 
            this.cbo_tag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tag.FormattingEnabled = true;
            this.cbo_tag.Items.AddRange(new object[] {
            "Comment"});
            this.cbo_tag.Location = new System.Drawing.Point(62, 81);
            this.cbo_tag.Name = "cbo_tag";
            this.cbo_tag.Size = new System.Drawing.Size(121, 21);
            this.cbo_tag.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Select Field:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Auto Tag Modifier";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Location = new System.Drawing.Point(55, 4);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(333, 37);
            this.lbl_Title.TabIndex = 31;
            this.lbl_Title.Text = "Media: Download Plugin";
            // 
            // pic_TopLine
            // 
            this.pic_TopLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(131)))), ((int)(((byte)(155)))));
            this.pic_TopLine.Location = new System.Drawing.Point(-17, 47);
            this.pic_TopLine.Name = "pic_TopLine";
            this.pic_TopLine.Size = new System.Drawing.Size(492, 5);
            this.pic_TopLine.TabIndex = 32;
            this.pic_TopLine.TabStop = false;
            // 
            // pic_ICO
            // 
            this.pic_ICO.Image = global::mediaDownloader.Properties.Resources.basic_icon;
            this.pic_ICO.Location = new System.Drawing.Point(4, 2);
            this.pic_ICO.Name = "pic_ICO";
            this.pic_ICO.Size = new System.Drawing.Size(49, 41);
            this.pic_ICO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ICO.TabIndex = 30;
            this.pic_ICO.TabStop = false;
            // 
            // pic_Top
            // 
            this.pic_Top.BackColor = System.Drawing.Color.DimGray;
            this.pic_Top.Location = new System.Drawing.Point(-6, -2);
            this.pic_Top.Name = "pic_Top";
            this.pic_Top.Size = new System.Drawing.Size(491, 50);
            this.pic_Top.TabIndex = 29;
            this.pic_Top.TabStop = false;
            // 
            // frm_TagModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 373);
            this.Controls.Add(this.grp_Tag);
            this.Controls.Add(this.grp_FrmButtons);
            this.Controls.Add(this.cbo_tag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_TopLine);
            this.Controls.Add(this.pic_ICO);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.pic_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_TagModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Downloader: Modify Tag";
            this.Load += new System.EventHandler(this.frm_TagModify_Load);
            this.grp_Tag.ResumeLayout(false);
            this.grp_Tag.PerformLayout();
            this.grp_FrmButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_TopLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ICO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Top)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_CustomComment;
        private System.Windows.Forms.CheckBox chk_SendCustom;
        private System.Windows.Forms.CheckBox chk_URL;
        private System.Windows.Forms.CheckBox chk_Date;
        private System.Windows.Forms.CheckBox chk_PlugInfo;
        private System.Windows.Forms.TextBox txt_CommentPreview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grp_Tag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button but_Close;
        private System.Windows.Forms.Button but_NextStage;
        private System.Windows.Forms.GroupBox grp_FrmButtons;
        private System.Windows.Forms.ComboBox cbo_tag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_TopLine;
        private System.Windows.Forms.PictureBox pic_ICO;
        private System.Windows.Forms.PictureBox pic_Top;
        private System.Windows.Forms.Label lbl_Title;
    }
}