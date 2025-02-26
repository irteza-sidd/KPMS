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
    public partial class Transition : Form
    {
        public Transition()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if(panel2.Width >=703)
            {
                timer1.Stop();
                Home obj = new Home();
                Hide();
                obj.Tag = this;
                obj.Location = this.Location;
                obj.Show(this);
            }
        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Transition_Load(object sender, EventArgs e)
        {

        }
    }
}
