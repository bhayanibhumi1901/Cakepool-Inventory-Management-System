namespace Cakepool_Inventory_System
{
    partial class AddCategories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UnitBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddCategories_clear = new System.Windows.Forms.Button();
            this.AddCategories_remove = new System.Windows.Forms.Button();
            this.AddCategories_update = new System.Windows.Forms.Button();
            this.AddCategories_add = new System.Windows.Forms.Button();
            this.CategoryText = new System.Windows.Forms.TextBox();
            this.Unit = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.AllCategoriesData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllCategoriesData)).BeginInit();
            this.SuspendLayout();
            // 
            // UnitBox
            // 
            this.UnitBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitBox.FormattingEnabled = true;
            this.UnitBox.Items.AddRange(new object[] {
            "Gram",
            "Kg",
            "Piece",
            "liter",
            "Pack"});
            this.UnitBox.Location = new System.Drawing.Point(7, 104);
            this.UnitBox.Name = "UnitBox";
            this.UnitBox.Size = new System.Drawing.Size(315, 34);
            this.UnitBox.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UnitBox);
            this.panel1.Controls.Add(this.AddCategories_clear);
            this.panel1.Controls.Add(this.AddCategories_remove);
            this.panel1.Controls.Add(this.AddCategories_update);
            this.panel1.Controls.Add(this.AddCategories_add);
            this.panel1.Controls.Add(this.CategoryText);
            this.panel1.Controls.Add(this.Unit);
            this.panel1.Controls.Add(this.Category);
            this.panel1.Location = new System.Drawing.Point(18, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 750);
            this.panel1.TabIndex = 4;
            // 
            // AddCategories_clear
            // 
            this.AddCategories_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.AddCategories_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCategories_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCategories_clear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCategories_clear.ForeColor = System.Drawing.Color.White;
            this.AddCategories_clear.Location = new System.Drawing.Point(182, 256);
            this.AddCategories_clear.Name = "AddCategories_clear";
            this.AddCategories_clear.Size = new System.Drawing.Size(135, 57);
            this.AddCategories_clear.TabIndex = 50;
            this.AddCategories_clear.Text = "Clear";
            this.AddCategories_clear.UseVisualStyleBackColor = false;
            this.AddCategories_clear.Click += new System.EventHandler(this.AddCategories_clear_Click);
            // 
            // AddCategories_remove
            // 
            this.AddCategories_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.AddCategories_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCategories_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCategories_remove.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCategories_remove.ForeColor = System.Drawing.Color.White;
            this.AddCategories_remove.Location = new System.Drawing.Point(13, 256);
            this.AddCategories_remove.Name = "AddCategories_remove";
            this.AddCategories_remove.Size = new System.Drawing.Size(135, 57);
            this.AddCategories_remove.TabIndex = 49;
            this.AddCategories_remove.Text = "Remove";
            this.AddCategories_remove.UseVisualStyleBackColor = false;
            this.AddCategories_remove.Click += new System.EventHandler(this.AddCategories_remove_Click);
            // 
            // AddCategories_update
            // 
            this.AddCategories_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.AddCategories_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCategories_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCategories_update.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCategories_update.ForeColor = System.Drawing.Color.White;
            this.AddCategories_update.Location = new System.Drawing.Point(182, 169);
            this.AddCategories_update.Name = "AddCategories_update";
            this.AddCategories_update.Size = new System.Drawing.Size(135, 57);
            this.AddCategories_update.TabIndex = 48;
            this.AddCategories_update.Text = "Update";
            this.AddCategories_update.UseVisualStyleBackColor = false;
            this.AddCategories_update.Click += new System.EventHandler(this.AddCategories_update_Click);
            // 
            // AddCategories_add
            // 
            this.AddCategories_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.AddCategories_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCategories_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCategories_add.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCategories_add.ForeColor = System.Drawing.Color.White;
            this.AddCategories_add.Location = new System.Drawing.Point(13, 169);
            this.AddCategories_add.Name = "AddCategories_add";
            this.AddCategories_add.Size = new System.Drawing.Size(135, 57);
            this.AddCategories_add.TabIndex = 47;
            this.AddCategories_add.Text = "Add";
            this.AddCategories_add.UseVisualStyleBackColor = false;
            this.AddCategories_add.Click += new System.EventHandler(this.AddCategories_add_Click);
            // 
            // CategoryText
            // 
            this.CategoryText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryText.Location = new System.Drawing.Point(7, 34);
            this.CategoryText.Name = "CategoryText";
            this.CategoryText.Size = new System.Drawing.Size(315, 33);
            this.CategoryText.TabIndex = 46;
            // 
            // Unit
            // 
            this.Unit.AutoSize = true;
            this.Unit.BackColor = System.Drawing.Color.Transparent;
            this.Unit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unit.ForeColor = System.Drawing.Color.Black;
            this.Unit.Location = new System.Drawing.Point(2, 74);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(70, 27);
            this.Unit.TabIndex = 40;
            this.Unit.Text = "Unit :";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.BackColor = System.Drawing.Color.Transparent;
            this.Category.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.ForeColor = System.Drawing.Color.Black;
            this.Category.Location = new System.Drawing.Point(2, 4);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(128, 27);
            this.Category.TabIndex = 39;
            this.Category.Text = "Category :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SearchText);
            this.panel2.Controls.Add(this.Search);
            this.panel2.Controls.Add(this.AllCategoriesData);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(366, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(698, 750);
            this.panel2.TabIndex = 5;
            // 
            // SearchText
            // 
            this.SearchText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchText.Location = new System.Drawing.Point(102, 43);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(586, 33);
            this.SearchText.TabIndex = 51;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.BackColor = System.Drawing.Color.Transparent;
            this.Search.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.Black;
            this.Search.Location = new System.Drawing.Point(3, 45);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(93, 27);
            this.Search.TabIndex = 51;
            this.Search.Text = "Search";
            // 
            // AllCategoriesData
            // 
            this.AllCategoriesData.AllowUserToAddRows = false;
            this.AllCategoriesData.AllowUserToDeleteRows = false;
            this.AllCategoriesData.AllowUserToResizeColumns = false;
            this.AllCategoriesData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.AllCategoriesData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AllCategoriesData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllCategoriesData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllCategoriesData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AllCategoriesData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllCategoriesData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AllCategoriesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AllCategoriesData.DefaultCellStyle = dataGridViewCellStyle3;
            this.AllCategoriesData.EnableHeadersVisualStyles = false;
            this.AllCategoriesData.Location = new System.Drawing.Point(8, 80);
            this.AllCategoriesData.Name = "AllCategoriesData";
            this.AllCategoriesData.ReadOnly = true;
            this.AllCategoriesData.RowHeadersVisible = false;
            this.AllCategoriesData.RowHeadersWidth = 51;
            this.AllCategoriesData.RowTemplate.Height = 24;
            this.AllCategoriesData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllCategoriesData.Size = new System.Drawing.Size(680, 657);
            this.AllCategoriesData.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 27);
            this.label1.TabIndex = 51;
            this.label1.Text = "All Categories";
            // 
            // AddCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "AddCategories";
            this.Size = new System.Drawing.Size(1082, 788);
            this.Load += new System.EventHandler(this.AddCategories_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllCategoriesData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox UnitBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddCategories_clear;
        private System.Windows.Forms.Button AddCategories_remove;
        private System.Windows.Forms.Button AddCategories_update;
        private System.Windows.Forms.Button AddCategories_add;
        private System.Windows.Forms.TextBox CategoryText;
        private System.Windows.Forms.Label Unit;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.DataGridView AllCategoriesData;
        private System.Windows.Forms.Label label1;
    }
}
