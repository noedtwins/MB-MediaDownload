﻿namespace MusicBeePlugin
{
    partial class frm_StartPage
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
            this.components = new System.ComponentModel.Container();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pic_Top = new System.Windows.Forms.PictureBox();
            this.but_ContStage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MediaURL = new System.Windows.Forms.TextBox();
            this.pnl_AvaFormat = new System.Windows.Forms.Panel();
            this.pnl_SCDownload = new System.Windows.Forms.Panel();
            this.lbl_DecodeInfo = new System.Windows.Forms.Label();
            this.pic_SCLoad = new System.Windows.Forms.PictureBox();
            this.lbl_SCInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pic_INILOAD = new System.Windows.Forms.PictureBox();
            this.flow_DownRdoButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.grp_ShowMsg = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_MsgInfo = new System.Windows.Forms.Label();
            this.grp_VidDetails = new System.Windows.Forms.GroupBox();
            this.lbl_FormatCount = new System.Windows.Forms.Label();
            this.lbl_VideoTitle = new System.Windows.Forms.Label();
            this.pic_Thumb = new System.Windows.Forms.PictureBox();
            this.but_Reset = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.grp_FrmButtons = new System.Windows.Forms.GroupBox();
            this.but_Previous = new System.Windows.Forms.Button();
            this.but_NextStage = new System.Windows.Forms.Button();
            this.tmr_CompleteTaskStart = new System.Windows.Forms.Timer(this.components);
            this.bkWork_GetDetails = new System.ComponentModel.BackgroundWorker();
            this.but_MoreOptions = new System.Windows.Forms.Button();
            this.pic_TopLine = new System.Windows.Forms.PictureBox();
            this.pic_ICO = new System.Windows.Forms.PictureBox();
            this.grp_Info = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Top)).BeginInit();
            this.pnl_AvaFormat.SuspendLayout();
            this.pnl_SCDownload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SCLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_INILOAD)).BeginInit();
            this.grp_ShowMsg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grp_VidDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Thumb)).BeginInit();
            this.grp_FrmButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TopLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ICO)).BeginInit();
            this.grp_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Location = new System.Drawing.Point(66, 5);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(333, 37);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "Media: Download Plugin";
            // 
            // pic_Top
            // 
            this.pic_Top.BackColor = System.Drawing.Color.DimGray;
            this.pic_Top.Location = new System.Drawing.Point(-12, 0);
            this.pic_Top.Name = "pic_Top";
            this.pic_Top.Size = new System.Drawing.Size(491, 50);
            this.pic_Top.TabIndex = 0;
            this.pic_Top.TabStop = false;
            // 
            // but_ContStage
            // 
            this.but_ContStage.Location = new System.Drawing.Point(197, 103);
            this.but_ContStage.Name = "but_ContStage";
            this.but_ContStage.Size = new System.Drawing.Size(75, 23);
            this.but_ContStage.TabIndex = 4;
            this.but_ContStage.Text = "Continue";
            this.but_ContStage.UseVisualStyleBackColor = true;
            this.but_ContStage.Click += new System.EventHandler(this.but_ContStage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Media URL";
            // 
            // txt_MediaURL
            // 
            this.txt_MediaURL.Location = new System.Drawing.Point(0, 0);
            this.txt_MediaURL.Name = "txt_MediaURL";
            this.txt_MediaURL.Size = new System.Drawing.Size(100, 20);
            this.txt_MediaURL.TabIndex = 0;
            // 
            // pnl_AvaFormat
            // 
            this.pnl_AvaFormat.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_AvaFormat.Controls.Add(this.pnl_SCDownload);
            this.pnl_AvaFormat.Controls.Add(this.pic_INILOAD);
            this.pnl_AvaFormat.Controls.Add(this.flow_DownRdoButtons);
            this.pnl_AvaFormat.Location = new System.Drawing.Point(0, 177);
            this.pnl_AvaFormat.Name = "pnl_AvaFormat";
            this.pnl_AvaFormat.Size = new System.Drawing.Size(472, 238);
            this.pnl_AvaFormat.TabIndex = 8;
            this.pnl_AvaFormat.Visible = false;
            // 
            // pnl_SCDownload
            // 
            this.pnl_SCDownload.Controls.Add(this.lbl_DecodeInfo);
            this.pnl_SCDownload.Controls.Add(this.pic_SCLoad);
            this.pnl_SCDownload.Controls.Add(this.lbl_SCInfo);
            this.pnl_SCDownload.Controls.Add(this.label2);
            this.pnl_SCDownload.Controls.Add(this.pictureBox2);
            this.pnl_SCDownload.Location = new System.Drawing.Point(6, 8);
            this.pnl_SCDownload.Name = "pnl_SCDownload";
            this.pnl_SCDownload.Size = new System.Drawing.Size(458, 189);
            this.pnl_SCDownload.TabIndex = 2;
            this.pnl_SCDownload.Visible = false;
            // 
            // lbl_DecodeInfo
            // 
            this.lbl_DecodeInfo.AutoSize = true;
            this.lbl_DecodeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DecodeInfo.Location = new System.Drawing.Point(118, 144);
            this.lbl_DecodeInfo.Name = "lbl_DecodeInfo";
            this.lbl_DecodeInfo.Size = new System.Drawing.Size(260, 32);
            this.lbl_DecodeInfo.TabIndex = 5;
            this.lbl_DecodeInfo.Text = "Attempting to retrieve a http stream...\r\nThis may take a few seconds";
            // 
            // pic_SCLoad
            // 
            this.pic_SCLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_SCLoad.Image = global::MusicBeePlugin.Properties.Resources.ajaxLoad;
            this.pic_SCLoad.Location = new System.Drawing.Point(124, 103);
            this.pic_SCLoad.Name = "pic_SCLoad";
            this.pic_SCLoad.Size = new System.Drawing.Size(216, 36);
            this.pic_SCLoad.TabIndex = 4;
            this.pic_SCLoad.TabStop = false;
            // 
            // lbl_SCInfo
            // 
            this.lbl_SCInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SCInfo.Location = new System.Drawing.Point(82, 30);
            this.lbl_SCInfo.Name = "lbl_SCInfo";
            this.lbl_SCInfo.Size = new System.Drawing.Size(361, 87);
            this.lbl_SCInfo.TabIndex = 3;
            this.lbl_SCInfo.Text = "Unknown Label Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soundcloud Information";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MusicBeePlugin.Properties.Resources._300px_Simple_Attention_svg;
            this.pictureBox2.Location = new System.Drawing.Point(7, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pic_INILOAD
            // 
            this.pic_INILOAD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_INILOAD.Image = global::MusicBeePlugin.Properties.Resources.ajaxLoad;
            this.pic_INILOAD.Location = new System.Drawing.Point(130, 80);
            this.pic_INILOAD.Name = "pic_INILOAD";
            this.pic_INILOAD.Size = new System.Drawing.Size(216, 67);
            this.pic_INILOAD.TabIndex = 0;
            this.pic_INILOAD.TabStop = false;
            // 
            // flow_DownRdoButtons
            // 
            this.flow_DownRdoButtons.BackColor = System.Drawing.SystemColors.Control;
            this.flow_DownRdoButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flow_DownRdoButtons.Location = new System.Drawing.Point(5, 3);
            this.flow_DownRdoButtons.Name = "flow_DownRdoButtons";
            this.flow_DownRdoButtons.Size = new System.Drawing.Size(462, 195);
            this.flow_DownRdoButtons.TabIndex = 1;
            this.flow_DownRdoButtons.Visible = false;
            // 
            // grp_ShowMsg
            // 
            this.grp_ShowMsg.Controls.Add(this.pictureBox1);
            this.grp_ShowMsg.Controls.Add(this.lbl_MsgInfo);
            this.grp_ShowMsg.Location = new System.Drawing.Point(9, 380);
            this.grp_ShowMsg.Name = "grp_ShowMsg";
            this.grp_ShowMsg.Size = new System.Drawing.Size(461, 38);
            this.grp_ShowMsg.TabIndex = 2;
            this.grp_ShowMsg.TabStop = false;
            this.grp_ShowMsg.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MusicBeePlugin.Properties.Resources._300px_Simple_Attention_svg;
            this.pictureBox1.Location = new System.Drawing.Point(1, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_MsgInfo
            // 
            this.lbl_MsgInfo.AutoSize = true;
            this.lbl_MsgInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MsgInfo.Location = new System.Drawing.Point(36, 14);
            this.lbl_MsgInfo.Name = "lbl_MsgInfo";
            this.lbl_MsgInfo.Size = new System.Drawing.Size(50, 15);
            this.lbl_MsgInfo.TabIndex = 2;
            this.lbl_MsgInfo.Text = "txt_MSG";
            // 
            // grp_VidDetails
            // 
            this.grp_VidDetails.Controls.Add(this.lbl_FormatCount);
            this.grp_VidDetails.Controls.Add(this.lbl_VideoTitle);
            this.grp_VidDetails.Controls.Add(this.pic_Thumb);
            this.grp_VidDetails.Location = new System.Drawing.Point(3, 103);
            this.grp_VidDetails.Name = "grp_VidDetails";
            this.grp_VidDetails.Size = new System.Drawing.Size(462, 68);
            this.grp_VidDetails.TabIndex = 10;
            this.grp_VidDetails.TabStop = false;
            this.grp_VidDetails.Visible = false;
            // 
            // lbl_FormatCount
            // 
            this.lbl_FormatCount.AutoSize = true;
            this.lbl_FormatCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FormatCount.Location = new System.Drawing.Point(92, 40);
            this.lbl_FormatCount.Name = "lbl_FormatCount";
            this.lbl_FormatCount.Size = new System.Drawing.Size(177, 16);
            this.lbl_FormatCount.TabIndex = 2;
            this.lbl_FormatCount.Text = "Discovered Valid Formats: 0";
            // 
            // lbl_VideoTitle
            // 
            this.lbl_VideoTitle.AutoSize = true;
            this.lbl_VideoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VideoTitle.Location = new System.Drawing.Point(91, 15);
            this.lbl_VideoTitle.Name = "lbl_VideoTitle";
            this.lbl_VideoTitle.Size = new System.Drawing.Size(117, 20);
            this.lbl_VideoTitle.TabIndex = 1;
            this.lbl_VideoTitle.Text = "lbl_VideoTitle";
            // 
            // pic_Thumb
            // 
            this.pic_Thumb.ErrorImage = global::MusicBeePlugin.Properties.Resources.unknownThumb;
            this.pic_Thumb.Image = global::MusicBeePlugin.Properties.Resources.ajaxLoad;
            this.pic_Thumb.Location = new System.Drawing.Point(6, 13);
            this.pic_Thumb.Name = "pic_Thumb";
            this.pic_Thumb.Size = new System.Drawing.Size(79, 48);
            this.pic_Thumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_Thumb.TabIndex = 0;
            this.pic_Thumb.TabStop = false;
            // 
            // but_Reset
            // 
            this.but_Reset.Location = new System.Drawing.Point(176, 11);
            this.but_Reset.Name = "but_Reset";
            this.but_Reset.Size = new System.Drawing.Size(112, 30);
            this.but_Reset.TabIndex = 10;
            this.but_Reset.Text = "Reset This Stage";
            this.but_Reset.UseVisualStyleBackColor = true;
            this.but_Reset.Visible = false;
            this.but_Reset.Click += new System.EventHandler(this.but_Reset_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 461);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(479, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // grp_FrmButtons
            // 
            this.grp_FrmButtons.Controls.Add(this.but_Previous);
            this.grp_FrmButtons.Controls.Add(this.but_Reset);
            this.grp_FrmButtons.Controls.Add(this.but_NextStage);
            this.grp_FrmButtons.Location = new System.Drawing.Point(4, 413);
            this.grp_FrmButtons.Name = "grp_FrmButtons";
            this.grp_FrmButtons.Size = new System.Drawing.Size(469, 46);
            this.grp_FrmButtons.TabIndex = 11;
            this.grp_FrmButtons.TabStop = false;
            // 
            // but_Previous
            // 
            this.but_Previous.Location = new System.Drawing.Point(9, 11);
            this.but_Previous.Name = "but_Previous";
            this.but_Previous.Size = new System.Drawing.Size(112, 30);
            this.but_Previous.TabIndex = 10;
            this.but_Previous.Text = "<- Previous";
            this.but_Previous.UseVisualStyleBackColor = true;
            this.but_Previous.Click += new System.EventHandler(this.but_Previous_Click);
            // 
            // but_NextStage
            // 
            this.but_NextStage.Location = new System.Drawing.Point(345, 10);
            this.but_NextStage.Name = "but_NextStage";
            this.but_NextStage.Size = new System.Drawing.Size(118, 30);
            this.but_NextStage.TabIndex = 9;
            this.but_NextStage.Text = "Continue ->";
            this.but_NextStage.UseVisualStyleBackColor = true;
            this.but_NextStage.Visible = false;
            this.but_NextStage.Click += new System.EventHandler(this.but_NextStage_Click);
            // 
            // bkWork_GetDetails
            // 
            this.bkWork_GetDetails.WorkerReportsProgress = true;
            this.bkWork_GetDetails.WorkerSupportsCancellation = true;
            this.bkWork_GetDetails.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkWork_GetDetails_DoWork);
            this.bkWork_GetDetails.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bkWork_GetDetails_Completed);
            // 
            // but_MoreOptions
            // 
            this.but_MoreOptions.Image = global::MusicBeePlugin.Properties.Resources.menu_icon_16;
            this.but_MoreOptions.Location = new System.Drawing.Point(442, 63);
            this.but_MoreOptions.Name = "but_MoreOptions";
            this.but_MoreOptions.Size = new System.Drawing.Size(26, 38);
            this.but_MoreOptions.TabIndex = 12;
            this.but_MoreOptions.UseVisualStyleBackColor = true;
            this.but_MoreOptions.Click += new System.EventHandler(this.but_PasteFromClipboard_Click);
            // 
            // pic_TopLine
            // 
            this.pic_TopLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(131)))), ((int)(((byte)(155)))));
            this.pic_TopLine.Location = new System.Drawing.Point(-2, 49);
            this.pic_TopLine.Name = "pic_TopLine";
            this.pic_TopLine.Size = new System.Drawing.Size(492, 5);
            this.pic_TopLine.TabIndex = 3;
            this.pic_TopLine.TabStop = false;
            // 
            // pic_ICO
            // 
            this.pic_ICO.Image = global::MusicBeePlugin.Properties.Resources.iconFile1;
            this.pic_ICO.Location = new System.Drawing.Point(15, 3);
            this.pic_ICO.Name = "pic_ICO";
            this.pic_ICO.Size = new System.Drawing.Size(49, 41);
            this.pic_ICO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ICO.TabIndex = 1;
            this.pic_ICO.TabStop = false;
            // 
            // grp_Info
            // 
            this.grp_Info.Controls.Add(this.label5);
            this.grp_Info.Controls.Add(this.label4);
            this.grp_Info.Controls.Add(this.label3);
            this.grp_Info.Controls.Add(this.pictureBox3);
            this.grp_Info.Location = new System.Drawing.Point(7, 140);
            this.grp_Info.Name = "grp_Info";
            this.grp_Info.Size = new System.Drawing.Size(462, 175);
            this.grp_Info.TabIndex = 13;
            this.grp_Info.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(390, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "The creator of this plugin does not take liability towards the user or any third " +
    "party \r\nfor the permissibility of downloading content using this plugin.\r\n";
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(138, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 93);
            this.label4.TabIndex = 2;
            this.label4.Text = "Supported Media\r\n---------------------\r\n• YouTube Media\r\n• Downloadable Soundclou" +
    "d Media\r\n• Restricted Download Soundcloud Media (128kpbs Maximum)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Information";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MusicBeePlugin.Properties.Resources._300px_Simple_Attention_svg;
            this.pictureBox3.Location = new System.Drawing.Point(5, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(127, 97);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // frm_StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 483);
            this.Controls.Add(this.grp_Info);
            this.Controls.Add(this.grp_ShowMsg);
            this.Controls.Add(this.but_MoreOptions);
            this.Controls.Add(this.grp_FrmButtons);
            this.Controls.Add(this.grp_VidDetails);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_ContStage);
            this.Controls.Add(this.pic_TopLine);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.pic_ICO);
            this.Controls.Add(this.pic_Top);
            this.Controls.Add(this.pnl_AvaFormat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frm_StartPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicBee Plugin: Media Download (By Cyano)";
            this.Activated += new System.EventHandler(this.frm_StartPage_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_StartPage_FormClosing);
            this.Load += new System.EventHandler(this.frm_StartPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Top)).EndInit();
            this.pnl_AvaFormat.ResumeLayout(false);
            this.pnl_SCDownload.ResumeLayout(false);
            this.pnl_SCDownload.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SCLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_INILOAD)).EndInit();
            this.grp_ShowMsg.ResumeLayout(false);
            this.grp_ShowMsg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grp_VidDetails.ResumeLayout(false);
            this.grp_VidDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Thumb)).EndInit();
            this.grp_FrmButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_TopLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ICO)).EndInit();
            this.grp_Info.ResumeLayout(false);
            this.grp_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public void InitCustomControls(Plugin.MusicBeeApiInterface useAPI)
        {
            this.pic_ICO.Parent = this.pic_Top;
            this.lbl_Title.Parent = this.pic_Top;

            if (!mLogic.legacyMode)
            {
                this.txt_MediaURL = (System.Windows.Forms.TextBox)useAPI.MB_AddPanel(null, Plugin.PluginPanelDock.TextBox);
            }

            this.txt_MediaURL.Location = new System.Drawing.Point(5, 77);
            this.txt_MediaURL.Name = "txt_MediaURL";
            this.txt_MediaURL.Size = new System.Drawing.Size(435, 20);
            this.txt_MediaURL.TabIndex = 6;
            this.txt_MediaURL.Text = "Insert URL Here...";
            this.txt_MediaURL.Enter += new System.EventHandler(this.txt_MediaURL_Enter);
            this.txt_MediaURL.Leave += new System.EventHandler(this.txt_MediaURL_Leave);
            this.Controls.Add(txt_MediaURL);
            this.txt_MediaURL.BringToFront();
        }

        private System.Windows.Forms.PictureBox pic_Top;
        private System.Windows.Forms.PictureBox pic_ICO;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox pic_TopLine;
        private System.Windows.Forms.Button but_ContStage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MediaURL;
        private System.Windows.Forms.Panel pnl_AvaFormat;
        private System.Windows.Forms.PictureBox pic_INILOAD;
        private System.Windows.Forms.FlowLayoutPanel flow_DownRdoButtons;
        private System.Windows.Forms.GroupBox grp_VidDetails;
        private System.Windows.Forms.Label lbl_VideoTitle;
        private System.Windows.Forms.PictureBox pic_Thumb;
        private System.Windows.Forms.Label lbl_FormatCount;
        private System.Windows.Forms.Button but_Reset;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox grp_FrmButtons;
        private System.Windows.Forms.Button but_NextStage;
        private System.Windows.Forms.Timer tmr_CompleteTaskStart;
        private System.ComponentModel.BackgroundWorker bkWork_GetDetails;
        private System.Windows.Forms.Button but_MoreOptions;
        private System.Windows.Forms.GroupBox grp_ShowMsg;
        private System.Windows.Forms.Label lbl_MsgInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button but_Previous;
        private System.Windows.Forms.Panel pnl_SCDownload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_SCInfo;
        private System.Windows.Forms.Label lbl_DecodeInfo;
        private System.Windows.Forms.PictureBox pic_SCLoad;
        private System.Windows.Forms.GroupBox grp_Info;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;

    }
}