using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace mediaDownloader
{
    public enum moveType { inbox, library, none }

    public struct mediaDetails
    {
        public string url;
        public string title;
        public string formatCode;
        public int convertToBitRate;
        public Boolean cropSelected;
        public string startTime;
        public string endTime;
        public Boolean videoMode;

        public Image cachedThumb;
        public moveType moveTo;

        public String titleTag;
        public String artistTag;
        public String albumTag;

        public String fullTempPath;
        public String downloadPath;
        public String fileName;
        public String addMBMode;

    }

}
