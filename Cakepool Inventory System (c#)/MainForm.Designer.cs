namespace Cakepool_Inventory_System
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainFormTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MainFormCloseButton = new System.Windows.Forms.Button();
            this.SideBar = new System.Windows.Forms.Panel();
            this.Orders = new System.Windows.Forms.Button();
            this.SignOut = new System.Windows.Forms.Button();
            this.Customers = new System.Windows.Forms.Button();
            this.AddProducts = new System.Windows.Forms.Button();
            this.AddCategories = new System.Windows.Forms.Button();
            this.AddUser = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AdminLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MainFormTitleBar.SuspendLayout();
            this.SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainFormTitleBar
            // 
            this.MainFormTitleBar.Controls.Add(this.label1);
            this.MainFormTitleBar.Controls.Add(this.MainFormCloseButton);
            this.MainFormTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainFormTitleBar.Location = new System.Drawing.Point(0, 0);
            this.MainFormTitleBar.Name = "MainFormTitleBar";
            this.MainFormTitleBar.Size = new System.Drawing.Size(1346, 40);
            this.MainFormTitleBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cakepool Inventory System";
            // 
            // MainFormCloseButton
            // 
            this.MainFormCloseButton.BackColor = System.Drawing.Color.Maroon;
            this.MainFormCloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainFormCloseButton.BackgroundImage")));
            this.MainFormCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainFormCloseButton.FlatAppearance.BorderSize = 0;
            this.MainFormCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainFormCloseButton.Location = new System.Drawing.Point(1305, 0);
            this.MainFormCloseButton.Name = "MainFormCloseButton";
            this.MainFormCloseButton.Size = new System.Drawing.Size(41, 39);
            this.MainFormCloseButton.TabIndex = 1;
            this.MainFormCloseButton.UseVisualStyleBackColor = false;
            this.MainFormCloseButton.Click += new System.EventHandler(this.MainFormCloseButton_Click);
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.SideBar.Controls.Add(this.Orders);
            this.SideBar.Controls.Add(this.SignOut);
            this.SideBar.Controls.Add(this.Customers);
            this.SideBar.Controls.Add(this.AddProducts);
            this.SideBar.Controls.Add(this.AddCategories);
            this.SideBar.Controls.Add(this.AddUser);
            this.SideBar.Controls.Add(this.Dashboard);
            this.SideBar.Controls.Add(this.label2);
            this.SideBar.Controls.Add(this.AdminLogo);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 40);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(264, 788);
            this.SideBar.TabIndex = 1;
            // 
            // Orders
            // 
            this.Orders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Orders.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.Orders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.Orders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.Orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Orders.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orders.ForeColor = System.Drawing.Color.White;
            this.Orders.Location = new System.Drawing.Point(16, 524);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(228, 47);
            this.Orders.TabIndex = 11;
            this.Orders.Text = "Orders";
            this.Orders.UseVisualStyleBackColor = true;
            this.Orders.Click += new System.EventHandler(this.Orders_Click);
            // 
            // SignOut
            // 
            this.SignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.SignOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.SignOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.SignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignOut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOut.ForeColor = System.Drawing.Color.White;
            this.SignOut.Location = new System.Drawing.Point(16, 711);
            this.SignOut.Name = "SignOut";
            this.SignOut.Size = new System.Drawing.Size(228, 47);
            this.SignOut.TabIndex = 10;
            this.SignOut.Text = "Sign Out";
            this.SignOut.UseVisualStyleBackColor = true;
            this.SignOut.Click += new System.EventHandler(this.SignOut_Click);
            // 
            // Customers
            // 
            this.Customers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Customers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.Customers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.Customers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.Customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customers.ForeColor = System.Drawing.Color.White;
            this.Customers.Location = new System.Drawing.Point(16, 455);
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(228, 47);
            this.Customers.TabIndex = 9;
            this.Customers.Text = "Customers";
            this.Customers.UseVisualStyleBackColor = true;
            this.Customers.Click += new System.EventHandler(this.Customers_Click);
            // 
            // AddProducts
            // 
            this.AddProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddProducts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.AddProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.AddProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.AddProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProducts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProducts.ForeColor = System.Drawing.Color.White;
            this.AddProducts.Location = new System.Drawing.Point(16, 386);
            this.AddProducts.Name = "AddProducts";
            this.AddProducts.Size = new System.Drawing.Size(228, 47);
            this.AddProducts.TabIndex = 8;
            this.AddProducts.Text = "Add Products";
            this.AddProducts.UseVisualStyleBackColor = true;
            this.AddProducts.Click += new System.EventHandler(this.AddProducts_Click);
            // 
            // AddCategories
            // 
            this.AddCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCategories.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.AddCategories.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.AddCategories.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.AddCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCategories.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCategories.ForeColor = System.Drawing.Color.White;
            this.AddCategories.Location = new System.Drawing.Point(16, 317);
            this.AddCategories.Name = "AddCategories";
            this.AddCategories.Size = new System.Drawing.Size(228, 47);
            this.AddCategories.TabIndex = 7;
            this.AddCategories.Text = "Add Categories";
            this.AddCategories.UseVisualStyleBackColor = true;
            this.AddCategories.Click += new System.EventHandler(this.AddCategories_Click);
            // 
            // AddUser
            // 
            this.AddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.AddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.AddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUser.ForeColor = System.Drawing.Color.White;
            this.AddUser.Location = new System.Drawing.Point(16, 248);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(228, 47);
            this.AddUser.TabIndex = 6;
            this.AddUser.Text = "Add Users";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.Dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.Dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.ForeColor = System.Drawing.Color.White;
            this.Dashboard.Location = new System.Drawing.Point(16, 179);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(228, 47);
            this.Dashboard.TabIndex = 5;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.UseVisualStyleBackColor = true;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welcome Admin ,";
            // 
            // AdminLogo
            // 
            this.AdminLogo.BackColor = System.Drawing.Color.Transparent;
            this.AdminLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdminLogo.BackgroundImage")));
            this.AdminLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AdminLogo.Location = new System.Drawing.Point(65, 3);
            this.AdminLogo.Name = "AdminLogo";
            this.AdminLogo.Size = new System.Drawing.Size(134, 113);
            this.AdminLogo.TabIndex = 3;
            this.AdminLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 38);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(264, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1082, 788);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 828);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.MainFormTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.MainFormTitleBar.ResumeLayout(false);
            this.MainFormTitleBar.PerformLayout();
            this.SideBar.ResumeLayout(false);
            this.SideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainFormTitleBar;
        private System.Windows.Forms.Button MainFormCloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox AdminLogo;
        private System.Windows.Forms.Button AddProducts;
        private System.Windows.Forms.Button AddCategories;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Button Customers;
        private System.Windows.Forms.Button SignOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Orders;
    }
}