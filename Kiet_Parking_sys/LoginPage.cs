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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Login_page_pic_Click(object sender, EventArgs e)
        {

        }

        private void icon2_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            BusinessLayer obj1 = new BusinessLayer();
            int a=obj1.log(Email_text.Text, Pass_text.Text);
            if (a == 1)
            {
                Transition obj2 = new Transition();
                Hide();
                obj2.Tag = this;
                obj2.Location = this.Location;
                obj2.Show(this);
                
            }
            else
                MessageBox.Show("Check your username or passsword !"); 
        }

        private void Email_text_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Username_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
