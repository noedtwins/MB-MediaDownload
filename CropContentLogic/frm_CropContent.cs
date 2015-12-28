using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace mediaDownloader.CropContentLogic
{
    public partial class frm_CropContent : Form
    {
        public frm_CropContent()
        {
            InitializeComponent();
            lbl_Title.Parent = pic_Top;
            pic_ICO.Parent = pic_Top;
        }

        public void resumeLoad()
        {
            if (pluginInstance.details.cropSelected)
                rangeBar.SelectRange(changeTimeSeconds(pluginInstance.details.startTime), changeTimeSeconds(pluginInstance.details.endTime));
            else
                setControls(Convert.ToInt32(rangeBar.TotalMaximum));
        }

        public void getTimeStarter()
        { tmr_Wait.Enabled = true; }

        private void getTimeFromVideo()
        {
            int totalSeconds = YoutubeExtractor.DownloadUrlResolver.getVideoDuration(pluginInstance.details.url);
            
            if (totalSeconds == -1)
            {
                MessageBox.Show("An error occured retrieving duration.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Visible = false;
            }
            else
            {
                setControls(totalSeconds);
                grp_Overlay.Visible = false;
            }

        }

        private void setControls(int maxTime)
        {
            rangeBar.SetRangeLimit(0, Convert.ToDouble(maxTime));
            rangeBar.SelectRange(0, maxTime);
            txt_End.Text = changeSecondsToFormatString(maxTime);
            lbl_TimeEnd.Text = changeSecondsToFormatString(maxTime);

        }

        public void testControls()
        {
            //Test Code with dummy data
            lbl_TimeEnd.Text = "00:05:00";
            txt_End.Text = "00:05:00";
            setControls(changeTimeSeconds(txt_End.Text));
        }


        private int changeTimeSeconds(string correctlyFormatedText)
        {
            Regex matchPattern = new Regex(@"(?<hours>\d\d):(?<mins>\d\d):(?<seconds>\d\d)");
            Match rgMatch = matchPattern.Match(correctlyFormatedText);

            string hours = rgMatch.Groups["hours"].Value;
            string mins = rgMatch.Groups["mins"].Value;
            string seconds = rgMatch.Groups["seconds"].Value;

            int totalseconds;
            totalseconds = ((Convert.ToInt32(hours) * 60 * 60) + (Convert.ToInt32(mins) * 60) + (Convert.ToInt32(seconds)));


            return totalseconds;

        }

        private string changeSecondsToFormatString(int seconds)
        {
            TimeSpan t = TimeSpan.FromSeconds(seconds);
            string builder = t.ToString(@"hh\:mm\:ss");
            return builder;
        }


        private void OnRangeChanged(object sender, System.EventArgs e)
        {
            txt_Start.Text = changeSecondsToFormatString(Convert.ToInt32(rangeBar.RangeMinimum.ToString()));
            txt_End.Text = changeSecondsToFormatString(Convert.ToInt32(rangeBar.RangeMaximum.ToString()));
        }

        private void OnRangeChanging(object sender, System.EventArgs e)
        {
            txt_Start.Text = changeSecondsToFormatString(Convert.ToInt32(rangeBar.RangeMinimum.ToString()));
            txt_End.Text = changeSecondsToFormatString(Convert.ToInt32(rangeBar.RangeMaximum.ToString()));
        }



        private void frm_CropContent_Load(object sender, EventArgs e)
        {

            rangeBar.SetRangeLimit(0, 500);
            rangeBar.SelectRange(0, 200);
        }

        private void but_NextStage_Click(object sender, EventArgs e)
        {
            if (txt_End.Text == txt_Start.Text)
            {
                //The bar itself doesn't let it go below, so we only need to check if its equal
                MessageBox.Show("Invalid time range specified. Please enter a valid time range", "Plugin Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                pluginInstance.details.cropSelected = true;
                pluginInstance.details.startTime = txt_Start.Text;
                pluginInstance.details.endTime = txt_End.Text;
                MessageBox.Show("The changes have been applied successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void but_Reset_Click(object sender, EventArgs e)
        {
            pluginInstance.details.cropSelected = false;
            txt_End.Text = changeSecondsToFormatString(rangeBar.TotalMaximum);
            txt_Start.Text = "00:00:00";
            rangeBar.SelectRange(0, rangeBar.TotalMaximum);
        }

        private void but_PreviousStage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmr_Wait_Tick(object sender, EventArgs e)
        {
            getTimeFromVideo();
            pluginInstance.details.cropSelected = false;
            txt_End.Text = changeSecondsToFormatString(rangeBar.TotalMaximum);
            txt_Start.Text = "00:00:00";
            tmr_Wait.Enabled = false;
        }

        private void frm_CropContent_FormClosing(object sender, FormClosingEventArgs e)
        {
            pluginInstance.returnToSaveFile();

        }
    }
}
