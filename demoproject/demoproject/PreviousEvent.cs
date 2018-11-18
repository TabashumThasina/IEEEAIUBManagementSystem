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
    public partial class PreviousEvent : MetroFramework.Forms.MetroForm
    {
        string id;
        Database db = new Database();
        public PreviousEvent()
        {
            InitializeComponent();
        }

        public PreviousEvent(string ID)
        {
            this.id = ID;
            InitializeComponent();
            dataGridView1 = db.Eventview(dataGridView1, "select * from PreEvent1");
        }

        private void PreviousEvent_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Upcoming_Events u1 = new Upcoming_Events(id);
            u1.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FUserProfile f1 = new FUserProfile(id);
            f1.Show();
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //this.Close();
            new FHome().Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PreviousEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
