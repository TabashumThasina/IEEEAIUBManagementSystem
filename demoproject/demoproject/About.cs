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

namespace demoproject
{
    public partial class About : MetroFramework.Forms.MetroForm
    {
        public About()
        {
            InitializeComponent();
            /*var pos1 = this.PointToScreen(label1.Location);
            pos1 = pictureBox1.PointToClient(pos1);
            label1.Parent = pictureBox1;
            label1.Location = pos1;
            label1.BackColor = Color.Transparent;*/
        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void About_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
