using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cakepool_Inventory_System
{
    public partial class MainForm : Form
    {
        AddUsers addUsersControl;
        AddCategories addCategoriesControl;
        AddProducts addProductsControl;
        Orders ordersControl;
        Customers customersControl;
        public MainForm()
        {
            InitializeComponent();
            AddUser.Click += new EventHandler(AddUser_Click);
            AddCategories.Click += new EventHandler(AddCategories_Click);
            AddProducts.Click += new EventHandler(AddProducts_Click);
            Orders.Click += new EventHandler(Orders_Click);
            Customers.Click += new EventHandler(Customers_Click);

            // Initialize the controls once
            addUsersControl = new AddUsers();
            addCategoriesControl = new AddCategories();
            addProductsControl = new AddProducts();
            ordersControl = new Orders();
            customersControl = new Customers();

            // Add them to the FlowLayoutPanel but keep them hidden
            flowLayoutPanel1.Controls.Add(addUsersControl);
            flowLayoutPanel1.Controls.Add(addCategoriesControl);
            flowLayoutPanel1.Controls.Add(addProductsControl);
            flowLayoutPanel1.Controls.Add(ordersControl);
            flowLayoutPanel1.Controls.Add(customersControl);

            addUsersControl.Hide();
            addCategoriesControl.Hide();
            addProductsControl.Hide();
            ordersControl.Hide();
            customersControl.Hide();
        }

        private void MainFormCloseButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Exit ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void SignOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Sign Out ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
       "Dashboard module is under development.",
       "Coming Soon",
       MessageBoxButtons.OK,
       MessageBoxIcon.Information);
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            HideAllControls();
            addUsersControl.Show();
        }

        private void AddCategories_Click(object sender, EventArgs e)
        {
            HideAllControls();
            addCategoriesControl.Show();
        }

        private void AddProducts_Click(object sender, EventArgs e)
        {
            HideAllControls();
            addProductsControl.Show();
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            HideAllControls();
            customersControl.Show();
        }

        private void Orders_Click(object sender, EventArgs e)
        {
            HideAllControls();
            ordersControl.Show();
        }
        private void HideAllControls()
        {
            addUsersControl.Hide();
            addCategoriesControl.Hide();
            addProductsControl.Hide();
            ordersControl.Hide();
            customersControl.Hide();
        }
    }
}
