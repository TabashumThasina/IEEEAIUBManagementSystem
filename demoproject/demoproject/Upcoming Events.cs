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
    public partial class Upcoming_Events : MetroFramework.Forms.MetroForm
    {
        string ID;
        Database db = new Database();
        public Upcoming_Events()
        {
            InitializeComponent();
        }
        public Upcoming_Events(string id)
        {
            this.ID = id;
            InitializeComponent();
            dataGridView1 = db.Eventview(dataGridView1,"select * from UpcomingEvent order by Date");


        }

        private void Upcoming_Events_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FUserProfile(ID).Show();
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
            new FHome().Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //this.Close();
            new FHome().Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PreviousEvent p1 = new PreviousEvent();
            p1.Show();
        }
        
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Upcoming_Events_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
