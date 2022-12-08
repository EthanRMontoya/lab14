using System.DirectoryServices;
using System.Diagnostics;
using System.Security.Policy;

namespace lab14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        DateTime started;
        private void progressBar1_Click(object sender, EventArgs e)
        {
        }

        private void StartTiming_Click(object sender, EventArgs e)
        {
            StartingInfo.Visible = false;
            Counting.Visible = true;
            started = DateTime.Now;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Counting.Visible = false;
            var elapsedTime = DateTime.Now - started;
            var delta = TimeSpan.FromSeconds((double)numTimer.Value) - elapsedTime;
            MessageBox.Show($"your time is stopped at {elapsedTime} and delta is {delta}");
            StartingInfo.Visible = true;

            if(Math.Abs(delta.Seconds) < 1)
            {
                pWinner.Visible = true;
                string target = "https://www.youtube.com/watch?v=saCaZ3KvYgY";
               
                try
                {
                    Process.Start(new ProcessStartInfo { FileName = target, UseShellExecute = true });
                }

                catch (System.ComponentModel.Win32Exception noBrowser)
                {
                    MessageBox.Show("man something wrong happened");
                }
            }
            else
            {
                string targetL = "https://www.youtube.com/watch?v=-ZGlaAxB7nI";
                MessageBox.Show("you lose bud");
                StartingInfo.Visible = true;
                try
                {
                    Process.Start(new ProcessStartInfo { FileName = targetL, UseShellExecute = true });
                }

                catch (System.ComponentModel.Win32Exception noBrowser)
                {
                    MessageBox.Show("man something wrong happened");
                }
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pWinner.Visible = false;
            StartingInfo.Visible = true;
        }
    }
}