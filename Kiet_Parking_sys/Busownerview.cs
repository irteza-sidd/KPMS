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
    public partial class Busownerview : Form
    {
        public Busownerview()
        {
            InitializeComponent();
        }

        private void Busownerview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kPMSDataSet2.Businfo' table. You can move, or remove it, as needed.
            this.businfoTableAdapter1.Fill(this.kPMSDataSet2.Businfo);
            // TODO: This line of code loads data into the 'kPMSDataSet1.Businfo' table. You can move, or remove it, as needed.
            this.businfoTableAdapter.Fill(this.kPMSDataSet1.Businfo);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            Home obj15 = new Home();
            Hide();
            obj15.Tag = this;
           
            obj15.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Records obj14 = new Records();
            Hide();
            obj14.Tag = this;
          
            obj14.Show(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Home obj1 = new Home();
            Hide();
            obj1.Tag = this;
            
            obj1.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contact_Us obj = new Contact_Us();
            Hide();
            obj.Tag = this;

            obj.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            About obj = new About();
            Hide();
            obj.Tag = this;
            obj.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Developer obj = new Developer();
            Hide();
            obj.Tag = this;

            obj.Show(this);
        }
    }
}
