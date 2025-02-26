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
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            BusinessLayer obj45 = new BusinessLayer();
            string a = obj45.vehicleswash();
            MessageBox.Show("Washed Vehicles : " + a.ToString());
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            Home obj15 = new Home();
            Hide();
            obj15.Tag = this;
           
            obj15.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BusinessLayer obj44 = new BusinessLayer();
            string a=obj44.TotalNoOfVehicles();
            MessageBox.Show("Total Vehicles: "+a.ToString());   
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BusinessLayer obj45 = new BusinessLayer();
            string a = obj45.CarsAmountCollected();
            MessageBox.Show("Cars Amount Collected : " + a.ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Carownerview obj = new Carownerview();
            Hide();
            obj.Tag = this;
         
            obj.Show(this);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Busownerview obj = new Busownerview();
            Hide();
            obj.Tag = this;
            
            obj.Show(this);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Scooterownerview obj = new Scooterownerview();
            Hide();
            obj.Tag = this;
            
            obj.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BusinessLayer obj45 = new BusinessLayer();
            string a = obj45.Noofcars();
            MessageBox.Show("Number of cars : " + a.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BusinessLayer obj45 = new BusinessLayer();
            string a = obj45.Noofbuses();
            MessageBox.Show("Number of buses : " + a.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BusinessLayer obj45 = new BusinessLayer();
            string a = obj45.Noofscooters();
            MessageBox.Show("Number of scooters : " + a.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BusinessLayer obj45 = new BusinessLayer();
            string a = obj45.BusesAmountCollected();
            MessageBox.Show("Buses Amount Collected : " + a.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
          BusinessLayer obj45 = new BusinessLayer();
            string a = obj45.ScootersAmountCollected();
            MessageBox.Show("Scooters Amount Collected : " + a.ToString());
        
        }

        private void button13_Click(object sender, EventArgs e)
        {
            BusinessLayer obj45 = new BusinessLayer();
            string a = obj45.vehicleshade();
            MessageBox.Show("Shaded Vehicles : " + a.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BusinessLayer obj45 = new BusinessLayer();
            string a = obj45.allcash();
            MessageBox.Show("Total Cash Collected : " + a.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Showinvoiceform obj = new Showinvoiceform();
            obj.Tag = this;
         
            obj.Show(this);
        }

        private void SideMenu_panael_Paint(object sender, PaintEventArgs e)
        {

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

        private void Developer_button_Click(object sender, EventArgs e)
        {
            Developer obj = new Developer();
            Hide();
            obj.Tag = this;
            
            obj.Show(this);
        }
    }
}
