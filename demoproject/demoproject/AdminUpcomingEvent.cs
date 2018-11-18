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
    public partial class AdminUpcomingEvent : MetroFramework.Forms.MetroForm
    {
        string ID;
        Database db = new Database();
        public AdminUpcomingEvent()
        {
            InitializeComponent();
        }//constructer
        public AdminUpcomingEvent(string id)
        {
            this.ID = id;
            InitializeComponent();
            dataGridView1 = db.Eventview(dataGridView1, "select * from UpcomingEvent");
        }
        private void AdminUpcomingEvent_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e) //adding
        {
            if (textBox1.Text.TrimEnd() != "")
            {
                string s1 = "select * from UpcomingEvent where id = " + textBox1.Text.TrimEnd();
                if (db.loginsearch(s1) == false)
                {
                    string s = "insert into UpcomingEvent values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "');";
                    db.insertMember(s);
                    dataGridView1 = db.Eventview(dataGridView1, "select * from UpcomingEvent ");
                }
                else
                {
                    MessageBox.Show("This Event Id is already exist. Please Enter an Unique ID");
                }

            }
            else
            {
                MessageBox.Show("Please Enter the Event ID");
            }


        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e) //logout
        {
            //this.Close();
            new FHome().Show();
        }

        private void metroButton5_Click(object sender, EventArgs e) //customize event
        {
            this.Hide();
            AdminCustomizeEve a5 = new AdminCustomizeEve(ID);
            a5.Show();
        }

        private void metroButton6_Click(object sender, EventArgs e) // back to admin dashboard
        {
            this.Hide();
            Admin a6 = new Admin(ID);
            a6.Show();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Data has been Saved");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }

        private void metroButton3_Click(object sender, EventArgs e) //deleting an event
        {
            
            if (textBox1.Text.TrimEnd() != "")
            {
                string s = "select * from UpcomingEvent where id =" + textBox1.Text.TrimEnd();
                if (db.loginsearch(s))
                {
                    db.delete(this.textBox1.Text, "UpcomingEvent", "id");
                    dataGridView1 = db.Eventview(dataGridView1, "select *from UpcomingEvent");
                }
                else
                {
                    MessageBox.Show("Not Found to Delete");
                }

            }
            else
            {
                MessageBox.Show("Please Enter Enter ID");
            }
            
            
        }

        private void metroButton2_Click(object sender, EventArgs e) ///updating event details
        {
            string s = "select * from UpcomingEvent where id =" + textBox1.Text.Trim();
            if (textBox1.Text.Trim() != "")
            {
                if (db.loginsearch(s))
                {
                    s = "update UpcomingEvent set EventTitle = ' " + textBox2.Text.TrimEnd() + "',Venue='" + textBox3.Text.TrimEnd() + "',Date='" + textBox4.Text.TrimEnd() + "',RegFee ='" + textBox5.Text.TrimEnd() + "' where id ='" + textBox1.Text.TrimEnd() + "';";
                    db.update(s);
                    dataGridView1 = db.Eventview(dataGridView1, "select * from UpcomingEvent");

                }
                else
                {
                    MessageBox.Show("Not found");
                }

            }
            else
            {
                MessageBox.Show("Please enter the event id");
            }
          
                    

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                db.addtopreevent(this.textBox1.Text);
                dataGridView1 = db.Eventview(dataGridView1, "select * from UpcomingEvent");

            }
            else
            {
                MessageBox.Show("Please Enter the event id");
            }
          
        }

        private void AdminUpcomingEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
