namespace mediaDownloader
{
    partial class frm_ProcessMedia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ProcessMedia));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_TRate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grp_Download = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Size = new System.Windows.Forms.Label();
            this.txt_ConvLog = new System.Windows.Forms.TextBox();
            this.tmr_DelayStage4 = new System.Windows.Forms.Timer(this.components);
            this.bkWork_ConvertVideo = new System.ComponentModel.BackgroundWorker();
            this.bkWork_DownloadVideo = new System.ComponentModel.BackgroundWorker();
            this.tmr_StartProcess = new System.Windows.Forms.Timer(this.components);
            this.but_Finish = new System.Windows.Forms.Button();
            this.grp_FrmButtons = new System.Windows.Forms.GroupBox();
            this.lbl_LargeHeading = new System.Windows.Forms.Label();
            this.but_ConvertAgain = new System.Windows.Forms.Button();
            this.lbl_ManProg = new System.Windows.Forms.Label();
            this.lbl_Desc = new System.Windows.Forms.Label();
            this.prg_Main = new System.Windows.Forms.ProgressBar();
            this.lbl_Stage = new System.Windows.Forms.Label();
            this.lbl_DownloadETA = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pic_INILOAD = new System.Windows.Forms.PictureBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pic_Top = new System.Windows.Forms.PictureBox();
            this.tmr_DelayStage2 = new System.Windows.Forms.Timer(this.components);
            this.pic_TopLine = new System.Windows.Forms.PictureBox();
            this.pic_ICO = new System.Windows.Forms.PictureBox();
            this.bk_Decipher = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1.SuspendLayout();
            this.grp_Download.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grp_FrmButtons.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_INILOAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TopLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ICO)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 469);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(480, 22);
            this.statusStrip1.TabIndex = 39;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(168, 17);
            this.toolStripStatusLabel1.Text = "Media Downloader - By Cyano";
            // 
            // lbl_TRate
            // 
            this.lbl_TRate.AutoSize = true;
            this.lbl_TRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TRate.Location = new System.Drawing.Point(6, 89);
            this.lbl_TRate.Name = "lbl_TRate";
            this.lbl_TRate.Size = new System.Drawing.Size(191, 16);
            this.lbl_TRate.TabIndex = 25;
            this.lbl_TRate.Text = "Waiting for Download to Start....";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Download Information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grp_Download
            // 
            this.grp_Download.Controls.Add(this.pictureBox1);
            this.grp_Download.Controls.Add(this.lbl_TRate);
            this.grp_Download.Controls.Add(this.lbl_Size);
            this.grp_Download.Controls.Add(this.label2);
            this.grp_Download.Location = new System.Drawing.Point(38, 277);
            this.grp_Download.Name = "grp_Download";
            this.grp_Download.Size = new System.Drawing.Size(416, 124);
            this.grp_Download.TabIndex = 49;
            this.grp_Download.TabStop = false;
            this.grp_Download.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(131)))), ((int)(((byte)(155)))));
            this.pictureBox1.Location = new System.Drawing.Point(-55, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 5);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Size
            // 
            this.lbl_Size.AutoSize = true;
            this.lbl_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Size.Location = new System.Drawing.Point(6, 51);
            this.lbl_Size.Name = "lbl_Size";
            this.lbl_Size.Size = new System.Drawing.Size(191, 16);
            this.lbl_Size.TabIndex = 24;
            this.lbl_Size.Text = "Waiting for Download to Start....";
            // 
            // txt_ConvLog
            // 
            this.txt_ConvLog.Location = new System.Drawing.Point(48, 277);
            this.txt_ConvLog.Multiline = true;
            this.txt_ConvLog.Name = "txt_ConvLog";
            this.txt_ConvLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_ConvLog.Size = new System.Drawing.Size(406, 124);
            this.txt_ConvLog.TabIndex = 48;
            // 
            // tmr_DelayStage4
            // 
            this.tmr_DelayStage4.Interval = 1000;
            this.tmr_DelayStage4.Tick += new System.EventHandler(this.tmr_DelayStage4_Tick_1);
            // 
            // bkWork_ConvertVideo
            // 
            this.bkWork_ConvertVideo.WorkerSupportsCancellation = true;
            this.bkWork_ConvertVideo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkWork_ConvertVideo_DoWork);
            this.bkWork_ConvertVideo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bkWork_ConvertVideo_RunWorkerCompleted);
            // 
            // bkWork_DownloadVideo
            // 
            this.bkWork_DownloadVideo.WorkerReportsProgress = true;
            this.bkWork_DownloadVideo.WorkerSupportsCancellation = true;
            this.bkWork_DownloadVideo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkWork_DownloadVideo_DoWork);
            this.bkWork_DownloadVideo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bkWork_DownloadVideo_ProgressChanged);
            this.bkWork_DownloadVideo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bkWork_DownloadVideo_RunWorkerCompleted);
            // 
            // tmr_StartProcess
            // 
            this.tmr_StartProcess.Interval = 250;
            // 
            // but_Finish
            // 
            this.but_Finish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_Finish.Location = new System.Drawing.Point(3, 16);
            this.but_Finish.Name = "but_Finish";
            this.but_Finish.Size = new System.Drawing.Size(463, 27);
            this.but_Finish.TabIndex = 11;
            this.but_Finish.Text = "Cancel";
            this.but_Finish.UseVisualStyleBackColor = true;
            this.but_Finish.Click += new System.EventHandler(this.but_Finish_Click);
            // 
            // grp_FrmButtons
            // 
            this.grp_FrmButtons.Controls.Add(this.but_Finish);
            this.grp_FrmButtons.Location = new System.Drawing.Point(8, 412);
            this.grp_FrmButtons.Name = "grp_FrmButtons";
            this.grp_FrmButtons.Size = new System.Drawing.Size(469, 46);
            this.grp_FrmButtons.TabIndex = 46;
            this.grp_FrmButtons.TabStop = false;
            // 
            // lbl_LargeHeading
            // 
            this.lbl_LargeHeading.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LargeHeading.Location = new System.Drawing.Point(-7, 57);
            this.lbl_LargeHeading.Name = "lbl_LargeHeading";
            this.lbl_LargeHeading.Size = new System.Drawing.Size(491, 47);
            this.lbl_LargeHeading.TabIndex = 45;
            this.lbl_LargeHeading.Text = "Please Wait...";
            this.lbl_LargeHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // but_ConvertAgain
            // 
            this.but_ConvertAgain.Location = new System.Drawing.Point(136, 103);
            this.but_ConvertAgain.Name = "but_ConvertAgain";
            this.but_ConvertAgain.Size = new System.Drawing.Size(145, 37);
            this.but_ConvertAgain.TabIndex = 21;
            this.but_ConvertAgain.Text = "Convert Another Video";
            this.but_ConvertAgain.UseVisualStyleBackColor = true;
            this.but_ConvertAgain.Visible = false;
            this.but_ConvertAgain.Click += new System.EventHandler(this.but_ConvertAgain_Click);
            // 
            // lbl_ManProg
            // 
            this.lbl_ManProg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManProg.Location = new System.Drawing.Point(18, 100);
            this.lbl_ManProg.Name = "lbl_ManProg";
            this.lbl_ManProg.Size = new System.Drawing.Size(372, 25);
            this.lbl_ManProg.TabIndex = 3;
            this.lbl_ManProg.Text = "0%";
            this.lbl_ManProg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Desc
            // 
            this.lbl_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Desc.Location = new System.Drawing.Point(9, 37);
            this.lbl_Desc.Name = "lbl_Desc";
            this.lbl_Desc.Size = new System.Drawing.Size(404, 45);
            this.lbl_Desc.TabIndex = 2;
            this.lbl_Desc.Text = "Performing Initial Steps...";
            this.lbl_Desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prg_Main
            // 
            this.prg_Main.Location = new System.Drawing.Point(66, 79);
            this.prg_Main.Name = "prg_Main";
            this.prg_Main.Size = new System.Drawing.Size(309, 18);
            this.prg_Main.TabIndex = 1;
            // 
            // lbl_Stage
            // 
            this.lbl_Stage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stage.Location = new System.Drawing.Point(61, 13);
            this.lbl_Stage.Name = "lbl_Stage";
            this.lbl_Stage.Size = new System.Drawing.Size(273, 25);
            this.lbl_Stage.TabIndex = 0;
            this.lbl_Stage.Text = "Stage 1 of 5";
            this.lbl_Stage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_DownloadETA
            // 
            this.lbl_DownloadETA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DownloadETA.Location = new System.Drawing.Point(29, 127);
            this.lbl_DownloadETA.Name = "lbl_DownloadETA";
            this.lbl_DownloadETA.Size = new System.Drawing.Size(367, 23);
            this.lbl_DownloadETA.TabIndex = 22;
            this.lbl_DownloadETA.Text = "Estimated Time Remaining: Calculating...";
            this.lbl_DownloadETA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_DownloadETA.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_DownloadETA);
            this.groupBox1.Controls.Add(this.but_ConvertAgain);
            this.groupBox1.Controls.Add(this.pic_INILOAD);
            this.groupBox1.Controls.Add(this.lbl_ManProg);
            this.groupBox1.Controls.Add(this.prg_Main);
            this.groupBox1.Controls.Add(this.lbl_Stage);
            this.groupBox1.Controls.Add(this.lbl_Desc);
            this.groupBox1.Location = new System.Drawing.Point(38, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 157);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // pic_INILOAD
            // 
            this.pic_INILOAD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_INILOAD.Image = global::mediaDownloader.Properties.Resources.ajaxLoad;
            this.pic_INILOAD.Location = new System.Drawing.Point(109, 79);
            this.pic_INILOAD.Name = "pic_INILOAD";
            this.pic_INILOAD.Size = new System.Drawing.Size(249, 51);
            this.pic_INILOAD.TabIndex = 4;
            this.pic_INILOAD.TabStop = false;
            this.pic_INILOAD.Visible = false;
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
            this.lbl_Title.TabIndex = 42;
            this.lbl_Title.Text = "Media: Download Plugin";
            // 
            // pic_Top
            // 
            this.pic_Top.BackColor = System.Drawing.Color.DimGray;
            this.pic_Top.Location = new System.Drawing.Point(-1, 0);
            this.pic_Top.Name = "pic_Top";
            this.pic_Top.Size = new System.Drawing.Size(513, 50);
            this.pic_Top.TabIndex = 40;
            this.pic_Top.TabStop = false;
            // 
            // tmr_DelayStage2
            // 
            this.tmr_DelayStage2.Interval = 1000;
            this.tmr_DelayStage2.Tick += new System.EventHandler(this.tmr_DelayStage2_Tick);
            // 
            // pic_TopLine
            // 
            this.pic_TopLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(131)))), ((int)(((byte)(155)))));
            this.pic_TopLine.Location = new System.Drawing.Point(-8, 49);
            this.pic_TopLine.Name = "pic_TopLine";
            this.pic_TopLine.Size = new System.Drawing.Size(492, 5);
            this.pic_TopLine.TabIndex = 43;
            this.pic_TopLine.TabStop = false;
            // 
            // pic_ICO
            // 
            this.pic_ICO.Image = global::mediaDownloader.Properties.Resources.basic_icon;
            this.pic_ICO.Location = new System.Drawing.Point(10, 2);
            this.pic_ICO.Name = "pic_ICO";
            this.pic_ICO.Size = new System.Drawing.Size(49, 41);
            this.pic_ICO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ICO.TabIndex = 41;
            this.pic_ICO.TabStop = false;
            // 
            // bk_Decipher
            // 
            this.bk_Decipher.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bk_Decipher_DoWork);
            this.bk_Decipher.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bk_Decipher_RunWorkerCompleted);
            // 
            // frm_ProcessMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 491);
            this.Controls.Add(this.grp_Download);
            this.Controls.Add(this.pic_TopLine);
            this.Controls.Add(this.pic_ICO);
            this.Controls.Add(this.txt_ConvLog);
            this.Controls.Add(this.grp_FrmButtons);
            this.Controls.Add(this.lbl_LargeHeading);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pic_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_ProcessMedia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Download Plugin: Processing Media...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_ProcessMedia_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grp_Download.ResumeLayout(false);
            this.grp_Download.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grp_FrmButtons.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_INILOAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TopLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ICO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_TRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grp_Download;
        private System.Windows.Forms.Label lbl_Size;
        private System.Windows.Forms.PictureBox pic_TopLine;
        private System.Windows.Forms.PictureBox pic_ICO;
        private System.Windows.Forms.TextBox txt_ConvLog;
        private System.Windows.Forms.Timer tmr_DelayStage4;
        private System.ComponentModel.BackgroundWorker bkWork_ConvertVideo;
        private System.ComponentModel.BackgroundWorker bkWork_DownloadVideo;
        private System.Windows.Forms.Timer tmr_StartProcess;
        private System.Windows.Forms.Button but_Finish;
        private System.Windows.Forms.GroupBox grp_FrmButtons;
        private System.Windows.Forms.Label lbl_LargeHeading;
        private System.Windows.Forms.Button but_ConvertAgain;
        private System.Windows.Forms.PictureBox pic_INILOAD;
        private System.Windows.Forms.Label lbl_ManProg;
        private System.Windows.Forms.Label lbl_Desc;
        private System.Windows.Forms.ProgressBar prg_Main;
        private System.Windows.Forms.Label lbl_Stage;
        private System.Windows.Forms.Label lbl_DownloadETA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pic_Top;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Timer tmr_DelayStage2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.ComponentModel.BackgroundWorker bk_Decipher;
    }
}