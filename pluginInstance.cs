﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace mediaDownloader
{
    static class pluginInstance
    {

        /* Holders for Instanced forms */
        private static MusicBeePlugin.Plugin mbApi;
        private static frm_StartInstance loadedSplashScreen;
        private static frm_GetURL loadedURLCatch;
        private static frm_SaveFile loadedSaveFile;
        private static frm_Settings loadedSettingsForm;
        private static CropContentLogic.frm_CropContent loadedCropContent;
        public static mediaDetails details; //TODO: Add Encapsulation
        public static serialConfig config;
        private static Boolean alreadyCalledApplication = false;
        private static string configuationPath;
        private static string configuationFileName = @"\mb_MediaDownloader_Settings.xml";
        public static Boolean forceDefaultSettings = false;
        public static Boolean instanceRunning = false;
        public static Boolean flagLoadFromMenu = false;

        public static void runoutsideMB()
        {
            if (!alreadyCalledApplication)
            {
                alreadyCalledApplication = true;
                Application.Run(loadedSplashScreen);
            }
            else
                gotoSplashScreen(false);       

        }

        public static void reloadPlugin()
        {
            clearInstance();
            createNewInstance();
        }

        public static void linkMBApi(MusicBeePlugin.Plugin linkAPI)
        {
            mbApi = linkAPI;
            configuationPath = mbApi.getLocationOfSettingsFileFromMBApi();
        }

        public static void createNewInstance() //Create new Plugin Instance
        {
            if (Program.isStandaloneMode)
            {
                configuationPath = Environment.CurrentDirectory;
            }
            else
            {
                configuationPath = mbApi.getLocationOfSettingsFileFromMBApi();
            }

            loadSettings();
            clearInstance();
            loadedSplashScreen = new frm_StartInstance();
            instanceRunning = true;
            if (Program.isStandaloneMode)
            {
                runoutsideMB();
            }
            else
            {
                if (config.skipSplash && config.termsAccepted)
                {
                    if (flagLoadFromMenu)
                    {
                        gotoCatchURL();
                        flagLoadFromMenu = false;
                        return;
                    }
                }
                flagLoadFromMenu = false;
                gotoSplashScreen(false);
            }
        }

        public static void loadSettings()
        {
            String configLocation = configuationPath + configuationFileName;

            if (!File.Exists(configLocation) || forceDefaultSettings)
            {
                config = new serialConfig(configLocation);
                config.loadDefaultSettings();
                MessageBox.Show("Media Downloader: No Settings File Found. \nDefault Settings will be applied", "Plugin Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                config.saveSettings(config);
            }
            else
            {
                try
                {
                    XmlSerializer settingReader = new XmlSerializer(typeof(serialConfig));
                    StreamReader fileReader = new StreamReader(configLocation);
                    config = (serialConfig)settingReader.Deserialize(fileReader);
                    config.configLoc = configLocation;
                    fileReader.Close();

                }
                catch
                {
                    DialogResult failedRead = MessageBox.Show("Media Downloader Error\n There was aproblem loading the settings file, It may be corrupt.\n Create a new default settings file?", "Plugin Error",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (failedRead == DialogResult.Yes)
                    {
                        config = new serialConfig(configLocation);
                        config.loadDefaultSettings();
                        config.configLoc = configLocation;
                        config.saveSettings(config);
                    }
                    else
                    {
                        MessageBox.Show("Media Downloader: Pugin unable to start due to a configuation error\nSource Reference Error: config.cs +93", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        closeApplication();
                    }
                }
            }

            checkSettingVersion();
        }

        private static void checkSettingVersion()
        {
            if (config.loadedVersion < config.SETTINGVERSION)
            {
                MessageBox.Show("Media Downloader: The current plugin settings file was written for a earlier verison\nThe setting file will be restored to defaults", "Information", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                forceDefaultSettings = true;
                loadSettings();
                forceDefaultSettings = false;
            }
        }

        public static void closeApplication()
        {
            if (Program.isStandaloneMode)
                Application.Exit();
            else
                clearInstance();
        }

        public static void clearInstance()
        {

            if (loadedSaveFile != null)
            {
                loadedSaveFile.Dispose();
                loadedSaveFile = null;
            }

            if (loadedURLCatch != null)
            {
                loadedURLCatch.Dispose();
                loadedURLCatch = null;
            }

            if (loadedSettingsForm != null)
            {
                loadedSettingsForm.Dispose();
                loadedSettingsForm = null;
            }

            if (loadedCropContent != null)
            {
                loadedCropContent.Dispose();
                loadedCropContent = null; 
            }
            instanceRunning = false;


            //try { loadedSplashScreen.Close(); }
            //catch { }

        }

        public static void hideAllForms()
        {
            try
            {
                loadedSplashScreen.Hide();
                loadedSaveFile.Hide();
                loadedURLCatch.Hide();
                loadedSettingsForm.Hide();
                loadedCropContent.Hide();
            }
            catch
            {
                Debug.Print("001 - Null Form?");
            }
        }

        public static void gotoSplashScreen(Boolean resetAll)
        {
            if (resetAll)
            {
                createNewInstance();
                return;
            }
            hideAllForms();
            
            loadedSplashScreen.updateTermsBox();
            loadedSplashScreen.Show();
        }

        public static void gotoCropContent()
        {
            if (loadedCropContent == null || loadedCropContent.IsDisposed)
            {
                loadedCropContent = new CropContentLogic.frm_CropContent();
                loadedCropContent.getTimeStarter();
            }

            hideAllForms();
            loadedCropContent.resumeLoad();
            loadedCropContent.Show();
        }

        public static void gotoCatchURL()
        {
            if (loadedURLCatch == null || loadedURLCatch.IsDisposed)
                loadedURLCatch = new frm_GetURL();

            hideAllForms();
            loadedURLCatch.Show();
        }

        public static void showSettingsForm()
        {
            if (loadedSettingsForm == null || loadedSettingsForm.IsDisposed)
                loadedSettingsForm = new frm_Settings();

            hideAllForms();
            loadedSettingsForm.Show();
        }

        public static void gotoSaveFile()
        {
            if (loadedSaveFile == null)
            {
                loadedSaveFile = new frm_SaveFile();
            }

            hideAllForms();
            loadedSaveFile.firstStart();
            loadedSaveFile.Show();

        }

        public static void returnToSaveFile()
        {
            //if returning from crop
            hideAllForms();
            loadedSaveFile.updateCropButton();
            loadedSaveFile.Show();
        }

        public static void startProcess()
        {
            hideAllForms();
            frm_ProcessMedia startTask = new frm_ProcessMedia();
            startTask.Show();
            startTask.runStages();
                
        }

        public static MusicBeePlugin.Plugin getAPI()
        {
            return mbApi;
        }

    }
}
