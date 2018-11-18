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
    public partial class FLogin : MetroFramework.Forms.MetroForm
    {
        User u = new User();
        Database db = new Database();
        public FLogin()
        {
            InitializeComponent();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            Admin a1 = new Admin();
            a1.Show();
            this.Hide();
            FUserProfile f1 = new FUserProfile();
            f1.Show();*/

            string s = "select * from Member where AIUB_ID ='" + metroTextBox1.Text.TrimEnd() + "' and Password='" + metroTextBox2.Text.TrimEnd() + "';";
            if (db.loginsearch(s))
            {
                //string name= "select FirstName,AIUB_ID,IEEE_ID,Email,Contact,Dept,MembershipType from Member where AIUB_ID ='" + metroTextBox1.Text + "' and Password='" + metroTextBox2.Text + "';"; 
                bool b = db.DetectAdmin(metroTextBox1.Text);
                //MessageBox.Show(Convert.ToString(b));
                if (b == true)
                {

                    new Admin(this.metroTextBox1.Text).Show();
                    this.Hide();
                }
                else
                {
                    db.User_View(metroTextBox1.Text, u);
                    // if(u.type.Equals("0"))
                    new FUserProfile(this.metroTextBox1.Text).Show();
                    //new Admin(this.metroTextBox1.Text).Show();
                    this.Hide();

                }


            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FHome h = new FHome();
            h.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            FSignUp s = new FSignUp();
            s.Show();
            this.Hide();
        }

        private void FLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
