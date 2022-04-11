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
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StartScreen f2 = new StartScreen();
            if (f2.Text != null) ;
            {
                this.Visible = false;
                StartScreen startScreen = new StartScreen();
                startScreen.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/petux616/?r=nametag");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/petux616/?r=nametag");
        }
    }
}
