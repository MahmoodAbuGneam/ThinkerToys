namespace ThinkerToys
{
    partial class BiggerSmallerEqualsGame
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelFirstNumber = new Label();
            labelSecondNumber = new Label();
            labelResult = new Label();
            buttonLess = new Button();
            buttonGreater = new Button();
            buttonEqual = new Button();
            buttonNewGame = new Button();
            labelScore = new Label();
            labelTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            buttonHome = new Button();
            SuspendLayout();
            // 
            // labelFirstNumber
            // 
            labelFirstNumber.BackColor = Color.Transparent;
            labelFirstNumber.Font = new Font("Microsoft Sans Serif", 20F);
            labelFirstNumber.Location = new Point(200, 98);
            labelFirstNumber.Margin = new Padding(4, 0, 4, 0);
            labelFirstNumber.Name = "labelFirstNumber";
            labelFirstNumber.Size = new Size(116, 46);
            labelFirstNumber.TabIndex = 0;
            labelFirstNumber.Text = "0";
            labelFirstNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSecondNumber
            // 
            labelSecondNumber.BackColor = Color.Transparent;
            labelSecondNumber.Font = new Font("Microsoft Sans Serif", 20F);
            labelSecondNumber.Location = new Point(408, 98);
            labelSecondNumber.Margin = new Padding(4, 0, 4, 0);
            labelSecondNumber.Name = "labelSecondNumber";
            labelSecondNumber.Size = new Size(116, 46);
            labelSecondNumber.TabIndex = 1;
            labelSecondNumber.Text = "0";
            labelSecondNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelResult
            // 
            labelResult.BackColor = Color.Transparent;
            labelResult.Font = new Font("Microsoft Sans Serif", 14F);
            labelResult.Location = new Point(284, 83);
            labelResult.Margin = new Padding(4, 0, 4, 0);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(164, 80);
            labelResult.TabIndex = 2;
            labelResult.Text = "Result";
            labelResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonLess
            // 
            buttonLess.Font = new Font("Microsoft Sans Serif", 14F);
            buttonLess.Location = new Point(196, 241);
            buttonLess.Margin = new Padding(4);
            buttonLess.Name = "buttonLess";
            buttonLess.Size = new Size(88, 58);
            buttonLess.TabIndex = 3;
            buttonLess.Text = "<";
            buttonLess.UseVisualStyleBackColor = true;
            buttonLess.Click += buttonLess_Click;
            // 
            // buttonGreater
            // 
            buttonGreater.Font = new Font("Microsoft Sans Serif", 14F);
            buttonGreater.Location = new Point(311, 241);
            buttonGreater.Margin = new Padding(4);
            buttonGreater.Name = "buttonGreater";
            buttonGreater.Size = new Size(88, 58);
            buttonGreater.TabIndex = 4;
            buttonGreater.Text = ">";
            buttonGreater.UseVisualStyleBackColor = true;
            buttonGreater.Click += buttonGreater_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.Font = new Font("Microsoft Sans Serif", 14F);
            buttonEqual.Location = new Point(437, 241);
            buttonEqual.Margin = new Padding(4);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(88, 58);
            buttonEqual.TabIndex = 5;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = true;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // buttonNewGame
            // 
            buttonNewGame.Font = new Font("Microsoft Sans Serif", 12F);
            buttonNewGame.Location = new Point(11, 309);
            buttonNewGame.Margin = new Padding(4);
            buttonNewGame.Name = "buttonNewGame";
            buttonNewGame.Size = new Size(133, 46);
            buttonNewGame.TabIndex = 6;
            buttonNewGame.Text = "New Game";
            buttonNewGame.UseVisualStyleBackColor = true;
            buttonNewGame.Click += buttonNewGame_Click;
            // 
            // labelScore
            // 
            labelScore.Font = new Font("Microsoft Sans Serif", 14F);
            labelScore.Location = new Point(178, 17);
            labelScore.Margin = new Padding(4, 0, 4, 0);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(116, 35);
            labelScore.TabIndex = 7;
            labelScore.Text = "Score: 0";
            labelScore.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTime
            // 
            labelTime.Font = new Font("Microsoft Sans Serif", 14F);
            labelTime.Location = new Point(374, 17);
            labelTime.Margin = new Padding(4, 0, 4, 0);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(116, 35);
            labelTime.TabIndex = 8;
            labelTime.Text = "Time: 30";
            labelTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // buttonHome
            // 
            buttonHome.AllowDrop = true;
            buttonHome.BackColor = Color.DarkOrange;
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            buttonHome.ForeColor = Color.Black;
            buttonHome.Location = new Point(605, 17);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(105, 35);
            buttonHome.TabIndex = 9;
            buttonHome.Text = "Home";
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += buttonTopRightHome_Click;
            // 
            // BiggerSmallerEqualsGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.kindergarten_preschool_colorful_banner_with_empty_copy_space_background_800563_2789;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(720, 380);
            Controls.Add(buttonHome);
            Controls.Add(labelTime);
            Controls.Add(labelScore);
            Controls.Add(buttonNewGame);
            Controls.Add(buttonEqual);
            Controls.Add(buttonGreater);
            Controls.Add(buttonLess);
            Controls.Add(labelResult);
            Controls.Add(labelSecondNumber);
            Controls.Add(labelFirstNumber);
            Margin = new Padding(4);
            Name = "BiggerSmallerEqualsGame";
            Text = "BiggerSmallerEqualsGame";
            Load += BiggerSmallerEqualsGame_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label labelFirstNumber;
        private System.Windows.Forms.Label labelSecondNumber;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonLess;
        private System.Windows.Forms.Button buttonGreater;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonHome;
    }
}
