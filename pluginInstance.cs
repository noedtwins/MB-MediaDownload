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


        public static void runoutsideMB()
        {
            Application.Run(loadedSplashScreen);
        }

        public static void createNewInstance() //Create new Plugin Instance
        {
            clearInstance();
            loadedSplashScreen = new frm_StartInstance();
            if (config.outsideMB)
            {
                runoutsideMB();
            }
            else
            {
                gotoSplashScreen();
            }
        }

        public static void clearInstance()
        {
            loadedSaveFile = null;
            loadedURLCatch = null;
            loadedSplashScreen = null;

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

        public static void gotoSplashScreen()
        {
            hideAllForms();
            loadedSplashScreen.Show();
        }

        public static void gotoCatchURL()
        {
            if (loadedURLCatch == null)
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

    }
}
