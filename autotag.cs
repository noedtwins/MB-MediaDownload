using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace mediaDownloader
{
    static class autotag
    {
        public struct autoTagInfo
        {
            public String attemptTitle;
            public String attemptArtist;
        }

        public static string removeSpecialCharactersFromFileName(String FileName)
        {
            string toreturn = "ERROR";
            toreturn = Regex.Replace(FileName, @"[^\w\d\s]*", "");

            return toreturn;
        }

        public static autoTagInfo performAutoTag(String videoTitle)
        {
            autoTagInfo Holder = new autoTagInfo(); //Hold the values that this function will eventually return.

            //Basic Version: "Artist - Title"
            Regex tagMatchString = new Regex(@"(?<artistTag>[^-]*)-(?<titleTag>.*)"); //This is the basic match
            Match m = tagMatchString.Match(videoTitle);
            Holder.attemptTitle = m.Groups["titleTag"].Value; //Set the applicable values
            Holder.attemptArtist = m.Groups["artistTag"].Value;

            if (Holder.attemptTitle == "" || Holder.attemptArtist == "") //If the basic version returns no match..
            {
                //Secondary version auto-tag (if no tag was found) - TODO: Improve this function
                if (pluginInstance.config.advanceAutoTag) //If setting allows this version to run
                {
                    string format;

                    ////////////////
                    //Multiple Whitespace (Requires No Special Characters - use format)
                    ///////////////
                    format = Regex.Replace(videoTitle, @"[^\w\d\s]*", "");
                    Regex matchMultipleWhitespace = new Regex(@"((?<titleTag>(.)+[^(\s\s)+]))(\s\s)+(?<artistTag>(.)+)");
                    Match mutliWhistespace = matchMultipleWhitespace.Match(format);
                    Holder.attemptTitle = mutliWhistespace.Groups["titleTag"].Value;
                    Holder.attemptArtist = mutliWhistespace.Groups["artistTag"].Value;

                    //If no match again check for:


                    ////////////////
                    //Quotes, Brackets (Requires Special Characters - use Label)
                    ///////////////
                    if (Holder.attemptTitle == "" || Holder.attemptArtist == "")
                    {

                        format = videoTitle;

                        Regex matchSingleQuoteTitle = new Regex(@"(')(?<titleTag>(.+))(')");
                        Match quoteMatchTitle = matchSingleQuoteTitle.Match(format);
                        Holder.attemptTitle = quoteMatchTitle.Groups["titleTag"].Value;
                        Regex matchSingleQuoteArtist = new Regex(@"(?:^|')([^']*)(?:$|')");
                        Match quoteMatchArtist = matchSingleQuoteArtist.Match(format);
                        Holder.attemptArtist = quoteMatchArtist.Value;
                        Holder.attemptArtist = Holder.attemptArtist.Replace("'", "");
                    }

                    //If no match again check for:


                    ////////////////
                    //Double Quotes
                    ///////////////
                    if (Holder.attemptTitle == "" || Holder.attemptArtist == "")
                    {
                        format = videoTitle;

                        string sm = "\""; //Escape the speech mark
                        Regex matchDoubleQuoteTitle = new Regex(@"(" + sm + ")(?<titleTag>(.+))(" + sm + ")");
                        Match doubleQuoteMatch = matchDoubleQuoteTitle.Match(format);
                        Holder.attemptTitle = doubleQuoteMatch.Groups["titleTag"].Value;

                        Regex matchDoubleQuoteArtist = new Regex(@"(?:^|" + sm + ")([^" + sm + "]*)(?:$|" + sm + ")");
                        Match doubleQuoteMatchArtist = matchDoubleQuoteArtist.Match(format);
                        Holder.attemptArtist = doubleQuoteMatchArtist.Value;
                        Holder.attemptArtist = Holder.attemptArtist.Replace(sm, "");
                    }


                    //If no match again check for:


                    ////////////////
                    //Brackets
                    ///////////////
                    if (Holder.attemptTitle == "" || Holder.attemptArtist == "")
                    {
                       
                        format = videoTitle;
                        Regex matchBracketTitle = new Regex(@"(?:^|()([^(]*)(?:$|))");
                        Match bracketMatchTitle = matchBracketTitle.Match(format);
                        Holder.attemptTitle = bracketMatchTitle.Value;
                        Holder.attemptTitle = Holder.attemptTitle.Replace("(", "");
                        Holder.attemptTitle = Holder.attemptTitle.Replace(")", "");

                        Regex matchBracketArtist = new Regex(@"(()(?<artistTag>(.+))())");
                        Match bracketMatchArtist = matchBracketArtist.Match(format);
                        Holder.attemptArtist = bracketMatchArtist.Groups["artistTag"].Value;

                    }

                    //If we don't meet a match with any of those, then just put the video title as the autotag.
                    if (Holder.attemptTitle == "" || Holder.attemptArtist == "")
                    {
                        Holder.attemptTitle = Regex.Replace(videoTitle, @"[^\w\d\s]*", "");
                        Holder.attemptArtist = "";
                    }

                }

            }

            //Remove any extra whitespace characters at the end 
            Holder.attemptTitle = Holder.attemptTitle.Trim();
            Holder.attemptArtist = Holder.attemptArtist.Trim();

            return Holder;

        }

    }
}
