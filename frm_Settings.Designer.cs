using System.Windows.Forms;

namespace mediaDownloader
{
    partial class frm_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Settings));
            this.rdo_Inbox = new System.Windows.Forms.RadioButton();
            this.label26 = new System.Windows.Forms.Label();
            this.rdo_TopAlways = new System.Windows.Forms.RadioButton();
            this.rdo_TopRecent = new System.Windows.Forms.RadioButton();
            this.rdo_TopNever = new System.Windows.Forms.RadioButton();
            this.pnl_OnTop = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chk_PipeFFMPEG = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chk_AutoClose = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.chk_AutoPaste = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.chk_AutoTag = new System.Windows.Forms.CheckBox();
            this.but_TagEditor = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.chk_Comment = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.rdo_NoWarn = new System.Windows.Forms.RadioButton();
            this.rdo_Warn = new System.Windows.Forms.RadioButton();
            this.rdo_Appendix = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.rdo_Music = new System.Windows.Forms.RadioButton();
            this.rdo_None = new System.Windows.Forms.RadioButton();
            this.tbl_TempFolderCntrl = new System.Windows.Forms.TableLayoutPanel();
            this.chk_SeperateDir = new System.Windows.Forms.CheckBox();
            this.chk_DelTemp = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chk_Smoothing = new System.Windows.Forms.CheckBox();
            this.lbl_SettingVersion = new System.Windows.Forms.Label();
            this.chk_AdvFeatures = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.but_Restore = new System.Windows.Forms.Button();
            this.but_ClearMRU = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.chk_HideTagWarn = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chk_Legacy = new System.Windows.Forms.CheckBox();
            this.chk_useModifiedLibrary = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.but_Close = new System.Windows.Forms.Button();
            this.txt_TempPath = new System.Windows.Forms.TextBox();
            this.txt_rg3Loc = new System.Windows.Forms.TextBox();
            this.but_NextStage = new System.Windows.Forms.Button();
            this.txt_DefaultPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.but_DefaultBrowse = new System.Windows.Forms.Button();
            this.but_TempBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbl_FilePaths = new System.Windows.Forms.TableLayoutPanel();
            this.grp_FrmButtons = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnl_VisCntrl = new System.Windows.Forms.Panel();
            this.cbo_BitRate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.chk_ExtractAudio = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.but_BrowseFFMpeg = new System.Windows.Forms.Button();
            this.tbl_FFMPEG = new System.Windows.Forms.TableLayoutPanel();
            this.chk_Window = new System.Windows.Forms.CheckBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.chk_FallbackUse = new System.Windows.Forms.CheckBox();
            this.label32 = new System.Windows.Forms.Label();
            this.tbl_overwrite = new System.Windows.Forms.TableLayoutPanel();
            this.label31 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tbl_rg3args = new System.Windows.Forms.TableLayoutPanel();
            this.chk_ViewArgs = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.but_browserg3 = new System.Windows.Forms.Button();
            this.tbl_rg3Loc = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chk_Fallbackrg3 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.num_Reattempt = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txt_rg3Args = new System.Windows.Forms.TextBox();
            this.txt_FFMpegPath = new System.Windows.Forms.TextBox();
            this.txt_OverrideSignature = new System.Windows.Forms.TextBox();
            this.fldr_MainBrowse = new System.Windows.Forms.FolderBrowserDialog();
            this.dlg_OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.label27 = new System.Windows.Forms.Label();
            this.pic_TopLine = new System.Windows.Forms.PictureBox();
            this.pic_ICO = new System.Windows.Forms.PictureBox();
            this.pic_Top = new System.Windows.Forms.PictureBox();
            this.pnl_OnTop.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tbl_TempFolderCntrl.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tbl_FilePaths.SuspendLayout();
            this.grp_FrmButtons.SuspendLayout();
            this.pnl_VisCntrl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Reattempt)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TopLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ICO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Top)).BeginInit();
            this.SuspendLayout();
            // 
            // rdo_Inbox
            // 
            this.rdo_Inbox.AutoSize = true;
            this.rdo_Inbox.Checked = true;
            this.rdo_Inbox.Location = new System.Drawing.Point(171, 5);
            this.rdo_Inbox.Name = "rdo_Inbox";
            this.rdo_Inbox.Size = new System.Drawing.Size(51, 17);
            this.rdo_Inbox.TabIndex = 8;
            this.rdo_Inbox.TabStop = true;
            this.rdo_Inbox.Text = "Inbox";
            this.rdo_Inbox.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(3, 6);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(56, 16);
            this.label26.TabIndex = 10;
            this.label26.Text = "On Top:";
            // 
            // rdo_TopAlways
            // 
            this.rdo_TopAlways.AutoSize = true;
            this.rdo_TopAlways.Location = new System.Drawing.Point(59, 5);
            this.rdo_TopAlways.Name = "rdo_TopAlways";
            this.rdo_TopAlways.Size = new System.Drawing.Size(58, 17);
            this.rdo_TopAlways.TabIndex = 8;
            this.rdo_TopAlways.Text = "Always";
            this.rdo_TopAlways.UseVisualStyleBackColor = true;
            // 
            // rdo_TopRecent
            // 
            this.rdo_TopRecent.AutoSize = true;
            this.rdo_TopRecent.Location = new System.Drawing.Point(123, 6);
            this.rdo_TopRecent.Name = "rdo_TopRecent";
            this.rdo_TopRecent.Size = new System.Drawing.Size(154, 17);
            this.rdo_TopRecent.TabIndex = 9;
            this.rdo_TopRecent.Text = "Most Recent Instance Only";
            this.rdo_TopRecent.UseVisualStyleBackColor = true;
            // 
            // rdo_TopNever
            // 
            this.rdo_TopNever.AutoSize = true;
            this.rdo_TopNever.Checked = true;
            this.rdo_TopNever.Location = new System.Drawing.Point(283, 5);
            this.rdo_TopNever.Name = "rdo_TopNever";
            this.rdo_TopNever.Size = new System.Drawing.Size(54, 17);
            this.rdo_TopNever.TabIndex = 11;
            this.rdo_TopNever.TabStop = true;
            this.rdo_TopNever.Text = "Never";
            this.rdo_TopNever.UseVisualStyleBackColor = true;
            // 
            // pnl_OnTop
            // 
            this.pnl_OnTop.Controls.Add(this.label26);
            this.pnl_OnTop.Controls.Add(this.rdo_TopAlways);
            this.pnl_OnTop.Controls.Add(this.rdo_TopRecent);
            this.pnl_OnTop.Controls.Add(this.rdo_TopNever);
            this.pnl_OnTop.Enabled = false;
            this.pnl_OnTop.Location = new System.Drawing.Point(3, 138);
            this.pnl_OnTop.Name = "pnl_OnTop";
            this.pnl_OnTop.Size = new System.Drawing.Size(536, 27);
            this.pnl_OnTop.TabIndex = 26;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chk_PipeFFMPEG);
            this.tabPage3.Controls.Add(this.checkBox1);
            this.tabPage3.Controls.Add(this.chk_AutoClose);
            this.tabPage3.Controls.Add(this.pnl_OnTop);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.chk_AutoPaste);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.chk_AutoTag);
            this.tabPage3.Controls.Add(this.but_TagEditor);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.chk_Comment);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(539, 271);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Features";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chk_PipeFFMPEG
            // 
            this.chk_PipeFFMPEG.AutoSize = true;
            this.chk_PipeFFMPEG.Enabled = false;
            this.chk_PipeFFMPEG.Location = new System.Drawing.Point(3, 242);
            this.chk_PipeFFMPEG.Name = "chk_PipeFFMPEG";
            this.chk_PipeFFMPEG.Size = new System.Drawing.Size(210, 17);
            this.chk_PipeFFMPEG.TabIndex = 29;
            this.chk_PipeFFMPEG.Text = "Pipe FFMPEG output to Download Log";
            this.chk_PipeFFMPEG.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(6, 219);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(358, 17);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "Skip Splash Screen (Requires Terms To Be Accepted To Take Effect)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chk_AutoClose
            // 
            this.chk_AutoClose.AutoSize = true;
            this.chk_AutoClose.Location = new System.Drawing.Point(6, 196);
            this.chk_AutoClose.Name = "chk_AutoClose";
            this.chk_AutoClose.Size = new System.Drawing.Size(304, 17);
            this.chk_AutoClose.TabIndex = 27;
            this.chk_AutoClose.Text = "Automatically close the plugin once process has completed";
            this.chk_AutoClose.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 170);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 21);
            this.label16.TabIndex = 24;
            this.label16.Text = "Other Settings";
            // 
            // chk_AutoPaste
            // 
            this.chk_AutoPaste.AutoSize = true;
            this.chk_AutoPaste.Location = new System.Drawing.Point(6, 114);
            this.chk_AutoPaste.Name = "chk_AutoPaste";
            this.chk_AutoPaste.Size = new System.Drawing.Size(401, 17);
            this.chk_AutoPaste.TabIndex = 20;
            this.chk_AutoPaste.Text = "Auto Paste valid URL\'s if data is found in the clipboard (On \"Insert Media URL\")";
            this.chk_AutoPaste.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 21);
            this.label15.TabIndex = 23;
            this.label15.Text = "Custom Features";
            // 
            // chk_AutoTag
            // 
            this.chk_AutoTag.AutoSize = true;
            this.chk_AutoTag.Location = new System.Drawing.Point(6, 63);
            this.chk_AutoTag.Name = "chk_AutoTag";
            this.chk_AutoTag.Size = new System.Drawing.Size(281, 17);
            this.chk_AutoTag.TabIndex = 21;
            this.chk_AutoTag.Text = "Attempt to AutoTag Metadata using Media Information";
            this.chk_AutoTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_AutoTag.UseVisualStyleBackColor = true;
            // 
            // but_TagEditor
            // 
            this.but_TagEditor.Location = new System.Drawing.Point(218, 31);
            this.but_TagEditor.Name = "but_TagEditor";
            this.but_TagEditor.Size = new System.Drawing.Size(111, 23);
            this.but_TagEditor.TabIndex = 22;
            this.but_TagEditor.Text = "Modify Tag Info";
            this.but_TagEditor.UseVisualStyleBackColor = true;
            this.but_TagEditor.Click += new System.EventHandler(this.but_TagEditor_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(2, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 21);
            this.label14.TabIndex = 21;
            this.label14.Text = "File Tagging";
            // 
            // chk_Comment
            // 
            this.chk_Comment.AutoSize = true;
            this.chk_Comment.Location = new System.Drawing.Point(6, 35);
            this.chk_Comment.Name = "chk_Comment";
            this.chk_Comment.Size = new System.Drawing.Size(215, 17);
            this.chk_Comment.TabIndex = 0;
            this.chk_Comment.Text = "Add a comment tag to the converted file";
            this.chk_Comment.UseVisualStyleBackColor = true;
            this.chk_Comment.CheckedChanged += new System.EventHandler(this.chk_Comment_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.rdo_NoWarn);
            this.panel2.Controls.Add(this.rdo_Warn);
            this.panel2.Controls.Add(this.rdo_Appendix);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(3, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 27);
            this.panel2.TabIndex = 19;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(3, 6);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(148, 16);
            this.label20.TabIndex = 10;
            this.label20.Text = "Overwrite Existing Files:";
            // 
            // rdo_NoWarn
            // 
            this.rdo_NoWarn.AutoSize = true;
            this.rdo_NoWarn.Checked = true;
            this.rdo_NoWarn.Location = new System.Drawing.Point(246, 5);
            this.rdo_NoWarn.Name = "rdo_NoWarn";
            this.rdo_NoWarn.Size = new System.Drawing.Size(105, 17);
            this.rdo_NoWarn.TabIndex = 8;
            this.rdo_NoWarn.TabStop = true;
            this.rdo_NoWarn.Text = "Without Warning";
            this.rdo_NoWarn.UseVisualStyleBackColor = true;
            // 
            // rdo_Warn
            // 
            this.rdo_Warn.AutoSize = true;
            this.rdo_Warn.Location = new System.Drawing.Point(157, 5);
            this.rdo_Warn.Name = "rdo_Warn";
            this.rdo_Warn.Size = new System.Drawing.Size(90, 17);
            this.rdo_Warn.TabIndex = 9;
            this.rdo_Warn.Text = "With Warning";
            this.rdo_Warn.UseVisualStyleBackColor = true;
            // 
            // rdo_Appendix
            // 
            this.rdo_Appendix.AutoSize = true;
            this.rdo_Appendix.Location = new System.Drawing.Point(355, 5);
            this.rdo_Appendix.Name = "rdo_Appendix";
            this.rdo_Appendix.Size = new System.Drawing.Size(153, 17);
            this.rdo_Appendix.TabIndex = 11;
            this.rdo_Appendix.Text = "Add A Numbered Appendix";
            this.rdo_Appendix.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "File Locations";
            // 
            // rdo_Music
            // 
            this.rdo_Music.AutoSize = true;
            this.rdo_Music.Location = new System.Drawing.Point(222, 5);
            this.rdo_Music.Name = "rdo_Music";
            this.rdo_Music.Size = new System.Drawing.Size(87, 17);
            this.rdo_Music.TabIndex = 9;
            this.rdo_Music.Text = "Music Library";
            this.rdo_Music.UseVisualStyleBackColor = true;
            // 
            // rdo_None
            // 
            this.rdo_None.AutoSize = true;
            this.rdo_None.Location = new System.Drawing.Point(321, 5);
            this.rdo_None.Name = "rdo_None";
            this.rdo_None.Size = new System.Drawing.Size(150, 17);
            this.rdo_None.TabIndex = 11;
            this.rdo_None.Text = "Do Not Add To Music Bee";
            this.rdo_None.UseVisualStyleBackColor = true;
            // 
            // tbl_TempFolderCntrl
            // 
            this.tbl_TempFolderCntrl.ColumnCount = 2;
            this.tbl_TempFolderCntrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.63129F));
            this.tbl_TempFolderCntrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.36871F));
            this.tbl_TempFolderCntrl.Controls.Add(this.chk_SeperateDir, 0, 0);
            this.tbl_TempFolderCntrl.Controls.Add(this.chk_DelTemp, 1, 0);
            this.tbl_TempFolderCntrl.Location = new System.Drawing.Point(2, 4);
            this.tbl_TempFolderCntrl.Name = "tbl_TempFolderCntrl";
            this.tbl_TempFolderCntrl.RowCount = 1;
            this.tbl_TempFolderCntrl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_TempFolderCntrl.Size = new System.Drawing.Size(537, 23);
            this.tbl_TempFolderCntrl.TabIndex = 21;
            // 
            // chk_SeperateDir
            // 
            this.chk_SeperateDir.AutoSize = true;
            this.chk_SeperateDir.Location = new System.Drawing.Point(3, 3);
            this.chk_SeperateDir.Name = "chk_SeperateDir";
            this.chk_SeperateDir.Size = new System.Drawing.Size(263, 17);
            this.chk_SeperateDir.TabIndex = 6;
            this.chk_SeperateDir.Text = "Use a seperate directory instead for temporary files";
            this.chk_SeperateDir.UseVisualStyleBackColor = true;
            this.chk_SeperateDir.CheckedChanged += new System.EventHandler(this.chk_SeperateDir_CheckedChanged);
            // 
            // chk_DelTemp
            // 
            this.chk_DelTemp.AutoSize = true;
            this.chk_DelTemp.Location = new System.Drawing.Point(291, 3);
            this.chk_DelTemp.Name = "chk_DelTemp";
            this.chk_DelTemp.Size = new System.Drawing.Size(224, 17);
            this.chk_DelTemp.TabIndex = 20;
            this.chk_DelTemp.Text = "Do not automatically delete temporary files";
            this.chk_DelTemp.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Default Add To Music Bee:";
            // 
            // chk_Smoothing
            // 
            this.chk_Smoothing.AutoSize = true;
            this.chk_Smoothing.Location = new System.Drawing.Point(6, 243);
            this.chk_Smoothing.Name = "chk_Smoothing";
            this.chk_Smoothing.Size = new System.Drawing.Size(441, 17);
            this.chk_Smoothing.TabIndex = 30;
            this.chk_Smoothing.Text = "During video download - Delay GUI Updates (Prevents freezeing on high speed inter" +
    "net)";
            this.chk_Smoothing.UseVisualStyleBackColor = true;
            // 
            // lbl_SettingVersion
            // 
            this.lbl_SettingVersion.AutoSize = true;
            this.lbl_SettingVersion.Location = new System.Drawing.Point(7, 133);
            this.lbl_SettingVersion.Name = "lbl_SettingVersion";
            this.lbl_SettingVersion.Size = new System.Drawing.Size(113, 13);
            this.lbl_SettingVersion.TabIndex = 28;
            this.lbl_SettingVersion.Text = "Unknown Settings File";
            // 
            // chk_AdvFeatures
            // 
            this.chk_AdvFeatures.AutoSize = true;
            this.chk_AdvFeatures.Location = new System.Drawing.Point(6, 177);
            this.chk_AdvFeatures.Name = "chk_AdvFeatures";
            this.chk_AdvFeatures.Size = new System.Drawing.Size(351, 17);
            this.chk_AdvFeatures.TabIndex = 27;
            this.chk_AdvFeatures.Text = "Enable Experimental/Testing Features (See Forum Post If Applicable)";
            this.chk_AdvFeatures.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(1, 153);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 21);
            this.label21.TabIndex = 26;
            this.label21.Text = "Advanced";
            // 
            // but_Restore
            // 
            this.but_Restore.Location = new System.Drawing.Point(6, 105);
            this.but_Restore.Name = "but_Restore";
            this.but_Restore.Size = new System.Drawing.Size(233, 23);
            this.but_Restore.TabIndex = 25;
            this.but_Restore.Text = "Reset to default settings";
            this.but_Restore.UseVisualStyleBackColor = true;
            this.but_Restore.Click += new System.EventHandler(this.but_Restore_Click);
            // 
            // but_ClearMRU
            // 
            this.but_ClearMRU.Enabled = false;
            this.but_ClearMRU.Location = new System.Drawing.Point(5, 76);
            this.but_ClearMRU.Name = "but_ClearMRU";
            this.but_ClearMRU.Size = new System.Drawing.Size(233, 23);
            this.but_ClearMRU.TabIndex = 24;
            this.but_ClearMRU.Text = "Clear Recently Selected Folders";
            this.but_ClearMRU.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(2, 52);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 21);
            this.label19.TabIndex = 23;
            this.label19.Text = "Tools";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(96, 28);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(131, 13);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Non-Public Alpha Release";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(7, 28);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(92, 13);
            this.label24.TabIndex = 25;
            this.label24.Text = "Created By Cyano";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(0, 3);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(156, 21);
            this.label22.TabIndex = 23;
            this.label22.Text = "Plugin Information";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(164, 21);
            this.label18.TabIndex = 22;
            this.label18.Text = "Plugin Notifications";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.linkLabel1);
            this.tabPage5.Controls.Add(this.label24);
            this.tabPage5.Controls.Add(this.label23);
            this.tabPage5.Controls.Add(this.label22);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(539, 271);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "About";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Null";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(1, 56);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(143, 21);
            this.label23.TabIndex = 24;
            this.label23.Text = "With Thanks To....";
            // 
            // chk_HideTagWarn
            // 
            this.chk_HideTagWarn.AutoSize = true;
            this.chk_HideTagWarn.Location = new System.Drawing.Point(6, 31);
            this.chk_HideTagWarn.Name = "chk_HideTagWarn";
            this.chk_HideTagWarn.Size = new System.Drawing.Size(300, 17);
            this.chk_HideTagWarn.TabIndex = 10;
            this.chk_HideTagWarn.Text = "Hide Message: Warn me when I have left a tag field blank";
            this.chk_HideTagWarn.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chk_Legacy);
            this.tabPage4.Controls.Add(this.chk_useModifiedLibrary);
            this.tabPage4.Controls.Add(this.chk_Smoothing);
            this.tabPage4.Controls.Add(this.lbl_SettingVersion);
            this.tabPage4.Controls.Add(this.chk_AdvFeatures);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.but_Restore);
            this.tabPage4.Controls.Add(this.but_ClearMRU);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.chk_HideTagWarn);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(539, 271);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Uncategorized";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chk_Legacy
            // 
            this.chk_Legacy.AutoSize = true;
            this.chk_Legacy.Enabled = false;
            this.chk_Legacy.Location = new System.Drawing.Point(6, 221);
            this.chk_Legacy.Name = "chk_Legacy";
            this.chk_Legacy.Size = new System.Drawing.Size(331, 17);
            this.chk_Legacy.TabIndex = 32;
            this.chk_Legacy.Text = "Force MusicBee Legacy Mode (Run Plugin on MB Version < 2.4)";
            this.chk_Legacy.UseVisualStyleBackColor = true;
            // 
            // chk_useModifiedLibrary
            // 
            this.chk_useModifiedLibrary.AutoSize = true;
            this.chk_useModifiedLibrary.Enabled = false;
            this.chk_useModifiedLibrary.Location = new System.Drawing.Point(6, 200);
            this.chk_useModifiedLibrary.Name = "chk_useModifiedLibrary";
            this.chk_useModifiedLibrary.Size = new System.Drawing.Size(298, 17);
            this.chk_useModifiedLibrary.TabIndex = 31;
            this.chk_useModifiedLibrary.Text = "Using Unmodified YouTube Extractor Library (By FlagBug)";
            this.chk_useModifiedLibrary.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.rdo_Inbox);
            this.panel1.Controls.Add(this.rdo_Music);
            this.panel1.Controls.Add(this.rdo_None);
            this.panel1.Location = new System.Drawing.Point(3, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 27);
            this.panel1.TabIndex = 18;
            // 
            // but_Close
            // 
            this.but_Close.Location = new System.Drawing.Point(5, 11);
            this.but_Close.Name = "but_Close";
            this.but_Close.Size = new System.Drawing.Size(112, 30);
            this.but_Close.TabIndex = 11;
            this.but_Close.Text = "Cancel";
            this.but_Close.UseVisualStyleBackColor = true;
            this.but_Close.Click += new System.EventHandler(this.but_Close_Click);
            // 
            // txt_TempPath
            // 
            this.txt_TempPath.Location = new System.Drawing.Point(146, 37);
            this.txt_TempPath.Name = "txt_TempPath";
            this.txt_TempPath.Size = new System.Drawing.Size(312, 20);
            this.txt_TempPath.TabIndex = 36;
            // 
            // txt_rg3Loc
            // 
            this.txt_rg3Loc.Location = new System.Drawing.Point(146, 37);
            this.txt_rg3Loc.Name = "txt_rg3Loc";
            this.txt_rg3Loc.Size = new System.Drawing.Size(312, 20);
            this.txt_rg3Loc.TabIndex = 36;
            // 
            // but_NextStage
            // 
            this.but_NextStage.Location = new System.Drawing.Point(341, 11);
            this.but_NextStage.Name = "but_NextStage";
            this.but_NextStage.Size = new System.Drawing.Size(118, 30);
            this.but_NextStage.TabIndex = 9;
            this.but_NextStage.Text = "Save && Exit";
            this.but_NextStage.UseVisualStyleBackColor = true;
            this.but_NextStage.Click += new System.EventHandler(this.but_NextStage_Click);
            // 
            // txt_DefaultPath
            // 
            this.txt_DefaultPath.Location = new System.Drawing.Point(146, 3);
            this.txt_DefaultPath.Name = "txt_DefaultPath";
            this.txt_DefaultPath.Size = new System.Drawing.Size(312, 20);
            this.txt_DefaultPath.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Default Path:";
            // 
            // but_DefaultBrowse
            // 
            this.but_DefaultBrowse.Location = new System.Drawing.Point(464, 3);
            this.but_DefaultBrowse.Name = "but_DefaultBrowse";
            this.but_DefaultBrowse.Size = new System.Drawing.Size(52, 23);
            this.but_DefaultBrowse.TabIndex = 5;
            this.but_DefaultBrowse.Text = "Browse";
            this.but_DefaultBrowse.UseVisualStyleBackColor = true;
            this.but_DefaultBrowse.Click += new System.EventHandler(this.but_DefaultBrowse_Click);
            // 
            // but_TempBrowse
            // 
            this.but_TempBrowse.Location = new System.Drawing.Point(464, 37);
            this.but_TempBrowse.Name = "but_TempBrowse";
            this.but_TempBrowse.Size = new System.Drawing.Size(52, 23);
            this.but_TempBrowse.TabIndex = 4;
            this.but_TempBrowse.Text = "Browse";
            this.but_TempBrowse.UseVisualStyleBackColor = true;
            this.but_TempBrowse.Click += new System.EventHandler(this.but_TempBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Temporary Path:";
            // 
            // tbl_FilePaths
            // 
            this.tbl_FilePaths.ColumnCount = 3;
            this.tbl_FilePaths.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tbl_FilePaths.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tbl_FilePaths.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tbl_FilePaths.Controls.Add(this.label3, 0, 0);
            this.tbl_FilePaths.Controls.Add(this.but_DefaultBrowse, 2, 0);
            this.tbl_FilePaths.Controls.Add(this.but_TempBrowse, 2, 1);
            this.tbl_FilePaths.Controls.Add(this.label2, 0, 1);
            this.tbl_FilePaths.Location = new System.Drawing.Point(6, 30);
            this.tbl_FilePaths.Name = "tbl_FilePaths";
            this.tbl_FilePaths.RowCount = 2;
            this.tbl_FilePaths.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_FilePaths.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_FilePaths.Size = new System.Drawing.Size(530, 69);
            this.tbl_FilePaths.TabIndex = 6;
            // 
            // grp_FrmButtons
            // 
            this.grp_FrmButtons.Controls.Add(this.but_Close);
            this.grp_FrmButtons.Controls.Add(this.but_NextStage);
            this.grp_FrmButtons.Location = new System.Drawing.Point(45, 377);
            this.grp_FrmButtons.Name = "grp_FrmButtons";
            this.grp_FrmButtons.Size = new System.Drawing.Size(469, 46);
            this.grp_FrmButtons.TabIndex = 35;
            this.grp_FrmButtons.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Settings";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Location = new System.Drawing.Point(63, 1);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(333, 37);
            this.lbl_Title.TabIndex = 32;
            this.lbl_Title.Text = "Media: Download Plugin";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 21);
            this.label10.TabIndex = 7;
            this.label10.Text = "Default Options";
            // 
            // pnl_VisCntrl
            // 
            this.pnl_VisCntrl.Controls.Add(this.panel2);
            this.pnl_VisCntrl.Controls.Add(this.tbl_TempFolderCntrl);
            this.pnl_VisCntrl.Controls.Add(this.panel1);
            this.pnl_VisCntrl.Controls.Add(this.label10);
            this.pnl_VisCntrl.Controls.Add(this.cbo_BitRate);
            this.pnl_VisCntrl.Controls.Add(this.label5);
            this.pnl_VisCntrl.Location = new System.Drawing.Point(3, 103);
            this.pnl_VisCntrl.Name = "pnl_VisCntrl";
            this.pnl_VisCntrl.Size = new System.Drawing.Size(539, 169);
            this.pnl_VisCntrl.TabIndex = 22;
            // 
            // cbo_BitRate
            // 
            this.cbo_BitRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_BitRate.FormattingEnabled = true;
            this.cbo_BitRate.Items.AddRange(new object[] {
            "Use Same Audio Bitrate as the video",
            "32",
            "64",
            "128",
            "192",
            "256",
            "320"});
            this.cbo_BitRate.Location = new System.Drawing.Point(173, 46);
            this.cbo_BitRate.Name = "cbo_BitRate";
            this.cbo_BitRate.Size = new System.Drawing.Size(255, 21);
            this.cbo_BitRate.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Default Conversion BitRate:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnl_VisCntrl);
            this.tabPage1.Controls.Add(this.tbl_FilePaths);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(539, 271);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Defaults";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(6, 74);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(547, 297);
            this.tabControl1.TabIndex = 37;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.chk_ExtractAudio);
            this.tabPage6.Controls.Add(this.label12);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.label4);
            this.tabPage6.Controls.Add(this.but_BrowseFFMpeg);
            this.tabPage6.Controls.Add(this.tbl_FFMPEG);
            this.tabPage6.Controls.Add(this.chk_Window);
            this.tabPage6.Controls.Add(this.tabControl2);
            this.tabPage6.Controls.Add(this.label29);
            this.tabPage6.Controls.Add(this.tableLayoutPanel1);
            this.tabPage6.Controls.Add(this.label28);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(539, 271);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Downloading && Converting Settings";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // chk_ExtractAudio
            // 
            this.chk_ExtractAudio.AutoSize = true;
            this.chk_ExtractAudio.Location = new System.Drawing.Point(3, 247);
            this.chk_ExtractAudio.Name = "chk_ExtractAudio";
            this.chk_ExtractAudio.Size = new System.Drawing.Size(362, 17);
            this.chk_ExtractAudio.TabIndex = 32;
            this.chk_ExtractAudio.Text = "Extract audio stream from original file instead of converting the video file";
            this.chk_ExtractAudio.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(0, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(196, 21);
            this.label12.TabIndex = 33;
            this.label12.Text = "Audio Stream Extracting";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-1, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 21);
            this.label11.TabIndex = 31;
            this.label11.Text = "Conversion Library";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "FFMpeg.exe Location:";
            // 
            // but_BrowseFFMpeg
            // 
            this.but_BrowseFFMpeg.Location = new System.Drawing.Point(462, 174);
            this.but_BrowseFFMpeg.Name = "but_BrowseFFMpeg";
            this.but_BrowseFFMpeg.Size = new System.Drawing.Size(75, 23);
            this.but_BrowseFFMpeg.TabIndex = 29;
            this.but_BrowseFFMpeg.Text = "Browse";
            this.but_BrowseFFMpeg.UseVisualStyleBackColor = true;
            this.but_BrowseFFMpeg.Click += new System.EventHandler(this.but_BrowseFFMpeg_Click);
            // 
            // tbl_FFMPEG
            // 
            this.tbl_FFMPEG.ColumnCount = 1;
            this.tbl_FFMPEG.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_FFMPEG.Location = new System.Drawing.Point(144, 174);
            this.tbl_FFMPEG.Name = "tbl_FFMPEG";
            this.tbl_FFMPEG.RowCount = 1;
            this.tbl_FFMPEG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_FFMPEG.Size = new System.Drawing.Size(316, 23);
            this.tbl_FFMPEG.TabIndex = 30;
            // 
            // chk_Window
            // 
            this.chk_Window.AutoSize = true;
            this.chk_Window.Location = new System.Drawing.Point(4, 202);
            this.chk_Window.Name = "chk_Window";
            this.chk_Window.Size = new System.Drawing.Size(412, 17);
            this.chk_Window.TabIndex = 28;
            this.chk_Window.Text = "Display the FFMpeg conversion console window when conversion process begins";
            this.chk_Window.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(13, 48);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(510, 104);
            this.tabControl2.TabIndex = 26;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.chk_FallbackUse);
            this.tabPage7.Controls.Add(this.label32);
            this.tabPage7.Controls.Add(this.tbl_overwrite);
            this.tabPage7.Controls.Add(this.label31);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(502, 78);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "YouTube Extractor (By FlagBug) Settings";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // chk_FallbackUse
            // 
            this.chk_FallbackUse.AutoSize = true;
            this.chk_FallbackUse.Location = new System.Drawing.Point(6, 6);
            this.chk_FallbackUse.Name = "chk_FallbackUse";
            this.chk_FallbackUse.Size = new System.Drawing.Size(480, 17);
            this.chk_FallbackUse.TabIndex = 24;
            this.chk_FallbackUse.Text = "Attempt fallback signature decipher upon 403 Error (See Settings-> Signature Deci" +
    "pher Fallback)";
            this.chk_FallbackUse.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(3, 56);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(462, 13);
            this.label32.TabIndex = 23;
            this.label32.Text = "Override automatic decipher by manual signature operations. Leave blank to obtain" +
    " automatically";
            // 
            // tbl_overwrite
            // 
            this.tbl_overwrite.ColumnCount = 1;
            this.tbl_overwrite.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_overwrite.Location = new System.Drawing.Point(121, 30);
            this.tbl_overwrite.Name = "tbl_overwrite";
            this.tbl_overwrite.RowCount = 1;
            this.tbl_overwrite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_overwrite.Size = new System.Drawing.Size(342, 23);
            this.tbl_overwrite.TabIndex = 21;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(3, 33);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(121, 16);
            this.label31.TabIndex = 20;
            this.label31.Text = "Override Decipher:";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.tbl_rg3args);
            this.tabPage8.Controls.Add(this.chk_ViewArgs);
            this.tabPage8.Controls.Add(this.label13);
            this.tabPage8.Controls.Add(this.but_browserg3);
            this.tabPage8.Controls.Add(this.tbl_rg3Loc);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(502, 78);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "RG3 Extractor Settings";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tbl_rg3args
            // 
            this.tbl_rg3args.ColumnCount = 1;
            this.tbl_rg3args.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_rg3args.Location = new System.Drawing.Point(8, 55);
            this.tbl_rg3args.Name = "tbl_rg3args";
            this.tbl_rg3args.RowCount = 1;
            this.tbl_rg3args.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_rg3args.Size = new System.Drawing.Size(488, 23);
            this.tbl_rg3args.TabIndex = 35;
            // 
            // chk_ViewArgs
            // 
            this.chk_ViewArgs.Appearance = System.Windows.Forms.Appearance.Button;
            this.chk_ViewArgs.AutoSize = true;
            this.chk_ViewArgs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_ViewArgs.Location = new System.Drawing.Point(4, 31);
            this.chk_ViewArgs.Name = "chk_ViewArgs";
            this.chk_ViewArgs.Size = new System.Drawing.Size(492, 23);
            this.chk_ViewArgs.TabIndex = 34;
            this.chk_ViewArgs.Text = "Use custom RG3 Process Arguments (https://github.com/rg3/youtube-dl/blob/master/R" +
    "EADME.md)";
            this.chk_ViewArgs.UseVisualStyleBackColor = true;
            this.chk_ViewArgs.CheckedChanged += new System.EventHandler(this.chk_ViewArgs_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(176, 16);
            this.label13.TabIndex = 31;
            this.label13.Text = "rg3-youtube-dl.exe Location:";
            // 
            // but_browserg3
            // 
            this.but_browserg3.Location = new System.Drawing.Point(421, 3);
            this.but_browserg3.Name = "but_browserg3";
            this.but_browserg3.Size = new System.Drawing.Size(75, 23);
            this.but_browserg3.TabIndex = 32;
            this.but_browserg3.Text = "Browse";
            this.but_browserg3.UseVisualStyleBackColor = true;
            this.but_browserg3.Click += new System.EventHandler(this.but_browserg3_Click);
            // 
            // tbl_rg3Loc
            // 
            this.tbl_rg3Loc.ColumnCount = 1;
            this.tbl_rg3Loc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_rg3Loc.Location = new System.Drawing.Point(180, 3);
            this.tbl_rg3Loc.Name = "tbl_rg3Loc";
            this.tbl_rg3Loc.RowCount = 1;
            this.tbl_rg3Loc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_rg3Loc.Size = new System.Drawing.Size(238, 23);
            this.tbl_rg3Loc.TabIndex = 33;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chk_Fallbackrg3);
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(502, 78);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Signature Decipher Fallback";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chk_Fallbackrg3
            // 
            this.chk_Fallbackrg3.AutoSize = true;
            this.chk_Fallbackrg3.Location = new System.Drawing.Point(6, 35);
            this.chk_Fallbackrg3.Name = "chk_Fallbackrg3";
            this.chk_Fallbackrg3.Size = new System.Drawing.Size(296, 17);
            this.chk_Fallbackrg3.TabIndex = 24;
            this.chk_Fallbackrg3.Text = "Use RG3 Library to Retrieve Deciphered Download URL ";
            this.chk_Fallbackrg3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.num_Reattempt, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(178, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(288, 23);
            this.tableLayoutPanel2.TabIndex = 23;
            // 
            // num_Reattempt
            // 
            this.num_Reattempt.Location = new System.Drawing.Point(3, 3);
            this.num_Reattempt.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_Reattempt.Name = "num_Reattempt";
            this.num_Reattempt.Size = new System.Drawing.Size(70, 20);
            this.num_Reattempt.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Retry #Times on 403 Errors:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(4, 25);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(80, 16);
            this.label29.TabIndex = 24;
            this.label29.Text = "Use Library:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(84, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(203, 23);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "YouTube Extractor (By Flagbug)",
            "RG3 Extractor"});
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "YouTube Extractor (By Flagbug)";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(1, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(191, 21);
            this.label28.TabIndex = 23;
            this.label28.Text = "Media-Extractor Library";
            // 
            // txt_rg3Args
            // 
            this.txt_rg3Args.Location = new System.Drawing.Point(712, 388);
            this.txt_rg3Args.Name = "txt_rg3Args";
            this.txt_rg3Args.Size = new System.Drawing.Size(132, 20);
            this.txt_rg3Args.TabIndex = 35;
            this.txt_rg3Args.Visible = false;
            // 
            // txt_FFMpegPath
            // 
            this.txt_FFMpegPath.Location = new System.Drawing.Point(3, 3);
            this.txt_FFMpegPath.Name = "txt_FFMpegPath";
            this.txt_FFMpegPath.Size = new System.Drawing.Size(310, 20);
            this.txt_FFMpegPath.TabIndex = 29;
            // 
            // txt_OverrideSignature
            // 
            this.txt_OverrideSignature.Enabled = false;
            this.txt_OverrideSignature.Location = new System.Drawing.Point(3, 3);
            this.txt_OverrideSignature.MaxLength = 20;
            this.txt_OverrideSignature.Name = "txt_OverrideSignature";
            this.txt_OverrideSignature.Size = new System.Drawing.Size(336, 20);
            this.txt_OverrideSignature.TabIndex = 29;
            // 
            // dlg_OpenFile
            // 
            this.dlg_OpenFile.Filter = "FFMPEG EXE|ffmpeg.exe|EXE File|*.exe";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Red;
            this.label27.Location = new System.Drawing.Point(249, 51);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(317, 16);
            this.label27.TabIndex = 38;
            this.label27.Text = "Some settings are unavailable in this version";
            // 
            // pic_TopLine
            // 
            this.pic_TopLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(131)))), ((int)(((byte)(155)))));
            this.pic_TopLine.Location = new System.Drawing.Point(-9, 46);
            this.pic_TopLine.Name = "pic_TopLine";
            this.pic_TopLine.Size = new System.Drawing.Size(602, 5);
            this.pic_TopLine.TabIndex = 33;
            this.pic_TopLine.TabStop = false;
            // 
            // pic_ICO
            // 
            this.pic_ICO.Image = global::mediaDownloader.Properties.Resources.basic_icon;
            this.pic_ICO.Location = new System.Drawing.Point(7, -1);
            this.pic_ICO.Name = "pic_ICO";
            this.pic_ICO.Size = new System.Drawing.Size(49, 41);
            this.pic_ICO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ICO.TabIndex = 31;
            this.pic_ICO.TabStop = false;
            // 
            // pic_Top
            // 
            this.pic_Top.BackColor = System.Drawing.Color.DimGray;
            this.pic_Top.Location = new System.Drawing.Point(-4, 0);
            this.pic_Top.Name = "pic_Top";
            this.pic_Top.Size = new System.Drawing.Size(746, 50);
            this.pic_Top.TabIndex = 30;
            this.pic_Top.TabStop = false;
            // 
            // frm_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 438);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.pic_TopLine);
            this.Controls.Add(this.grp_FrmButtons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pic_ICO);
            this.Controls.Add(this.pic_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Download Plugin: Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Settings_FormClosing);
            this.pnl_OnTop.ResumeLayout(false);
            this.pnl_OnTop.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tbl_TempFolderCntrl.ResumeLayout(false);
            this.tbl_TempFolderCntrl.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbl_FilePaths.ResumeLayout(false);
            this.tbl_FilePaths.PerformLayout();
            this.grp_FrmButtons.ResumeLayout(false);
            this.pnl_VisCntrl.ResumeLayout(false);
            this.pnl_VisCntrl.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_Reattempt)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
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
                this.txt_DefaultPath = (TextBox)pluginInstance.getAPI().getInterface().MB_AddPanel(null, MusicBeePlugin.Plugin.PluginPanelDock.TextBox);
                this.txt_FFMpegPath = (TextBox)pluginInstance.getAPI().getInterface().MB_AddPanel(null, MusicBeePlugin.Plugin.PluginPanelDock.TextBox);
                this.txt_OverrideSignature = (TextBox)pluginInstance.getAPI().getInterface().MB_AddPanel(null, MusicBeePlugin.Plugin.PluginPanelDock.TextBox);
                this.txt_TempPath = (TextBox)pluginInstance.getAPI().getInterface().MB_AddPanel(null, MusicBeePlugin.Plugin.PluginPanelDock.TextBox);
                this.txt_rg3Loc = (TextBox)pluginInstance.getAPI().getInterface().MB_AddPanel(null, MusicBeePlugin.Plugin.PluginPanelDock.TextBox);
                this.txt_rg3Args = (TextBox)pluginInstance.getAPI().getInterface().MB_AddPanel(null, MusicBeePlugin.Plugin.PluginPanelDock.TextBox);
            }


            tbl_FilePaths.Controls.Add(txt_DefaultPath, 1, 0);
            tbl_FilePaths.Controls.Add(txt_TempPath, 1, 1);
            tbl_FFMPEG.Controls.Add(txt_FFMpegPath, 0, 0);
            tbl_overwrite.Controls.Add(txt_OverrideSignature, 0, 0);
            tbl_rg3Loc.Controls.Add(txt_rg3Loc, 0, 0);
            tbl_rg3args.Controls.Add(txt_rg3Args, 0, 0);

            txt_TempPath.Dock = DockStyle.Fill;
            txt_DefaultPath.Dock = DockStyle.Fill;
            txt_FFMpegPath.Dock = DockStyle.Fill;
            txt_OverrideSignature.Dock = DockStyle.Fill;
            txt_rg3Loc.Dock = DockStyle.Fill;
            txt_rg3Args.Dock = DockStyle.Fill;
            this.txt_OverrideSignature.Enabled = false;

         }


        #endregion

        private System.Windows.Forms.RadioButton rdo_Inbox;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.RadioButton rdo_TopAlways;
        private System.Windows.Forms.RadioButton rdo_TopRecent;
        private System.Windows.Forms.RadioButton rdo_TopNever;
        private System.Windows.Forms.Panel pnl_OnTop;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox chk_AutoPaste;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chk_AutoTag;
        private System.Windows.Forms.Button but_TagEditor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chk_Comment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.RadioButton rdo_NoWarn;
        private System.Windows.Forms.RadioButton rdo_Warn;
        private System.Windows.Forms.RadioButton rdo_Appendix;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdo_Music;
        private System.Windows.Forms.RadioButton rdo_None;
        private System.Windows.Forms.TableLayoutPanel tbl_TempFolderCntrl;
        private System.Windows.Forms.CheckBox chk_SeperateDir;
        private System.Windows.Forms.CheckBox chk_DelTemp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pic_TopLine;
        private System.Windows.Forms.PictureBox pic_Top;
        private System.Windows.Forms.CheckBox chk_Smoothing;
        private System.Windows.Forms.Label lbl_SettingVersion;
        private System.Windows.Forms.CheckBox chk_AdvFeatures;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button but_Restore;
        private System.Windows.Forms.Button but_ClearMRU;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.CheckBox chk_HideTagWarn;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button but_Close;
        private System.Windows.Forms.TextBox txt_TempPath;
        private System.Windows.Forms.TextBox txt_rg3Loc;
        private System.Windows.Forms.Button but_NextStage;
        private System.Windows.Forms.TextBox txt_DefaultPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button but_DefaultBrowse;
        private System.Windows.Forms.Button but_TempBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tbl_FilePaths;
        private System.Windows.Forms.GroupBox grp_FrmButtons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnl_VisCntrl;
        private System.Windows.Forms.ComboBox cbo_BitRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.PictureBox pic_ICO;
        private System.Windows.Forms.FolderBrowserDialog fldr_MainBrowse;
        private System.Windows.Forms.OpenFileDialog dlg_OpenFile;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TableLayoutPanel tbl_overwrite;
        private System.Windows.Forms.TextBox txt_OverrideSignature;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button but_BrowseFFMpeg;
        private System.Windows.Forms.TableLayoutPanel tbl_FFMPEG;
        private System.Windows.Forms.TextBox txt_FFMpegPath;
        private System.Windows.Forms.CheckBox chk_Window;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chk_ExtractAudio;
        private System.Windows.Forms.CheckBox chk_AutoClose;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chk_Legacy;
        private System.Windows.Forms.CheckBox chk_useModifiedLibrary;
        private System.Windows.Forms.CheckBox checkBox1;
        private CheckBox chk_FallbackUse;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label8;
        private NumericUpDown num_Reattempt;
        private CheckBox chk_PipeFFMPEG;
        private CheckBox chk_Fallbackrg3;
        private Label label13;
        private Button but_browserg3;
        private TableLayoutPanel tbl_rg3Loc;
        private TextBox txt_rg3Args;
        private CheckBox chk_ViewArgs;
        private TableLayoutPanel tbl_rg3args;
    }
}