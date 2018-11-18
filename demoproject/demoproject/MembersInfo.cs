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
    public partial class MembersInfo : MetroFramework.Forms.MetroForm
    {
        string ID;
        static bool searched = false;
        Database db = new Database();
        public MembersInfo()
        {
            InitializeComponent();
        }
        public MembersInfo(string id)
        {
            this.ID = id;
            InitializeComponent();
            dataGridView1 = db.Eventview(dataGridView1, "select * from Member");
        }

        private void MembersInfo_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            Admin a15 = new Admin(ID);
            a15.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMemberApproval m16 = new AdminMemberApproval();
            m16.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.TrimEnd() != "")
            {
                string s = " select * from Member where AIUB_ID = " + textBox1.Text.TrimEnd();
                if(db.loginsearch(s))
                {
                    dataGridView2 = db.Eventview(dataGridView2, "select * from Member where AIUB_ID = " + textBox1.Text.TrimEnd());
                    searched = true;
                }
                else
                {
                    MessageBox.Show("Not found");
                }
            }
            else
            {
                MessageBox.Show("Please first search");
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (searched)
            {
                
                db.delete(textBox1.Text.TrimEnd(), "Member", "AIUB_ID");
                dataGridView1 = db.Eventview(dataGridView1, "select * from Member");
                MessageBox.Show("Succesfully Deleted");
            }
            else
            {
                MessageBox.Show("Search First");
            }
        }

        private void MembersInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
    }
}
