using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixel_Racer
{
    public partial class gameoverForm : Form
    {
        
        public gameoverForm(int score)
        {
            InitializeComponent();
            lblScore.Text = "Your Score: "+score.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
            frm.ResetGame();
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.ForeColor = Color.DarkOrange;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.DarkOrange;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }
    }
}
