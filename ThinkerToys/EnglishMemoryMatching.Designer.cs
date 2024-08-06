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
            private Label msglbl;
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
                components = new System.ComponentModel.Container();
                lblStatus = new Label();
                lblTimeLeft = new Label();
                lblCoins = new Label();
                btnRestart = new Button();
                GameTimer = new Timer(components);
                msglbl = new Label();
                btnHome = new Button();
                SuspendLayout();
                // 
                // lblStatus
                // 
                lblStatus.AutoSize = true;
                lblStatus.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
                lblStatus.Location = new Point(529, 165);
                lblStatus.Margin = new Padding(4, 0, 4, 0);
                lblStatus.Name = "lblStatus";
                lblStatus.Size = new Size(255, 29);
                lblStatus.TabIndex = 0;
                lblStatus.Text = "Mismatched: 0 times.";
                // 
                // lblTimeLeft
                // 
                lblTimeLeft.AutoSize = true;
                lblTimeLeft.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
                lblTimeLeft.Location = new Point(580, 220);
                lblTimeLeft.Margin = new Padding(4, 0, 4, 0);
                lblTimeLeft.Name = "lblTimeLeft";
                lblTimeLeft.Size = new Size(160, 29);
                lblTimeLeft.TabIndex = 1;
                lblTimeLeft.Text = "Time Left: 30";
                lblTimeLeft.Click += lblTimeLeft_Click;
                // 
                // lblCoins
                // 
                lblCoins.AutoSize = true;
                lblCoins.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
                lblCoins.Location = new Point(611, 111);
                lblCoins.Margin = new Padding(4, 0, 4, 0);
                lblCoins.Name = "lblCoins";
                lblCoins.Size = new Size(107, 29);
                lblCoins.TabIndex = 2;
                lblCoins.Text = "Coins: 0";
                // 
                // btnRestart
                // 
                btnRestart.BackColor = Color.LightBlue;
                btnRestart.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
                btnRestart.Location = new Point(590, 299);
                btnRestart.Margin = new Padding(4, 5, 4, 5);
                btnRestart.Name = "btnRestart";
                btnRestart.Size = new Size(150, 62);
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
                // msglbl
                // 
                msglbl.AutoSize = true;
                msglbl.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
                msglbl.Location = new Point(553, 392);
                msglbl.Name = "msglbl";
                msglbl.Size = new Size(213, 30);
                msglbl.TabIndex = 4;
                msglbl.Text = "Have a Fun Game !!";
                // 
                // btnHome
                // 
                btnHome.BackColor = Color.LightBlue;
                btnHome.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
                btnHome.Location = new Point(628, 29);
                btnHome.Margin = new Padding(4, 5, 4, 5);
                btnHome.Name = "btnHome";
                btnHome.Size = new Size(90, 40);
                btnHome.TabIndex = 5;
                btnHome.Text = "Home";
                btnHome.UseVisualStyleBackColor = false;
                btnHome.Click += btnHome_Click;
                // 
                // Form1
                // 
                AutoScaleDimensions = new SizeF(10F, 25F);
                AutoScaleMode = AutoScaleMode.Font;
                BackColor = Color.WhiteSmoke;
                ClientSize = new Size(778, 694);
                Controls.Add(btnHome);
                Controls.Add(msglbl);
                Controls.Add(btnRestart);
                Controls.Add(lblCoins);
                Controls.Add(lblTimeLeft);
                Controls.Add(lblStatus);
                Margin = new Padding(4, 5, 4, 5);
                Name = "Form1";
                Text = "English Matching Game";
                Load += Form1_Load;
                ResumeLayout(false);
                PerformLayout();
            }
        }

}