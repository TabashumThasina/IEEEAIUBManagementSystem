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
    public partial class changepass : MetroFramework.Forms.MetroForm
    {
        string ID;
        Database db = new Database();
        public changepass()
        {
            InitializeComponent();
            /*var pos1 = this.PointToScreen(label1.Location);
            pos1 = pictureBox2.PointToClient(pos1);
            label1.Parent = pictureBox2;
            label1.Location = pos1;
            label1.BackColor = Color.Transparent;

            var pos2 = this.PointToScreen(label2.Location);
            pos2 = pictureBox2.PointToClient(pos2);
            label2.Parent = pictureBox2;
            label2.Location = pos2;
            label2.BackColor = Color.Transparent;

            var pos3 = this.PointToScreen(label3.Location);
            pos3 = pictureBox2.PointToClient(pos3);
            label3.Parent = pictureBox2;
            label3.Location = pos3;
            label3.BackColor = Color.Transparent;*/
        }
        public changepass (string s)
        {
            this.ID = s;
            InitializeComponent();
        }
        private void changepass_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            //this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (textBox1.Text.Equals(textBox2.Text))
            {
                MessageBox.Show("Your new password has been saved");
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Not matched");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {*/

        }

        /*private void button4_Click(object sender, EventArgs e)
        {
            Customize y2 = new Customize();
            this.Hide();
            y2.Show();
        }*/

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (db.DetectPass(ID, textBox5.Text))    // dectecting matched with current password
            {
                if (textBox4.Text.Equals(textBox3.Text))        // matching confirm and new pass
                {
                    string s = "update Member set Password=" + textBox4.Text + "where AIUB_ID =" + ID; // changing in database
                    db.update(s);
                    MessageBox.Show("Your new password has been saved");
                    textBox4.Text = "";   // after changing pass form textbox is becoimg nill
                    textBox5.Text = "";
                    textBox3.Text = "";

                }
                else
                {
                    MessageBox.Show("Not matched");
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox3.Text = "";
                }
            }
            else
            {
                MessageBox.Show("invalid current password");
                textBox4.Text = "";
                textBox5.Text = "";
                textBox3.Text = "";
            }
           
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            FHome f1 = new FHome();
            f1.Show();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
                    Customize y2 = new Customize(ID);
                    this.Hide();
                    y2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
