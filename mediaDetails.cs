using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using YoutubeExtractor;

namespace mediaDownloader
{
    public enum moveType { inbox, library, none }

    public struct mediaDetails
    {
        public string unnomralisedURL;
        public string url;
        public string mediaID;
        public string title;
        public int formatCode;
        public int audioBitRate;
        public AudioType audioFormat;
        public int convertToBitRate;
        public string selectedResolution;
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

        public IEnumerable<VideoInfo> results;
        public VideoInfo selectedResult;
    }

}
