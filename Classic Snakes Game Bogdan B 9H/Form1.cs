using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
namespace Classic_Snakes_Game_Bogdan_B_9H
{
    public partial class Form1 : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();
        int maxWidth;
        int maxHeight; 
        int score;
        int highscore;
        Random rand = new Random();
        bool goLeft, goRight, goDown, goUp;
        public Form1()
        {
            InitializeComponent();
            gameTimer.Stop();
            new Settings();
        }
        private void txtScore_Click(object sender, EventArgs e)
        {

        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Settings.directions != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && Settings.directions != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && Settings.directions != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && Settings.directions != "up")
            {
                goDown = true;
            }
        }
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }
        private void StartGame(object sender, EventArgs e)
        {
            RestartGame();
            noobButton.Visible = false;
            proButton.Visible = false;
            expertButton.Visible = false;
            difficulty.Visible = false;
            if (gameTimer.Interval < 40)
            {
                error.Visible = true;
            }
            else
            {
                error.Visible = false;
            }
        }
        private void TakeSnapShot(object sender, EventArgs e)
        {
            noobButton.Visible = false;
            proButton.Visible = false;
            expertButton.Visible = false;
            difficulty.Visible = false;
            Label caption = new Label();
            caption.Text = "I scored: " + score + " and my HighScore is " + highscore + " on the Snake Game from Bykovskiy Bogdan";
            caption.Font = new Font("Stika small", 9, FontStyle.Bold);
            caption.ForeColor = Color.Indigo;
            caption.AutoSize = false;
            caption.Width = picCanvas.Width;
            caption.Height = 30;
            caption.TextAlign = ContentAlignment.MiddleCenter;
            picCanvas.Controls.Add(caption);
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "Snake Game Snapshot";
            dialog.DefaultExt = "jpg";
            dialog.Filter = "JPG Image file | *.jpg";
            dialog.ValidateNames = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(picCanvas.Width);
                int height = Convert.ToInt32(picCanvas.Height);
                Bitmap bmp = new Bitmap(width, height);
                picCanvas.DrawToBitmap(bmp, new Rectangle(0,0, width, height));
                bmp.Save(dialog.FileName, ImageFormat.Jpeg);
                picCanvas.Controls.Remove(caption);
            }
        }
        private void GameTimerEvent(object sender, EventArgs e)
        {
            if (goLeft)
            {
                Settings.directions = "left";
            }
            if (goRight)
            {
                Settings.directions = "right";
            }
            if (goDown)
            {
                Settings.directions = "down";
            }
            if (goUp)
            {
                Settings.directions = "up";
            }
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                    }
                    if (Snake[i].X < 0)
                    {
                        Snake[i].X = maxWidth;
                    }
                    if (Snake[i].X > maxWidth)
                    {
                        Snake[i].X = 0;
                    }
                    if (Snake[i].Y < 0)
                    {
                        Snake[i].Y = maxHeight;
                    }
                    if (Snake[i].Y > maxHeight)
                    {
                        Snake[i].Y = 0;
                    } 
                    if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                    {
                        EatFood();
                    }     
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if  (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();
                        }
                    }        
                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
            picCanvas.Invalidate();
        }
        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            Brush snakeColour;
            for (int i = 0; i < Snake.Count; i++)
            {
                if (i == 0)
                {
                    snakeColour = Brushes.DarkMagenta;
                }
                else
                {
                    snakeColour = Brushes.MediumOrchid;
                }
                if (i > 8)
                {
                    snakeColour = Brushes.Fuchsia;
                }
                if (i > 13)
                {
                    snakeColour = Brushes.Magenta;
                }
                if (i > 18)
                {
                    snakeColour = Brushes.Orchid;
                }
                if (i > 23)
                {
                    snakeColour = Brushes.DarkOrchid;
                }
                if (i > 28)
                {
                    snakeColour = Brushes.DarkMagenta;
                }
                if (i > 33)
                {
                    snakeColour = Brushes.Fuchsia;
                }
                if (i > 38)
                {
                    snakeColour = Brushes.Magenta;
                } 
                if (i > 43)
                {
                    snakeColour = Brushes.Orchid;
                }
                if (i > 48)
                {
                    snakeColour = Brushes.DarkOrchid;
                }
                if (i > 53)
                {
                    snakeColour = Brushes.Fuchsia;
                }
                if (i > 58)
                {
                    snakeColour = Brushes.Magenta;
                }
                if (i > 63)
                {
                    snakeColour = Brushes.Orchid;
                }
                if (i > 68)
                {
                    snakeColour = Brushes.DarkOrchid;
                }
                if (i > 73)
                {
                    snakeColour = Brushes.DarkMagenta;
                }
                if (i > 78)
                {
                    snakeColour = Brushes.Fuchsia;
                }
                if (i > 83)
                {
                    snakeColour = Brushes.Magenta;
                }
                if (i > 88)
                {
                    snakeColour = Brushes.Orchid;
                }
                if (i > 93)
                {
                    snakeColour = Brushes.DarkOrchid;
                }
                if (i > 98)
                {
                    snakeColour = Brushes.DarkOrchid;
                }
                if (i > 103)
                {
                    snakeColour = Brushes.DarkOrchid;
                }
                canvas.FillEllipse(snakeColour, new Rectangle
                    (
                    Snake[i].X * Settings.Width,
                    Snake[i].Y * Settings.Height,
                    Settings.Width, Settings.Height
                    ));
            }
            canvas.FillEllipse(Brushes.Indigo, new Rectangle
            (
            food.X * Settings.Width,
            food.Y * Settings.Height,
            Settings.Width, Settings.Height
            ));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            gameTimer.Interval = 100;
            noobButton.Visible = false;
            proButton.Visible = false;
            expertButton.Visible = false;
            difficulty.Visible = false;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            gameTimer.Interval = 70;
            noobButton.Visible = false;
            proButton.Visible = false;
            expertButton.Visible = false;
            difficulty.Visible = false;
        }
        private void difficulty_Click(object sender, EventArgs e)
        {

        }
        private void proButton_Click(object sender, EventArgs e)
        {
            gameTimer.Interval = 40;
            noobButton.Visible = false;
            proButton.Visible = false;
            expertButton.Visible = false;
            difficulty.Visible = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            gameTimer.Interval = 1;
            error.Visible = false;
            noobButton.Visible = true;
            proButton.Visible = true;
            expertButton.Visible = true;
            difficulty.Visible = true;
            gameTimer.Stop();
            startButton.Enabled = true;
            snapButton.Enabled = true;
            if (score > highscore)
            {
                highscore = score;
                txtHighScore.Text = "High Score: " + Environment.NewLine + highscore;
                txtHighScore.ForeColor = Color.MediumOrchid;
                txtHighScore.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void error_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
  
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            StartScreen f2 = new StartScreen();
            if (f2.Text != null) ;
            {
                this.Visible = false;
                StartScreen startScreen = new StartScreen();
                startScreen.Show();
            }
            gameTimer.Interval = 1;
        }

        private void RestartGame()
        {
            maxWidth = picCanvas.Width / Settings.Width - 1;
            maxHeight = picCanvas.Height / Settings.Height - 1;
            Snake.Clear();
            startButton.Enabled = false;
            snapButton.Enabled = false;
            score = 0;
            txtScore.Text = "Score: " + score;
            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head); 
            for (int i = 0; i < 3; i++)
            {
                Circle body = new Circle();
                Snake.Add(body);
            }
            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

            gameTimer.Start();
        }
        private void EatFood()
        {
            score += 1;
            txtScore.Text = "Score: " + score;
            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(body);
            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
        }
        private void GameOver()
        {
            gameTimer.Stop();
            startButton.Enabled = true;
            snapButton.Enabled = true;
            if (score > highscore)
            {
                highscore = score;
                txtHighScore.Text = "High Score: " + Environment.NewLine + highscore;
                txtHighScore.ForeColor = Color.MediumOrchid;
                txtHighScore.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
    }
}
