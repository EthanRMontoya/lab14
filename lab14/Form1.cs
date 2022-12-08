using System.DirectoryServices;

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
            }
            else
            {
                MessageBox.Show("you lose bud");
                StartingInfo.Visible = true;
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