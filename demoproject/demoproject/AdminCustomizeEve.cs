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
    public partial class AdminCustomizeEve : MetroFramework.Forms.MetroForm
    {
        string ID;
        public AdminCustomizeEve()
        {
            InitializeComponent();
        }
        public AdminCustomizeEve(string id)
        {
            this.ID = id;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdPreEvents a1 = new AdPreEvents(ID);
            a1.Show();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminUpcomingEvent ap2 = new AdminUpcomingEvent(ID);
            ap2.Show();

        }

        private void AdminCustomizeEve_Load(object sender, EventArgs e)
        {

        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //this.Close();
            new FHome().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin a1 = new Admin(ID);
            a1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckSuggestionBox csb1 = new CheckSuggestionBox(ID);
            csb1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AdminCustomizeEve_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
