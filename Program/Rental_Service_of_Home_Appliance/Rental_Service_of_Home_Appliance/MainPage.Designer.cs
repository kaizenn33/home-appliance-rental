
namespace Rental_Service_of_Home_Appliance
{
    partial class MainPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.Image")));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerRegisterToolStripMenuItem,
            this.customerLoginToolStripMenuItem});
            this.customerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("customerToolStripMenuItem.Image")));
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.customerToolStripMenuItem.Text = "&Customer";
            // 
            // customerRegisterToolStripMenuItem
            // 
            this.customerRegisterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("customerRegisterToolStripMenuItem.Image")));
            this.customerRegisterToolStripMenuItem.Name = "customerRegisterToolStripMenuItem";
            this.customerRegisterToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.customerRegisterToolStripMenuItem.Text = "Customer Register";
            this.customerRegisterToolStripMenuItem.Click += new System.EventHandler(this.customerRegisterToolStripMenuItem_Click);
            // 
            // customerLoginToolStripMenuItem
            // 
            this.customerLoginToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("customerLoginToolStripMenuItem.Image")));
            this.customerLoginToolStripMenuItem.Name = "customerLoginToolStripMenuItem";
            this.customerLoginToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.customerLoginToolStripMenuItem.Text = "Customer Login";
            this.customerLoginToolStripMenuItem.Click += new System.EventHandler(this.customerLoginToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminRegisterToolStripMenuItem,
            this.adminLoginToolStripMenuItem});
            this.adminToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adminToolStripMenuItem.Image")));
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.adminToolStripMenuItem.Text = "&Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // adminRegisterToolStripMenuItem
            // 
            this.adminRegisterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adminRegisterToolStripMenuItem.Image")));
            this.adminRegisterToolStripMenuItem.Name = "adminRegisterToolStripMenuItem";
            this.adminRegisterToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.adminRegisterToolStripMenuItem.Text = "Admin Register";
            this.adminRegisterToolStripMenuItem.Click += new System.EventHandler(this.adminRegisterToolStripMenuItem_Click);
            // 
            // adminLoginToolStripMenuItem
            // 
            this.adminLoginToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adminLoginToolStripMenuItem.Image")));
            this.adminLoginToolStripMenuItem.Name = "adminLoginToolStripMenuItem";
            this.adminLoginToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.adminLoginToolStripMenuItem.Text = "Admin Login";
            this.adminLoginToolStripMenuItem.Click += new System.EventHandler(this.adminLoginToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem.Image")));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 179);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(338, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 64);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to\r\nAppliance Rental Service";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(589, 51);
            this.label2.TabIndex = 4;
            this.label2.Text = "Our renting business company provides affordable rental services for people\r\nlook" +
    "ing to hire home electrical appliances from small to large for a minimum preiod " +
    "of time\r\nstarting from ONE month.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(715, 51);
            this.label3.TabIndex = 5;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Main Page";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminLoginToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

