﻿namespace mediaDownloader
{
    partial class frm_GetURL
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
            this.but_Previous = new System.Windows.Forms.Button();
            this.but_Reset = new System.Windows.Forms.Button();
            this.but_NextStage = new System.Windows.Forms.Button();
            this.lbl_FormatCount = new System.Windows.Forms.Label();
            this.lbl_VideoTitle = new System.Windows.Forms.Label();
            this.txt_MediaURL = new System.Windows.Forms.TextBox();
            this.grp_FrmButtons = new System.Windows.Forms.GroupBox();
            this.grp_VidDetails = new System.Windows.Forms.GroupBox();
            this.flow_DownRdoButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.pic_Thumb = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.but_ContStage = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.bk_QueryFormats = new System.ComponentModel.BackgroundWorker();
            this.pic_InfLoad = new System.Windows.Forms.PictureBox();
            this.but_MoreOptions = new System.Windows.Forms.Button();
            this.pic_TopLine = new System.Windows.Forms.PictureBox();
            this.pic_ICO = new System.Windows.Forms.PictureBox();
            this.pic_Top = new System.Windows.Forms.PictureBox();
            this.grp_FrmButtons.SuspendLayout();
            this.grp_VidDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Thumb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_InfLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TopLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ICO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Top)).BeginInit();
            this.SuspendLayout();
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
            // txt_MediaURL
            // 
            this.txt_MediaURL.Location = new System.Drawing.Point(3, 77);
            this.txt_MediaURL.Name = "txt_MediaURL";
            this.txt_MediaURL.Size = new System.Drawing.Size(430, 20);
            this.txt_MediaURL.TabIndex = 14;
            this.txt_MediaURL.Text = "Insert URL Here...";
            // 
            // grp_FrmButtons
            // 
            this.grp_FrmButtons.Controls.Add(this.but_Previous);
            this.grp_FrmButtons.Controls.Add(this.but_Reset);
            this.grp_FrmButtons.Controls.Add(this.but_NextStage);
            this.grp_FrmButtons.Location = new System.Drawing.Point(3, 417);
            this.grp_FrmButtons.Name = "grp_FrmButtons";
            this.grp_FrmButtons.Size = new System.Drawing.Size(469, 46);
            this.grp_FrmButtons.TabIndex = 25;
            this.grp_FrmButtons.TabStop = false;
            // 
            // grp_VidDetails
            // 
            this.grp_VidDetails.Controls.Add(this.flow_DownRdoButtons);
            this.grp_VidDetails.Controls.Add(this.lbl_FormatCount);
            this.grp_VidDetails.Controls.Add(this.lbl_VideoTitle);
            this.grp_VidDetails.Controls.Add(this.pic_Thumb);
            this.grp_VidDetails.Location = new System.Drawing.Point(10, 103);
            this.grp_VidDetails.Name = "grp_VidDetails";
            this.grp_VidDetails.Size = new System.Drawing.Size(462, 304);
            this.grp_VidDetails.TabIndex = 24;
            this.grp_VidDetails.TabStop = false;
            this.grp_VidDetails.Visible = false;
            // 
            // flow_DownRdoButtons
            // 
            this.flow_DownRdoButtons.BackColor = System.Drawing.SystemColors.Control;
            this.flow_DownRdoButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flow_DownRdoButtons.Location = new System.Drawing.Point(0, 74);
            this.flow_DownRdoButtons.Name = "flow_DownRdoButtons";
            this.flow_DownRdoButtons.Size = new System.Drawing.Size(462, 224);
            this.flow_DownRdoButtons.TabIndex = 3;
            this.flow_DownRdoButtons.Visible = false;
            // 
            // pic_Thumb
            // 
            this.pic_Thumb.Image = global::mediaDownloader.Properties.Resources.ajaxLoad;
            this.pic_Thumb.Location = new System.Drawing.Point(6, 13);
            this.pic_Thumb.Name = "pic_Thumb";
            this.pic_Thumb.Size = new System.Drawing.Size(79, 48);
            this.pic_Thumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_Thumb.TabIndex = 0;
            this.pic_Thumb.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 469);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(480, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Media URL";
            // 
            // but_ContStage
            // 
            this.but_ContStage.Location = new System.Drawing.Point(194, 103);
            this.but_ContStage.Name = "but_ContStage";
            this.but_ContStage.Size = new System.Drawing.Size(75, 23);
            this.but_ContStage.TabIndex = 20;
            this.but_ContStage.Text = "Continue";
            this.but_ContStage.UseVisualStyleBackColor = true;
            this.but_ContStage.Click += new System.EventHandler(this.but_ContStage_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Location = new System.Drawing.Point(63, 7);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(333, 37);
            this.lbl_Title.TabIndex = 18;
            this.lbl_Title.Text = "Media: Download Plugin";
            // 
            // bk_QueryFormats
            // 
            this.bk_QueryFormats.WorkerSupportsCancellation = true;
            this.bk_QueryFormats.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bk_QueryFormats_DoWork);
            this.bk_QueryFormats.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bk_QueryFormats_RunWorkerCompleted);
            // 
            // pic_InfLoad
            // 
            this.pic_InfLoad.Image = global::mediaDownloader.Properties.Resources.ajaxLoad;
            this.pic_InfLoad.Location = new System.Drawing.Point(135, 276);
            this.pic_InfLoad.Name = "pic_InfLoad";
            this.pic_InfLoad.Size = new System.Drawing.Size(236, 28);
            this.pic_InfLoad.TabIndex = 27;
            this.pic_InfLoad.TabStop = false;
            this.pic_InfLoad.Visible = false;
            // 
            // but_MoreOptions
            // 
            this.but_MoreOptions.Image = global::mediaDownloader.Properties.Resources.menu_icon_16;
            this.but_MoreOptions.Location = new System.Drawing.Point(439, 63);
            this.but_MoreOptions.Name = "but_MoreOptions";
            this.but_MoreOptions.Size = new System.Drawing.Size(26, 38);
            this.but_MoreOptions.TabIndex = 26;
            this.but_MoreOptions.UseVisualStyleBackColor = true;
            this.but_MoreOptions.Click += new System.EventHandler(this.but_MoreOptions_Click);
            // 
            // pic_TopLine
            // 
            this.pic_TopLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(131)))), ((int)(((byte)(155)))));
            this.pic_TopLine.Location = new System.Drawing.Point(-5, 49);
            this.pic_TopLine.Name = "pic_TopLine";
            this.pic_TopLine.Size = new System.Drawing.Size(492, 5);
            this.pic_TopLine.TabIndex = 19;
            this.pic_TopLine.TabStop = false;
            // 
            // pic_ICO
            // 
            this.pic_ICO.Image = global::mediaDownloader.Properties.Resources.basic_icon;
            this.pic_ICO.Location = new System.Drawing.Point(10, 2);
            this.pic_ICO.Name = "pic_ICO";
            this.pic_ICO.Size = new System.Drawing.Size(49, 41);
            this.pic_ICO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ICO.TabIndex = 16;
            this.pic_ICO.TabStop = false;
            // 
            // pic_Top
            // 
            this.pic_Top.BackColor = System.Drawing.Color.DimGray;
            this.pic_Top.Location = new System.Drawing.Point(-15, 0);
            this.pic_Top.Name = "pic_Top";
            this.pic_Top.Size = new System.Drawing.Size(509, 50);
            this.pic_Top.TabIndex = 15;
            this.pic_Top.TabStop = false;
            // 
            // frm_GetURL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 491);
            this.Controls.Add(this.pic_InfLoad);
            this.Controls.Add(this.but_MoreOptions);
            this.Controls.Add(this.txt_MediaURL);
            this.Controls.Add(this.grp_FrmButtons);
            this.Controls.Add(this.grp_VidDetails);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_ContStage);
            this.Controls.Add(this.pic_TopLine);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.pic_ICO);
            this.Controls.Add(this.pic_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_GetURL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Download Plugin: Retrieve URL";
            this.Activated += new System.EventHandler(this.frm_GetURL_Activated);
            this.grp_FrmButtons.ResumeLayout(false);
            this.grp_VidDetails.ResumeLayout(false);
            this.grp_VidDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Thumb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_InfLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TopLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ICO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Top)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button but_Previous;
        private System.Windows.Forms.Button but_Reset;
        private System.Windows.Forms.Button but_NextStage;
        private System.Windows.Forms.Label lbl_FormatCount;
        private System.Windows.Forms.Label lbl_VideoTitle;
        private System.Windows.Forms.PictureBox pic_Thumb;
        private System.Windows.Forms.Button but_MoreOptions;
        private System.Windows.Forms.TextBox txt_MediaURL;
        private System.Windows.Forms.GroupBox grp_FrmButtons;
        private System.Windows.Forms.GroupBox grp_VidDetails;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_ContStage;
        private System.Windows.Forms.PictureBox pic_TopLine;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox pic_ICO;
        private System.Windows.Forms.PictureBox pic_Top;
        private System.Windows.Forms.PictureBox pic_InfLoad;
        private System.ComponentModel.BackgroundWorker bk_QueryFormats;
        private System.Windows.Forms.FlowLayoutPanel flow_DownRdoButtons;
    }
}