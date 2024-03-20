using System.Diagnostics;
using System.Xml.Linq;

namespace C968
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            PartsTable = new DataGridView();
            PartID = new DataGridViewTextBoxColumn();
            Name1 = new DataGridViewTextBoxColumn();
            Inventory = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Min = new DataGridViewTextBoxColumn();
            Max = new DataGridViewTextBoxColumn();
            IMSLabel = new Label();
            PartsLabel = new Label();
            ProductsTable = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            Name2 = new DataGridViewTextBoxColumn();
            Inventory1 = new DataGridViewTextBoxColumn();
            Price1 = new DataGridViewTextBoxColumn();
            Min1 = new DataGridViewTextBoxColumn();
            Max1 = new DataGridViewTextBoxColumn();
            ProductsLabel = new Label();
            SearchBar = new TextBox();
            SearchButton = new Button();
            SearchBar1 = new TextBox();
            SearchuButton1 = new Button();
            AddButton = new Button();
            ModifyButton = new Button();
            DeleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PartsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductsTable).BeginInit();
            SuspendLayout();
            // 
            // PartsTable
            // 
            PartsTable.AccessibleName = "PartsTable";
            PartsTable.AllowUserToResizeColumns = false;
            PartsTable.AllowUserToResizeRows = false;
            PartsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PartsTable.Columns.AddRange(new DataGridViewColumn[] { PartID, Name1, Inventory, Price, Min, Max });
            PartsTable.Location = new Point(12, 95);
            PartsTable.MultiSelect = false;
            PartsTable.Name = "PartsTable";
            PartsTable.RowHeadersVisible = false;
            PartsTable.RowTemplate.Height = 25;
            PartsTable.ShowEditingIcon = false;
            PartsTable.ShowRowErrors = false;
            PartsTable.Size = new Size(607, 299);
            PartsTable.TabIndex = 0;
            // 
            // PartID
            // 
            PartID.HeaderText = "Part ID";
            PartID.Name = "PartID";
            PartID.ReadOnly = true;
            // 
            // Name1
            // 
            Name1.HeaderText = "Name";
            Name1.Name = "Name1";
            Name1.ReadOnly = true;
            // 
            // Inventory
            // 
            Inventory.HeaderText = "Inventory";
            Inventory.Name = "Inventory";
            Inventory.ReadOnly = true;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Min
            // 
            Min.HeaderText = "Min";
            Min.Name = "Min";
            Min.ReadOnly = true;
            // 
            // Max
            // 
            Max.HeaderText = "Max";
            Max.Name = "Max";
            Max.ReadOnly = true;
            // 
            // IMSLabel
            // 
            IMSLabel.AutoSize = true;
            IMSLabel.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            IMSLabel.Location = new Point(503, 9);
            IMSLabel.Name = "IMSLabel";
            IMSLabel.Size = new Size(348, 31);
            IMSLabel.TabIndex = 1;
            IMSLabel.Text = "Inventory Management System";
            // 
            // PartsLabel
            // 
            PartsLabel.AutoSize = true;
            PartsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PartsLabel.Location = new Point(12, 71);
            PartsLabel.Name = "PartsLabel";
            PartsLabel.Size = new Size(44, 21);
            PartsLabel.TabIndex = 3;
            PartsLabel.Text = "Parts";
            // 
            // ProductsTable
            // 
            ProductsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsTable.Columns.AddRange(new DataGridViewColumn[] { ProductID, Name2, Inventory1, Price1, Min1, Max1 });
            ProductsTable.Location = new Point(641, 95);
            ProductsTable.Name = "ProductsTable";
            ProductsTable.RowHeadersVisible = false;
            ProductsTable.RowTemplate.Height = 25;
            ProductsTable.Size = new Size(608, 299);
            ProductsTable.TabIndex = 4;
            // 
            // ProductID
            // 
            ProductID.HeaderText = "Product ID";
            ProductID.Name = "ProductID";
            ProductID.ReadOnly = true;
            // 
            // Name2
            // 
            Name2.HeaderText = "Name";
            Name2.Name = "Name2";
            Name2.ReadOnly = true;
            // 
            // Inventory1
            // 
            Inventory1.HeaderText = "Inventory";
            Inventory1.Name = "Inventory1";
            Inventory1.ReadOnly = true;
            // 
            // Price1
            // 
            Price1.HeaderText = "Price";
            Price1.Name = "Price1";
            Price1.ReadOnly = true;
            // 
            // Min1
            // 
            Min1.HeaderText = "Min";
            Min1.Name = "Min1";
            Min1.ReadOnly = true;
            // 
            // Max1
            // 
            Max1.HeaderText = "Max";
            Max1.Name = "Max1";
            Max1.ReadOnly = true;
            // 
            // ProductsLabel
            // 
            ProductsLabel.AutoSize = true;
            ProductsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProductsLabel.Location = new Point(641, 71);
            ProductsLabel.Name = "ProductsLabel";
            ProductsLabel.Size = new Size(71, 21);
            ProductsLabel.TabIndex = 5;
            ProductsLabel.Text = "Products";
            // 
            // SearchBar
            // 
            SearchBar.BorderStyle = BorderStyle.FixedSingle;
            SearchBar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SearchBar.Location = new Point(415, 63);
            SearchBar.Name = "SearchBar";
            SearchBar.Size = new Size(204, 29);
            SearchBar.TabIndex = 6;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(334, 60);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 29);
            SearchButton.TabIndex = 7;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchBar1
            // 
            SearchBar1.BorderStyle = BorderStyle.FixedSingle;
            SearchBar1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SearchBar1.Location = new Point(1045, 60);
            SearchBar1.Name = "SearchBar1";
            SearchBar1.Size = new Size(204, 29);
            SearchBar1.TabIndex = 8;
            // 
            // SearchuButton1
            // 
            SearchuButton1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SearchuButton1.Location = new Point(964, 60);
            SearchuButton1.Name = "SearchuButton1";
            SearchuButton1.Size = new Size(75, 29);
            SearchuButton1.TabIndex = 9;
            SearchuButton1.Text = "Search";
            SearchuButton1.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(382, 400);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 29);
            AddButton.TabIndex = 10;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // ModifyButton
            // 
            ModifyButton.Location = new Point(463, 400);
            ModifyButton.Name = "ModifyButton";
            ModifyButton.Size = new Size(75, 29);
            ModifyButton.TabIndex = 11;
            ModifyButton.Text = "Modify";
            ModifyButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(544, 400);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 29);
            DeleteButton.TabIndex = 12;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 512);
            Controls.Add(DeleteButton);
            Controls.Add(ModifyButton);
            Controls.Add(AddButton);
            Controls.Add(SearchuButton1);
            Controls.Add(SearchBar1);
            Controls.Add(SearchButton);
            Controls.Add(SearchBar);
            Controls.Add(ProductsLabel);
            Controls.Add(ProductsTable);
            Controls.Add(PartsLabel);
            Controls.Add(IMSLabel);
            Controls.Add(PartsTable);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)PartsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView PartsTable;
        private DataGridViewTextBoxColumn PartID;
        private DataGridViewTextBoxColumn Name1;
        private DataGridViewTextBoxColumn Inventory;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Min;
        private DataGridViewTextBoxColumn Max;
        private Label IMSLabel;
        private Label PartsLabel;
        private DataGridView ProductsTable;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn Name2;
        private DataGridViewTextBoxColumn Inventory1;
        private DataGridViewTextBoxColumn Price1;
        private DataGridViewTextBoxColumn Min1;
        private DataGridViewTextBoxColumn Max1;
        private Label ProductsLabel;
        private TextBox SearchBar;
        private Button SearchButton;
        private TextBox SearchBar1;
        private Button SearchuButton1;
        private Button AddButton;
        private Button ModifyButton;
        private Button DeleteButton;
    }
}