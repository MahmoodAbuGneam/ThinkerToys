namespace ThinkerToys
{
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

        partial class EnglishMemoryMatching
        {
            private IContainer components = null;
            private Label lblStatus;
            private Label lblTimeLeft;
            private Label lblCoins;
            private Button btnRestart;
            private Timer GameTimer;
            private Button btnHome;

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

        private void InitializeComponent()
        {
            components = new Container();
            lblStatus = new Label();
            lblTimeLeft = new Label();
            lblCoins = new Label();
            btnRestart = new Button();
            GameTimer = new Timer(components);
            btnHome = new Button();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblStatus.Location = new Point(591, 108);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(169, 19);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Mismatched: 0 times.";
            // 
            // lblTimeLeft
            // 
            lblTimeLeft.AutoSize = true;
            lblTimeLeft.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblTimeLeft.Location = new Point(629, 145);
            lblTimeLeft.Name = "lblTimeLeft";
            lblTimeLeft.Size = new Size(107, 19);
            lblTimeLeft.TabIndex = 1;
            lblTimeLeft.Text = "Time Left: 30";
            lblTimeLeft.Click += lblTimeLeft_Click;
            // 
            // lblCoins
            // 
            lblCoins.AutoSize = true;
            lblCoins.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblCoins.Location = new Point(645, 72);
            lblCoins.Name = "lblCoins";
            lblCoins.Size = new Size(73, 19);
            lblCoins.TabIndex = 2;
            lblCoins.Text = "Coins: 0";
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.LightBlue;
            btnRestart.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnRestart.Location = new Point(631, 182);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(105, 37);
            btnRestart.TabIndex = 3;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += RestartGameEvent;
            // 
            // GameTimer
            // 
            GameTimer.Interval = 1000;
            GameTimer.Tick += TimerEvent;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.LightBlue;
            btnHome.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnHome.Location = new Point(649, 25);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(63, 24);
            btnHome.TabIndex = 5;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // EnglishMemoryMatching
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(762, 701);
            Controls.Add(btnHome);
            Controls.Add(btnRestart);
            Controls.Add(lblCoins);
            Controls.Add(lblTimeLeft);
            Controls.Add(lblStatus);
            Name = "EnglishMemoryMatching";
            Text = "English Matching Game";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }

}