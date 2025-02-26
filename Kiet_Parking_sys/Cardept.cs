using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Microsoft.Reporting.WinForms;

namespace Kiet_Parking_sys
{
    public partial class Cardept : Form
    {
        public Cardept()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BusinessLayer obj31 = new BusinessLayer();
            int a=obj31.DepartureofCar(textBox1.Text, textBox2.Text, textBox4.Text);
            if (a == 0)
            {
                MessageBox.Show("Car Departured");
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

        private void Home_button_Click(object sender, EventArgs e)
        {
            Home obj9 = new Home();
            Hide();
            obj9.Tag = this;
           
            obj9.Show(this);
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

        private void Help_button_Click(object sender, EventArgs e)
        {
            Contact_Us obj = new Contact_Us();
            Hide();
            obj.Tag = this;

            obj.Show(this);
        }
    }
}
