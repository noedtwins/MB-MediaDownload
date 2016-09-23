using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace MusicBeePlugin
{
    public partial class Plugin
    {
        private MusicBeeApiInterface mbApiInterface;
        private PluginInfo about = new PluginInfo();

        public PluginInfo Initialise(IntPtr apiInterfacePtr)
        {
            mbApiInterface = new MusicBeeApiInterface();
            mbApiInterface.Initialise(apiInterfacePtr);
            about.PluginInfoVersion = PluginInfoVersion;
            about.Name = "Media Downloader";
            about.Description = "Download and Convert Media Straight to MB.";
            about.Author = "Cyano";
            about.TargetApplication = "";   // current only applies to artwork, lyrics or instant messenger name that appears in the provider drop down selector or target Instant Messenger
            about.Type = PluginType.General;
            about.VersionMajor = 1;  // your plugin version
            about.VersionMinor = 7;
            about.Revision = 0;
            about.MinInterfaceVersion = MinInterfaceVersion;
            about.MinApiRevision = MinApiRevision;
            about.ReceiveNotifications = (ReceiveNotificationFlags.PlayerEvents | ReceiveNotificationFlags.TagEvents);
            about.ConfigurationPanelHeight = 0;   // height in pixels that musicbee should reserve in a panel for config settings. When set, a handle to an empty panel will be passed to the Configure function
            return about;
        }

        public MusicBeeApiInterface getInterface()
        {
            return mbApiInterface;
        }

        public string getLocationOfSettingsFileFromMBApi()
        {
            string path = mbApiInterface.Setting_GetPersistentStoragePath();
            return path;
        }


        private void createPluginMenu()
        {
            mbApiInterface.MB_AddMenuItem("mnuTools/Plugin: Media Downloader (Cyano)", "Plugin: Start Cyano's Media Download Plugin", menuClicked);      
        }

        private void menuClicked(object sender, EventArgs args)
        {
            mediaDownloader.Program.isStandaloneMode = false; //Running in MB Mode.

            if (mediaDownloader.pluginInstance.instanceRunning == true && !mediaDownloader.pluginInstance.config.multipleinstances)
            {
                DialogResult closeInstance = MessageBox.Show("Another instance of Media Downloader is already running.", "Plugin Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                mediaDownloader.pluginInstance.instanceRunning = true;
            }

            mediaDownloader.pluginInstance.flagLoadFromMenu = true;
            mediaDownloader.pluginInstance.createNewInstance();


        }


        public bool Configure(IntPtr panelHandle)
        {
            System.Windows.Forms.MessageBox.Show("Media Downloader: Please start the plugin to change the settings!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
           return false;
        }
       
        // called by MusicBee when the user clicks Apply or Save in the MusicBee Preferences screen.
        // its up to you to figure out whether anything has changed and needs updating
        public void SaveSettings()
        {
            // save any persistent settings in a sub-folder of this path
            string dataPath = mbApiInterface.Setting_GetPersistentStoragePath();
        }

        // MusicBee is closing the plugin (plugin is being disabled by user or MusicBee is shutting down)
        public void Close(PluginCloseReason reason)
        {
        }

        // uninstall this plugin - clean up any persisted files
        public void Uninstall()
        {
            System.Windows.Forms.MessageBox.Show("Media Downloader: The settings for this plugin will be lost!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mediaDownloader.pluginInstance.forceDefaultSettings = true;
            mediaDownloader.pluginInstance.loadSettings();

            System.Windows.Forms.MessageBox.Show("Media Downloader - Please delete the files out of your plugins folder!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        // receive event notifications from MusicBee
        // you need to set about.ReceiveNotificationFlags = PlayerEvents to receive all notifications, and not just the startup event
        public void ReceiveNotification(string sourceFileUrl, NotificationType type)
        {
            // perform some action depending on the notification type
            switch (type)
            {
                case NotificationType.PluginStartup:
                    {
                        createPluginMenu();
                        mediaDownloader.Program.isStandaloneMode = false;
                        mediaDownloader.pluginInstance.linkMBApi(this);
                    }
                        break;
            }
        }

        // return an array of lyric or artwork provider names this plugin supports
        // the providers will be iterated through one by one and passed to the RetrieveLyrics/ RetrieveArtwork function in order set by the user in the MusicBee Tags(2) preferences screen until a match is found
        public string[] GetProviders()
        {
            return null;
        }

        // return lyrics for the requested artist/title from the requested provider
        // only required if PluginType = LyricsRetrieval
        // return null if no lyrics are found
        public string RetrieveLyrics(string sourceFileUrl, string artist, string trackTitle, string album, bool synchronisedPreferred, string provider)
        {
            return null;
        }

        // return Base64 string representation of the artwork binary data from the requested provider
        // only required if PluginType = ArtworkRetrieval
        // return null if no artwork is found
        public string RetrieveArtwork(string sourceFileUrl, string albumArtist, string album, string provider)
        {
            //Return Convert.ToBase64String(artworkBinaryData)
            return null;
        }
   }
}