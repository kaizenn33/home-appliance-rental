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
    public partial class CustomerLogin : Form
    {
        dsCustomerTableAdapters.CustomerTableAdapter cta = new dsCustomerTableAdapters.CustomerTableAdapter();//connecting dataset
        public static string CustID, CustNm;
        int count = 0;
        private void ClearData() //method to clear data
        {
            txtCustUsername.Text = " ";
            txtCustPsw.Text = " ";
        }
        public CustomerLogin()
        {
            InitializeComponent();
        }

        private void CustomerLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData(); // recalling the pre-defined method
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int cun = Convert.ToInt32(txtCustUsername.Text.Length);
            int cpw = Convert.ToInt32(txtCustPsw.Text.Length);

            if (cun == 0)
            {
                MessageBox.Show("Enter username", "Customer Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }// checking condition, button disabled
            else if (cpw == 0)
            {
                MessageBox.Show("Enter Password", "Customer Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (count >= 3)
            {
                MessageBox.Show("Fail Attempts of Login", "Customer Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                this.Close();
                MainPage m = new MainPage();
                m.Show();
            }
            else
            {
                string Username, Password;
                Username = txtCustUsername.Text;
                Password = txtCustPsw.Text;
                DataTable dt = new DataTable();
                dt = cta.CheckLoginCust(Username, Password);
                if (dt.Rows.Count > 0)
                {
                    CustID = dt.Rows[0][0].ToString();
                    CustNm = dt.Rows[0][1].ToString();

                    btnSubmit.Enabled = true;
                    MessageBox.Show("Login Successful", "Customer Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    CustomerHome ch = new CustomerHome();
                    ch.Show();
                    this.Close();
                }
                else
                {
                    count += 1;
                    MessageBox.Show("Invalid Login", "Customer Login Form", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            } //Receiving Username and Password to the conencted database using data table
        }
    }
}
