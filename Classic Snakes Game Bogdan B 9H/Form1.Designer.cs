
namespace Classic_Snakes_Game_Bogdan_B_9H
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startButton = new System.Windows.Forms.Button();
            this.snapButton = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtHighScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.noobButton = new System.Windows.Forms.Button();
            this.expertButton = new System.Windows.Forms.Button();
            this.difficulty = new System.Windows.Forms.Label();
            this.proButton = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Teal;
            this.startButton.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.startButton.Location = new System.Drawing.Point(599, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(115, 74);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartGame);
            // 
            // snapButton
            // 
            this.snapButton.BackColor = System.Drawing.Color.Teal;
            this.snapButton.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.snapButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.snapButton.Location = new System.Drawing.Point(599, 92);
            this.snapButton.Name = "snapButton";
            this.snapButton.Size = new System.Drawing.Size(115, 74);
            this.snapButton.TabIndex = 0;
            this.snapButton.Text = "Snap";
            this.snapButton.UseVisualStyleBackColor = false;
            this.snapButton.Click += new System.EventHandler(this.TakeSnapShot);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtScore.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtScore.Location = new System.Drawing.Point(594, 185);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(86, 25);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Score: 0";
            this.txtScore.Click += new System.EventHandler(this.txtScore_Click);
            // 
            // txtHighScore
            // 
            this.txtHighScore.AutoSize = true;
            this.txtHighScore.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtHighScore.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtHighScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtHighScore.Location = new System.Drawing.Point(594, 229);
            this.txtHighScore.Name = "txtHighScore";
            this.txtHighScore.Size = new System.Drawing.Size(131, 25);
            this.txtHighScore.TabIndex = 2;
            this.txtHighScore.Text = "HighScore: 0";
            this.txtHighScore.Click += new System.EventHandler(this.txtScore_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // noobButton
            // 
            this.noobButton.BackColor = System.Drawing.Color.Teal;
            this.noobButton.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noobButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.noobButton.Location = new System.Drawing.Point(33, 265);
            this.noobButton.Name = "noobButton";
            this.noobButton.Size = new System.Drawing.Size(160, 120);
            this.noobButton.TabIndex = 3;
            this.noobButton.Text = "Noob";
            this.noobButton.UseVisualStyleBackColor = false;
            this.noobButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // expertButton
            // 
            this.expertButton.BackColor = System.Drawing.Color.Teal;
            this.expertButton.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expertButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.expertButton.Location = new System.Drawing.Point(219, 265);
            this.expertButton.Name = "expertButton";
            this.expertButton.Size = new System.Drawing.Size(160, 120);
            this.expertButton.TabIndex = 4;
            this.expertButton.Text = "Expert";
            this.expertButton.UseVisualStyleBackColor = false;
            this.expertButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // difficulty
            // 
            this.difficulty.AutoSize = true;
            this.difficulty.BackColor = System.Drawing.Color.Teal;
            this.difficulty.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.difficulty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.difficulty.Location = new System.Drawing.Point(153, 185);
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(296, 35);
            this.difficulty.TabIndex = 5;
            this.difficulty.Text = "Choose your difficulty";
            this.difficulty.Click += new System.EventHandler(this.difficulty_Click);
            // 
            // proButton
            // 
            this.proButton.BackColor = System.Drawing.Color.Teal;
            this.proButton.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.proButton.Location = new System.Drawing.Point(406, 265);
            this.proButton.Name = "proButton";
            this.proButton.Size = new System.Drawing.Size(160, 120);
            this.proButton.TabIndex = 6;
            this.proButton.Text = "Pro";
            this.proButton.UseVisualStyleBackColor = false;
            this.proButton.Click += new System.EventHandler(this.proButton_Click);
            // 
            // restart
            // 
            this.restart.AutoSize = true;
            this.restart.BackColor = System.Drawing.Color.Teal;
            this.restart.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.restart.Location = new System.Drawing.Point(600, 319);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(134, 35);
            this.restart.TabIndex = 7;
            this.restart.Text = "difficulty";
            this.restart.Click += new System.EventHandler(this.label1_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.BackColor = System.Drawing.Color.Teal;
            this.error.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.error.Location = new System.Drawing.Point(11, 308);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(544, 35);
            this.error.TabIndex = 8;
            this.error.Text = "ERROR! CHOSE YOUR DIFFICULTY FIRST!";
            this.error.Visible = false;
            this.error.Click += new System.EventHandler(this.error_Click);
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.SeaGreen;
            this.picCanvas.BackgroundImage = global::Classic_Snakes_Game_Bogdan_B_9H.Properties.Resources.grass;
            this.picCanvas.Location = new System.Drawing.Point(8, 12);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(580, 680);
            this.picCanvas.TabIndex = 1;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphics);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(659, 657);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Back";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(746, 717);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.error);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.proButton);
            this.Controls.Add(this.difficulty);
            this.Controls.Add(this.expertButton);
            this.Controls.Add(this.noobButton);
            this.Controls.Add(this.txtHighScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.snapButton);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Classic Snake Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button snapButton;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtHighScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button noobButton;
        private System.Windows.Forms.Button expertButton;
        private System.Windows.Forms.Label difficulty;
        private System.Windows.Forms.Button proButton;
        private System.Windows.Forms.Label restart;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label label1;
    }
}

