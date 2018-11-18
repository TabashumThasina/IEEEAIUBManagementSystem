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
    public partial class AdPreEvents : MetroFramework.Forms.MetroForm
    {
        string ID;
        Database db = new Database();
        public AdPreEvents()
        {
            InitializeComponent();
        }
        public AdPreEvents(string id)
        {
            this.ID = id;
            InitializeComponent();
            dataGridView1 = db.Eventview(dataGridView1, "select * from PreEvent1");
        }

        private void AdPreEvents_Load(object sender, EventArgs e)
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
            AdminCustomizeEve a11 = new AdminCustomizeEve(ID);
            a11.Show();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin a12 = new Admin(ID);
            a12.Show();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminCustomizeEve(ID).Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin(ID).Show();
        }

        private void AdPreEvents_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
