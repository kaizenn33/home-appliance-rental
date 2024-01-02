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
    public partial class RentAppliance : Form
    {
        dsApplianceTableAdapters.temptblTableAdapter ttb = new dsApplianceTableAdapters.temptblTableAdapter(); // dataset connceting to temporary table
        dsApplianceTableAdapters.Rent1TableAdapter rta = new dsApplianceTableAdapters.Rent1TableAdapter(); // dataset connecting to rent table
        dsApplianceTableAdapters.ApplianceRentTableAdapter ara = new dsApplianceTableAdapters.ApplianceRentTableAdapter(); // dataset connecting to dummy table
       
        DataTable dtrnt = new DataTable();
        DataRow drrnt; // data row
        int tmonth;
       public static int tprice , tqty; // global variables

        public RentAppliance()
        {
            InitializeComponent();
        }

        public void AppList() // method for data rows of rent data grid view
        {
            drrnt = dtrnt.NewRow();
            dtrnt.Columns.Add("ApplianceID").ToString();
            dtrnt.Columns.Add("ApplianceName").ToString();
            dtrnt.Columns.Add("TypeName").ToString();
            dtrnt.Columns.Add("Brand").ToString();
            dtrnt.Columns.Add("Consumption").ToString();
            dtrnt.Columns.Add("MonthlyCost").ToString();
            dtrnt.Columns.Add("AvaiableQuantity").ToString();

            dgvrentapp.Refresh();
            dgvrentapp.DataSource = dtrnt;

        }

        private void RentAutoID() // Method for auto insertion of ID of Rent
        {
            DataTable dte = new DataTable();
            dte = rta.GetData();
            if (dte.Rows.Count == 0)
            {
                txtrntid.Text = "R001";
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
                        txtrntid.Text = "R00" + (newid + 1);
                    }
                    else if (newid >= 10 && newid<= 99)
                    {
                        txtrntid.Text = "R0" + (newid + 1);
                    }
                    else if (newid >= 100 && newid <= 999)
                    {
                        txtrntid.Text = "R" + (newid + 1);
                    }

                }
            }
        }

        private void RentAppliance_Load(object sender, EventArgs e)
        {
           

            RentAutoID();
            dgvrentapp.DataSource = ttb.GetData(); // getting data from dataset

            txtrntid.Enabled = false;
            txtrntcustnm.Enabled = false;
            txtrntcustnm.Text = CustomerLogin.CustNm; // using the customer's name from customer login 
            txtRntDt.Text = DateTime.Now.ToString(); // date time of now

            DataTable dt = new DataTable();
            dt = ttb.GetData();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    tprice += Convert.ToInt32(dt.Rows[i]["RentAmt"]); // total price showing
                    tqty += Convert.ToInt32(dt.Rows[i]["RentQty"]); // total quantity showing

                }
            }
            txttprc.Text = tprice.ToString(); // total price on text box
            txttqty.Text = tqty.ToString(); // total quantity on text box

            txttprc.Enabled = false;
            txttqty.Enabled = false;
        }

        private void dgvrentapp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRntBck_Click(object sender, EventArgs e)
        {
            CustomerHome ch = new CustomerHome();
            ch.Show();
            this.Close();
        }

        private void dgvrentapp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRntCnfm_Click(object sender, EventArgs e)
           
        {
            if (cboperiod.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose period to rent", "Rent", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                cboperiod.Focus();
            }
            else
            {
                string rentstatus = "Rent";
                ClsRent cr = new ClsRent();
                cr.display();


                cr.rntid = txtrntid.Text;
                cr.custid = CustomerLogin.CustID;
                cr.rntdt = Convert.ToString(txtRntDt);
                cr.tqt = Convert.ToInt32(txttqty.Text);
                cr.tprc = Convert.ToInt32(txttprc.Text);
                cr.prm = Convert.ToInt32(txtprmt.Text);
                cr.netpr = Convert.ToInt32(txtntprc.Text); // data from text box to var of class

                int count = rta.RentInsert(cr.rntid, cr.custid, cr.rntdt, tmonth, cr.tqt, cr.tprc, cr.prm, cr.netpr, rentstatus); // insertion of var
                if (count > 0)
                {
                    DataTable dt = new DataTable();
                    dt = ttb.GetData();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string APid;
                        int rqt, ram;
                        APid = dt.Rows[i]["ApplianceID"].ToString();
                        rqt = Convert.ToInt32(dt.Rows[i]["RentQty"]);
                        ram = Convert.ToInt32(dt.Rows[i]["RentAmt"]);
                        ara.Insert(txtrntid.Text, APid, rqt, ram);
                        ttb.deletedata();
                        dgvrentapp.DataSource = ttb.GetData();
                    }
                    MessageBox.Show("Rent Upload Complete", "Rent", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                } 
            }
        }

        private void txtrntcustnm_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tmonth = Convert.ToInt32(cboperiod.SelectedItem.ToString()); // var for rental period
            txttprc.Text =Convert.ToString(Convert.ToInt32(tmonth) * Convert.ToInt32(tprice)); //final total price = rental period * total price
           if (tmonth >= 6 && tmonth <= 12)
            {
                tprice = tprice * tmonth; 
                txtprmt.Text = Convert.ToString(Convert.ToInt32(tprice)*0.1); // caculation of promotion
                txtntprc.Text = Convert.ToString(tprice - Convert.ToInt32(txtprmt.Text)); // calculation of net price
            }
            else
            {
                tprice = tprice * tmonth;
                txtprmt.Text = "0";
                txtntprc.Text = Convert.ToString(tprice);
            }
        }
    }
}
