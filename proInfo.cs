using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace mediaDownloader
{
    static class proInfo
    {
        
        public static string rgProcessLocation = "youtube-dl.exe"; //add get and set
        public static string ffmpegProcessLocation = "ffmpeg.exe"; //add get and set

        public enum ProcessType //rg or ffmpeg
        { rg, ffmpeg, other }


        public struct ProcessDetails
        {
            public Process program;
            public ProcessType type;
            public string fileName;
            public string args;

            public int procID;
            public bool created;
            public bool running;
        }

        /* To Move */
        public struct VideoDetails
        {
            public string URL;
            public string title;
            public string thumbnailLoc;
            
        }


        //RG3 Functions
        public static string rg_getTags() //Optional Tags
        {
            string optArgs = "";
            optArgs = optArgs + "--newline "; //new Line for each progress
            optArgs = optArgs + "--no-call-home "; //prevent call homes

            return optArgs;
        }

        //FFMPEG Functions
    }
}
