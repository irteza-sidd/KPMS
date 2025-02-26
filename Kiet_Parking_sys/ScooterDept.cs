using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
namespace Kiet_Parking_sys
{
    public partial class ScooterDept : Form
    {
        public ScooterDept()
        {
            InitializeComponent();
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            Home obj13 = new Home();
            Hide();
            obj13.Tag = this;
       
            obj13.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BusinessLayer obj33 = new BusinessLayer();
            int a=obj33.DepartureofScooter(textBox1.Text, textBox2.Text, textBox4.Text);
            if (a == 0)
            {
                MessageBox.Show("Scooter Departured");
                Home obj1 = new Home();
                Hide();
                obj1.Tag = this;
                obj1.Show(this);
                Showinvoiceform obj = new Showinvoiceform(textBox4.Text);
                obj.Show();
            }
            else
                MessageBox.Show("Data not found");
        }

        private void SideMenu_panael_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Help_button_Click(object sender, EventArgs e)
        {
            Contact_Us obj = new Contact_Us();
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

        private void Developer_button_Click(object sender, EventArgs e)
        {
            Developer obj = new Developer();
            Hide();
            obj.Tag = this;

            
            obj.Show(this);
        }
    }
}
