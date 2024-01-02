
namespace Rental_Service_of_Home_Appliance
{
    partial class RentAppliance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvrentapp = new System.Windows.Forms.DataGridView();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnRntBck = new System.Windows.Forms.Button();
            this.btnRntCnfm = new System.Windows.Forms.Button();
            this.rntid = new System.Windows.Forms.Label();
            this.txtrntid = new System.Windows.Forms.TextBox();
            this.txtRntDt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RntPrd = new System.Windows.Forms.Label();
            this.cboperiod = new System.Windows.Forms.ComboBox();
            this.txttprc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttqty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtrntcustnm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprmt = new System.Windows.Forms.TextBox();
            this.Promotion = new System.Windows.Forms.Label();
            this.txtntprc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrentapp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvrentapp
            // 
            this.dgvrentapp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrentapp.Location = new System.Drawing.Point(285, 130);
            this.dgvrentapp.Name = "dgvrentapp";
            this.dgvrentapp.Size = new System.Drawing.Size(503, 197);
            this.dgvrentapp.TabIndex = 0;
            this.dgvrentapp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrentapp_CellClick);
            this.dgvrentapp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrentapp_CellContentClick);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(12, 20);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(180, 29);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Rent Appliance List";
            // 
            // btnRntBck
            // 
            this.btnRntBck.Location = new System.Drawing.Point(15, 374);
            this.btnRntBck.Name = "btnRntBck";
            this.btnRntBck.Size = new System.Drawing.Size(104, 23);
            this.btnRntBck.TabIndex = 2;
            this.btnRntBck.Text = "Back";
            this.btnRntBck.UseVisualStyleBackColor = true;
            this.btnRntBck.Click += new System.EventHandler(this.btnRntBck_Click);
            // 
            // btnRntCnfm
            // 
            this.btnRntCnfm.Location = new System.Drawing.Point(14, 341);
            this.btnRntCnfm.Name = "btnRntCnfm";
            this.btnRntCnfm.Size = new System.Drawing.Size(104, 23);
            this.btnRntCnfm.TabIndex = 3;
            this.btnRntCnfm.Text = "Confirm";
            this.btnRntCnfm.UseVisualStyleBackColor = true;
            this.btnRntCnfm.Click += new System.EventHandler(this.btnRntCnfm_Click);
            // 
            // rntid
            // 
            this.rntid.AutoSize = true;
            this.rntid.Location = new System.Drawing.Point(11, 89);
            this.rntid.Name = "rntid";
            this.rntid.Size = new System.Drawing.Size(44, 13);
            this.rntid.TabIndex = 4;
            this.rntid.Text = "Rent ID";
            // 
            // txtrntid
            // 
            this.txtrntid.Location = new System.Drawing.Point(85, 86);
            this.txtrntid.Name = "txtrntid";
            this.txtrntid.Size = new System.Drawing.Size(163, 20);
            this.txtrntid.TabIndex = 5;
            // 
            // txtRntDt
            // 
            this.txtRntDt.Location = new System.Drawing.Point(625, 86);
            this.txtRntDt.Name = "txtRntDt";
            this.txtRntDt.Size = new System.Drawing.Size(163, 20);
            this.txtRntDt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(551, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date of Rent";
            // 
            // RntPrd
            // 
            this.RntPrd.AutoSize = true;
            this.RntPrd.Location = new System.Drawing.Point(282, 89);
            this.RntPrd.Name = "RntPrd";
            this.RntPrd.Size = new System.Drawing.Size(37, 13);
            this.RntPrd.TabIndex = 8;
            this.RntPrd.Text = "Period";
            // 
            // cboperiod
            // 
            this.cboperiod.FormattingEnabled = true;
            this.cboperiod.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboperiod.Location = new System.Drawing.Point(335, 85);
            this.cboperiod.Name = "cboperiod";
            this.cboperiod.Size = new System.Drawing.Size(181, 21);
            this.cboperiod.TabIndex = 9;
            this.cboperiod.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txttprc
            // 
            this.txttprc.Location = new System.Drawing.Point(356, 348);
            this.txttprc.Name = "txttprc";
            this.txttprc.Size = new System.Drawing.Size(163, 20);
            this.txttprc.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total Price";
            // 
            // txttqty
            // 
            this.txttqty.Location = new System.Drawing.Point(356, 376);
            this.txttqty.Name = "txttqty";
            this.txttqty.Size = new System.Drawing.Size(163, 20);
            this.txttqty.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total Quantity";
            // 
            // txtrntcustnm
            // 
            this.txtrntcustnm.Location = new System.Drawing.Point(116, 201);
            this.txtrntcustnm.Name = "txtrntcustnm";
            this.txtrntcustnm.Size = new System.Drawing.Size(163, 20);
            this.txtrntcustnm.TabIndex = 17;
            this.txtrntcustnm.TextChanged += new System.EventHandler(this.txtrntcustnm_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Customer Name";
            // 
            // txtprmt
            // 
            this.txtprmt.Location = new System.Drawing.Point(356, 409);
            this.txtprmt.Name = "txtprmt";
            this.txtprmt.Size = new System.Drawing.Size(163, 20);
            this.txtprmt.TabIndex = 19;
            // 
            // Promotion
            // 
            this.Promotion.AutoSize = true;
            this.Promotion.Location = new System.Drawing.Point(282, 412);
            this.Promotion.Name = "Promotion";
            this.Promotion.Size = new System.Drawing.Size(54, 13);
            this.Promotion.TabIndex = 18;
            this.Promotion.Text = "Promotion";
            // 
            // txtntprc
            // 
            this.txtntprc.Location = new System.Drawing.Point(625, 348);
            this.txtntprc.Name = "txtntprc";
            this.txtntprc.Size = new System.Drawing.Size(163, 20);
            this.txtntprc.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Net Price";
            // 
            // RentAppliance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtntprc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtprmt);
            this.Controls.Add(this.Promotion);
            this.Controls.Add(this.txtrntcustnm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttqty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttprc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboperiod);
            this.Controls.Add(this.RntPrd);
            this.Controls.Add(this.txtRntDt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtrntid);
            this.Controls.Add(this.rntid);
            this.Controls.Add(this.btnRntCnfm);
            this.Controls.Add(this.btnRntBck);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.dgvrentapp);
            this.Name = "RentAppliance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentAppliance";
            this.Load += new System.EventHandler(this.RentAppliance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrentapp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvrentapp;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnRntBck;
        private System.Windows.Forms.Button btnRntCnfm;
        private System.Windows.Forms.Label rntid;
        private System.Windows.Forms.TextBox txtrntid;
        private System.Windows.Forms.TextBox txtRntDt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RntPrd;
        private System.Windows.Forms.ComboBox cboperiod;
        private System.Windows.Forms.TextBox txttprc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttqty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtrntcustnm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtprmt;
        private System.Windows.Forms.Label Promotion;
        private System.Windows.Forms.TextBox txtntprc;
        private System.Windows.Forms.Label label4;
    }
}