using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classic_Snakes_Game_Bogdan_B_9H
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void LoadGame(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            if (f2.Text != null) ;
            {
                this.Visible = false;
                Form1 form1 = new Form1();
                form1.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            How_To_Play f2 = new How_To_Play();
            if (f2.Text != null) ;
            {
                this.Visible = false;
                How_To_Play how_To_Play = new How_To_Play();
                how_To_Play.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Credits f2 = new Credits();
            if (f2.Text != null) ;
            {
                this.Visible = false;
                Credits credits = new Credits();
                credits.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
