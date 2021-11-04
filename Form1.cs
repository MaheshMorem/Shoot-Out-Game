using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird2
{
    public partial class Form1 : Form
    {
        bool goUp, goDown, shot, gameOver,  Restarts = false, gameStart = false;
        int scores = 0,choice;
        int enemySpeed = 12;
        int speed =12;
        int[] a = { 1613, 1656, 1699, 1742, 1785, 1828, 1871 };
        int b;
       
        Random r = new Random();

        int birdSpeed = 12;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            
            txtScore.Text = "Press Shift";//
            
            gameStart = true;//
            gameTimer.Enabled = false;//
            txtScore.Enabled = true;
            txtSuggestion.Visible = true;

            txtScore.Visible = true;
            txtGameOver.Visible = false;
            pipeTop.Left = pipeTop.Left + 300;
            pipeBottom.Left = pipeBottom.Left + 300;
        }
        private void gameTimerEvent(object sender, EventArgs e)
        {
            
            /*if(scores % 10 == 0 && scores > 0 )
            {
                speed += 1;
            }*/
            if(Restarts == true)
            {
                foreach (Control i in this.Controls)
                {
                    if (i is PictureBox && (string)i.Tag == "bullet")
                    {
                       i.Controls.Remove(i);
                       i.Dispose();
                    }
                }
                foreach (Control i in this.Controls)
                {
                    if (i is PictureBox && (string)i.Tag == "bullet")
                    {
                        i.Controls.Remove(i);
                        i.Dispose();
                    }
                }
                foreach (Control i in this.Controls)
                {
                    if (i is PictureBox && (string)i.Tag == "bullet")
                    {
                        i.Controls.Remove(i);
                        i.Dispose();
                    }
                }
                foreach (Control i in this.Controls)
                {
                    if (i is PictureBox && (string)i.Tag == "bullet")
                    {
                        i.Controls.Remove(i);
                        i.Dispose();
                    }
                }
                Restarts = false;
            }
            

            if (Restarts == false)
            {
                Score.Text = "Score:" + scores; 
                if (goUp == true && FlappyBirds.Top > 0)
                {
                    FlappyBirds.Top -= birdSpeed;
                }

                if (goDown == true && FlappyBirds.Top + FlappyBirds.Height < this.ClientSize.Height)
                {
                    FlappyBirds.Top += birdSpeed;
                }

                foreach (Control c in this.Controls)
                {
                    if(c is PictureBox && (string)c.Tag =="bullet")
                    {
                        foreach (Control d in this.Controls)
                        {
                            if (d is PictureBox && (string)d.Tag == "pipe")
                            {
                                if (c.Bounds.IntersectsWith(d.Bounds))
                                {
                                    DisposeBullet(((PictureBox)c));
                                }
                            }
                        }
                    }
                    
                }

                foreach (Control i in this.Controls)
                {
                if (i is PictureBox && (string)i.Tag == "pipe")
                    {
                        /*if(scores > 5)
                        {
                            speed = 15;
                            i.Left -= speed;
                        }*/
                        /*else {*/ i.Left -= speed; /* }*/
                        
                        if (i.Left < -30)
                        {
                            b = r.Next(1510,1828);
                            i.Left = b;
                        }
                    }
                    if (i is PictureBox && (string)i.Tag == "enemy")
                    {
                       /* if (scores > 5)
                        {
                            speed = 15;
                            i.Left -= speed;
                        }*/
                         i.Left -= enemySpeed; 
                        
                        if (i.Left < -30)
                        {
                            ChangeEnemy();
                        }
                    }
                    if (i is PictureBox && (string)i.Tag == "bullet")
                    {
                        i.Left += speed;

                        if (i.Left > this.ClientSize.Width && (string)i.Tag == "bullet")
                        {
                            scores--;
                            DisposeBullet(((PictureBox)i));

        
                        }
                        if (Mahesh.Bounds.IntersectsWith(i.Bounds))
                        {
                            scores++;
                            if (scores % 10 == 0 && scores > 0)
                            {
                                speed += 3;
                                birdSpeed += 3;
                            }
                            ChangeEnemy();
                            //RemoveEnemy();
                            DisposeBullet(((PictureBox)i));
                        }
                    }


                    if (i is PictureBox && ((string)i.Tag == "pipe" || (string)i.Tag == "enemy"))
                    {
                        if (FlappyBirds.Bounds.IntersectsWith(i.Bounds) && ((string)i.Tag == "pipe" || (string)i.Tag == "enemy"))
                        {
                            endGame();

                        }
                    }

                    if (FlappyBirds.Top < 0 || FlappyBirds.Top > this.ClientSize.Height - ground.Height - Mahesh.Height)
                    {
                        endGame();
                    }
                }
            }
        }
        private void ChangeEnemy()
        {
            choice = r.Next(1,6);
            switch (choice)
            {
                case 1: Mahesh.Image = Properties.Resources.anand1; break;

                case 2: Mahesh.Image = Properties.Resources.Mithil2; break;

                case 3: Mahesh.Image = Properties.Resources.Srinu; break;

                case 4: Mahesh.Image = Properties.Resources.Vamsi1; break;

                case 5: Mahesh.Image = Properties.Resources.Sheshank2; break;

                case 6:Mahesh.Image = Properties.Resources.Krishna2; break;
            }
            Mahesh.Left = this.ClientSize.Width+200;
            Mahesh.Top = r.Next(20, this.ClientSize.Height - ground.Height - Mahesh.Height);

        }
        private void gameKeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Space && shot == false)
            {
                MakeBullets();
                shot = true;
            }
        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (shot == true)
            {
                shot = false;
            }
            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                Restarts = true;
                Restart();
                
            }
            if(e.KeyCode == Keys.ShiftKey && gameStart == true)//
            {//
                FlappyBirds.Visible = true;
                txtSuggestion.Visible = false;
                txtScore.ForeColor = Color.Green;
                txtScore.Visible = false;//
                txtScore.Enabled = false;//
                gameTimer.Enabled = true;//
                gameStart = false;//
            }//
        }
        private void Restart()
        {

            goUp = false;
            goDown = false;
            shot = false;
            gameOver = false;
            scores = 0;
            enemySpeed = 12;
            speed = 12;
            birdSpeed = 12;
            txtGameOver.Visible = false;
            txtScore.Enabled = false;
            txtScore.Visible = false;

            Score.Text = "Score:" + scores;

            FlappyBirds.Top = 161;
            pipeBottom.Left = 1500;
            pipeBottom.Top = this.ClientSize.Height - pipeBottom.Height -ground.Height;
            pipeTop.Top = 0;
            pipeTop.Left = this.ClientSize.Width +300;
            Mahesh.Left = this.ClientSize.Width + 100;
            Mahesh.Top = r.Next(20, this.ClientSize.Height - ground.Height - Mahesh.Height);
            //bulletVanish = true;
            
            
            gameTimer.Start();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Score_Click(object sender, EventArgs e)
        {

        }

        private void txtGameOver_Click(object sender, EventArgs e)
        {

        }

        private void endGame()
        {
            txtGameOver.Visible= true;
            txtScore.Enabled = true;
            txtScore.Visible = true;
            txtScore.Text = "Score : "+ scores;
            gameTimer.Stop();
            gameOver = true;     
        }

        private void RemoveEnemy()
        {
            Mahesh.Top = r.Next(20, this.ClientSize.Height - ground.Height - Mahesh.Height);
            Mahesh.Left = 1000;
        }

        private void DisposeBullet(PictureBox bullet)
        {
            this.Controls.Remove(bullet);
            bullet.Dispose();
        }

        private void MakeBullets()
        {
            PictureBox bullets = new PictureBox();
            bullets.Height = 5;
            bullets.Width = 10;

            bullets.Left = FlappyBirds.Left + FlappyBirds.Width;
            bullets.Top = FlappyBirds.Top + (FlappyBirds.Height / 2);
            bullets.BackColor = Color.Red;
            bullets.Tag = "bullet";

            this.Controls.Add(bullets);
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pipeBottom_Click(object sender, EventArgs e)
        {

        }


    }
}

