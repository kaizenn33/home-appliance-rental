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
    public partial class CustomerHome : Form
    {
        dsApplianceTableAdapters.ApplianceTypeTableAdapter atd = new dsApplianceTableAdapters.ApplianceTypeTableAdapter(); // connecting dataset of appliance type
        dsApplianceTableAdapters.ViewAppTableAdapter vta = new dsApplianceTableAdapters.ViewAppTableAdapter(); // connecting dataset with view ViewApp
        dsApplianceTableAdapters.temptblTableAdapter tba = new dsApplianceTableAdapters.temptblTableAdapter(); // connecting dataset with temporary table
        public static string apid, apnm, aptid, brand, consump, monthlyc, avaqty; // global variables to be used in multiple pages and grid views
        public int rntqty, rntamt;
        public static int TotalAmt, TotalQty;
        
        public CustomerHome()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to log out?", "Customer Home", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            MainPage mp = new MainPage();
            mp.Show();
            this.Close();
        }

        public void Select_ApplianceType() // choosing appliance type method
        {
            DataTable dtb = new DataTable();
            dtb = atd.GetData();
            if (dtb.Rows.Count > 0)
            {
                DataRow R = dtb.NewRow();
                R[0] = 0;
                R[1] = "Choose Appliance Type";
                dtb.Rows.InsertAt(R, 0);
             cboCustAppType.DataSource = dtb;
                //cboServiceTypeID.DisplayMember= "Servicetype";
                cboCustAppType.ValueMember = "TypeName";
            }
        }

        private void CustomerHome_Load(object sender, EventArgs e)
        {
            Select_ApplianceType();
            dgvCustApp.DataSource = vta.GetData();
            btncustadd.Enabled = false;
        }

        private void dgvCustApp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncustadd_Click(object sender, EventArgs e) 
        {
            tba.Insert(apid, apnm, aptid, brand, consump, monthlyc, avaqty, Convert.ToInt32(rntqty), rntamt); // data insertion of temporary table
            RentAppliance ra = new RentAppliance(); // directing to Rent page
            ra.Show();
            this.Close();
        }

        private void btnCustShow_Click(object sender, EventArgs e)
        {
            string apptypenm = cboCustAppType.SelectedValue.ToString();
            DataTable dt = new DataTable();
            DataRow dr;
            dt = vta.CheckApplianceType(apptypenm);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dr = dt.NewRow();

                    dr["ApplianceID"] = dt.Rows[i][0].ToString();
                    dr["ApplianceName"] = dt.Rows[i][1].ToString();
                    dr["TypeName"] = dt.Rows[i][2].ToString();
                    dr["Brand"] = dt.Rows[i][3].ToString();
                    dr["Consumption"] = dt.Rows[i][4].ToString();
                    dr["MonthlyCost"] = dt.Rows[i][5].ToString();
                    dr["AvaiableQuantity"] = dt.Rows[i][6].ToString(); 

                    dgvCustApp.Refresh();
                    dgvCustApp.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Record Not Found");
            } // to show the selected appliance type on data grid view when the button Show is clicked
            
        
        }

        private void dgvCustApp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TotalAmt = 0;
            TotalQty = 0;

            rntqty = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter Appliance Quantity to Rent"));
            int index = dgvCustApp.CurrentCell.RowIndex;

            apid = dgvCustApp.Rows[index].Cells["ApplianceID"].Value.ToString();
            apnm = dgvCustApp.Rows[index].Cells["ApplianceName"].Value.ToString();
            aptid = dgvCustApp.Rows[index].Cells["TypeName"].Value.ToString();
            brand = dgvCustApp.Rows[index].Cells["Brand"].Value.ToString();
            consump = dgvCustApp.Rows[index].Cells["Consumption"].Value.ToString();
            monthlyc = dgvCustApp.Rows[index].Cells["MonthlyCost"].Value.ToString();
            avaqty = dgvCustApp.Rows[index].Cells["AvaiableQuantity"].Value.ToString();

            rntamt = Convert.ToInt32(rntqty) * Convert.ToInt32(monthlyc);

            TotalAmt += rntamt;
            TotalQty += rntqty;

            btncustadd.Enabled = true;
        } // Functions of renting on cell click. Total price, total quantity caculating included
    }
}
