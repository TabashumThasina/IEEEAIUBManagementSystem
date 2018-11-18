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
    public partial class CheckSuggestionBox : MetroFramework.Forms.MetroForm
    {
        string id;
        Database db = new Database();
        public CheckSuggestionBox()//constructor
        {
            InitializeComponent();
        }
        public CheckSuggestionBox(string ID)
        {
            this.id = ID;
            InitializeComponent();
            dataGridView1 = db.Eventview(dataGridView1, "select * from Event");
        }

        private void CheckSuggestionBox_Load(object sender, EventArgs e)
        {

        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)//logout
        {
            //this.Close();
            new FHome().Show();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin a20 = new Admin(id);
            a20.Show();
        }// back to admin dashboard

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)//deleteing suggestion of a specific member
        {
             db.delete(this.textBox1.Text, "Event","AIUB_ID");
            dataGridView1 = db.Eventview(dataGridView1, "select * from Event");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CheckSuggestionBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
