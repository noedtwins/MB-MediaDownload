﻿using System;
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
        public readonly int SETTINGVERSION = 5;

        public serialConfig()
        {

        }

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

        private bool _useTempFolder;
        [XmlAttribute]
        public bool useTempFolder
        {
            get { return _useTempFolder; }
            set { _useTempFolder = value; }
        }

        private bool _delTempFiles;
        [XmlAttribute]
        public bool preventDelTempFiles
        {
            get { return _delTempFiles; }
            set { _delTempFiles = value; }
        }

        private string _tempFolder;
        [XmlAttribute]
        public string tempFolder
        {
            get { return _tempFolder; }
            set { _tempFolder = value; }
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

        private bool _displayConsole;
        [XmlAttribute]
        public bool displayConsole
        {
            get { return _displayConsole; }
            set { _displayConsole = value; }
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

        private bool _sameValBitRateAsVideo;
        [XmlAttribute]
        public bool sameValBitRateAsVideo
        {
            get { return _sameValBitRateAsVideo; }
            set { _sameValBitRateAsVideo = value; }
        }

        private bool _m4aMake;
        [XmlAttribute]
        public bool m4aMake
        {
            get { return _m4aMake; }
            set { _m4aMake = value; }
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

        private bool _smoothing;
        [XmlAttribute]
        public bool smoothing
        {
            get { return _smoothing; }
            set { _smoothing = value; }
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

        private string _downloadLibraryType;
        [XmlAttribute]
        public string downloadLibraryType
        {
            get { return _downloadLibraryType; }
            set { _downloadLibraryType = value; }
        }

        private string _manualDecipherOperataion;
        [XmlAttribute]
        public string manualDecipherOperataion
        {
            get { return _manualDecipherOperataion; }
            set { _manualDecipherOperataion = value; }
        }

        private bool _useUnModifiedYTVersion;
        [XmlAttribute]
        public bool useUnModifiedYTVersion
        {
            get { return _useUnModifiedYTVersion; }
            set { _useUnModifiedYTVersion = value; }
        }

        private bool _useMBLegacy;
        [XmlAttribute]
        public bool useMBLegacy
        {
            get { return _useMBLegacy; }
            set { _useMBLegacy = value; }
        }

        private bool _pipeFFMPEG;
        [XmlAttribute]
        public bool pipeFFMPEG
        {
            get { return _pipeFFMPEG; }
            set { _pipeFFMPEG = value; }
        }

        private int _retryDecipher;
        [XmlAttribute]
        public int retryDecipher
        {
            get { return _retryDecipher; }
            set { _retryDecipher = value;  }
        }

        private bool _useFallbackdecipher;
        [XmlAttribute]
        public bool useFallbackdecipher
        {
            get { return _useFallbackdecipher; }
            set { _useFallbackdecipher = value; }
        }

        private bool _fallbackRG3;
        [XmlAttribute]
        public bool fallbackRG3
        {
            get { return _fallbackRG3; }
            set { _fallbackRG3 = value; }
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

        public void loadDefaultSettings()
        {
            bitRate = 256;
            tempFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MusicBee";
            mainFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            addComment = true;
            addInbox = true;
            autoTagInfo = true;
            autoPasteURL = true;
            addLibrary = false;
            displayConsole = false;
            autoClosePlugin = false;
            ffmpegPath = Environment.CurrentDirectory + @"\Plugins\ffmpeg.exe";
            rg3Path = Environment.CurrentDirectory + @"\Plugins\rg3-youtube-dl.exe";
            extractAudio = false;
            sameValBitRateAsVideo = false;
            hideTagMessage = false;
            m4aMake = true;
            addCTagPlugInfo = true;
            addCTagDateTime = true;
            addCTagSource = true;
            addCTagCustomText = false;
            addCTagCustomTextVal = "";
            useTempFolder = false;
            testFeature = false;
            preventDelTempFiles = false;
            pipeFFMPEG = false;
            overwriteMode = "warn";
            smoothing = true;
            loadedVersion = SETTINGVERSION;
            termsAccepted = false;
            clipboardMessageShown = false;
            useFallbackdecipher = true; //NEED TO IMPLEMENT!
            retryDecipher = 3;
            fallbackRG3 = true;
            rg3Args = " --get-url" + " --no-check-certificate --no-call-home";
            downloadLibraryType = "YouTubeExtractor";
            manualDecipherOperataion = "";
            useUnModifiedYTVersion = false;
            useMBLegacy = false;
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
