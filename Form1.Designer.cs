
namespace FlappyBird2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.FlappyBirds = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.Mahesh = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGameOver = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtSuggestion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBirds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mahesh)).BeginInit();
            this.SuspendLayout();
            // 
            // pipeTop
            // 
            this.pipeTop.Image = ((System.Drawing.Image)(resources.GetObject("pipeTop.Image")));
            this.pipeTop.Location = new System.Drawing.Point(1569, 2);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(83, 210);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 0;
            this.pipeTop.TabStop = false;
            this.pipeTop.Tag = "pipe";
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.SystemColors.Highlight;
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-1, 558);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1547, 110);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // FlappyBirds
            // 
            this.FlappyBirds.Image = ((System.Drawing.Image)(resources.GetObject("FlappyBirds.Image")));
            this.FlappyBirds.Location = new System.Drawing.Point(396, 124);
            this.FlappyBirds.Name = "FlappyBirds";
            this.FlappyBirds.Size = new System.Drawing.Size(126, 124);
            this.FlappyBirds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FlappyBirds.TabIndex = 2;
            this.FlappyBirds.TabStop = false;
            this.FlappyBirds.Visible = false;
            this.FlappyBirds.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = ((System.Drawing.Image)(resources.GetObject("pipeBottom.Image")));
            this.pipeBottom.Location = new System.Drawing.Point(1346, 394);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(82, 165);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 3;
            this.pipeBottom.TabStop = false;
            this.pipeBottom.Tag = "pipe";
            this.pipeBottom.Click += new System.EventHandler(this.pipeBottom_Click);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.SystemColors.Desktop;
            this.Score.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Score.Location = new System.Drawing.Point(-1, 2);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(156, 42);
            this.Score.TabIndex = 4;
            this.Score.Text = "Score:0";
            this.Score.Click += new System.EventHandler(this.Score_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Mahesh
            // 
            this.Mahesh.BackColor = System.Drawing.SystemColors.Highlight;
            this.Mahesh.Image = global::FlappyBird2.Properties.Resources.Krishna2;
            this.Mahesh.Location = new System.Drawing.Point(1709, 56);
            this.Mahesh.Name = "Mahesh";
            this.Mahesh.Size = new System.Drawing.Size(140, 142);
            this.Mahesh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mahesh.TabIndex = 5;
            this.Mahesh.TabStop = false;
            this.Mahesh.Tag = "enemy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(522, 609);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Made With ❤ by";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(818, 593);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 53);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mahesh";
            // 
            // txtGameOver
            // 
            this.txtGameOver.AutoSize = true;
            this.txtGameOver.Font = new System.Drawing.Font("Snap ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGameOver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtGameOver.Location = new System.Drawing.Point(513, 229);
            this.txtGameOver.Name = "txtGameOver";
            this.txtGameOver.Size = new System.Drawing.Size(539, 103);
            this.txtGameOver.TabIndex = 8;
            this.txtGameOver.Text = "Game Over";
            this.txtGameOver.Click += new System.EventHandler(this.txtGameOver_Click);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Enabled = false;
            this.txtScore.Font = new System.Drawing.Font("Snap ITC", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtScore.ForeColor = System.Drawing.Color.Green;
            this.txtScore.Location = new System.Drawing.Point(594, 158);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(348, 61);
            this.txtScore.TabIndex = 9;
            this.txtScore.Text = "Press Shift";
            // 
            // txtSuggestion
            // 
            this.txtSuggestion.AutoSize = true;
            this.txtSuggestion.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtSuggestion.Font = new System.Drawing.Font("Snap ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSuggestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtSuggestion.Location = new System.Drawing.Point(226, 497);
            this.txtSuggestion.Name = "txtSuggestion";
            this.txtSuggestion.Size = new System.Drawing.Size(1114, 48);
            this.txtSuggestion.TabIndex = 10;
            this.txtSuggestion.Text = "You loose your score by one if you waste a bullet";
            this.txtSuggestion.Visible = false;
            this.txtSuggestion.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1547, 667);
            this.Controls.Add(this.txtSuggestion);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtGameOver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Mahesh);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.FlappyBirds);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeTop);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Mahesh";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBirds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mahesh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox FlappyBirds;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.PictureBox Mahesh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtGameOver;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtSuggestion;
    }
}

