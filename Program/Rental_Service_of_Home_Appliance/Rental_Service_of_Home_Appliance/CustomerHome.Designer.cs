
namespace Rental_Service_of_Home_Appliance
{
    partial class CustomerHome
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btncustadd = new System.Windows.Forms.Button();
            this.btnCustShow = new System.Windows.Forms.Button();
            this.lblcustnm = new System.Windows.Forms.Label();
            this.cboCustAppType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCustApp = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustApp)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLogOut);
            this.tabPage2.Controls.Add(this.btncustadd);
            this.tabPage2.Controls.Add(this.btnCustShow);
            this.tabPage2.Controls.Add(this.lblcustnm);
            this.tabPage2.Controls.Add(this.cboCustAppType);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dgvCustApp);
            this.tabPage2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(779, 406);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btncustadd
            // 
            this.btncustadd.Location = new System.Drawing.Point(13, 343);
            this.btncustadd.Name = "btncustadd";
            this.btncustadd.Size = new System.Drawing.Size(80, 27);
            this.btncustadd.TabIndex = 5;
            this.btncustadd.Text = "Add";
            this.btncustadd.UseVisualStyleBackColor = true;
            this.btncustadd.Click += new System.EventHandler(this.btncustadd_Click);
            // 
            // btnCustShow
            // 
            this.btnCustShow.Location = new System.Drawing.Point(351, 26);
            this.btnCustShow.Name = "btnCustShow";
            this.btnCustShow.Size = new System.Drawing.Size(80, 27);
            this.btnCustShow.TabIndex = 4;
            this.btnCustShow.Text = "Show";
            this.btnCustShow.UseVisualStyleBackColor = true;
            this.btnCustShow.Click += new System.EventHandler(this.btnCustShow_Click);
            // 
            // lblcustnm
            // 
            this.lblcustnm.AutoSize = true;
            this.lblcustnm.Location = new System.Drawing.Point(50, 26);
            this.lblcustnm.Name = "lblcustnm";
            this.lblcustnm.Size = new System.Drawing.Size(0, 20);
            this.lblcustnm.TabIndex = 3;
            this.lblcustnm.Click += new System.EventHandler(this.label2_Click);
            // 
            // cboCustAppType
            // 
            this.cboCustAppType.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustAppType.FormattingEnabled = true;
            this.cboCustAppType.Location = new System.Drawing.Point(178, 26);
            this.cboCustAppType.Name = "cboCustAppType";
            this.cboCustAppType.Size = new System.Drawing.Size(156, 25);
            this.cboCustAppType.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search appliance type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvCustApp
            // 
            this.dgvCustApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustApp.Location = new System.Drawing.Point(13, 71);
            this.dgvCustApp.Name = "dgvCustApp";
            this.dgvCustApp.Size = new System.Drawing.Size(750, 247);
            this.dgvCustApp.TabIndex = 0;
            this.dgvCustApp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustApp_CellClick);
            this.dgvCustApp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustApp_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 432);
            this.tabControl1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(683, 343);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(80, 27);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // CustomerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CustomerHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomerHome_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustApp)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btncustadd;
        private System.Windows.Forms.Button btnCustShow;
        private System.Windows.Forms.Label lblcustnm;
        private System.Windows.Forms.ComboBox cboCustAppType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCustApp;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnLogOut;
    }
}