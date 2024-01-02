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
 
    public partial class AdminRegistration : Form
    {
        dsApplianceTableAdapters.Admin_ListTableAdapter adl = new dsApplianceTableAdapters.Admin_ListTableAdapter(); //Connecting the dataset
        public AdminRegistration()
        {
            InitializeComponent();
        }

        private void AdmAutoID() // Method fot auto insertion of ID of admin
        {
            DataTable dte = new DataTable();
            dte = adl.GetData();
            if (dte.Rows.Count == 0)
            {
                txtAdmID.Text = "A001";
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
                        txtAdmID.Text = "A00" + (newid + 1);
                    }
                    else if (newid >= 10 && newid <= 99)
                    {
                        txtAdmID.Text = "A0" + (newid + 1);
                    }
                    else if (newid >= 100 && newid <= 999)
                    {
                        txtAdmID.Text = "A" + (newid + 1);
                    }

                }
            }
        }
        private void AdminRegistration_Load(object sender, EventArgs e) 
        {
            AdmAutoID(); //Calling auto ID method on the form load
            txtAdmID.Enabled = false; //disabling the text box for unique ID entry
        }

        private void btngtLogin_Click(object sender, EventArgs e) 
        {
            AdminLogin al = new AdminLogin(); //Directing to the login page when the user clicks the 'Go to Login' button
            al.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtAdmName.Text = "";
            txtAdmUsername.Text = " ";
            txtAdmPsw.Text= " ";
            txtAdmSalary.Text = "";
            txtAdmPh.Text = "";
            txtAdmEmail.Text = " ";
            txtAdmAddress.Text = "";

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            clsAdm ca = new clsAdm(); //connceting with class that receives and returns the values
            ca.display();
            int anm = Convert.ToInt32(txtAdmName.Text.Length);
            int ausn = Convert.ToInt32(txtAdmUsername.Text.Length);
            int apw = Convert.ToInt32(txtAdmPsw.Text.Length);
            int salr = Convert.ToInt32(txtAdmSalary.Text.Length);
            int aph = Convert.ToInt32(txtAdmPh.Text.Length);
            int amll = Convert.ToInt32(txtAdmEmail.Text.Length);
            int aadd = Convert.ToInt32(txtAdmAddress.Text.Length);

            if ( anm == 0)
            {
                MessageBox.Show("Enter full information", "Admin Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtAdmName.Focus();
            }

            else if ( ausn == 0)
            {

                MessageBox.Show("Enter full information", "Admin Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtAdmUsername.Focus();
            }

            else if (apw == 0)
            {
                MessageBox.Show("Enter full information", "Admin Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtAdmPsw.Focus();
            }
            else if (apw < 8)
            {
                MessageBox.Show("Invalid password entry", "Admin Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (apw > 16)
            {
                MessageBox.Show("Invalid password entry", "Admin Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (!txtAdmPsw.Text.Any(ch => char.IsUpper(ch)) || !txtAdmPsw.Text.Any(ch => char.IsLower(ch)))
            {
                MessageBox.Show("Password must contain at least one upper case letter and one lower case letter.", "Admin Register", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtAdmPsw.SelectAll();
                txtAdmPsw.Focus();
            }
            else if (salr == 0)
            {
                MessageBox.Show("Enter full information", "Admin Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtAdmSalary.Focus();
            }
            else if (aph == 0)
            {
                MessageBox.Show("Enter full information", "Admin Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtAdmPh.Focus();
            }

            else if (amll == 0)
            {
                MessageBox.Show("Enter full information", "Admin Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtAdmEmail.Focus();
            }

            else if (aadd == 0)
            {
                MessageBox.Show("Enter full information", "Admin Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtAdmAddress.Focus();
            }

          
            else if (dtpDOB.Value == null)
            {
                MessageBox.Show("Enter full information", "Admin Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                dtpDOB.Focus();
            }
            else
            {
                int i;
                String DOB;
                ca.AdmID = txtAdmID.Text;
                ca.AdmName = txtAdmName.Text;
                ca.AdmUsn = txtAdmUsername.Text;
                ca.AdmPsw = txtAdmPsw.Text;
                ca.AdmPh = txtAdmPh.Text;
                ca.AdmEml = txtAdmEmail.Text;
                ca.AdmAdd = txtAdmAddress.Text;
                ca.AdmSalary = txtAdmSalary.Text;
                DOB = dtpDOB.Value.ToString(); // assigning data from the text boxes to the class's variables for returning

                i = adl.Insert(ca.AdmID, ca.AdmName, ca.AdmUsn, ca.AdmPsw, ca.AdmPh, ca.AdmEml, ca.AdmAdd, ca.AdmSalary, Convert.ToDateTime(DOB)); // inserting data
                if (i > 0)
                {
                    MessageBox.Show("Admin Registration Completed", "Admin Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid Entry", "Admin Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            } //checking conditions of data entry
           
        }
    }
}