using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using YoutubeExtractor;

namespace mediaDownloader
{
    public struct mediaDetails
    {
        public string unnomralisedURL;
        public string url;
        public string mediaID;
        public string title;
        public int formatCode;
        public int audioBitRate;
        public AudioType audioFormat;
        public string selectedResolution;
        public Boolean cropSelected;
        public Image cachedThumb;

        public IEnumerable<VideoInfo> results;
        public VideoInfo selectedResult;
    }

}
