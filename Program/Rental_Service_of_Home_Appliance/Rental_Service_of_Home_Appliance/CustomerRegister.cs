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
    public partial class CustomerRegister : Form
    {
        dsCustomerTableAdapters.CustomerTableAdapter cust = new dsCustomerTableAdapters.CustomerTableAdapter();// connecting with customer dataset
        public string cnm1;
        public CustomerRegister()
        {
            InitializeComponent();
        }

        private void CustomerRegister_Load(object sender, EventArgs e)
        {
            CustAutoID();
            txtCustID.Enabled = false;
        }

        private void CustAutoID() // auto id method for customer
        {
            DataTable dte = new DataTable();
            dte = cust.GetData();
            if (dte.Rows.Count == 0)
            {
                txtCustID.Text = "C001";
            }
            else
            {

                if (dte.Rows.Count > 0)
                {
                    int size = dte.Rows.Count - 1;
                    string oldid = dte.Rows[size][0].ToString();
                    int newid = Convert.ToInt32(oldid.Substring(1, 3));
                    if (newid >= 1 && newid <= 9)
                    {
                        txtCustID.Text = "C00" + (newid + 1);
                    }
                    else if (newid >= 10 && newid <= 99)
                    {
                        txtCustID.Text = "C0" + (newid + 1);
                    }
                    else if (newid >= 100 && newid <= 999)
                    {
                        txtCustID.Text = "C" + (newid + 1);
                    }

                }
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btngtLogin_Click(object sender, EventArgs e)
        {
            CustomerLogin cl = new CustomerLogin(); // directing the customer login when Login button is clicked
            cl.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustName.Text = "";
            txtCustUsername.Text = " ";
            txtCustPsw.Text = " ";
            txtCustPh.Text = "";
            txtCustEmail.Text = "";
            txtCustAddress.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            clsCustReg cr = new clsCustReg(); // calling get and set class
            cr.display();
            dsCustomerTableAdapters.CustomerTableAdapter cus = new dsCustomerTableAdapters.CustomerTableAdapter();

            int length = txtCustPsw.Text.Length; // variable for length of customer password
            int cname = Convert.ToInt32(txtCustName.Text.Length);
            int cunmae = Convert.ToInt32(txtCustUsername.Text.Length);
            int cpsw = Convert.ToInt32(txtCustPsw.Text.Length);
            int cph = Convert.ToInt32(txtCustPh.Text.Length);
            int cem = Convert.ToInt32(txtCustEmail.Text.Length);
            int cadd = Convert.ToInt32(txtCustAddress.Text.Length);


            if (cname == 0)
            {
                MessageBox.Show("Enter full info", "Customer Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (cunmae == 0)
            {
                MessageBox.Show("Enter full info", "Customer Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            else if (cpsw == 0)
            {
                MessageBox.Show("Enter full info", "Customer Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (length < 8)
            {
                MessageBox.Show("Invalid Password", "Customer Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (length > 16)
            {
                MessageBox.Show("Invalid Password", "Customer Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (!txtCustPsw.Text.Any(ch => char.IsUpper(ch)) || !txtCustPsw.Text.Any(ch => char.IsLower(ch)))
            {
                MessageBox.Show("Password must contain at least one upper case letter and one lower case letter.", "Admin Register", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtCustPsw.SelectAll();
                txtCustPsw.Focus();
            }
            else if (cph == 0)
            {
                MessageBox.Show("Enter full info", "Customer Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (cem == 0)
            {
                MessageBox.Show("Enter full info", "Customer Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (cadd == 0)
            {
                MessageBox.Show("Enter full info", "Customer Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Complete Registration", "Customer Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            //checking null

            cnm1 = txtCustName.Text.ToString();

            cr.CustID = txtCustID.Text;
           cr.CustName = txtCustName.Text;
            cr.CustUsername = txtCustUsername.Text;
            cr.CustPsw = txtCustPsw.Text;
           cr.Custph= txtCustPh.Text;
            cr.CustEmail = txtCustEmail.Text;
            cr.CustAddress = txtCustAddress.Text; //Receiving data from text box to variables

            cus.Insert(cr.CustID, cr.CustName, cr.CustUsername, cr.CustPsw, cr.Custph, cr.CustEmail,cr.CustAddress); //inserting data to dbs

           
        }
    }
}
