namespace lab14
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartingInfo = new System.Windows.Forms.GroupBox();
            this.numTimer = new System.Windows.Forms.NumericUpDown();
            this.StartTimer = new System.Windows.Forms.Label();
            this.StartTiming = new System.Windows.Forms.Button();
            this.Counting = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.pWinner = new System.Windows.Forms.Panel();
            this.resultsW = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Button();
            this.winL = new System.Windows.Forms.Label();
            this.StartingInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimer)).BeginInit();
            this.Counting.SuspendLayout();
            this.pWinner.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartingInfo
            // 
            this.StartingInfo.Controls.Add(this.numTimer);
            this.StartingInfo.Controls.Add(this.StartTimer);
            this.StartingInfo.Controls.Add(this.StartTiming);
            this.StartingInfo.Location = new System.Drawing.Point(261, 47);
            this.StartingInfo.Name = "StartingInfo";
            this.StartingInfo.Size = new System.Drawing.Size(200, 100);
            this.StartingInfo.TabIndex = 0;
            this.StartingInfo.TabStop = false;
            this.StartingInfo.Text = "groupBox1";
            // 
            // numTimer
            // 
            this.numTimer.Location = new System.Drawing.Point(52, 35);
            this.numTimer.Name = "numTimer";
            this.numTimer.Size = new System.Drawing.Size(120, 23);
            this.numTimer.TabIndex = 2;
            // 
            // StartTimer
            // 
            this.StartTimer.AutoSize = true;
            this.StartTimer.Location = new System.Drawing.Point(52, 17);
            this.StartTimer.Name = "StartTimer";
            this.StartTimer.Size = new System.Drawing.Size(63, 15);
            this.StartTimer.TabIndex = 1;
            this.StartTimer.Text = "TimerTime";
            this.StartTimer.Click += new System.EventHandler(this.label2_Click);
            // 
            // StartTiming
            // 
            this.StartTiming.Location = new System.Drawing.Point(40, 64);
            this.StartTiming.Name = "StartTiming";
            this.StartTiming.Size = new System.Drawing.Size(132, 23);
            this.StartTiming.TabIndex = 0;
            this.StartTiming.Text = "Start Timing";
            this.StartTiming.UseVisualStyleBackColor = true;
            this.StartTiming.Click += new System.EventHandler(this.StartTiming_Click);
            // 
            // Counting
            // 
            this.Counting.Controls.Add(this.label1);
            this.Counting.Controls.Add(this.ProgressBar);
            this.Counting.Controls.Add(this.button2);
            this.Counting.Location = new System.Drawing.Point(145, 252);
            this.Counting.Name = "Counting";
            this.Counting.Size = new System.Drawing.Size(453, 100);
            this.Counting.TabIndex = 1;
            this.Counting.TabStop = false;
            this.Counting.Text = "groupBox2";
            this.Counting.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 2;
            // 
            // ProgressBar
            // 
            this.ProgressBar.AccessibleName = "v";
            this.ProgressBar.Location = new System.Drawing.Point(37, 22);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(401, 23);
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProgressBar.TabIndex = 1;
            this.ProgressBar.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pWinner
            // 
            this.pWinner.Controls.Add(this.resultsW);
            this.pWinner.Controls.Add(this.restart);
            this.pWinner.Controls.Add(this.winL);
            this.pWinner.Font = new System.Drawing.Font("GothicE", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.pWinner.Location = new System.Drawing.Point(182, 82);
            this.pWinner.Name = "pWinner";
            this.pWinner.Size = new System.Drawing.Size(382, 159);
            this.pWinner.TabIndex = 2;
            this.pWinner.Visible = false;
            // 
            // resultsW
            // 
            this.resultsW.AutoSize = true;
            this.resultsW.Location = new System.Drawing.Point(144, 12);
            this.resultsW.Name = "resultsW";
            this.resultsW.Size = new System.Drawing.Size(0, 36);
            this.resultsW.TabIndex = 2;
            this.resultsW.Visible = false;
            // 
            // restart
            // 
            this.restart.Location = new System.Drawing.Point(110, 116);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(159, 40);
            this.restart.TabIndex = 1;
            this.restart.Text = "restart";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.button1_Click);
            // 
            // winL
            // 
            this.winL.AutoSize = true;
            this.winL.Location = new System.Drawing.Point(119, 48);
            this.winL.Name = "winL";
            this.winL.Size = new System.Drawing.Size(161, 36);
            this.winL.TabIndex = 0;
            this.winL.Text = "YOU WIN";
            this.winL.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pWinner);
            this.Controls.Add(this.Counting);
            this.Controls.Add(this.StartingInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.StartingInfo.ResumeLayout(false);
            this.StartingInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimer)).EndInit();
            this.Counting.ResumeLayout(false);
            this.Counting.PerformLayout();
            this.pWinner.ResumeLayout(false);
            this.pWinner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox StartingInfo;
        private Label StartTimer;
        private Button StartTiming;
        private GroupBox Counting;
        private Label label1;
        private ProgressBar ProgressBar;
        private Button button2;
        private NumericUpDown numTimer;
        private Panel pWinner;
        private Label winL;
        private Button restart;
        private Label resultsW;
    }
}