namespace Tic_Tac_Toe
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label1 = new Label();
            btnPlay = new Button();
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
            label1.TabIndex = 1;
            label1.Text = "TIC-TAC-TOE";
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.FromArgb(192, 255, 192);
            btnPlay.FlatAppearance.BorderColor = Color.Lime;
            btnPlay.FlatAppearance.BorderSize = 3;
            btnPlay.FlatStyle = FlatStyle.Popup;
            btnPlay.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlay.Location = new Point(88, 158);
            btnPlay.Margin = new Padding(3, 2, 3, 2);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(131, 30);
            btnPlay.TabIndex = 2;
            btnPlay.Text = "PLAY";
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += BtnPlay_Click;
            // 
            // btnImgClose
            // 
            btnImgClose.Image = (Image)resources.GetObject("btnImgClose.Image");
            btnImgClose.Location = new Point(269, 12);
            btnImgClose.Name = "btnImgClose";
            btnImgClose.Size = new Size(25, 25);
            btnImgClose.SizeMode = PictureBoxSizeMode.CenterImage;
            btnImgClose.TabIndex = 21;
            btnImgClose.TabStop = false;
            btnImgClose.Click += BtnClose_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(306, 338);
            Controls.Add(btnImgClose);
            Controls.Add(btnPlay);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)btnImgClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnPlay;
        private PictureBox btnImgClose;
    }
}