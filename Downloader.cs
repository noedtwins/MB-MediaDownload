using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace mediaDownloader
{
    public class Downloader
    {
        public event EventHandler DownloadFinished;
        public event EventHandler DownloadStarted;

        private int? BytesToDownload;
        private string SavePath;
        private string downloadURL;

        private bool useSmoothing = true;
        private int smoothCounter = 0;

        public Downloader(string URL, string savePath, int? bytesToDownload = null)
        {
            this.SavePath = savePath;
            this.BytesToDownload = bytesToDownload;
            this.downloadURL = URL;
        }

        public event EventHandler<ProgressEventArgs> DownloadProgressChanged;

        public void Execute()
        {
            this.OnDownloadStarted(EventArgs.Empty);
            var request = (HttpWebRequest)WebRequest.Create(this.downloadURL);   


            if (this.BytesToDownload.HasValue)
                request.AddRange(0, this.BytesToDownload.Value - 1);

            DateTime startTime;

            using (WebResponse response = request.GetResponse())
            {
                using (Stream source = response.GetResponseStream())
                {
                    using (FileStream target = File.Open(this.SavePath, FileMode.Create, FileAccess.Write))
                    {
                        var buffer = new byte[1024];
                        bool cancel = false;
                        int bytes;
                        int copiedBytes = 0;

                        startTime = DateTime.Now;

                        while (!cancel && (bytes = source.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            target.Write(buffer, 0, bytes);

                            copiedBytes += bytes;
                            double percent = ((copiedBytes * 1.0 / response.ContentLength) * 100);

                            var eventArgs = new ProgressEventArgs(percent, copiedBytes, response.ContentLength, startTime);

                            if (this.DownloadProgressChanged != null)
                            {
                                if (useSmoothing == true)
                                {
                                    if (smoothCounter == 100)
                                    {
                                        this.DownloadProgressChanged(this, eventArgs);
                                        smoothCounter = 0;
                                    }
                                    else
                                        smoothCounter++;
                                }
                                else
                                    this.DownloadProgressChanged(this, eventArgs);

                                if (eventArgs.Cancel)
                                    cancel = true;
                            }
                        }
                    }
                }
            }

            this.OnDownloadFinished(EventArgs.Empty);
        }


        protected void OnDownloadFinished(EventArgs e)
        {
            if (this.DownloadFinished != null)
            {
                this.DownloadFinished(this, e);
            }
        }

        protected void OnDownloadStarted(EventArgs e)
        {
            if (this.DownloadStarted != null)
            {
                this.DownloadStarted(this, e);
            }
        }
    }
}