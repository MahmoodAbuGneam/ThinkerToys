using System;
using System.Drawing;

namespace ThinkerToys
{
    partial class MathGameForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblEquals;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox spritePictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

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
            lblNum1 = new Label();
            lblOperator = new Label();
            lblNum2 = new Label();
            lblEquals = new Label();
            lblTime = new Label();
            lblScore = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            spritePictureBox = new PictureBox();
            lblCorrectMessage = new Label();
            buttonNewGame = new Button();
            buttonHome = new Button();
            ((System.ComponentModel.ISupportInitialize)spritePictureBox).BeginInit();
            SuspendLayout();
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.BackColor = Color.Black;
            lblNum1.Font = new Font("Arial", 30F, FontStyle.Bold);
            lblNum1.ForeColor = Color.White;
            lblNum1.Location = new Point(71, 100);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(130, 46);
            lblNum1.TabIndex = 1;
            lblNum1.Text = "Num1";
            // 
            // lblOperator
            // 
            lblOperator.AutoSize = true;
            lblOperator.BackColor = Color.Transparent;
            lblOperator.Font = new Font("Arial", 30F, FontStyle.Bold);
            lblOperator.ForeColor = Color.White;
            lblOperator.Location = new Point(157, 100);
            lblOperator.Name = "lblOperator";
            lblOperator.Size = new Size(43, 46);
            lblOperator.TabIndex = 2;
            lblOperator.Text = "+";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.BackColor = Color.Black;
            lblNum2.Font = new Font("Arial", 30F, FontStyle.Bold);
            lblNum2.ForeColor = Color.White;
            lblNum2.ImageAlign = ContentAlignment.MiddleLeft;
            lblNum2.Location = new Point(230, 100);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(130, 46);
            lblNum2.TabIndex = 3;
            lblNum2.Text = "Num2";
            // 
            // lblEquals
            // 
            lblEquals.AutoSize = true;
            lblEquals.BackColor = Color.Black;
            lblEquals.Font = new Font("Arial", 30F, FontStyle.Bold);
            lblEquals.ForeColor = Color.White;
            lblEquals.Location = new Point(339, 100);
            lblEquals.Name = "lblEquals";
            lblEquals.Size = new Size(43, 46);
            lblEquals.TabIndex = 4;
            lblEquals.Text = "=";
            lblEquals.Click += lblEquals_Click;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Black;
            lblTime.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(243, 9);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(76, 29);
            lblTime.TabIndex = 5;
            lblTime.Text = "Time:";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.Black;
            lblScore.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblScore.ForeColor = Color.White;
            lblScore.Location = new Point(452, 9);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(106, 29);
            lblScore.TabIndex = 6;
            lblScore.Text = "Score: 0";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 20F, FontStyle.Bold);
            button1.ForeColor = Color.Orange;
            button1.Location = new Point(595, 79);
            button1.Name = "button1";
            button1.Size = new Size(80, 80);
            button1.TabIndex = 8;
            button1.Text = "Option1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += AnswerButton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 20F, FontStyle.Bold);
            button2.ForeColor = Color.Orange;
            button2.Location = new Point(692, 79);
            button2.Name = "button2";
            button2.Size = new Size(80, 80);
            button2.TabIndex = 9;
            button2.Text = "Option2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += AnswerButton_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 20F, FontStyle.Bold);
            button3.ForeColor = Color.Orange;
            button3.Location = new Point(595, 183);
            button3.Name = "button3";
            button3.Size = new Size(80, 80);
            button3.TabIndex = 10;
            button3.Text = "Option3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += AnswerButton_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial", 20F, FontStyle.Bold);
            button4.ForeColor = Color.Orange;
            button4.Location = new Point(692, 183);
            button4.Name = "button4";
            button4.Size = new Size(80, 80);
            button4.TabIndex = 11;
            button4.Text = "Option4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += AnswerButton_Click;
            // 
            // spritePictureBox
            // 
            spritePictureBox.BackColor = Color.Black;
            spritePictureBox.Location = new Point(12, 325);
            spritePictureBox.Name = "spritePictureBox";
            spritePictureBox.Size = new Size(130, 113);
            spritePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            spritePictureBox.TabIndex = 7;
            spritePictureBox.TabStop = false;
            spritePictureBox.Paint += Homebt_Paint;
            // 
            // lblCorrectMessage
            // 
            lblCorrectMessage.AutoSize = true;
            lblCorrectMessage.BackColor = Color.Black;
            lblCorrectMessage.ForeColor = Color.White;
            lblCorrectMessage.Location = new Point(211, 183);
            lblCorrectMessage.Name = "lblCorrectMessage";
            lblCorrectMessage.Size = new Size(0, 15);
            lblCorrectMessage.TabIndex = 14;
            // 
            // buttonNewGame
            // 
            buttonNewGame.Font = new Font("Microsoft Sans Serif", 12F);
            buttonNewGame.Location = new Point(12, 5);
            buttonNewGame.Margin = new Padding(4);
            buttonNewGame.Name = "buttonNewGame";
            buttonNewGame.Size = new Size(152, 49);
            buttonNewGame.TabIndex = 6;
            buttonNewGame.Text = "New Game";
            buttonNewGame.UseVisualStyleBackColor = true;
            buttonNewGame.Click += buttonNewGame_Click;
            // 
            // buttonHome
            // 
            buttonHome.AllowDrop = true;
            buttonHome.BackColor = Color.DarkOrange;
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            buttonHome.ForeColor = Color.Black;
            buttonHome.Location = new Point(691, 18);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(120, 37);
            buttonHome.TabIndex = 9;
            buttonHome.Text = "Home";
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += homebt_Click;
            // 
            // MathGameForm
            // 
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackgroundImage = Properties.Resources.blackground_black;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHome);
            Controls.Add(buttonNewGame);
            Controls.Add(lblCorrectMessage);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(spritePictureBox);
            Controls.Add(lblScore);
            Controls.Add(lblTime);
            Controls.Add(lblEquals);
            Controls.Add(lblNum2);
            Controls.Add(lblOperator);
            Controls.Add(lblNum1);
            DoubleBuffered = true;
            Name = "MathGameForm";
            Text = "MathSpeedGame";
            Load += MathGameForm_Load;
            ((System.ComponentModel.ISupportInitialize)spritePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblCorrectMessage;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonHome;
    }
}