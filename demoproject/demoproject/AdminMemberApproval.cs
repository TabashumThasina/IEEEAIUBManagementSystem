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
    public partial class AdminMemberApproval : MetroFramework.Forms.MetroForm
    {
        static bool searched = false;
        string id;
        Database db = new Database();
        User u = new User();
        public AdminMemberApproval()
        {
            InitializeComponent();
        }
        public AdminMemberApproval(string id)
        {
            this.id = id;

            InitializeComponent();
            dataGridView1 = db.Eventview(dataGridView1, "select * from MemberApproval");
        }


        private void AdminMemberApproval_Load(object sender, EventArgs e)
        {

        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //this.Close();
            new FHome().Show();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin a17 = new Admin(id);
            a17.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MembersInfo m5 = new MembersInfo(id);
            m5.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (searched) 
            {
                // string s = "insert into Member (FirstName,LastName,AIUB_ID,IEEE_ID,Dept,Gender,Password,Contact,MembershipType,Email) values ('" + metroTextBox8.Text + "','" + metroTextBox7.Text + "','" + metroTextBox6.Text + "','" + metroTextBox5.Text + "','" + metroTextBox2.Text+ "','" +comboBox1.Text + "','" + textBox2.Text + "','" + metroTextBox4.Text + "','" + comboBox2.Text + "','" + metroTextBox1.Text +  "');";
                string s = "insert into Member (FirstName,LastName,AIUB_ID,IEEE_ID,Dept,Gender,Password,Contact,MembershipType,Email) values ('" + u.FName + "','" + u.LName + "','" + u.AID + "','" + u.IID + "','" + u.Department + "','" + u.gender + "','" + u.Password + "','" + u.Contact + "','" + u.MemberType + "','" + u.Email + "');";
                db.insertMember(s);
                db.delete(u.AID, "MemberApproval", "AIUB_ID");
                MessageBox.Show("Member Added and Please infor your member the update");
                searched = false;
                textBox1.Text = "";
                dataGridView1 = db.Eventview(dataGridView1, "select * from MemberApproval");
            }
           else
            {
                MessageBox.Show("Search First");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.TrimEnd() != "")
            {
                string s = "select * from MemberApproval where AIUB_ID = " + textBox1.Text;
                if (db.loginsearch(s))
                {
                    u = db.MemberApproval(u, textBox1.Text);
                    metroTextBox8.Text = u.FName;
                    metroTextBox7.Text = u.LName;
                    metroTextBox6.Text = u.AID;
                    metroTextBox5.Text = u.IID;
                    metroTextBox1.Text = u.Email;
                    metroTextBox4.Text = u.Contact;
                    comboBox1.Text = u.gender;
                    comboBox2.Text = u.MemberType;
                    textBox2.Text = u.Password;
                    metroTextBox2.Text = u.Department;
                    searched = true;

                }
                else
                {
                    MessageBox.Show("Not Found");
                }

            }
            else
            {
                MessageBox.Show("Enter AIUB_ID TO search");
            }
            
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (searched)
            {
                
                db.delete(u.AID, "MemberApproval", "AIUB_ID");
                MessageBox.Show("Member Declined and please inform member the update");
                searched = false;
                textBox1.Text = "";
                dataGridView1 = db.Eventview(dataGridView1, "select * from MemberApproval");
            }
            else
            {
                MessageBox.Show("Search First");
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void AdminMemberApproval_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
