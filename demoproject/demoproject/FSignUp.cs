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
    public partial class FSignUp : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        public FSignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FHome l = new FHome();
            l.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            
            
            if (metroTextBox6.Text.Equals(metroTextBox9.Text)&& (metroTextBox9.Text.IndexOf(' ') == -1))
            {
              //  MessageBox.Show(metroTextBox1.Text + " , " + metroTextBox2.Text + " , " + metroTextBox3.Text + " , " + metroTextBox4.Text + " , " + metroTextBox11.Text + " , " + metroTextBox12.Text + " , " + metroTextBox7.Text + " , " + dateTimePicker1.Text + " , " + comboBox1.SelectedIndex);
                if (metroTextBox1.Text==""|| metroTextBox2.Text==""|| metroTextBox3.Text == ""|| metroTextBox4.Text == ""|| metroTextBox11.Text == ""|| metroTextBox12.Text == ""||metroTextBox7.Text==""||dateTimePicker1.Text==""||comboBox1.SelectedIndex<-1||listBox1.SelectedIndex<-1)
                {
                    MessageBox.Show("Fill the Form Properly");
                    metroTextBox6.Text = "";
                    metroTextBox9.Text = "";
                }
                /*else if(metroCheckBox1.Checked==false)
                {
                    MessageBox.Show("Terms and condition");
                    metroTextBox6.Text = "";
                    metroTextBox9.Text = "";
                }*/
                else
                {
                    //string s = "insert into Member (FirstName,LastName,AIUB_ID,IEEE_ID,Dept,Gender,DOB,Password,Contact,MembershipType,Email) values ('" + metroTextBox1.Text + "','" + metroTextBox2.Text + "','" + metroTextBox3.Text + "','" + metroTextBox4.Text + "','" + metroTextBox7.Text + "','" +comboBox1.Text+"','"+ dateTimePicker1.Text + "','" + metroTextBox9.Text + "','" + metroTextBox11.Text + "','" + metroTextBox12.Text + "','" + listBox1.Text + "');";
                    string s = "insert into MemberApproval (FirstName,LastName,AIUB_ID,IEEE_ID,Dept,Gender,DOB,Password,Contact,MembershipType,Email) values ('" + metroTextBox1.Text.TrimEnd() + "','" + metroTextBox2.Text.TrimEnd() + "','" + metroTextBox3.Text.TrimEnd() + "','" + metroTextBox4.Text.TrimEnd() + "','" + metroTextBox7.Text.TrimEnd() + "','" + comboBox1.Text + "','" + dateTimePicker1.Value.Date+ "','" + metroTextBox9.Text.TrimEnd() + "','" + metroTextBox11.Text.TrimEnd() + "','" + metroTextBox12.Text.TrimEnd() + "','" + listBox1.Text + "');";
                    db.insertMember(s);
                    MessageBox.Show("Successfully Request is Sent to Admin. You will be Confirmed via Mail or Contact number");
                    new FLogin().Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Error");
                metroTextBox6.Text = "";
                metroTextBox9.Text = "";

            }

        }

        private void metroTextBox6_Click(object sender, EventArgs e)
        {

        }


        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void metroTextBox12_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox11_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox9_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroRadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroRadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel12_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox7_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
