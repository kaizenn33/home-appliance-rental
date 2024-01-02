using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_Service_of_Home_Appliance
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customerRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerRegister cr = new CustomerRegister(); //Directing to Customer Register Page
            cr.Show();
        }

        private void adminRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminRegistration ar = new AdminRegistration(); //Directing to Admin Register Page
            ar.Show();
        }

        private void customerLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerLogin cl = new CustomerLogin(); // Directing to Customer Login Page
            cl.Show();
        }

        private void adminLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminLogin al = new AdminLogin(); // Directing to Admin Login Page
            al.Show();
        }

        private void ez_Click(object sender, EventArgs e)
        {
          
            
        }
    }
}
