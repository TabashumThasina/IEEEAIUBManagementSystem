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
    public partial class Suggestion : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        string ID;
        public Suggestion()
        {
            InitializeComponent();
        }
         public Suggestion(string ID)
        {
            this.ID= ID;
            InitializeComponent();
        }


        private void Suggestion_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            this.Hide();
            new FUserProfile(ID).Show();
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //this.Close();
            new FHome().Show();
        }

        private void Sent_Click(object sender, EventArgs e)
        {

            string s;
            if (comboBox1.Text.Equals("Yes"))
            {
                if (metroTextBox2.Text != "" && metroTextBox4.Text != "")
                {
                    s = " insert into Event (AIUB_ID,PersonalSug,EventTopic,Target,Speaker,Designation)values('" + ID + "','" + metroTextBox1.Text + "','" + metroTextBox3.Text + "','" + metroTextBox6.Text + "','" + metroTextBox4.Text + "','" + metroTextBox2.Text + "');";
                    db.insertMember(s);
                    MessageBox.Show("Successfully sent");
                }
                else
                {
                    MessageBox.Show("Please enter the speaker's detail");
                }
            }
            else
            {
                s = " insert into Event (AIUB_ID,PersonalSug,EventTopic,Target)values('" + ID + "','" + metroTextBox1.Text + "','" + metroTextBox3.Text + "','" + metroTextBox6.Text + "');";
                db.insertMember(s);
                MessageBox.Show("Successfully sent");
            }
            metroTextBox1.Text = "";
            metroTextBox2.Text = "";
            metroTextBox3.Text = "";
            metroTextBox4.Text = "";
            metroTextBox6.Text = "";
            comboBox1.Text = "";

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox6_Click(object sender, EventArgs e)
        {

        }

        private void Suggestion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
