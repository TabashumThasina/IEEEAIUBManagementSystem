using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Diagnostics;

namespace demoproject
{
    public partial class FHome : MetroFramework.Forms.MetroForm
    {
        public FHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            About ab1 = new About();
            ab1.Show();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            FLogin l = new FLogin();
            l.Show();
            this.Hide();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
           FSignUp s = new FSignUp();
            s.Show();
            this.Hide();
            
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contact c1 = new Contact();
            c1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.ieee.org/index.html");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/pages/IEEE/176104589110851");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/IEEEorg");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/company/ieee");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/ieeeorg/");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/user/IEEEorg");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.ieee.org/index.html");
        }

        private void FHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            IEEEAIUB ie1 = new IEEEAIUB();
            ie1.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Achievement ach1 = new Achievement();
            ach1.Show();
        }
    }
}
