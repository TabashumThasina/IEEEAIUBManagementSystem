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
    public partial class Contact : MetroFramework.Forms.MetroForm
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void Contact_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FHome fh1 = new FHome();
            fh1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSignUp fs1 = new FSignUp();
            fs1.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.ieee.org/about/contact_center/index.html");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com/maps/place/ECE+Building,BUET/@23.7264632,90.3886475,16z/data=!4m5!3m4!1s0x0:0x7e72e9fd2e6cd9fe!8m2!3d23.7263058!4d90.3886689?hl=en-US");
        }
    }
}
