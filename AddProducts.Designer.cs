namespace Cakepool_Inventory_System
{
    partial class AddProducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AllProductsData = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UnitText = new System.Windows.Forms.TextBox();
            this.AddProducts_clear = new System.Windows.Forms.Button();
            this.AddProducts_remove = new System.Windows.Forms.Button();
            this.AddProducts_update = new System.Windows.Forms.Button();
            this.AddProducts_add = new System.Windows.Forms.Button();
            this.QuantityText = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.Label();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.Unit = new System.Windows.Forms.Label();
            this.CategoryBox = new System.Windows.Forms.ComboBox();
            this.ProductText = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllProductsData)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchText);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AllProductsData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 480);
            this.panel1.TabIndex = 0;
            // 
            // SearchText
            // 
            this.SearchText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchText.Location = new System.Drawing.Point(90, 36);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(586, 31);
            this.SearchText.TabIndex = 55;
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.BackColor = System.Drawing.Color.Transparent;
            this.Search.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.Black;
            this.Search.Location = new System.Drawing.Point(4, 40);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(80, 23);
            this.Search.TabIndex = 56;
            this.Search.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 27);
            this.label1.TabIndex = 54;
            this.label1.Text = "Products";
            // 
            // AllProductsData
            // 
            this.AllProductsData.AllowUserToAddRows = false;
            this.AllProductsData.AllowUserToDeleteRows = false;
            this.AllProductsData.AllowUserToResizeColumns = false;
            this.AllProductsData.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.AllProductsData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.AllProductsData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllProductsData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AllProductsData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllProductsData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.AllProductsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AllProductsData.DefaultCellStyle = dataGridViewCellStyle6;
            this.AllProductsData.EnableHeadersVisualStyles = false;
            this.AllProductsData.Location = new System.Drawing.Point(0, 78);
            this.AllProductsData.Name = "AllProductsData";
            this.AllProductsData.ReadOnly = true;
            this.AllProductsData.RowHeadersVisible = false;
            this.AllProductsData.RowHeadersWidth = 51;
            this.AllProductsData.RowTemplate.Height = 24;
            this.AllProductsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllProductsData.Size = new System.Drawing.Size(1082, 402);
            this.AllProductsData.TabIndex = 53;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.UnitText);
            this.panel2.Controls.Add(this.AddProducts_clear);
            this.panel2.Controls.Add(this.AddProducts_remove);
            this.panel2.Controls.Add(this.AddProducts_update);
            this.panel2.Controls.Add(this.AddProducts_add);
            this.panel2.Controls.Add(this.QuantityText);
            this.panel2.Controls.Add(this.Quantity);
            this.panel2.Controls.Add(this.PriceText);
            this.panel2.Controls.Add(this.Price);
            this.panel2.Controls.Add(this.Unit);
            this.panel2.Controls.Add(this.CategoryBox);
            this.panel2.Controls.Add(this.ProductText);
            this.panel2.Controls.Add(this.Category);
            this.panel2.Controls.Add(this.ProductName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 497);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1082, 291);
            this.panel2.TabIndex = 1;
            // 
            // UnitText
            // 
            this.UnitText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitText.Location = new System.Drawing.Point(8, 173);
            this.UnitText.Name = "UnitText";
            this.UnitText.ReadOnly = true;
            this.UnitText.Size = new System.Drawing.Size(123, 31);
            this.UnitText.TabIndex = 66;
            // 
            // AddProducts_clear
            // 
            this.AddProducts_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.AddProducts_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddProducts_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProducts_clear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProducts_clear.ForeColor = System.Drawing.Color.White;
            this.AddProducts_clear.Location = new System.Drawing.Point(920, 167);
            this.AddProducts_clear.Name = "AddProducts_clear";
            this.AddProducts_clear.Size = new System.Drawing.Size(135, 57);
            this.AddProducts_clear.TabIndex = 65;
            this.AddProducts_clear.Text = "Clear";
            this.AddProducts_clear.UseVisualStyleBackColor = false;
            this.AddProducts_clear.Click += new System.EventHandler(this.AddProducts_clear_Click);
            // 
            // AddProducts_remove
            // 
            this.AddProducts_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.AddProducts_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddProducts_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProducts_remove.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProducts_remove.ForeColor = System.Drawing.Color.White;
            this.AddProducts_remove.Location = new System.Drawing.Point(752, 167);
            this.AddProducts_remove.Name = "AddProducts_remove";
            this.AddProducts_remove.Size = new System.Drawing.Size(135, 57);
            this.AddProducts_remove.TabIndex = 64;
            this.AddProducts_remove.Text = "Remove";
            this.AddProducts_remove.UseVisualStyleBackColor = false;
            this.AddProducts_remove.Click += new System.EventHandler(this.AddProducts_remove_Click);
            // 
            // AddProducts_update
            // 
            this.AddProducts_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.AddProducts_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddProducts_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProducts_update.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProducts_update.ForeColor = System.Drawing.Color.White;
            this.AddProducts_update.Location = new System.Drawing.Point(584, 167);
            this.AddProducts_update.Name = "AddProducts_update";
            this.AddProducts_update.Size = new System.Drawing.Size(135, 57);
            this.AddProducts_update.TabIndex = 63;
            this.AddProducts_update.Text = "Update";
            this.AddProducts_update.UseVisualStyleBackColor = false;
            this.AddProducts_update.Click += new System.EventHandler(this.AddProducts_update_Click);
            // 
            // AddProducts_add
            // 
            this.AddProducts_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.AddProducts_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddProducts_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProducts_add.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProducts_add.ForeColor = System.Drawing.Color.White;
            this.AddProducts_add.Location = new System.Drawing.Point(416, 167);
            this.AddProducts_add.Name = "AddProducts_add";
            this.AddProducts_add.Size = new System.Drawing.Size(135, 57);
            this.AddProducts_add.TabIndex = 62;
            this.AddProducts_add.Text = "Add";
            this.AddProducts_add.UseVisualStyleBackColor = false;
            this.AddProducts_add.Click += new System.EventHandler(this.AddProducts_add_Click);
            // 
            // QuantityText
            // 
            this.QuantityText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityText.Location = new System.Drawing.Point(414, 37);
            this.QuantityText.Name = "QuantityText";
            this.QuantityText.Size = new System.Drawing.Size(315, 33);
            this.QuantityText.TabIndex = 61;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.BackColor = System.Drawing.Color.Transparent;
            this.Quantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.ForeColor = System.Drawing.Color.Black;
            this.Quantity.Location = new System.Drawing.Point(409, 7);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(119, 27);
            this.Quantity.TabIndex = 60;
            this.Quantity.Text = "Quantity :";
            // 
            // PriceText
            // 
            this.PriceText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceText.Location = new System.Drawing.Point(414, 107);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(315, 33);
            this.PriceText.TabIndex = 59;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.BackColor = System.Drawing.Color.Transparent;
            this.Price.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.Color.Black;
            this.Price.Location = new System.Drawing.Point(409, 77);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(117, 27);
            this.Price.TabIndex = 58;
            this.Price.Text = "Price (₹) :";
            // 
            // Unit
            // 
            this.Unit.AutoSize = true;
            this.Unit.BackColor = System.Drawing.Color.Transparent;
            this.Unit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unit.ForeColor = System.Drawing.Color.Black;
            this.Unit.Location = new System.Drawing.Point(4, 147);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(60, 23);
            this.Unit.TabIndex = 56;
            this.Unit.Text = "Unit :";
            // 
            // CategoryBox
            // 
            this.CategoryBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Items.AddRange(new object[] {
            "Gram",
            "Kg",
            "Piece",
            "liter"});
            this.CategoryBox.Location = new System.Drawing.Point(8, 107);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(315, 34);
            this.CategoryBox.TabIndex = 55;
            this.CategoryBox.SelectedIndexChanged += new System.EventHandler(this.CategoryBox_SelectedIndexChanged_1);
            // 
            // ProductText
            // 
            this.ProductText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductText.Location = new System.Drawing.Point(8, 37);
            this.ProductText.Name = "ProductText";
            this.ProductText.Size = new System.Drawing.Size(315, 33);
            this.ProductText.TabIndex = 54;
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.BackColor = System.Drawing.Color.Transparent;
            this.Category.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.ForeColor = System.Drawing.Color.Black;
            this.Category.Location = new System.Drawing.Point(3, 77);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(128, 27);
            this.Category.TabIndex = 53;
            this.Category.Text = "Category :";
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.BackColor = System.Drawing.Color.Transparent;
            this.ProductName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.ForeColor = System.Drawing.Color.Black;
            this.ProductName.Location = new System.Drawing.Point(3, 7);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(185, 27);
            this.ProductName.TabIndex = 52;
            this.ProductName.Text = "Product Name :";
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddProducts";
            this.Size = new System.Drawing.Size(1082, 788);
            this.Load += new System.EventHandler(this.AddProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllProductsData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView AllProductsData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.ComboBox CategoryBox;
        private System.Windows.Forms.TextBox ProductText;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Label Unit;
        private System.Windows.Forms.TextBox QuantityText;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Button AddProducts_clear;
        private System.Windows.Forms.Button AddProducts_remove;
        private System.Windows.Forms.Button AddProducts_update;
        private System.Windows.Forms.Button AddProducts_add;
        private System.Windows.Forms.TextBox UnitText;
    }
}
