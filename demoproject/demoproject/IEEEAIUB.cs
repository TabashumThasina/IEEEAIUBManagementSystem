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
    public partial class IEEEAIUB : MetroFramework.Forms.MetroForm
    {
        public IEEEAIUB()
        {
            InitializeComponent();
        }

        private void IEEEAIUB_Load(object sender, EventArgs e)
        {

        }

        private void IEEEAIUB_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
