using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mediaDownloader
{
    static class config
    {
        public static Boolean outsideMB = true;
        public static Boolean pasteFromClipboard = true;
        public static String mainFolderPath = @"C:\";
        public static int defaultBitRate = 192;
        public static Boolean addToMBInbox = true;
        public static Boolean addToMBLibrary = true;
        public static Boolean extractAudio = false;
        public static Boolean m4aMake = true;
        public static Boolean autoTagInfo = true;
        public static Boolean enableAdvancedTag = true;
      
        public static Boolean useSameValueBitRateOnConversion = false;
    }
}   
