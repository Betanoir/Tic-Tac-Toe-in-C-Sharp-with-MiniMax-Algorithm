namespace Tic_Tac_Toe
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            label1 = new Label();
            btnPlayAgain = new Button();
            lblWins = new Label();
            lblLosses = new Label();
            lblWinStreak = new Label();
            lblDraws = new Label();
            lblWinLose = new Label();
            C3 = new Button();
            C2 = new Button();
            C1 = new Button();
            B3 = new Button();
            B2 = new Button();
            B1 = new Button();
            A3 = new Button();
            A2 = new Button();
            A1 = new Button();
            btnImgClose = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnImgClose).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(95, 9);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 3;
            label1.Text = "TIC-TAC-TOE";
            // 
            // btnPlayAgain
            // 
            btnPlayAgain.BackColor = Color.FromArgb(192, 255, 192);
            btnPlayAgain.Enabled = false;
            btnPlayAgain.FlatAppearance.BorderColor = Color.Lime;
            btnPlayAgain.FlatAppearance.BorderSize = 3;
            btnPlayAgain.FlatStyle = FlatStyle.Popup;
            btnPlayAgain.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlayAgain.ForeColor = Color.Black;
            btnPlayAgain.Location = new Point(9, 366);
            btnPlayAgain.Margin = new Padding(3, 2, 3, 2);
            btnPlayAgain.Name = "btnPlayAgain";
            btnPlayAgain.Size = new Size(289, 38);
            btnPlayAgain.TabIndex = 5;
            btnPlayAgain.Text = "PLAY AGAIN";
            btnPlayAgain.UseVisualStyleBackColor = false;
            btnPlayAgain.Click += BtnPlayAgain_Click;
            // 
            // lblWins
            // 
            lblWins.AutoSize = true;
            lblWins.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblWins.ForeColor = Color.White;
            lblWins.Location = new Point(10, 39);
            lblWins.Name = "lblWins";
            lblWins.Size = new Size(54, 19);
            lblWins.TabIndex = 6;
            lblWins.Text = "Wins: 0";
            // 
            // lblLosses
            // 
            lblLosses.AutoSize = true;
            lblLosses.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblLosses.ForeColor = Color.White;
            lblLosses.Location = new Point(153, 39);
            lblLosses.Name = "lblLosses";
            lblLosses.Size = new Size(64, 19);
            lblLosses.TabIndex = 7;
            lblLosses.Text = "Losses: 0";
            // 
            // lblWinStreak
            // 
            lblWinStreak.AutoSize = true;
            lblWinStreak.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblWinStreak.ForeColor = Color.White;
            lblWinStreak.Location = new Point(10, 63);
            lblWinStreak.Name = "lblWinStreak";
            lblWinStreak.Size = new Size(90, 19);
            lblWinStreak.TabIndex = 8;
            lblWinStreak.Text = "Win Streak: 0";
            // 
            // lblDraws
            // 
            lblDraws.AutoSize = true;
            lblDraws.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDraws.ForeColor = Color.White;
            lblDraws.Location = new Point(153, 63);
            lblDraws.Name = "lblDraws";
            lblDraws.Size = new Size(62, 19);
            lblDraws.TabIndex = 9;
            lblDraws.Text = "Draws: 0";
            // 
            // lblWinLose
            // 
            lblWinLose.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblWinLose.ForeColor = Color.White;
            lblWinLose.Location = new Point(9, 338);
            lblWinLose.Name = "lblWinLose";
            lblWinLose.Size = new Size(289, 21);
            lblWinLose.TabIndex = 10;
            lblWinLose.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // C3
            // 
            C3.BackColor = Color.FromArgb(80, 80, 80);
            C3.Enabled = false;
            C3.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            C3.ForeColor = Color.White;
            C3.Location = new Point(204, 250);
            C3.Margin = new Padding(3, 2, 3, 2);
            C3.Name = "C3";
            C3.Size = new Size(92, 79);
            C3.TabIndex = 19;
            C3.UseVisualStyleBackColor = false;
            C3.Click += BtnGame_Click;
            // 
            // C2
            // 
            C2.BackColor = Color.FromArgb(80, 80, 80);
            C2.Enabled = false;
            C2.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            C2.ForeColor = Color.White;
            C2.Location = new Point(108, 250);
            C2.Margin = new Padding(3, 2, 3, 2);
            C2.Name = "C2";
            C2.Size = new Size(92, 79);
            C2.TabIndex = 18;
            C2.UseVisualStyleBackColor = false;
            C2.Click += BtnGame_Click;
            // 
            // C1
            // 
            C1.BackColor = Color.FromArgb(80, 80, 80);
            C1.Enabled = false;
            C1.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            C1.ForeColor = Color.White;
            C1.Location = new Point(11, 250);
            C1.Margin = new Padding(3, 2, 3, 2);
            C1.Name = "C1";
            C1.Size = new Size(92, 79);
            C1.TabIndex = 17;
            C1.UseVisualStyleBackColor = false;
            C1.Click += BtnGame_Click;
            // 
            // B3
            // 
            B3.BackColor = Color.FromArgb(80, 80, 80);
            B3.Enabled = false;
            B3.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            B3.ForeColor = Color.White;
            B3.Location = new Point(204, 167);
            B3.Margin = new Padding(3, 2, 3, 2);
            B3.Name = "B3";
            B3.Size = new Size(92, 79);
            B3.TabIndex = 16;
            B3.UseVisualStyleBackColor = false;
            B3.Click += BtnGame_Click;
            // 
            // B2
            // 
            B2.BackColor = Color.FromArgb(80, 80, 80);
            B2.Enabled = false;
            B2.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            B2.ForeColor = Color.White;
            B2.Location = new Point(108, 167);
            B2.Margin = new Padding(3, 2, 3, 2);
            B2.Name = "B2";
            B2.Size = new Size(92, 79);
            B2.TabIndex = 15;
            B2.UseVisualStyleBackColor = false;
            B2.Click += BtnGame_Click;
            // 
            // B1
            // 
            B1.BackColor = Color.FromArgb(80, 80, 80);
            B1.Enabled = false;
            B1.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            B1.ForeColor = Color.White;
            B1.Location = new Point(11, 167);
            B1.Margin = new Padding(3, 2, 3, 2);
            B1.Name = "B1";
            B1.Size = new Size(92, 79);
            B1.TabIndex = 14;
            B1.UseVisualStyleBackColor = false;
            B1.Click += BtnGame_Click;
            // 
            // A3
            // 
            A3.BackColor = Color.FromArgb(80, 80, 80);
            A3.Enabled = false;
            A3.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            A3.ForeColor = Color.White;
            A3.Location = new Point(204, 85);
            A3.Margin = new Padding(3, 2, 3, 2);
            A3.Name = "A3";
            A3.Size = new Size(92, 79);
            A3.TabIndex = 13;
            A3.UseVisualStyleBackColor = false;
            A3.Click += BtnGame_Click;
            // 
            // A2
            // 
            A2.BackColor = Color.FromArgb(80, 80, 80);
            A2.Enabled = false;
            A2.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            A2.ForeColor = Color.White;
            A2.Location = new Point(108, 85);
            A2.Margin = new Padding(3, 2, 3, 2);
            A2.Name = "A2";
            A2.Size = new Size(92, 79);
            A2.TabIndex = 12;
            A2.UseVisualStyleBackColor = false;
            A2.Click += BtnGame_Click;
            // 
            // A1
            // 
            A1.BackColor = Color.FromArgb(80, 80, 80);
            A1.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            A1.ForeColor = Color.White;
            A1.Location = new Point(11, 85);
            A1.Margin = new Padding(3, 2, 3, 2);
            A1.Name = "A1";
            A1.Size = new Size(92, 79);
            A1.TabIndex = 11;
            A1.UseVisualStyleBackColor = false;
            A1.Click += BtnGame_Click;
            // 
            // btnImgClose
            // 
            btnImgClose.Image = (Image)resources.GetObject("btnImgClose.Image");
            btnImgClose.Location = new Point(269, 9);
            btnImgClose.Name = "btnImgClose";
            btnImgClose.Size = new Size(25, 25);
            btnImgClose.SizeMode = PictureBoxSizeMode.CenterImage;
            btnImgClose.TabIndex = 20;
            btnImgClose.TabStop = false;
            btnImgClose.Click += BtnClose_Click;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(306, 412);
            Controls.Add(btnImgClose);
            Controls.Add(C3);
            Controls.Add(C2);
            Controls.Add(C1);
            Controls.Add(B3);
            Controls.Add(B2);
            Controls.Add(B1);
            Controls.Add(A3);
            Controls.Add(A2);
            Controls.Add(A1);
            Controls.Add(lblWinLose);
            Controls.Add(lblDraws);
            Controls.Add(lblWinStreak);
            Controls.Add(lblLosses);
            Controls.Add(lblWins);
            Controls.Add(btnPlayAgain);
            Controls.Add(label1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game";
            Load += Game_Load;
            ((System.ComponentModel.ISupportInitialize)btnImgClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnPlayAgain;
        private Label lblWins;
        private Label lblLosses;
        private Label lblWinStreak;
        private Label lblDraws;
        private Label lblWinLose;
        private Button C3;
        private Button C2;
        private Button C1;
        private Button B3;
        private Button B2;
        private Button B1;
        private Button A3;
        private Button A2;
        private Button A1;
        private PictureBox btnImgClose;
    }
}