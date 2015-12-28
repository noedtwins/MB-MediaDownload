using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mediaDownloader
{
    static class pluginInstance
    {

        /* Holders for Instanced forms */
        private static frm_StartInstance loadedSplashScreen;
        private static frm_GetURL loadedURLCatch;
        private static frm_SaveFile loadedSaveFile;
        private static frm_Settings loadedSettingsForm;
        public static mediaDetails details; //TODO: Add Encapsulation
        public static serialConfig config;


        public static void runoutsideMB()
        {
            Application.Run(loadedSplashScreen);
        }

        public static void createNewInstance() //Create new Plugin Instance
        {
            config = new serialConfig(null);
            config.loadDefaultSettings();

            clearInstance();
            loadedSplashScreen = new frm_StartInstance();
            if (!Program.isStandaloneMode)
            {
                pluginInstance.config.outsideMB = true; //patch-er-uper job, fix this TODO
                runoutsideMB();
            }
            else
            {
                gotoSplashScreen(false);
            }
        }

        public static void clearInstance()
        {

            try {
                loadedSaveFile.Close();
                loadedURLCatch.Close();
                loadedSplashScreen.Close();
                loadedSettingsForm.Close();

                loadedSaveFile = null;
                loadedURLCatch = null;
                loadedSplashScreen = null;
                loadedSettingsForm = null;
            }
            catch { }
        }

        public static void hideAllForms()
        {
            try
            {
                loadedSplashScreen.Hide();
                loadedSaveFile.Hide();
                loadedURLCatch.Hide();
                loadedSettingsForm.Hide();
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

            loadedSplashScreen.Show();
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
                loadedSaveFile.firstStart();
            }

            hideAllForms();
            loadedSaveFile.Show();
        }

        public static void startProcess()
        {
            hideAllForms();
            frm_ProcessMedia startTask = new frm_ProcessMedia();
            startTask.Show();
            startTask.runStages();
                
        }

    }
}
