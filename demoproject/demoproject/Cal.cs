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
    public partial class Cal : MetroFramework.Forms.MetroForm
    {
        public Cal()
        {
            InitializeComponent();
        }

        private void Cal_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            new FUserProfile().Show();
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
            new FHome().Show();
        }
    }
}
