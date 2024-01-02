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
    public partial class AdminHome : Form
    {
        dsApplianceTableAdapters.Admin_ListTableAdapter adl = new dsApplianceTableAdapters.Admin_ListTableAdapter(); // connceting to admi list dataset
        dsApplianceTableAdapters.ApplianceTypeTableAdapter at = new dsApplianceTableAdapters.ApplianceTypeTableAdapter(); //connecting to appliance type dataset
        dsApplianceTableAdapters.ApplianceTableAdapter ata = new dsApplianceTableAdapters.ApplianceTableAdapter(); //connecting to appliance dataset
        dsApplianceTableAdapters.InventoryTableAdapter ita = new dsApplianceTableAdapters.InventoryTableAdapter(); //connecting to inventory dataset
        dsApplianceTableAdapters.MaintenanceTableAdapter mta = new dsApplianceTableAdapters.MaintenanceTableAdapter(); //connecting to maintenance dataset
        dsApplianceTableAdapters.Rent1TableAdapter r1ta = new dsApplianceTableAdapters.Rent1TableAdapter(); //connceting to rent

        DataTable dtrnt = new DataTable();
        DataRow drrnt;

        string mtnstt;
        public AdminHome()
        {
            
            InitializeComponent();

        }
        public void Select_ApplianceType() //method for choosing appliance type names in appliance 
        {
            DataTable dtb = new DataTable();
            dtb = at.GetData();
            if (dtb.Rows.Count > 0)
            {
                DataRow R = dtb.NewRow();
                R[0] = 0;
                R[1] = "Choose Appliance Type";
                dtb.Rows.InsertAt(R, 0);
                cboAppType.DataSource = dtb;
                //cboServiceTypeID.DisplayMember= "Servicetype";
                cboAppType.ValueMember = "TypeName";
            }
        }
        private void ApplianceAutoID()// method for auto id for appliance
        {
            DataTable dte = new DataTable();
            dte = ata.GetData();
            if (dte.Rows.Count == 0)
            {
                txtappid.Text = "A001";
            }
            else
            {

                if (dte.Rows.Count > 0)
                {
                    int size = dte.Rows.Count - 1;
                    string oldid = dte.Rows[size][0].ToString();
                    int newid = Convert.ToInt32(oldid.Substring(2, 2));
                    if (newid >= 10 && newid <= 99)
                    {
                        txtappid.Text = "A0" + (newid + 1);
                    }
                }
            }
        }
        private void ApplianceTypeIDAuto() /// method for appliance type auto id
        {
            DataTable dte = new DataTable();
            dte = at.GetData();
            if (dte.Rows.Count == 0)
            {
                txtATID.Text = "AT001";
            }
            else
            {

                if (dte.Rows.Count > 0)
                {
                    int size = dte.Rows.Count - 1;
                    string oldid = dte.Rows[size][0].ToString();
                    int newid = Convert.ToInt32(oldid.Substring(2, 3));
                    if (newid >= 1 && newid <= 9)
                    {
                        txtATID.Text = "AT00" + (newid + 1);
                    }
                }
            }
        }

        private void MaintenanceIDAuto() //method for maintenance auto id
        {
            DataTable dte = new DataTable();
            dte = mta.GetData();
            if (dte.Rows.Count == 0)
            {
                txtmtnid.Text = "MT001";
            }
            else
            {

                if (dte.Rows.Count > 0)
                {
                    int size = dte.Rows.Count - 1;
                    string oldid = dte.Rows[size][0].ToString();
                    int newid = Convert.ToInt32(oldid.Substring(2, 3));
                    if (newid >= 1 && newid <= 9)
                    {
                        txtmtnid.Text = "MT00" + (newid + 1);
                    }
                }
            }
        }
        private void AdminHome_Load(object sender, EventArgs e)
        {
            
            //dgvAdmList.DataSource = adl.GetData();
           

            

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
         
            
        }
        private void dgvdisplayappliancetype_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
        private void AdminHome_Load_2(object sender, EventArgs e)
        {
        }

        private void AdminHome_Load_1(object sender, EventArgs e)
        {
            ApplianceAutoID();
            txtappid.Enabled = false;


            ApplianceTypeIDAuto();
            txtATID.Enabled = false;


            InventoryAutoNum();
            txtInNum.Enabled = false;

            dgvdisplayappliancetype.DataSource = at.GetData();

            btnATupdt.Visible = false;
            btnATdel.Visible = false;

            lblAdmName.Text = AdminLogin.adminNm;

            Select_ApplianceType();

            MaintenanceIDAuto();
            txtmtnid.Enabled = false; //calling method for auto id on form load

            //RentAppList();
            dgvrentlist.DataSource = r1ta.GetData();

           
        }
        private void btnATSubmit_Click(object sender, EventArgs e)
        {
            ClsApplianceType cat = new ClsApplianceType(); //calling get set class for appliance type data receiving and returning
            
            int aptnm = Convert.ToInt32(textBox2.Text.Length);
            int aptaq = Convert.ToInt32(txtaaq.Text.Length);
            int apttq = Convert.ToInt32(txtatq.Text.Length);
            int aptiq = Convert.ToInt32(txtaiq.Text.Length);

            if (aptnm == 0)
            {
                MessageBox.Show("Enter Full Info of Applaince Type", "Appliance Type Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if ( aptaq == 0)
            {
                MessageBox.Show("Enter Full Info of Applaince Type", "Appliance Type Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (apttq == 0)
            {
                MessageBox.Show("Enter Full Info of Applaince Type", "Appliance Type Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (aptiq == 0)
            {
                MessageBox.Show("Enter Full Info of Applaince Type", "Appliance Type Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }//conditions for null values
            else
            {
                int i;
                cat.ATypeID = txtATID.Text;
                cat.ATypeName = textBox2.Text;
                int AAQ = int.Parse(txtaaq.Text);
                int ATQ = int.Parse(txtatq.Text);
                int AIQ = int.Parse(txtaiq.Text);
                i = at.Insert(cat.ATypeID, cat.ATypeName, AAQ, ATQ, AIQ);
                if (i > 0)
                {
                    MessageBox.Show("Complete Appliance Type Information", "Appliance Type Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Incomplete Appliance Type Entry", "Appliance Type Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }     //data inserting and sending to get set class     
        }
        private void dgvdisplayappliancetype_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvdisplayappliancetype_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btnATSubmit.Visible = false;
            btnATdel.Visible = true;
            btnATupdt.Visible = true; //features on cellclick
        }
        private void btnATdel_Click(object sender, EventArgs e)
        {

        }
        private void btnATupdt_Click(object sender, EventArgs e)
        {

        }
        string aptype;
        private void cboAppType_SelectedIndexChanged(object sender, EventArgs e) //receiving data from appliance type in combo box of appliance

        {
            string apptypeid = cboAppType.SelectedValue.ToString();
            DataTable dt = new DataTable();
            dt = at.CheckApplianceType(apptypeid);
            for (int  i = 0; i<dt.Rows.Count; i++)
            {
                aptype = dt.Rows[0][0].ToString();
            }
        }
        private void btnAppSubmit_Click(object sender, EventArgs e)
        {
            ClsAppliance capp = new ClsAppliance(); //calling get set class for appliance
            capp.display();

            int aptye = Convert.ToInt32(cboAppType.Text.Length);
            int brnd = Convert.ToInt32(cboBrand.Text.Length);
            int spec = Convert.ToInt32(txtappspec.Text.Length);
            int cons = Convert.ToInt32(txtappcosump.Text.Length);
            int cost = Convert.ToInt32(txtappcost.Text.Length);
            int status = Convert.ToInt32(txtappstatus.Text.Length);


            if (txtappnm.Text == " ")
            {
                MessageBox.Show("Enter Appliance Name", "Appliance Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if(aptye == 0)
            {
                MessageBox.Show("Enter Appliance Type", "Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            else if (brnd == 0)
            {
                MessageBox.Show("Enter Brand ", "Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (spec   == 0)
            {
                MessageBox.Show("Enter Specifications", "Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (cons == 0)
            {
                MessageBox.Show("Enter Power Consumption", "Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (cost == 0)
            {
                MessageBox.Show("Enter Monthly Cost", "Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (status == 0)
            {
                MessageBox.Show("Enter Appliance status", "Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }//checking null values
            else
            {
                int i;

                capp.AppID = txtappid.Text;
                capp.AppNm = txtappnm.Text;
                capp.AppType = cboAppType.Text;
                capp.AppBrand = cboBrand.Text;
                capp.AppSpec = txtappspec.Text;
                capp.AppConsump = txtappcosump.Text;
                capp.AppCost = txtappcost.Text;
                capp.AppMntn = txtappstatus.Text;

                i = ata.Insert(capp.AppID, capp.AppNm,aptype , capp.AppBrand, capp.AppSpec, capp.AppConsump, capp.AppCost, capp.AppMntn);
                if (i > 0)
                {
                    MessageBox.Show("Successful Appliance Insert", "Appliance Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Incomplete Appliance Entry", "Appliance Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            } //data insert, sending to class and conditions check
        }

        private void txtappstatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnAppBrowse_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            txtappnm.Text = " ";
            cboAppType.Text = " ";
            cboBrand.Text = " ";
            txtappspec.Text = " ";
            txtappcosump.Text = " ";
            txtappcost.Text = " ";
            txtappstatus.Text = " ";

        }//clearing texts

        private void btnAppDel_Click(object sender, EventArgs e)
        {

        }

        private void btnAppUpdate_Click(object sender, EventArgs e)
        {

        }
        public void RentAppList() // method for data rows of rent data grid view
        {
            drrnt = dtrnt.NewRow();
            dtrnt.Columns.Add("Rent ID").ToString();
            dtrnt.Columns.Add("Customer ID").ToString();
            dtrnt.Columns.Add("Admin ID").ToString();
            dtrnt.Columns.Add("Rent Date").ToString();
            dtrnt.Columns.Add("Rental Period").ToString();
            dtrnt.Columns.Add("Total Quantity").ToString();
            dtrnt.Columns.Add("Total Price").ToString();
            dtrnt.Columns.Add("Promotion").ToString();
            dtrnt.Columns.Add("Net Price").ToString();
            dtrnt.Columns.Add("Rental Status").ToString();


            dgvrentlist.Refresh();
            dgvrentlist.DataSource = dtrnt;

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            txtInAddr.Text = " ";
        }
        private void InventoryAutoNum() //method for auto number of inventory
        {
            DataTable dte = new DataTable();
            dte = ita.GetData();
            if (dte.Rows.Count == 0)
            {
                txtInNum.Text = "I001";
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
                        txtInNum.Text = "I00" + (newid + 1);
                    }
                }
            }
        }

        private void btnATclear_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtidat_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void btnMtnSub_Click(object sender, EventArgs e)
        {
            ClsAppliance ca = new ClsAppliance();
            int appid = Convert.ToInt32(txtMtnAppId.Text.Length);
            int stt = Convert.ToInt32(txtMtnStt.Text.Length);
            if ( appid == 0)
            {
                MessageBox.Show("Enter Appliance id", "Maintenance Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (stt == 0)
            {
                MessageBox.Show("Enter Maintenance Status", "Maintenance Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Complete information of Maintenance", "Maintenance Status",MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            mtnstt = txtMtnStt.Text;
            mta.Insert(txtmtnid.Text, txtMtnAppId.Text, dateTimePicker1.Value, dateTimePicker2.Value, mtnstt);
        }

        private void btnInSub_Click(object sender, EventArgs e)
        {
            ClsApplianceType cat = new ClsApplianceType();
            int addr = Convert.ToInt32(txtInAddr.Text.Length);
            int aptd = Convert.ToInt32(cboApid.Text.Length);
            if (addr == 0)
            {
                MessageBox.Show("Enter address of inventory", "Inventory Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (aptd == 0)
            {
                MessageBox.Show("Enter Appliance Type Id", "Inventory Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Complete information of Inventory", "Inventory Status", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            ita.Insert(txtInNum.Text, txtInAddr.Text, cboApid.Text); // inserting inventory data to database
        }

        private void btnRntShow_Click(object sender, EventArgs e)
        {
            string status = cboRentStt.SelectedItem.ToString();
            dtrnt = r1ta.CheckStt(status);
            for (int i = 0; i < dtrnt.Rows.Count; i++)
            {
                drrnt = dtrnt.NewRow();
                drrnt["RentID"] = dtrnt.Rows[i][0].ToString();
                drrnt["CustomerID"] = dtrnt.Rows[i][1].ToString();
                drrnt["AdminID"] = dtrnt.Rows[i][2].ToString();
                drrnt["RentDate"] = dtrnt.Rows[i][3].ToString();
                drrnt["RentalPeriod"] = dtrnt.Rows[i][4].ToString();
                drrnt["TotalQty"] = dtrnt.Rows[i][5].ToString();
                drrnt["TotalPrice"] = dtrnt.Rows[i][6].ToString();
                drrnt["Promotion"] = dtrnt.Rows[i][7].ToString();
                drrnt["NetPrice"] = dtrnt.Rows[i][8].ToString();
                drrnt["RentalStatus"] = dtrnt.Rows[i][9].ToString();

                dgvrentlist.Refresh();
                dgvrentlist.DataSource = dtrnt;

            }
        }

        private void btnRntShAl_Click(object sender, EventArgs e)
        {
            dgvrentlist.DataSource = r1ta.GetData();
        }
        private void cboApid_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMtnAppId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to log out?", "Admin Home", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            MainPage mp = new MainPage();
            mp.Show();
            this.Close();
        }
    }
}
