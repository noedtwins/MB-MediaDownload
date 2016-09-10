using System.Windows.Forms;

namespace mediaDownloader
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_GetURL));
            this.but_Previous = new System.Windows.Forms.Button();
            this.but_Reset = new System.Windows.Forms.Button();
            this.but_NextStage = new System.Windows.Forms.Button();
            this.lbl_FormatNumber = new System.Windows.Forms.Label();
            this.lbl_VideoTitle = new System.Windows.Forms.Label();
            this.txt_MediaURL = new System.Windows.Forms.TextBox();
            this.grp_FrmButtons = new System.Windows.Forms.GroupBox();
            this.grp_VidDetails = new System.Windows.Forms.GroupBox();
            this.pic_Thumb = new System.Windows.Forms.PictureBox();
            this.grp_loadingbar = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pic_InfLoad = new System.Windows.Forms.PictureBox();
            this.lbl_Process = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.but_ContStage = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.grp_Info = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.but_MoreOptions = new System.Windows.Forms.Button();
            this.pic_TopLine = new System.Windows.Forms.PictureBox();
            this.pic_ICO = new System.Windows.Forms.PictureBox();
            this.pic_Top = new System.Windows.Forms.PictureBox();
            this.bk_UseRG3 = new System.ComponentModel.BackgroundWorker();
            this.trm_AutoPressButton = new System.Windows.Forms.Timer(this.components);
            this.grp_FrmButtons.SuspendLayout();
            this.grp_VidDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Thumb)).BeginInit();
            this.grp_loadingbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_InfLoad)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.grp_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TopLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ICO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Top)).BeginInit();
            this.SuspendLayout();
            // 
            // but_Previous
            // 
            this.but_Previous.Location = new System.Drawing.Point(12, 14);
            this.but_Previous.Margin = new System.Windows.Forms.Padding(4);
            this.but_Previous.Name = "but_Previous";
            this.but_Previous.Size = new System.Drawing.Size(149, 37);
            this.but_Previous.TabIndex = 10;
            this.but_Previous.Text = "<- Previous";
            this.but_Previous.UseVisualStyleBackColor = true;
            this.but_Previous.Click += new System.EventHandler(this.but_Previous_Click);
            // 
            // but_Reset
            // 
            this.but_Reset.Location = new System.Drawing.Point(235, 14);
            this.but_Reset.Margin = new System.Windows.Forms.Padding(4);
            this.but_Reset.Name = "but_Reset";
            this.but_Reset.Size = new System.Drawing.Size(149, 37);
            this.but_Reset.TabIndex = 10;
            this.but_Reset.Text = "Reset This Stage";
            this.but_Reset.UseVisualStyleBackColor = true;
            this.but_Reset.Visible = false;
            this.but_Reset.Click += new System.EventHandler(this.but_Reset_Click);
            // 
            // but_NextStage
            // 
            this.but_NextStage.Location = new System.Drawing.Point(460, 12);
            this.but_NextStage.Margin = new System.Windows.Forms.Padding(4);
            this.but_NextStage.Name = "but_NextStage";
            this.but_NextStage.Size = new System.Drawing.Size(157, 37);
            this.but_NextStage.TabIndex = 9;
            this.but_NextStage.Text = "Continue ->";
            this.but_NextStage.UseVisualStyleBackColor = true;
            this.but_NextStage.Visible = false;
            this.but_NextStage.Click += new System.EventHandler(this.but_NextStage_Click);
            // 
            // lbl_FormatNumber
            // 
            this.lbl_FormatNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FormatNumber.Location = new System.Drawing.Point(94, 253);
            this.lbl_FormatNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_FormatNumber.Name = "lbl_FormatNumber";
            this.lbl_FormatNumber.Size = new System.Drawing.Size(428, 20);
            this.lbl_FormatNumber.TabIndex = 2;
            this.lbl_FormatNumber.Text = "Format Selected: Searching...";
            this.lbl_FormatNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_VideoTitle
            // 
            this.lbl_VideoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VideoTitle.Location = new System.Drawing.Point(90, 222);
            this.lbl_VideoTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_VideoTitle.Name = "lbl_VideoTitle";
            this.lbl_VideoTitle.Size = new System.Drawing.Size(428, 20);
            this.lbl_VideoTitle.TabIndex = 1;
            this.lbl_VideoTitle.Text = "Loading...";
            this.lbl_VideoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_MediaURL
            // 
            this.txt_MediaURL.Location = new System.Drawing.Point(3, 77);
            this.txt_MediaURL.Name = "txt_MediaURL";
            this.txt_MediaURL.Size = new System.Drawing.Size(430, 22);
            this.txt_MediaURL.TabIndex = 14;
            this.txt_MediaURL.Text = "Insert URL Here...";
            this.txt_MediaURL.Enter += new System.EventHandler(this.txt_MediaURL_Enter);
            this.txt_MediaURL.Leave += new System.EventHandler(this.txt_MediaURL_Leave);
            // 
            // grp_FrmButtons
            // 
            this.grp_FrmButtons.Controls.Add(this.but_Previous);
            this.grp_FrmButtons.Controls.Add(this.but_Reset);
            this.grp_FrmButtons.Controls.Add(this.but_NextStage);
            this.grp_FrmButtons.Location = new System.Drawing.Point(4, 513);
            this.grp_FrmButtons.Margin = new System.Windows.Forms.Padding(4);
            this.grp_FrmButtons.Name = "grp_FrmButtons";
            this.grp_FrmButtons.Padding = new System.Windows.Forms.Padding(4);
            this.grp_FrmButtons.Size = new System.Drawing.Size(625, 57);
            this.grp_FrmButtons.TabIndex = 25;
            this.grp_FrmButtons.TabStop = false;
            // 
            // grp_VidDetails
            // 
            this.grp_VidDetails.Controls.Add(this.pic_Thumb);
            this.grp_VidDetails.Controls.Add(this.lbl_FormatNumber);
            this.grp_VidDetails.Controls.Add(this.lbl_VideoTitle);
            this.grp_VidDetails.Location = new System.Drawing.Point(13, 127);
            this.grp_VidDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grp_VidDetails.Name = "grp_VidDetails";
            this.grp_VidDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grp_VidDetails.Size = new System.Drawing.Size(596, 355);
            this.grp_VidDetails.TabIndex = 24;
            this.grp_VidDetails.TabStop = false;
            this.grp_VidDetails.Visible = false;
            // 
            // pic_Thumb
            // 
            this.pic_Thumb.Image = global::mediaDownloader.Properties.Resources.ajaxLoad;
            this.pic_Thumb.Location = new System.Drawing.Point(183, 23);
            this.pic_Thumb.Margin = new System.Windows.Forms.Padding(4);
            this.pic_Thumb.Name = "pic_Thumb";
            this.pic_Thumb.Size = new System.Drawing.Size(221, 179);
            this.pic_Thumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Thumb.TabIndex = 0;
            this.pic_Thumb.TabStop = false;
            // 
            // grp_loadingbar
            // 
            this.grp_loadingbar.Controls.Add(this.label6);
            this.grp_loadingbar.Controls.Add(this.pic_InfLoad);
            this.grp_loadingbar.Controls.Add(this.lbl_Process);
            this.grp_loadingbar.Location = new System.Drawing.Point(138, 150);
            this.grp_loadingbar.Name = "grp_loadingbar";
            this.grp_loadingbar.Size = new System.Drawing.Size(345, 126);
            this.grp_loadingbar.TabIndex = 4;
            this.grp_loadingbar.TabStop = false;
            this.grp_loadingbar.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Please Wait";
            // 
            // pic_InfLoad
            // 
            this.pic_InfLoad.Image = global::mediaDownloader.Properties.Resources.ajaxLoad;
            this.pic_InfLoad.Location = new System.Drawing.Point(69, 80);
            this.pic_InfLoad.Margin = new System.Windows.Forms.Padding(4);
            this.pic_InfLoad.Name = "pic_InfLoad";
            this.pic_InfLoad.Size = new System.Drawing.Size(223, 34);
            this.pic_InfLoad.TabIndex = 27;
            this.pic_InfLoad.TabStop = false;
            // 
            // lbl_Process
            // 
            this.lbl_Process.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Process.Location = new System.Drawing.Point(6, 25);
            this.lbl_Process.Name = "lbl_Process";
            this.lbl_Process.Size = new System.Drawing.Size(333, 20);
            this.lbl_Process.TabIndex = 3;
            this.lbl_Process.Text = "?";
            this.lbl_Process.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 582);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(638, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(168, 17);
            this.toolStripStatusLabel1.Text = "Media Downloader - By Cyano";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Media URL";
            // 
            // but_ContStage
            // 
            this.but_ContStage.Location = new System.Drawing.Point(259, 127);
            this.but_ContStage.Margin = new System.Windows.Forms.Padding(4);
            this.but_ContStage.Name = "but_ContStage";
            this.but_ContStage.Size = new System.Drawing.Size(100, 28);
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
            this.lbl_Title.Location = new System.Drawing.Point(84, 9);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(333, 37);
            this.lbl_Title.TabIndex = 18;
            this.lbl_Title.Text = "Media: Download Plugin";
            // 
            // grp_Info
            // 
            this.grp_Info.Controls.Add(this.label5);
            this.grp_Info.Controls.Add(this.label4);
            this.grp_Info.Controls.Add(this.label3);
            this.grp_Info.Controls.Add(this.pictureBox3);
            this.grp_Info.Location = new System.Drawing.Point(16, 185);
            this.grp_Info.Margin = new System.Windows.Forms.Padding(4);
            this.grp_Info.Name = "grp_Info";
            this.grp_Info.Padding = new System.Windows.Forms.Padding(4);
            this.grp_Info.Size = new System.Drawing.Size(593, 215);
            this.grp_Info.TabIndex = 28;
            this.grp_Info.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(390, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "The creator of this plugin does not take liability towards the user or any third " +
    "party \r\nfor the permissibility of downloading content using this plugin.\r\n";
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(152, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(428, 114);
            this.label4.TabIndex = 2;
            this.label4.Text = "Accepted Media\r\n---------------------\r\n• YouTube\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Information";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::mediaDownloader.Properties.Resources.Information;
            this.pictureBox3.Location = new System.Drawing.Point(9, 15);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(135, 119);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 95);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(563, 28);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // but_MoreOptions
            // 
            this.but_MoreOptions.Image = global::mediaDownloader.Properties.Resources.menu_icon_16;
            this.but_MoreOptions.Location = new System.Drawing.Point(585, 78);
            this.but_MoreOptions.Margin = new System.Windows.Forms.Padding(4);
            this.but_MoreOptions.Name = "but_MoreOptions";
            this.but_MoreOptions.Size = new System.Drawing.Size(35, 47);
            this.but_MoreOptions.TabIndex = 26;
            this.but_MoreOptions.UseVisualStyleBackColor = true;
            this.but_MoreOptions.Click += new System.EventHandler(this.but_MoreOptions_Click);
            // 
            // pic_TopLine
            // 
            this.pic_TopLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(131)))), ((int)(((byte)(155)))));
            this.pic_TopLine.Location = new System.Drawing.Point(-7, 60);
            this.pic_TopLine.Margin = new System.Windows.Forms.Padding(4);
            this.pic_TopLine.Name = "pic_TopLine";
            this.pic_TopLine.Size = new System.Drawing.Size(656, 6);
            this.pic_TopLine.TabIndex = 19;
            this.pic_TopLine.TabStop = false;
            // 
            // pic_ICO
            // 
            this.pic_ICO.Image = global::mediaDownloader.Properties.Resources.basic_icon;
            this.pic_ICO.Location = new System.Drawing.Point(13, 2);
            this.pic_ICO.Margin = new System.Windows.Forms.Padding(4);
            this.pic_ICO.Name = "pic_ICO";
            this.pic_ICO.Size = new System.Drawing.Size(65, 50);
            this.pic_ICO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ICO.TabIndex = 16;
            this.pic_ICO.TabStop = false;
            // 
            // pic_Top
            // 
            this.pic_Top.BackColor = System.Drawing.Color.DimGray;
            this.pic_Top.Location = new System.Drawing.Point(-4, 0);
            this.pic_Top.Margin = new System.Windows.Forms.Padding(4);
            this.pic_Top.Name = "pic_Top";
            this.pic_Top.Size = new System.Drawing.Size(679, 62);
            this.pic_Top.TabIndex = 15;
            this.pic_Top.TabStop = false;
            // 
            // bk_UseRG3
            // 
            this.bk_UseRG3.WorkerSupportsCancellation = true;
            this.bk_UseRG3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bk_UseRG3_DoWork);
            this.bk_UseRG3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bk_UseRG3_RunWorkerCompleted);
            // 
            // trm_AutoPressButton
            // 
            this.trm_AutoPressButton.Enabled = true;
            this.trm_AutoPressButton.Interval = 250;
            this.trm_AutoPressButton.Tick += new System.EventHandler(this.trm_AutoPressButton_Tick);
            // 
            // frm_GetURL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 604);
            this.Controls.Add(this.grp_loadingbar);
            this.Controls.Add(this.grp_VidDetails);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.grp_Info);
            this.Controls.Add(this.but_MoreOptions);
            this.Controls.Add(this.grp_FrmButtons);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_ContStage);
            this.Controls.Add(this.pic_TopLine);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.pic_ICO);
            this.Controls.Add(this.pic_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_GetURL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Download Plugin: Retrieve URL";
            this.Activated += new System.EventHandler(this.frm_GetURL_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_GetURL_FormClosing);
            this.Enter += new System.EventHandler(this.frm_GetURL_Enter);
            this.grp_FrmButtons.ResumeLayout(false);
            this.grp_VidDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Thumb)).EndInit();
            this.grp_loadingbar.ResumeLayout(false);
            this.grp_loadingbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_InfLoad)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grp_Info.ResumeLayout(false);
            this.grp_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TopLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ICO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Top)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void initMBCustom()
        {
            if (!Program.isStandaloneMode)
            {
                this.txt_MediaURL = (TextBox)pluginInstance.getAPI().getInterface().MB_AddPanel(null, MusicBeePlugin.Plugin.PluginPanelDock.TextBox);
            }

            this.txt_MediaURL.TabIndex = 6;
            this.txt_MediaURL.Text = "Insert URL Here...";
            this.txt_MediaURL.Enter += new System.EventHandler(this.txt_MediaURL_Enter);
            this.txt_MediaURL.Leave += new System.EventHandler(this.txt_MediaURL_Leave);
            this.txt_MediaURL.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Controls.Add(txt_MediaURL);

            this.lbl_Title.Parent = pic_Top;
            this.pic_ICO.Parent = pic_Top;

        }

        #endregion
        private System.Windows.Forms.Button but_Previous;
        private System.Windows.Forms.Button but_Reset;
        private System.Windows.Forms.Button but_NextStage;
        private System.Windows.Forms.Label lbl_FormatNumber;
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
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox grp_Info;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox grp_loadingbar;
        private Label label6;
        private Label lbl_Process;
        private System.ComponentModel.BackgroundWorker bk_UseRG3;
        private Timer trm_AutoPressButton;
    }
}