
namespace Rental_Service_of_Home_Appliance
{
    partial class CustomerRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerRegister));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.txtCustPsw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustPh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btngtLogin = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(114, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(117, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter ID";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(263, 94);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(151, 20);
            this.txtCustID.TabIndex = 6;
            // 
            // txtCustPsw
            // 
            this.txtCustPsw.Location = new System.Drawing.Point(263, 236);
            this.txtCustPsw.Name = "txtCustPsw";
            this.txtCustPsw.Size = new System.Drawing.Size(151, 20);
            this.txtCustPsw.TabIndex = 8;
            this.txtCustPsw.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(117, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCustUsername
            // 
            this.txtCustUsername.Location = new System.Drawing.Point(263, 186);
            this.txtCustUsername.Name = "txtCustUsername";
            this.txtCustUsername.Size = new System.Drawing.Size(151, 20);
            this.txtCustUsername.TabIndex = 10;
            this.txtCustUsername.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(117, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter Username";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(263, 137);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(151, 20);
            this.txtCustName.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(117, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Enter Name";
            // 
            // txtCustPh
            // 
            this.txtCustPh.Location = new System.Drawing.Point(263, 287);
            this.txtCustPh.Name = "txtCustPh";
            this.txtCustPh.Size = new System.Drawing.Size(151, 20);
            this.txtCustPh.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(117, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Enter Phone";
            // 
            // txtCustEmail
            // 
            this.txtCustEmail.Location = new System.Drawing.Point(263, 332);
            this.txtCustEmail.Name = "txtCustEmail";
            this.txtCustEmail.Size = new System.Drawing.Size(151, 20);
            this.txtCustEmail.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(117, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Enter Email";
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.Location = new System.Drawing.Point(263, 375);
            this.txtCustAddress.Multiline = true;
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(151, 53);
            this.txtCustAddress.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(117, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Enter Address";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(34, 465);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 29);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btngtLogin
            // 
            this.btngtLogin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngtLogin.Location = new System.Drawing.Point(405, 465);
            this.btngtLogin.Name = "btngtLogin";
            this.btngtLogin.Size = new System.Drawing.Size(98, 29);
            this.btngtLogin.TabIndex = 20;
            this.btngtLogin.Text = "Go to Login";
            this.btngtLogin.UseVisualStyleBackColor = true;
            this.btngtLogin.Click += new System.EventHandler(this.btngtLogin_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(223, 465);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(98, 29);
            this.btnSubmit.TabIndex = 21;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // CustomerRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(539, 535);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btngtLogin);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtCustAddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCustEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCustPh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCustUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCustPsw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerRegister";
            this.Load += new System.EventHandler(this.CustomerRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.TextBox txtCustPsw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustPh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCustEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCustAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btngtLogin;
        private System.Windows.Forms.Button btnSubmit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}