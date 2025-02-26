using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiet_Parking_sys
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void Home_button_Click(object sender, EventArgs e)
        {

            Home obj4 = new Home();
            Hide();
            obj4.Tag = this;
            obj4.StartPosition = FormStartPosition.Manual;
            obj4.Location = this.Location;
            obj4.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void About_buuton_Click(object sender, EventArgs e)
        {

            About obj = new About();
            Hide();
            obj.Tag = this;
            obj.StartPosition = FormStartPosition.Manual;
            obj.Location = this.Location;
            obj.Show(this);
        }

        private void Developer_button_Click(object sender, EventArgs e)
        {
            Developer obj = new Developer();
            Hide();
            obj.Tag = this;
            obj.StartPosition = FormStartPosition.Manual;
            obj.Location = this.Location;
            obj.Show(this);

        }

        private void Help_button_Click(object sender, EventArgs e)
        {

            Contact_Us obj = new Contact_Us();
            Hide();
            obj.Tag = this;
            obj.StartPosition = FormStartPosition.Manual;
            obj.Location = this.Location;
            obj.Show(this);
        }
    }
}
