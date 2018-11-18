using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace demoproject
{
    public partial class FUserProfile : MetroFramework.Forms.MetroForm
    {
        
        string ID;
       
        public FUserProfile()
        {
            InitializeComponent();
        }
        public FUserProfile(string s)
        {
            this.ID = s;
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //this.Close();
            new FHome().Show();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            
            new YourProfileInfo(ID).Show();
            this.Hide();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            new Upcoming_Events(ID).Show();
            this.Hide();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            new Suggestion(ID).Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://web.facebook.com/groups/IEEEAIUBSB2016/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*new Suggestion().Show();
            this.Hide();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*new Upcoming_Events().Show();
            this.Hide();*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            YourProfileInfo f1 = new YourProfileInfo();
            f1.Show();*/
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customize c1 = new Customize(ID);
            c1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PreviousEvent p1 = new PreviousEvent(ID);
            p1.Show();
        }

        private void FUserProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        
    }
}
