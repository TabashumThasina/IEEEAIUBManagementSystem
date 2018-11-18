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
    public partial class Admin : MetroFramework.Forms.MetroForm
    {
        string ID;
        public Admin()
        {
            InitializeComponent();
        }
        public Admin(string id)
        {
            this.ID = id;
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new CheckSuggestionBox(ID).Show();
            this.Hide();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            new MembersInfo(ID).Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AdminCustomizeEve a1 = new AdminCustomizeEve(ID);
            a1.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            FHome fh1 = new FHome();
            fh1.Show();
            
            /*this.Close();
            new FHome().Show();*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMemberApproval m18 = new AdminMemberApproval(ID);
            m18.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new YourProfileInfo(ID).Show(); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
