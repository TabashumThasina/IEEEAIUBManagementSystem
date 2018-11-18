using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoproject
{
    public partial class YourProfileInfo : MetroFramework.Forms.MetroForm
    {
        public YourProfileInfo()
        {
            InitializeComponent();
        }
        User u = new User();
        Database db = new Database();

        public YourProfileInfo(string id)
        {
            InitializeComponent();
            u=db.User_View(id, u);
            metroTextBox8.Text = u.FName + " " + u.LName;
            metroTextBox7.Text = u.AID;
            metroTextBox6.Text = u.IID;
            metroTextBox5.Text = u.Email;
            metroTextBox1.Text = u.MemberType;
            metroTextBox3.Text = u.Contact;
            metroTextBox2.Text = u.Department;
           
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            new FHome().Show();
            //this.Close();

        }

        private void metroRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            new changepass().Show();
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           try
            {
                if (u.type.TrimEnd().Equals("Admin"))
                {
                    this.Hide();
                    new Admin(u.AID).Show();
                }
                else
                {
                    this.Hide();
                    new FUserProfile(u.AID).Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void metroTextBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customize c1 = new Customize(u.AID);
            c1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox8_Click(object sender, EventArgs e)
        {

        }

        private void YourProfileInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
