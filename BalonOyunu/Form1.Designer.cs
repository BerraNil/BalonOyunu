namespace BalonOyunu
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            bomb = new PictureBox();
            txtSkor = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bomb).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pinkBalloon;
            pictureBox1.Location = new Point(97, 155);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "ballon";
            pictureBox1.Click += BalonTiklandi;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.redHeart;
            pictureBox2.Location = new Point(87, 459);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(111, 116);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "ballon";
            pictureBox2.Click += BalonTiklandi;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.redStar;
            pictureBox3.Location = new Point(319, 177);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(111, 116);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "ballon";
            pictureBox3.Click += BalonTiklandi;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.yellowBalloon;
            pictureBox4.Location = new Point(464, 404);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(111, 116);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "ballon";
            pictureBox4.Click += BalonTiklandi;
            // 
            // bomb
            // 
            bomb.Image = Properties.Resources.bomb;
            bomb.Location = new Point(289, 628);
            bomb.Margin = new Padding(3, 4, 3, 4);
            bomb.Name = "bomb";
            bomb.Size = new Size(100, 98);
            bomb.SizeMode = PictureBoxSizeMode.AutoSize;
            bomb.TabIndex = 0;
            bomb.TabStop = false;
            bomb.Click += BombaTiklandi;
            // 
            // txtSkor
            // 
            txtSkor.AutoSize = true;
            txtSkor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSkor.Location = new Point(50, 32);
            txtSkor.Name = "txtSkor";
            txtSkor.Size = new Size(60, 28);
            txtSkor.TabIndex = 1;
            txtSkor.Text = "Skor:";
            // 
            // timer1
            // 
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(725, 703);
            Controls.Add(txtSkor);
            Controls.Add(bomb);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Balon";
            Load += Form1_Load;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)bomb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox bomb;
        private Label txtSkor;
        private System.Windows.Forms.Timer timer1;
    }
}