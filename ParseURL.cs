using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace mediaDownloader
{
    static class ParseURL
    {
        public static bool TryNormalizeYoutubeUrl(string url, out string normalizedUrl)
        {
            url = url.Trim();

            url = url.Replace("youtu.be/", "youtube.com/watch?v=");
            url = url.Replace("www.youtube", "youtube");
            url = url.Replace("youtube.com/embed/", "youtube.com/watch?v=");

            if (url.Contains("/v/"))
            {
                url = "http://youtube.com" + new Uri(url).AbsolutePath.Replace("/v/", "/watch?v=");
            }

            url = url.Replace("/watch#", "/watch?");

            IDictionary<string, string> query = ParseQueryString(url);

            string v;

            if (!query.TryGetValue("v", out v))
            {
                normalizedUrl = null;
                return false;
            }

            normalizedUrl = "http://youtube.com/watch?v=" + v;

            return true;
        }

        public static IDictionary<string, string> ParseQueryString(string s)
        {
            // remove anything other than query string from url
            if (s.Contains("?"))
            {
                s = s.Substring(s.IndexOf('?') + 1);
            }

            var dictionary = new Dictionary<string, string>();

            foreach (string vp in Regex.Split(s, "&"))
            {
                string[] strings = Regex.Split(vp, "=");
                dictionary.Add(strings[0], strings.Length == 2 ? UrlDecode(strings[1]) : string.Empty);
            }

            return dictionary;
        }

        internal static bool CheckAnyValidURL(string text, out string URL)
        {
            Regex MatchURL = new Regex(@"^http(s)?://([\w-]+.)+[\w-]+(/[\w- ./?%&=])?$"); //This is the basic match

            if (MatchURL.IsMatch(text))
            {
                URL = text;
                return true;
            }
            else
            {
                URL = null;
                return false;                
            }

        }

        public static string UrlDecode(string url)
        {
            return Uri.UnescapeDataString(url);
        }
    }
}
