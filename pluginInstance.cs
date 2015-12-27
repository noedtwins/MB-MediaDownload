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
            if (pluginInstance.config.outsideMB)
            {
                pluginInstance.config.outsideMB = false; //patch-er-uper job, fix this TODO
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

                loadedSaveFile = null;
                loadedURLCatch = null;
                loadedSplashScreen = null;
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
