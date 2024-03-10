namespace Rock__Paper__Scissor_Application
{
    partial class Form2
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
            label1 = new Label();
            Rock = new Button();
            Paper = new Button();
            Scissor = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            PlayerBox = new PictureBox();
            ComputerBox = new PictureBox();
            PlayerRock = new PictureBox();
            PlayerPaper = new PictureBox();
            PlayerScissor = new PictureBox();
            ComputerRock = new PictureBox();
            ComputerPaper = new PictureBox();
            ComputerScissor = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PlayerBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ComputerBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerRock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerPaper).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerScissor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ComputerRock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ComputerPaper).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ComputerScissor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(165, 9);
            label1.Name = "label1";
            label1.Size = new Size(268, 50);
            label1.TabIndex = 0;
            label1.Text = "Choose a Weapon!";
            // 
            // Rock
            // 
            Rock.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Rock.Location = new Point(34, 75);
            Rock.Name = "Rock";
            Rock.Size = new Size(145, 70);
            Rock.TabIndex = 1;
            Rock.Text = "Rock";
            Rock.UseVisualStyleBackColor = true;
            Rock.Click += Rock_Click;
            // 
            // Paper
            // 
            Paper.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Paper.Location = new Point(230, 75);
            Paper.Name = "Paper";
            Paper.Size = new Size(145, 70);
            Paper.TabIndex = 2;
            Paper.Text = "Paper";
            Paper.UseVisualStyleBackColor = true;
            Paper.Click += Paper_Click;
            // 
            // Scissor
            // 
            Scissor.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Scissor.Location = new Point(423, 75);
            Scissor.Name = "Scissor";
            Scissor.Size = new Size(145, 70);
            Scissor.TabIndex = 3;
            Scissor.Text = "Scissor";
            Scissor.UseVisualStyleBackColor = true;
            Scissor.Click += Scissor_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(77, 167);
            label2.Name = "label2";
            label2.Size = new Size(93, 44);
            label2.TabIndex = 4;
            label2.Text = "Player ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(280, 270);
            label3.Name = "label3";
            label3.Size = new Size(45, 44);
            label3.TabIndex = 5;
            label3.Text = "VS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agency FB", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(423, 167);
            label4.Name = "label4";
            label4.Size = new Size(123, 44);
            label4.TabIndex = 6;
            label4.Text = "Computer";
            // 
            // PlayerBox
            // 
            PlayerBox.Image = Properties.Resources.Yellow_Question_Mark;
            PlayerBox.Location = new Point(34, 217);
            PlayerBox.Name = "PlayerBox";
            PlayerBox.Size = new Size(168, 163);
            PlayerBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PlayerBox.TabIndex = 7;
            PlayerBox.TabStop = false;
            // 
            // ComputerBox
            // 
            ComputerBox.Image = Properties.Resources.Yellow_Question_Mark;
            ComputerBox.Location = new Point(400, 217);
            ComputerBox.Name = "ComputerBox";
            ComputerBox.Size = new Size(168, 163);
            ComputerBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ComputerBox.TabIndex = 8;
            ComputerBox.TabStop = false;
            // 
            // PlayerRock
            // 
            PlayerRock.Image = Properties.Resources.Rock_;
            PlayerRock.Location = new Point(34, 217);
            PlayerRock.Name = "PlayerRock";
            PlayerRock.Size = new Size(168, 163);
            PlayerRock.SizeMode = PictureBoxSizeMode.StretchImage;
            PlayerRock.TabIndex = 9;
            PlayerRock.TabStop = false;
            PlayerRock.Visible = false;
            // 
            // PlayerPaper
            // 
            PlayerPaper.Image = Properties.Resources.Paper;
            PlayerPaper.Location = new Point(34, 217);
            PlayerPaper.Name = "PlayerPaper";
            PlayerPaper.Size = new Size(168, 163);
            PlayerPaper.SizeMode = PictureBoxSizeMode.StretchImage;
            PlayerPaper.TabIndex = 10;
            PlayerPaper.TabStop = false;
            PlayerPaper.Visible = false;
            // 
            // PlayerScissor
            // 
            PlayerScissor.Image = Properties.Resources.Scissor;
            PlayerScissor.Location = new Point(34, 217);
            PlayerScissor.Name = "PlayerScissor";
            PlayerScissor.Size = new Size(168, 163);
            PlayerScissor.SizeMode = PictureBoxSizeMode.StretchImage;
            PlayerScissor.TabIndex = 11;
            PlayerScissor.TabStop = false;
            PlayerScissor.Visible = false;
            // 
            // ComputerRock
            // 
            ComputerRock.Image = Properties.Resources.Rock_;
            ComputerRock.Location = new Point(400, 217);
            ComputerRock.Name = "ComputerRock";
            ComputerRock.Size = new Size(168, 163);
            ComputerRock.SizeMode = PictureBoxSizeMode.StretchImage;
            ComputerRock.TabIndex = 12;
            ComputerRock.TabStop = false;
            ComputerRock.Visible = false;
            // 
            // ComputerPaper
            // 
            ComputerPaper.Image = Properties.Resources.Paper;
            ComputerPaper.Location = new Point(400, 217);
            ComputerPaper.Name = "ComputerPaper";
            ComputerPaper.Size = new Size(168, 163);
            ComputerPaper.SizeMode = PictureBoxSizeMode.StretchImage;
            ComputerPaper.TabIndex = 13;
            ComputerPaper.TabStop = false;
            ComputerPaper.Visible = false;
            // 
            // ComputerScissor
            // 
            ComputerScissor.Image = Properties.Resources.Scissor;
            ComputerScissor.Location = new Point(400, 217);
            ComputerScissor.Name = "ComputerScissor";
            ComputerScissor.Size = new Size(168, 163);
            ComputerScissor.SizeMode = PictureBoxSizeMode.StretchImage;
            ComputerScissor.TabIndex = 14;
            ComputerScissor.TabStop = false;
            ComputerScissor.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(620, 429);
            Controls.Add(ComputerScissor);
            Controls.Add(ComputerPaper);
            Controls.Add(ComputerRock);
            Controls.Add(PlayerScissor);
            Controls.Add(PlayerPaper);
            Controls.Add(PlayerRock);
            Controls.Add(ComputerBox);
            Controls.Add(PlayerBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Scissor);
            Controls.Add(Paper);
            Controls.Add(Rock);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "Form2";
            Text = "Rock Paper Scissors";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)PlayerBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ComputerBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerRock).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerPaper).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerScissor).EndInit();
            ((System.ComponentModel.ISupportInitialize)ComputerRock).EndInit();
            ((System.ComponentModel.ISupportInitialize)ComputerPaper).EndInit();
            ((System.ComponentModel.ISupportInitialize)ComputerScissor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Rock;
        private Button Paper;
        private Button Scissor;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox PlayerBox;
        private PictureBox ComputerBox;
        private PictureBox PlayerRock;
        private PictureBox PlayerPaper;
        private PictureBox PlayerScissor;
        private PictureBox ComputerRock;
        private PictureBox ComputerPaper;
        private PictureBox ComputerScissor;
    }
}