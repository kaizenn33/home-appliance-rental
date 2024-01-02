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
    public partial class AdminLogin : Form
    {
        dsApplianceTableAdapters.Admin_ListTableAdapter adl = new dsApplianceTableAdapters.Admin_ListTableAdapter(); // connceting the admin list dataset
        public static string adminID, adminNm; // variables for admin id and name
        int count = 0;
        private void ClearData()
        {
            txtAdmUsername.Text = " ";
            txtAdmPsw.Text = " ";
        } // method for clearing texts
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if  (txtAdmUsername.Text == " ")
            {
                MessageBox.Show("Please enter username", "Admin Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (txtAdmPsw.Text == " ")
            {
                MessageBox.Show("Please enter password", "Admin Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (count >= 3)
            {
                MessageBox.Show("Fail Attempts of Login", "Customer Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                MainPage m = new MainPage();
                m.Show();
            }
            else
            {
                string Username, Password;
                Username = txtAdmUsername.Text;
                Password = txtAdmPsw.Text;
                DataTable dt = new DataTable();
                dt = adl.CheckLoginAdm(Username, Password);
                if (dt.Rows.Count > 0)
                {
                    adminNm = dt.Rows[0][1].ToString();
                    adminID = dt.Rows[0][0].ToString(); // location in database

                    btnSubmit.Enabled = true;
                    MessageBox.Show("Login Successful", "Admin Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    AdminHome ah1 = new AdminHome();
                    ah1.Show();
                    this.Close();
                }
                else
                {
                    count += 1;
                    MessageBox.Show("Invalid Login Data", "Customer Login Form", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
