using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mediaDownloader
{
    public class ProgressEventArgs : EventArgs
        {


            public ProgressEventArgs(double progressPercentage, int copiedBytes, long contentLength, DateTime startTime)
            {
                this.ProgressPercentage = progressPercentage;
                this.copiedBytes = copiedBytes;
                this.contentLength = contentLength;
                this.timeStart = startTime;
                this.transferRate = valOfTransferRate();
                this.etaTime = calculateETA();

            }

            public void stopDownload()
            {
                Cancel = true;
            }


            static readonly string[] SizeSuffixes = { " bytes", " KB", " MB", " GB", " TB", " PB", " EB", " ZB", " YB" };
            static string SizeSuffix(Int64 value)
            {
                if (value < 0) { return "-" + SizeSuffix(-value); }
                if (value == 0) { return "0.0 bytes"; }

                int mag = (int)Math.Log(value, 1024);
                decimal adjustedSize = (decimal)value / (1L << (mag * 10));

                return string.Format("{0:n1} {1}", adjustedSize, SizeSuffixes[mag]);
            }

            public string valOfTransferRate()
            {
                double transferRate = calculateTransferRate();

                if (transferRate == 0)
                {
                    return "Calculating...";
                }
                else
                {
                    string finalString = SizeSuffix(Convert.ToInt64(transferRate)) + "/s";
                    return finalString;
                }

            }

            public string valOfEta()
            {
                int eta = calculateETA();
                if (eta == 0)
                {
                    return "Calculating...";
                }
                else
                {
                    return formatTime(eta);

                }
            }

            public string formatTime(int seconds)
            {
                int mins;
                int remainseconds;
                string builder = "Calculating...";

                mins = seconds / 60;
                remainseconds = seconds % 60;

                if (mins == 0)
                {
                    builder = remainseconds + " seconds";
                }
                else if (mins == 1)
                {
                    builder = mins + " minute, " + remainseconds + " seconds";
                }
                else
                {
                    builder = mins + " minutes, " + remainseconds + " seconds";
                }


                return builder;
            }

            public string formated_Recieved()
            {
                return SizeSuffix(Convert.ToInt64(copiedBytes));
            }

            public string formated_TotalGet()
            {
                return SizeSuffix(Convert.ToInt64(contentLength));
            }

            private double calculateTransferRate()
            {

                DateTime currentTime = DateTime.Now;

                double inSeconds = (currentTime - timeStart).TotalSeconds;

                if (copiedBytes == 0 || inSeconds == 0)
                { return 0; }
                else
                {
                    double transferRate = (this.copiedBytes / inSeconds);
                    return transferRate;
                }
            }


            private int calculateETA()
            {
                double tRate = calculateTransferRate();

                if (contentLength == 0 || tRate == 0)
                {
                    return 0;
                }
                else
                {
                    int etaTime = Convert.ToInt32((this.contentLength - this.copiedBytes) / tRate);
                    return etaTime;
                }
            }




            /// <summary>
            /// Gets or sets a token whether the operation that reports the progress should be canceled.
            /// </summary>
            public bool Cancel { get; set; }

            /// <summary>
            /// Gets the progress percentage in a range from 0.0 to 100.0.
            /// </summary>
            public double ProgressPercentage { get; private set; }
            public int copiedBytes { get; private set; }
            public long contentLength { get; private set; }
            public int etaTime { get; private set; }
            public string transferRate { get; private set; }
            public DateTime timeStart { get; private set; }
        }
    }