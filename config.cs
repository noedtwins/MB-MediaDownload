using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace mediaDownloader
{
    [XmlRoot("Configuration")]
    public class serialConfig
    {
        [XmlIgnoreAttribute]
        public Boolean outsideMB = true;

        [XmlIgnoreAttribute]
        public readonly int SETTINGVERSION = 6;

        public serialConfig()
        { }

        public serialConfig(string setLocation)
        {
            configLoc = setLocation;
        }

        [XmlIgnoreAttribute]
        public string configLoc = "";

        [XmlAttribute]
        public int loadedVersion = 0;

        private int _bitRate;
        [XmlAttribute]
        public int bitRate
        {
            get { return _bitRate; }
            set { _bitRate = value; }
        }

        private bool _delTempFiles;
        [XmlAttribute]
        public bool preventDelTempFiles
        {
            get { return _delTempFiles; }
            set { _delTempFiles = value; }
        }

        private string _mainFolder;
        [XmlAttribute]
        public string mainFolder
        {
            get { return _mainFolder; }
            set { _mainFolder = value; }
        }
        
        private bool _addInbox;
        [XmlAttribute]
        public bool addInbox
        {
            get { return _addInbox; }
            set { _addInbox = value; }
        }

        private bool _addLibrary;
        [XmlAttribute]
        public bool addLibrary
        {
            get { return _addLibrary; }
            set { _addLibrary = value; }
        }

        private bool _addComment;
        [XmlAttribute]
        public bool addComment
        {
            get { return _addComment; }
            set { _addComment = value; }
        }

        private string _ffmpegOutput;
        [XmlAttribute]
        public string ffmpegOutput
        {
            get { return _ffmpegOutput; }
            set { _ffmpegOutput = value; }
        }

        private string _ffmpegPath;
        [XmlAttribute]
        public string ffmpegPath
        {
            get { return _ffmpegPath; }
            set { _ffmpegPath = value; }
        }


        private bool _extractAudio;
        [XmlAttribute]
        public bool extractAudio
        {
            get { return _extractAudio; }
            set { _extractAudio = value; }
        }

        private bool _autoPasteURL;
        [XmlAttribute]
        public bool autoPasteURL
        {
            get { return _autoPasteURL; }
            set { _autoPasteURL = value; }
        }

        private bool _autoTagInfo;
        [XmlAttribute]
        public bool autoTagInfo
        {
            get { return _autoTagInfo; }
            set { _autoTagInfo = value; }
        }

        private bool _addCTagPlugInfo;
        [XmlAttribute]
        public bool addCTagPlugInfo
        {
           get { return _addCTagPlugInfo; }
           set { _addCTagPlugInfo = value; }
        }

        private bool _addCTagDateTime;
        [XmlAttribute]
        public bool addCTagDateTime
        {
          get { return _addCTagDateTime; }
          set { _addCTagDateTime = value; }
        }

        private bool _addCTagSource;
        [XmlAttribute]
        public bool addCTagSource
         {
          get { return _addCTagSource; }
          set { _addCTagSource = value; }
        }

        private bool _addCTagCustomText;
        [XmlAttribute]
        public bool addCTagCustomText
        {
          get { return _addCTagCustomText; }
          set { _addCTagCustomText = value; }
        }

        private string _addCTagCustomTextVal;
        [XmlAttribute]
        public string addCTagCustomTextVal
         {
          get { return _addCTagCustomTextVal; }
          set { _addCTagCustomTextVal = value; }
        }

        private bool _hideTagMessage;
        [XmlAttribute]
        public bool hideTagMessage
        {
            get { return _hideTagMessage; }
            set { _hideTagMessage = value; }
        }

        private bool _autoClosePlugin;
        [XmlAttribute]
        public bool autoClosePlugin
        {
            get { return _autoClosePlugin; }
            set { _autoClosePlugin = value; }
        }

        private string _overwriteMode;
        [XmlAttribute]
        public string overwriteMode
        {
            get { return _overwriteMode; }
            set { _overwriteMode = value; }
        }

        private bool _testFeature;
        [XmlAttribute]
        public bool testFeature
        {
            get { return _testFeature; }
            set { _testFeature = value; }
        }

        private bool _termsAccepted;
        [XmlAttribute]
        public bool termsAccepted
        {
            get { return _termsAccepted; }
            set { _termsAccepted = value; }
        }
        
        private bool _clipboardMessageShown;
        [XmlAttribute]
        public bool clipboardMessageShown
        {
            get { return _clipboardMessageShown; }
            set { _clipboardMessageShown = value; }
        }

        private string _rg3Path;
        [XmlAttribute]
        public string rg3Path
        {
            get { return _rg3Path; }
            set { _rg3Path = value; }
        }

        private string _rg3Args;
        [XmlAttribute]
        public string rg3Args
        {
            get { return _rg3Args; }
            set { _rg3Args = value; }
        }

        private bool _ontop;
        public bool ontop
        {
            get { return _ontop; }
            set { _ontop = value; }
        }

        private bool _multipleinstances;
        public bool multipleinstances
        {
            get { return _multipleinstances; }
            set { _multipleinstances = value; }
        }

        private bool _skipSplash;
        public bool skipSplash
        {
            get { return _skipSplash; }
            set { _skipSplash = value; }
        }

        public void loadDefaultSettings()
        {
            bitRate = 256;
            mainFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            addComment = true;
            addInbox = true;
            autoTagInfo = true;
            autoPasteURL = true;
            addLibrary = false;
            ffmpegOutput = "Pipe";
            autoClosePlugin = true;
            ffmpegPath = Environment.CurrentDirectory + @"\Plugins\ffmpeg.exe";
            rg3Path = Environment.CurrentDirectory + @"\Plugins\rg3-youtube-dl.exe";
            extractAudio = false;
            hideTagMessage = false;
            addCTagPlugInfo = true;
            addCTagDateTime = true;
            addCTagSource = true;
            addCTagCustomText = false;
            addCTagCustomTextVal = "";
            testFeature = false;
            preventDelTempFiles = false;
            overwriteMode = "warn";
            loadedVersion = SETTINGVERSION;
            termsAccepted = false;
            clipboardMessageShown = false;
            rg3Args = " --no-check-certificate --no-call-home";
            ontop = false;
            multipleinstances = false;
            skipSplash = false;
        }

        public string computeRG3Arguments(string url)
        {
            string sm = "\"";
            string builder = sm + url + sm + rg3Args;
            return builder;
        }

        public void saveSettings(serialConfig ObjectPass, Boolean skipSuccessMessage = false)
        {
            try
            {
                XmlSerializer settingWriter = new XmlSerializer(typeof(serialConfig));
                StreamWriter fileWriter = new StreamWriter(configLoc);
                settingWriter.Serialize(fileWriter, ObjectPass);
                fileWriter.Close();

                if (!skipSuccessMessage)
                    MessageBox.Show("The settings file has been saved!", "Plugin Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception e)
            {

                MessageBox.Show("An error occured saving the settings file.\n" + e, "Plugin Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }


}   
