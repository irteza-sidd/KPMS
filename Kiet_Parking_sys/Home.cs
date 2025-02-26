using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kiet_Parking_sys
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            customizedesign();
        }
        private void customizedesign()
        {
            carpanel.Visible = false;
            buspanel.Visible = false;
            scooterpanel.Visible = false;
        }
        private void hidesubmenu()
        {
            if(carpanel.Visible==true)
                carpanel.Visible = false;
            if (buspanel.Visible ==true)
             buspanel.Visible = false;
            if(scooterpanel.Visible ==true)
                scooterpanel.Visible = false;
        }
        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Help_button_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Scotter_button_Click(object sender, EventArgs e)
        {
            showsubmenu(scooterpanel);
        }

        private void Car_button_Click(object sender, EventArgs e)
        {
            showsubmenu(carpanel);
        }

        private void Logo_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            Carform obj1 = new Carform();
            Hide();
            obj1.Tag = this;
          
            
            obj1.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            Cardept obj8 = new Cardept();
            Hide();
            obj8.Tag = this;
           
           
            obj8.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            Busform obj2 = new Busform();
            Hide();
            obj2.Tag = this;
       
        
            obj2.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            BusDept obj10 = new BusDept();
            Hide();
            obj10.Tag = this;
         
            
            obj10.Show(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            Scooterform obj3 = new Scooterform();
            Hide();
            obj3.Tag = this;
          
            obj3.Show(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            ScooterDept obj11 = new ScooterDept();
            Hide();
            obj11.Tag = this;
          
           
            obj11.Show(this);
        }

        private void Bus_button_Click(object sender, EventArgs e)
        {
            showsubmenu(buspanel);
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            Home obj4 = new Home();
            Hide();
            obj4.Tag = this;
    
            
            obj4.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Records obj14 = new Records();
            Hide();
            obj14.Tag = this;
           
            obj14.Show(this);
        }

        private void About_buuton_Click(object sender, EventArgs e)
        {
            About obj = new About();
            Hide();
            obj.Tag = this;
          
           
            obj.Show(this);
        }

        private void Heading_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Developer_button_Click(object sender, EventArgs e)
        {
            Developer obj = new Developer();
            Hide();
            obj.Tag = this;
           
            obj.Show(this);
        }

        private void Help_button_Click_1(object sender, EventArgs e)
        {
            Contact_Us obj = new Contact_Us();
            Hide();
            obj.Tag = this;
          
            obj.Show(this);
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
