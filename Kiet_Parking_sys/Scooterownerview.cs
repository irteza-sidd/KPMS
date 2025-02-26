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
    public partial class Scooterownerview : Form
    {
        public Scooterownerview()
        {
            InitializeComponent();
        }

        private void Scooterownerview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kPMSDataSet3.Scooterinfo' table. You can move, or remove it, as needed.
            this.scooterinfoTableAdapter.Fill(this.kPMSDataSet3.Scooterinfo);

        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            Home obj15 = new Home();
            Hide();
            obj15.Tag = this;
            
            obj15.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Records obj14 = new Records();
            Hide();
            obj14.Tag = this;
           
            obj14.Show(this);
        }

        private void Home_button_Click_1(object sender, EventArgs e)
        {
            Home obj1 = new Home();
            Hide();
            obj1.Tag = this;
           
            obj1.Show(this);
        }

        private void Developer_button_Click(object sender, EventArgs e)
        {
            Developer obj = new Developer();
            Hide();
            obj.Tag = this;

            obj.Show(this);
        }

        private void About_buuton_Click(object sender, EventArgs e)
        {
            About obj = new About();
            Hide();
            obj.Tag = this;

            obj.Show(this);
        }

        private void Help_button_Click(object sender, EventArgs e)
        {
            Contact_Us obj = new Contact_Us();
            Hide();
            obj.Tag = this;

            obj.Show(this);
        }
    }
}
