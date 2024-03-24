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
            InStock = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Min = new DataGridViewTextBoxColumn();
            Max = new DataGridViewTextBoxColumn();
            MachineID = new DataGridViewTextBoxColumn();
            CompanyName = new DataGridViewTextBoxColumn();
            IMSLabel = new Label();
            PartsLabel = new Label();
            ProductsTable = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            Name2 = new DataGridViewTextBoxColumn();
            InStock1 = new DataGridViewTextBoxColumn();
            Price1 = new DataGridViewTextBoxColumn();
            Min1 = new DataGridViewTextBoxColumn();
            Max1 = new DataGridViewTextBoxColumn();
            ProductsLabel = new Label();
            PartsSearchTextBox = new TextBox();
            PartsSearchButton = new Button();
            ProductSearchTextBox = new TextBox();
            ProductSearchButton = new Button();
            PartsAddButton = new Button();
            PartsModifyButton = new Button();
            PartsDeleteButton = new Button();
            ProductDeleteButton = new Button();
            ProductModifyButton = new Button();
            ProductAddButton = new Button();
            ExitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PartsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductsTable).BeginInit();
            SuspendLayout();
            // 
            // PartsTable
            // 
            PartsTable.AccessibleName = "PartsTable";
            PartsTable.AllowUserToAddRows = false;
            PartsTable.AllowUserToResizeColumns = false;
            PartsTable.AllowUserToResizeRows = false;
            PartsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PartsTable.Columns.AddRange(new DataGridViewColumn[] { PartID, Name1, InStock, Price, Min, Max, MachineID, CompanyName });
            PartsTable.Location = new Point(12, 95);
            PartsTable.MultiSelect = false;
            PartsTable.Name = "PartsTable";
            PartsTable.RowHeadersVisible = false;
            PartsTable.RowTemplate.Height = 25;
            PartsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            // InStock
            // 
            InStock.HeaderText = "Inventory";
            InStock.Name = "InStock";
            InStock.ReadOnly = true;
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
            // MachineID
            // 
            MachineID.HeaderText = "Machine ID";
            MachineID.Name = "MachineID";
            MachineID.ReadOnly = true;
            MachineID.Visible = false;
            // 
            // CompanyName
            // 
            CompanyName.HeaderText = "Company Name";
            CompanyName.Name = "CompanyName";
            CompanyName.Visible = false;
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
            ProductsTable.AllowUserToAddRows = false;
            ProductsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsTable.Columns.AddRange(new DataGridViewColumn[] { ProductID, Name2, InStock1, Price1, Min1, Max1 });
            ProductsTable.Location = new Point(641, 95);
            ProductsTable.Name = "ProductsTable";
            ProductsTable.RowHeadersVisible = false;
            ProductsTable.RowTemplate.Height = 25;
            ProductsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            // InStock1
            // 
            InStock1.HeaderText = "Inventory";
            InStock1.Name = "InStock1";
            InStock1.ReadOnly = true;
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
            // PartsSearchTextBox
            // 
            PartsSearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            PartsSearchTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PartsSearchTextBox.Location = new Point(415, 63);
            PartsSearchTextBox.Name = "PartsSearchTextBox";
            PartsSearchTextBox.PlaceholderText = "Please enter a Part ID";
            PartsSearchTextBox.Size = new Size(204, 29);
            PartsSearchTextBox.TabIndex = 6;
            // 
            // PartsSearchButton
            // 
            PartsSearchButton.Location = new Point(334, 60);
            PartsSearchButton.Name = "PartsSearchButton";
            PartsSearchButton.Size = new Size(75, 29);
            PartsSearchButton.TabIndex = 7;
            PartsSearchButton.Text = "Search";
            PartsSearchButton.UseVisualStyleBackColor = true;
            // 
            // ProductSearchTextBox
            // 
            ProductSearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            ProductSearchTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProductSearchTextBox.Location = new Point(1045, 60);
            ProductSearchTextBox.Name = "ProductSearchTextBox";
            ProductSearchTextBox.PlaceholderText = "Please enter a Product ID";
            ProductSearchTextBox.Size = new Size(204, 29);
            ProductSearchTextBox.TabIndex = 8;
            // 
            // ProductSearchButton
            // 
            ProductSearchButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ProductSearchButton.Location = new Point(964, 60);
            ProductSearchButton.Name = "ProductSearchButton";
            ProductSearchButton.Size = new Size(75, 29);
            ProductSearchButton.TabIndex = 9;
            ProductSearchButton.Text = "Search";
            ProductSearchButton.UseVisualStyleBackColor = true;
            // 
            // PartsAddButton
            // 
            PartsAddButton.Location = new Point(382, 400);
            PartsAddButton.Name = "PartsAddButton";
            PartsAddButton.Size = new Size(75, 29);
            PartsAddButton.TabIndex = 10;
            PartsAddButton.Text = "Add";
            PartsAddButton.UseVisualStyleBackColor = true;
            // 
            // PartsModifyButton
            // 
            PartsModifyButton.Location = new Point(463, 400);
            PartsModifyButton.Name = "PartsModifyButton";
            PartsModifyButton.Size = new Size(75, 29);
            PartsModifyButton.TabIndex = 11;
            PartsModifyButton.Text = "Modify";
            PartsModifyButton.UseVisualStyleBackColor = true;
            // 
            // PartsDeleteButton
            // 
            PartsDeleteButton.Location = new Point(544, 400);
            PartsDeleteButton.Name = "PartsDeleteButton";
            PartsDeleteButton.Size = new Size(75, 29);
            PartsDeleteButton.TabIndex = 12;
            PartsDeleteButton.Text = "Delete";
            PartsDeleteButton.UseVisualStyleBackColor = true;
            // 
            // ProductDeleteButton
            // 
            ProductDeleteButton.Location = new Point(1172, 400);
            ProductDeleteButton.Name = "ProductDeleteButton";
            ProductDeleteButton.Size = new Size(75, 29);
            ProductDeleteButton.TabIndex = 15;
            ProductDeleteButton.Text = "Delete";
            ProductDeleteButton.UseVisualStyleBackColor = true;
            // 
            // ProductModifyButton
            // 
            ProductModifyButton.Location = new Point(1091, 400);
            ProductModifyButton.Name = "ProductModifyButton";
            ProductModifyButton.Size = new Size(75, 29);
            ProductModifyButton.TabIndex = 14;
            ProductModifyButton.Text = "Modify";
            ProductModifyButton.UseVisualStyleBackColor = true;
            // 
            // ProductAddButton
            // 
            ProductAddButton.Location = new Point(1010, 400);
            ProductAddButton.Name = "ProductAddButton";
            ProductAddButton.Size = new Size(75, 29);
            ProductAddButton.TabIndex = 13;
            ProductAddButton.Text = "Add";
            ProductAddButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(1172, 435);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 29);
            ExitButton.TabIndex = 16;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 512);
            Controls.Add(ExitButton);
            Controls.Add(ProductDeleteButton);
            Controls.Add(ProductModifyButton);
            Controls.Add(ProductAddButton);
            Controls.Add(PartsDeleteButton);
            Controls.Add(PartsModifyButton);
            Controls.Add(PartsAddButton);
            Controls.Add(ProductSearchButton);
            Controls.Add(ProductSearchTextBox);
            Controls.Add(PartsSearchButton);
            Controls.Add(PartsSearchTextBox);
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
        private Label IMSLabel;
        private Label PartsLabel;
        private DataGridView ProductsTable;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn Name2;
        private DataGridViewTextBoxColumn InStock1;
        private DataGridViewTextBoxColumn Price1;
        private DataGridViewTextBoxColumn Min1;
        private DataGridViewTextBoxColumn Max1;
        private Label ProductsLabel;
        private TextBox PartsSearchTextBox;
        private Button PartsSearchButton;
        private TextBox ProductSearchTextBox;
        private Button ProductSearchButton;
        private Button PartsAddButton;
        private Button PartsModifyButton;
        private Button PartsDeleteButton;
        private DataGridViewTextBoxColumn PartID;
        private DataGridViewTextBoxColumn Name1;
        private DataGridViewTextBoxColumn InStock;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Min;
        private DataGridViewTextBoxColumn Max;
        private DataGridViewTextBoxColumn MachineID;
        private DataGridViewTextBoxColumn CompanyName;
        private Button ProductDeleteButton;
        private Button ProductModifyButton;
        private Button ProductAddButton;
        private Button ExitButton;
    }
}