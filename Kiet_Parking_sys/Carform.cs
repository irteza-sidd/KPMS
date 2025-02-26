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
    public partial class Carform : Form
    {
        public Carform()
        {
            InitializeComponent();
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            Home obj5 = new Home();
            Hide();
            obj5.Tag = this;
           
            obj5.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BusinessLayer obj = new BusinessLayer();
            int a=obj.InsertCar(textBox1.Text, textBox2.Text, textBox4.Text, textBox3.Text, textBox5.Text, textBox6.Text,checkBox1.Checked, checkBox2.Checked, checkBox3.Checked);
            if (a == 0)
                MessageBox.Show("Car Is Already Parked");
            else
            {
                MessageBox.Show("Successfully Arrived");
                Home obj1 = new Home();
                Hide();
                obj1.Tag = this;
               
                obj1.Show(this);
            }
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
