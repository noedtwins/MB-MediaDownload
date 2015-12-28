namespace mediaDownloader
{
    partial class frm_SaveFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SaveFile));
            this.but_Swap = new System.Windows.Forms.Button();
            this.tbl_Tags = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Tag_Artist = new System.Windows.Forms.TextBox();
            this.txt_Tag_Title = new System.Windows.Forms.TextBox();
            this.txt_Tag_Album = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grp_FrmButtons = new System.Windows.Forms.GroupBox();
            this.but_PreviousStage = new System.Windows.Forms.Button();
            this.but_Reset = new System.Windows.Forms.Button();
            this.but_NextStage = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmr_DelayClose = new System.Windows.Forms.Timer(this.components);
            this.fldr_BrowseSelection = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pic_Artwork = new System.Windows.Forms.PictureBox();
            this.txt_FileName = new System.Windows.Forms.TextBox();
            this.grp_VidDetails = new System.Windows.Forms.GroupBox();
            this.lbl_Prefix = new System.Windows.Forms.Label();
            this.cbo_SetBitRate = new System.Windows.Forms.ComboBox();
            this.lbl_Convert = new System.Windows.Forms.Label();
            this.lbl_FormatStatus = new System.Windows.Forms.Label();
            this.lbl_VideoTitle = new System.Windows.Forms.Label();
            this.pic_VidThumb = new System.Windows.Forms.PictureBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pic_Top = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_Folder = new System.Windows.Forms.ComboBox();
            this.but_Crop = new System.Windows.Forms.Button();
            this.rdo_Video = new System.Windows.Forms.RadioButton();
            this.tbl_FileName = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.cbo_SelectFileFormat = new System.Windows.Forms.ComboBox();
            this.rdo_None = new System.Windows.Forms.RadioButton();
            this.rdo_Inbox = new System.Windows.Forms.RadioButton();
            this.rdo_Library = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.but_Browse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_ICO = new System.Windows.Forms.PictureBox();
            this.pic_TopLine = new System.Windows.Forms.PictureBox();
            this.tbl_Tags.SuspendLayout();
            this.grp_FrmButtons.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Artwork)).BeginInit();
            this.grp_VidDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_VidThumb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Top)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tbl_FileName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ICO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TopLine)).BeginInit();
            this.SuspendLayout();
            // 
            // but_Swap
            // 
            this.but_Swap.Location = new System.Drawing.Point(433, 12);
            this.but_Swap.Name = "but_Swap";
            this.but_Swap.Size = new System.Drawing.Size(26, 57);
            this.but_Swap.TabIndex = 8;
            this.but_Swap.UseVisualStyleBackColor = true;
            // 
            // tbl_Tags
            // 
            this.tbl_Tags.AutoSize = true;
            this.tbl_Tags.ColumnCount = 2;
            this.tbl_Tags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tbl_Tags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tbl_Tags.Controls.Add(this.label11, 0, 2);
            this.tbl_Tags.Controls.Add(this.txt_Tag_Artist, 1, 1);
            this.tbl_Tags.Controls.Add(this.txt_Tag_Title, 1, 0);
            this.tbl_Tags.Controls.Add(this.txt_Tag_Album, 1, 2);
            this.tbl_Tags.Controls.Add(this.label10, 0, 1);
            this.tbl_Tags.Controls.Add(this.label8, 0, 0);
            this.tbl_Tags.Location = new System.Drawing.Point(90, 12);
            this.tbl_Tags.Name = "tbl_Tags";
            this.tbl_Tags.RowCount = 3;
            this.tbl_Tags.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_Tags.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_Tags.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_Tags.Size = new System.Drawing.Size(340, 100);
            this.tbl_Tags.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Album:";
            // 
            // txt_Tag_Artist
            // 
            this.txt_Tag_Artist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Tag_Artist.Location = new System.Drawing.Point(54, 36);
            this.txt_Tag_Artist.Name = "txt_Tag_Artist";
            this.txt_Tag_Artist.Size = new System.Drawing.Size(283, 20);
            this.txt_Tag_Artist.TabIndex = 18;
            // 
            // txt_Tag_Title
            // 
            this.txt_Tag_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Tag_Title.Location = new System.Drawing.Point(54, 3);
            this.txt_Tag_Title.Name = "txt_Tag_Title";
            this.txt_Tag_Title.Size = new System.Drawing.Size(283, 20);
            this.txt_Tag_Title.TabIndex = 17;
            // 
            // txt_Tag_Album
            // 
            this.txt_Tag_Album.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Tag_Album.Location = new System.Drawing.Point(54, 69);
            this.txt_Tag_Album.Name = "txt_Tag_Album";
            this.txt_Tag_Album.Size = new System.Drawing.Size(283, 20);
            this.txt_Tag_Album.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Artist:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Title:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Artwork";
            // 
            // grp_FrmButtons
            // 
            this.grp_FrmButtons.Controls.Add(this.but_PreviousStage);
            this.grp_FrmButtons.Controls.Add(this.but_Reset);
            this.grp_FrmButtons.Controls.Add(this.but_NextStage);
            this.grp_FrmButtons.Location = new System.Drawing.Point(10, 406);
            this.grp_FrmButtons.Name = "grp_FrmButtons";
            this.grp_FrmButtons.Size = new System.Drawing.Size(469, 46);
            this.grp_FrmButtons.TabIndex = 27;
            this.grp_FrmButtons.TabStop = false;
            this.grp_FrmButtons.Enter += new System.EventHandler(this.grp_FrmButtons_Enter);
            // 
            // but_PreviousStage
            // 
            this.but_PreviousStage.Location = new System.Drawing.Point(5, 11);
            this.but_PreviousStage.Name = "but_PreviousStage";
            this.but_PreviousStage.Size = new System.Drawing.Size(112, 30);
            this.but_PreviousStage.TabIndex = 11;
            this.but_PreviousStage.Text = "<- Previous";
            this.but_PreviousStage.UseVisualStyleBackColor = true;
            this.but_PreviousStage.Click += new System.EventHandler(this.but_PreviousStage_Click);
            // 
            // but_Reset
            // 
            this.but_Reset.Location = new System.Drawing.Point(176, 11);
            this.but_Reset.Name = "but_Reset";
            this.but_Reset.Size = new System.Drawing.Size(112, 30);
            this.but_Reset.TabIndex = 10;
            this.but_Reset.Text = "Reset This Stage";
            this.but_Reset.UseVisualStyleBackColor = true;
            this.but_Reset.Click += new System.EventHandler(this.but_Reset_Click_1);
            // 
            // but_NextStage
            // 
            this.but_NextStage.Location = new System.Drawing.Point(341, 11);
            this.but_NextStage.Name = "but_NextStage";
            this.but_NextStage.Size = new System.Drawing.Size(118, 30);
            this.but_NextStage.TabIndex = 9;
            this.but_NextStage.Text = "Continue ->";
            this.but_NextStage.UseVisualStyleBackColor = true;
            this.but_NextStage.Click += new System.EventHandler(this.but_NextStage_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 469);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(480, 22);
            this.statusStrip1.TabIndex = 28;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(168, 17);
            this.toolStripStatusLabel1.Text = "Media Downloader - By Cyano";
            // 
            // tmr_DelayClose
            // 
            this.tmr_DelayClose.Interval = 1000;
            // 
            // fldr_BrowseSelection
            // 
            this.fldr_BrowseSelection.Description = "Select where to save the final convertd file.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.but_Swap);
            this.groupBox2.Controls.Add(this.tbl_Tags);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.pic_Artwork);
            this.groupBox2.Location = new System.Drawing.Point(13, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 113);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tagging";
            // 
            // pic_Artwork
            // 
            this.pic_Artwork.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Artwork.Image = global::mediaDownloader.Properties.Resources.unknownThumb;
            this.pic_Artwork.Location = new System.Drawing.Point(8, 32);
            this.pic_Artwork.Name = "pic_Artwork";
            this.pic_Artwork.Size = new System.Drawing.Size(80, 64);
            this.pic_Artwork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Artwork.TabIndex = 1;
            this.pic_Artwork.TabStop = false;
            // 
            // txt_FileName
            // 
            this.txt_FileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_FileName.Location = new System.Drawing.Point(3, 3);
            this.txt_FileName.Name = "txt_FileName";
            this.txt_FileName.Size = new System.Drawing.Size(242, 20);
            this.txt_FileName.TabIndex = 19;
            // 
            // grp_VidDetails
            // 
            this.grp_VidDetails.Controls.Add(this.lbl_Prefix);
            this.grp_VidDetails.Controls.Add(this.cbo_SetBitRate);
            this.grp_VidDetails.Controls.Add(this.lbl_Convert);
            this.grp_VidDetails.Controls.Add(this.lbl_FormatStatus);
            this.grp_VidDetails.Controls.Add(this.lbl_VideoTitle);
            this.grp_VidDetails.Controls.Add(this.pic_VidThumb);
            this.grp_VidDetails.Location = new System.Drawing.Point(13, 58);
            this.grp_VidDetails.Name = "grp_VidDetails";
            this.grp_VidDetails.Size = new System.Drawing.Size(462, 89);
            this.grp_VidDetails.TabIndex = 24;
            this.grp_VidDetails.TabStop = false;
            // 
            // lbl_Prefix
            // 
            this.lbl_Prefix.AutoSize = true;
            this.lbl_Prefix.Location = new System.Drawing.Point(262, 63);
            this.lbl_Prefix.Name = "lbl_Prefix";
            this.lbl_Prefix.Size = new System.Drawing.Size(30, 13);
            this.lbl_Prefix.TabIndex = 4;
            this.lbl_Prefix.Text = "kbps";
            // 
            // cbo_SetBitRate
            // 
            this.cbo_SetBitRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_SetBitRate.FormattingEnabled = true;
            this.cbo_SetBitRate.Items.AddRange(new object[] {
            "32",
            "64",
            "128",
            "192",
            "256",
            "320"});
            this.cbo_SetBitRate.Location = new System.Drawing.Point(216, 58);
            this.cbo_SetBitRate.Name = "cbo_SetBitRate";
            this.cbo_SetBitRate.Size = new System.Drawing.Size(46, 21);
            this.cbo_SetBitRate.TabIndex = 0;
            this.cbo_SetBitRate.TabStop = false;
            // 
            // lbl_Convert
            // 
            this.lbl_Convert.AutoSize = true;
            this.lbl_Convert.Location = new System.Drawing.Point(92, 61);
            this.lbl_Convert.Name = "lbl_Convert";
            this.lbl_Convert.Size = new System.Drawing.Size(126, 13);
            this.lbl_Convert.TabIndex = 3;
            this.lbl_Convert.Text = "MP3 Conversion BitRate:";
            // 
            // lbl_FormatStatus
            // 
            this.lbl_FormatStatus.AutoSize = true;
            this.lbl_FormatStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FormatStatus.Location = new System.Drawing.Point(92, 39);
            this.lbl_FormatStatus.Name = "lbl_FormatStatus";
            this.lbl_FormatStatus.Size = new System.Drawing.Size(336, 16);
            this.lbl_FormatStatus.TabIndex = 2;
            this.lbl_FormatStatus.Text = "Unknown Quality || Unknown Format Code || TAG CODE";
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
            // pic_VidThumb
            // 
            this.pic_VidThumb.Location = new System.Drawing.Point(6, 13);
            this.pic_VidThumb.Name = "pic_VidThumb";
            this.pic_VidThumb.Size = new System.Drawing.Size(79, 70);
            this.pic_VidThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_VidThumb.TabIndex = 0;
            this.pic_VidThumb.TabStop = false;
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
            this.lbl_Title.TabIndex = 22;
            this.lbl_Title.Text = "Media: Download Plugin";
            // 
            // pic_Top
            // 
            this.pic_Top.BackColor = System.Drawing.Color.DimGray;
            this.pic_Top.Location = new System.Drawing.Point(0, 0);
            this.pic_Top.Name = "pic_Top";
            this.pic_Top.Size = new System.Drawing.Size(491, 50);
            this.pic_Top.TabIndex = 20;
            this.pic_Top.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_Folder);
            this.groupBox1.Controls.Add(this.but_Crop);
            this.groupBox1.Controls.Add(this.rdo_Video);
            this.groupBox1.Controls.Add(this.tbl_FileName);
            this.groupBox1.Controls.Add(this.rdo_None);
            this.groupBox1.Controls.Add(this.rdo_Inbox);
            this.groupBox1.Controls.Add(this.rdo_Library);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.but_Browse);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 127);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Download Location";
            // 
            // cbo_Folder
            // 
            this.cbo_Folder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbo_Folder.FormattingEnabled = true;
            this.cbo_Folder.Items.AddRange(new object[] {
            "Unavailable Api: No Monitored Folders Loaded"});
            this.cbo_Folder.Location = new System.Drawing.Point(112, 20);
            this.cbo_Folder.Name = "cbo_Folder";
            this.cbo_Folder.Size = new System.Drawing.Size(276, 21);
            this.cbo_Folder.TabIndex = 1;
            this.cbo_Folder.TabStop = false;
            // 
            // but_Crop
            // 
            this.but_Crop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_Crop.Location = new System.Drawing.Point(332, 99);
            this.but_Crop.Name = "but_Crop";
            this.but_Crop.Size = new System.Drawing.Size(125, 23);
            this.but_Crop.TabIndex = 18;
            this.but_Crop.Text = "Crop Content (ERROR)";
            this.but_Crop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_Crop.UseVisualStyleBackColor = true;
            // 
            // rdo_Video
            // 
            this.rdo_Video.AutoSize = true;
            this.rdo_Video.Location = new System.Drawing.Point(210, 77);
            this.rdo_Video.Name = "rdo_Video";
            this.rdo_Video.Size = new System.Drawing.Size(86, 17);
            this.rdo_Video.TabIndex = 17;
            this.rdo_Video.TabStop = true;
            this.rdo_Video.Text = "Video Library";
            this.rdo_Video.UseVisualStyleBackColor = true;
            // 
            // tbl_FileName
            // 
            this.tbl_FileName.ColumnCount = 3;
            this.tbl_FileName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.16294F));
            this.tbl_FileName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.539823F));
            this.tbl_FileName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.30383F));
            this.tbl_FileName.Controls.Add(this.txt_FileName, 0, 0);
            this.tbl_FileName.Controls.Add(this.label13, 1, 0);
            this.tbl_FileName.Controls.Add(this.cbo_SelectFileFormat, 2, 0);
            this.tbl_FileName.Location = new System.Drawing.Point(112, 44);
            this.tbl_FileName.Name = "tbl_FileName";
            this.tbl_FileName.RowCount = 1;
            this.tbl_FileName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_FileName.Size = new System.Drawing.Size(339, 25);
            this.tbl_FileName.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(248, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 24);
            this.label13.TabIndex = 0;
            this.label13.Text = "•";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_SelectFileFormat
            // 
            this.cbo_SelectFileFormat.FormattingEnabled = true;
            this.cbo_SelectFileFormat.Items.AddRange(new object[] {
            "mp3",
            "aac",
            "m4a",
            "mp4",
            "flv",
            "3gp"});
            this.cbo_SelectFileFormat.Location = new System.Drawing.Point(259, 0);
            this.cbo_SelectFileFormat.Margin = new System.Windows.Forms.Padding(0);
            this.cbo_SelectFileFormat.Name = "cbo_SelectFileFormat";
            this.cbo_SelectFileFormat.Size = new System.Drawing.Size(80, 21);
            this.cbo_SelectFileFormat.TabIndex = 1;
            // 
            // rdo_None
            // 
            this.rdo_None.AutoSize = true;
            this.rdo_None.Location = new System.Drawing.Point(304, 77);
            this.rdo_None.Name = "rdo_None";
            this.rdo_None.Size = new System.Drawing.Size(147, 17);
            this.rdo_None.TabIndex = 15;
            this.rdo_None.TabStop = true;
            this.rdo_None.Text = "Do Not Add To MusicBee";
            this.rdo_None.UseVisualStyleBackColor = true;
            // 
            // rdo_Inbox
            // 
            this.rdo_Inbox.AutoSize = true;
            this.rdo_Inbox.Location = new System.Drawing.Point(159, 77);
            this.rdo_Inbox.Name = "rdo_Inbox";
            this.rdo_Inbox.Size = new System.Drawing.Size(51, 17);
            this.rdo_Inbox.TabIndex = 14;
            this.rdo_Inbox.TabStop = true;
            this.rdo_Inbox.Text = "Inbox";
            this.rdo_Inbox.UseVisualStyleBackColor = true;
            // 
            // rdo_Library
            // 
            this.rdo_Library.AutoSize = true;
            this.rdo_Library.Location = new System.Drawing.Point(68, 77);
            this.rdo_Library.Name = "rdo_Library";
            this.rdo_Library.Size = new System.Drawing.Size(87, 17);
            this.rdo_Library.TabIndex = 13;
            this.rdo_Library.TabStop = true;
            this.rdo_Library.Text = "Music Library";
            this.rdo_Library.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(220, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Select Playlists";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(109, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "No Playlists Selected";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Add To Playlists:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Add To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "File Name:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(131)))), ((int)(((byte)(155)))));
            this.pictureBox3.Location = new System.Drawing.Point(4, 69);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(459, 3);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // but_Browse
            // 
            this.but_Browse.Location = new System.Drawing.Point(394, 19);
            this.but_Browse.Name = "but_Browse";
            this.but_Browse.Size = new System.Drawing.Size(67, 23);
            this.but_Browse.TabIndex = 0;
            this.but_Browse.Text = "Browse";
            this.but_Browse.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Folder:";
            // 
            // pic_ICO
            // 
            this.pic_ICO.Image = global::mediaDownloader.Properties.Resources.basic_icon;
            this.pic_ICO.Location = new System.Drawing.Point(10, 2);
            this.pic_ICO.Name = "pic_ICO";
            this.pic_ICO.Size = new System.Drawing.Size(49, 41);
            this.pic_ICO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ICO.TabIndex = 21;
            this.pic_ICO.TabStop = false;
            // 
            // pic_TopLine
            // 
            this.pic_TopLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(131)))), ((int)(((byte)(155)))));
            this.pic_TopLine.Location = new System.Drawing.Point(-1, 49);
            this.pic_TopLine.Name = "pic_TopLine";
            this.pic_TopLine.Size = new System.Drawing.Size(484, 5);
            this.pic_TopLine.TabIndex = 23;
            this.pic_TopLine.TabStop = false;
            // 
            // frm_SaveFile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(480, 491);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.pic_ICO);
            this.Controls.Add(this.grp_FrmButtons);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pic_TopLine);
            this.Controls.Add(this.pic_Top);
            this.Controls.Add(this.grp_VidDetails);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_SaveFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Download Plugin: Save File As...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_SaveFile_FormClosing);
            this.Load += new System.EventHandler(this.frm_SaveFile_Load);
            this.tbl_Tags.ResumeLayout(false);
            this.tbl_Tags.PerformLayout();
            this.grp_FrmButtons.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Artwork)).EndInit();
            this.grp_VidDetails.ResumeLayout(false);
            this.grp_VidDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_VidThumb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Top)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbl_FileName.ResumeLayout(false);
            this.tbl_FileName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ICO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TopLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_ICO;
        private System.Windows.Forms.Button but_Swap;
        private System.Windows.Forms.TableLayoutPanel tbl_Tags;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pic_Artwork;
        private System.Windows.Forms.TextBox txt_Tag_Album;
        private System.Windows.Forms.TextBox txt_Tag_Title;
        private System.Windows.Forms.TextBox txt_Tag_Artist;
        private System.Windows.Forms.GroupBox grp_FrmButtons;
        private System.Windows.Forms.Button but_PreviousStage;
        private System.Windows.Forms.Button but_Reset;
        private System.Windows.Forms.Button but_NextStage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer tmr_DelayClose;
        private System.Windows.Forms.FolderBrowserDialog fldr_BrowseSelection;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pic_TopLine;
        private System.Windows.Forms.PictureBox pic_Top;
        private System.Windows.Forms.TextBox txt_FileName;
        private System.Windows.Forms.GroupBox grp_VidDetails;
        private System.Windows.Forms.Label lbl_Prefix;
        private System.Windows.Forms.ComboBox cbo_SetBitRate;
        private System.Windows.Forms.Label lbl_Convert;
        private System.Windows.Forms.Label lbl_FormatStatus;
        private System.Windows.Forms.Label lbl_VideoTitle;
        private System.Windows.Forms.PictureBox pic_VidThumb;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbo_Folder;
        private System.Windows.Forms.Button but_Crop;
        private System.Windows.Forms.RadioButton rdo_Video;
        private System.Windows.Forms.TableLayoutPanel tbl_FileName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbo_SelectFileFormat;
        private System.Windows.Forms.RadioButton rdo_None;
        private System.Windows.Forms.RadioButton rdo_Inbox;
        private System.Windows.Forms.RadioButton rdo_Library;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button but_Browse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}