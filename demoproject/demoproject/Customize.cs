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
    public partial class Customize : MetroFramework.Forms.MetroForm
    {
        string ID;
        Database db = new Database();
        public Customize()
        {
            
            InitializeComponent();
            /*var pos1 = this.PointToScreen(label1.Location);
            pos1 = pictureBox1.PointToClient(pos1);
            label1.Parent = pictureBox1;
            label1.Location = pos1;
            label1.BackColor = Color.Transparent;

            var pos2 = this.PointToScreen(label2.Location);
            pos2 = pictureBox1.PointToClient(pos2);
            label2.Parent = pictureBox1;
            label2.Location = pos2;
            label2.BackColor = Color.Transparent;

            var pos3 = this.PointToScreen(label3.Location);
            pos3 = pictureBox1.PointToClient(pos3);
            label3.Parent = pictureBox1;
            label3.Location = pos3;
            label3.BackColor = Color.Transparent;

            var pos4 = this.PointToScreen(label4.Location);
            pos4 = pictureBox1.PointToClient(pos4);
            label4.Parent = pictureBox1;
            label4.Location = pos4;
            label4.BackColor = Color.Transparent;*/
        }
        public Customize(string s)
        {
            this.ID = s;
            InitializeComponent();
        }
        private void Customize_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.DetectAdmin(ID))
                {
                    this.Hide();
                    new Admin(ID).Show();
                }
                else
                {
                    FUserProfile y = new FUserProfile(ID);  // profile info backing
                    y.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            YourProfileInfo y1 = new YourProfileInfo(ID);
            this.Hide();
            y1.Show();
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //this.Close();
            new FHome().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            changepass c1 = new changepass(ID);
            c1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            if (textBox2.Text.Trim()!="")
            {
                string s1 = "update Member set Contact = " + textBox2.Text +" where AIUB_ID = " +ID;
                //MessageBox.Show(s1);
                db.update(s1);
                MessageBox.Show("Succuessfully updated");
                textBox2.Text = "";

            }
           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customize_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
