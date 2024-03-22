namespace C968.Forms
{
    partial class AddProductModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductModal));
            AddProductLabel = new Label();
            MinTextBox = new TextBox();
            MinLabel = new Label();
            MaxTextBox = new TextBox();
            PartCostTextBox = new TextBox();
            InventoryTextBox = new TextBox();
            NameTextBox = new TextBox();
            IDTextBox = new TextBox();
            MaxLabel = new Label();
            PartCostLabel = new Label();
            InventoryLabel = new Label();
            NameLabel = new Label();
            IDLabel = new Label();
            SearchButton = new Button();
            SearchBar = new TextBox();
            PartsLabel = new Label();
            PartsTable = new DataGridView();
            PartID = new DataGridViewTextBoxColumn();
            Name1 = new DataGridViewTextBoxColumn();
            InStock = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Min = new DataGridViewTextBoxColumn();
            Max = new DataGridViewTextBoxColumn();
            MachineID = new DataGridViewTextBoxColumn();
            CompanyName = new DataGridViewTextBoxColumn();
            ProductPartsTable = new DataGridView();
            PartID1 = new DataGridViewTextBoxColumn();
            Name2 = new DataGridViewTextBoxColumn();
            InStock1 = new DataGridViewTextBoxColumn();
            Price1 = new DataGridViewTextBoxColumn();
            Min1 = new DataGridViewTextBoxColumn();
            Max1 = new DataGridViewTextBoxColumn();
            MachineID1 = new DataGridViewTextBoxColumn();
            CompanyName1 = new DataGridViewTextBoxColumn();
            PartsDeleteButton = new Button();
            PartsAddButton = new Button();
            CancelButton = new Button();
            SaveButton = new Button();
            ProductPartsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)PartsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductPartsTable).BeginInit();
            SuspendLayout();
            // 
            // AddProductLabel
            // 
            AddProductLabel.AutoSize = true;
            AddProductLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddProductLabel.Location = new Point(12, 20);
            AddProductLabel.Name = "AddProductLabel";
            AddProductLabel.Size = new Size(105, 21);
            AddProductLabel.TabIndex = 2;
            AddProductLabel.Text = "Add Product";
            // 
            // MinTextBox
            // 
            MinTextBox.BorderStyle = BorderStyle.FixedSingle;
            MinTextBox.Location = new Point(102, 182);
            MinTextBox.Name = "MinTextBox";
            MinTextBox.PlaceholderText = "Enter a number";
            MinTextBox.Size = new Size(100, 23);
            MinTextBox.TabIndex = 25;
            // 
            // MinLabel
            // 
            MinLabel.AutoSize = true;
            MinLabel.Location = new Point(56, 186);
            MinLabel.Name = "MinLabel";
            MinLabel.Size = new Size(28, 15);
            MinLabel.TabIndex = 31;
            MinLabel.Text = "Min";
            // 
            // MaxTextBox
            // 
            MaxTextBox.BorderStyle = BorderStyle.FixedSingle;
            MaxTextBox.Location = new Point(102, 211);
            MaxTextBox.Name = "MaxTextBox";
            MaxTextBox.PlaceholderText = "Enter a number";
            MaxTextBox.Size = new Size(100, 23);
            MaxTextBox.TabIndex = 27;
            // 
            // PartCostTextBox
            // 
            PartCostTextBox.BorderStyle = BorderStyle.FixedSingle;
            PartCostTextBox.Location = new Point(102, 154);
            PartCostTextBox.Name = "PartCostTextBox";
            PartCostTextBox.PlaceholderText = "Enter a decimal";
            PartCostTextBox.Size = new Size(100, 23);
            PartCostTextBox.TabIndex = 23;
            // 
            // InventoryTextBox
            // 
            InventoryTextBox.BorderStyle = BorderStyle.FixedSingle;
            InventoryTextBox.Location = new Point(102, 127);
            InventoryTextBox.Name = "InventoryTextBox";
            InventoryTextBox.PlaceholderText = "Enter a number";
            InventoryTextBox.Size = new Size(100, 23);
            InventoryTextBox.TabIndex = 22;
            // 
            // NameTextBox
            // 
            NameTextBox.BorderStyle = BorderStyle.FixedSingle;
            NameTextBox.Location = new Point(102, 100);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PlaceholderText = "Enter text";
            NameTextBox.Size = new Size(100, 23);
            NameTextBox.TabIndex = 20;
            // 
            // IDTextBox
            // 
            IDTextBox.BorderStyle = BorderStyle.FixedSingle;
            IDTextBox.Enabled = false;
            IDTextBox.Location = new Point(102, 73);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(100, 23);
            IDTextBox.TabIndex = 21;
            // 
            // MaxLabel
            // 
            MaxLabel.AutoSize = true;
            MaxLabel.Location = new Point(56, 215);
            MaxLabel.Name = "MaxLabel";
            MaxLabel.Size = new Size(30, 15);
            MaxLabel.TabIndex = 30;
            MaxLabel.Text = "Max";
            // 
            // PartCostLabel
            // 
            PartCostLabel.AutoSize = true;
            PartCostLabel.Location = new Point(23, 157);
            PartCostLabel.Name = "PartCostLabel";
            PartCostLabel.Size = new Size(63, 15);
            PartCostLabel.TabIndex = 29;
            PartCostLabel.Text = "Part / Cost";
            // 
            // InventoryLabel
            // 
            InventoryLabel.AutoSize = true;
            InventoryLabel.Location = new Point(29, 127);
            InventoryLabel.Name = "InventoryLabel";
            InventoryLabel.Size = new Size(57, 15);
            InventoryLabel.TabIndex = 28;
            InventoryLabel.Text = "Inventory";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(47, 100);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 26;
            NameLabel.Text = "Name";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(68, 73);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(18, 15);
            IDLabel.TabIndex = 24;
            IDLabel.Text = "ID";
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(574, 12);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 29);
            SearchButton.TabIndex = 35;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchBar
            // 
            SearchBar.BorderStyle = BorderStyle.FixedSingle;
            SearchBar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SearchBar.Location = new Point(655, 15);
            SearchBar.Name = "SearchBar";
            SearchBar.PlaceholderText = "Please enter a Part ID";
            SearchBar.Size = new Size(204, 29);
            SearchBar.TabIndex = 34;
            // 
            // PartsLabel
            // 
            PartsLabel.AutoSize = true;
            PartsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PartsLabel.Location = new Point(252, 23);
            PartsLabel.Name = "PartsLabel";
            PartsLabel.Size = new Size(129, 21);
            PartsLabel.TabIndex = 33;
            PartsLabel.Text = "All cadidate parts";
            // 
            // PartsTable
            // 
            PartsTable.AccessibleName = "PartsTable";
            PartsTable.AllowUserToAddRows = false;
            PartsTable.AllowUserToResizeColumns = false;
            PartsTable.AllowUserToResizeRows = false;
            PartsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PartsTable.Columns.AddRange(new DataGridViewColumn[] { PartID, Name1, InStock, Price, Min, Max, MachineID, CompanyName });
            PartsTable.Location = new Point(252, 47);
            PartsTable.MultiSelect = false;
            PartsTable.Name = "PartsTable";
            PartsTable.RowHeadersVisible = false;
            PartsTable.RowTemplate.Height = 25;
            PartsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PartsTable.ShowEditingIcon = false;
            PartsTable.ShowRowErrors = false;
            PartsTable.Size = new Size(607, 299);
            PartsTable.TabIndex = 32;
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
            // ProductPartsTable
            // 
            ProductPartsTable.AccessibleName = "ProductPartsTable";
            ProductPartsTable.AllowUserToAddRows = false;
            ProductPartsTable.AllowUserToResizeColumns = false;
            ProductPartsTable.AllowUserToResizeRows = false;
            ProductPartsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductPartsTable.Columns.AddRange(new DataGridViewColumn[] { PartID1, Name2, InStock1, Price1, Min1, Max1, MachineID1, CompanyName1 });
            ProductPartsTable.Location = new Point(252, 400);
            ProductPartsTable.MultiSelect = false;
            ProductPartsTable.Name = "ProductPartsTable";
            ProductPartsTable.RowHeadersVisible = false;
            ProductPartsTable.RowTemplate.Height = 25;
            ProductPartsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductPartsTable.ShowEditingIcon = false;
            ProductPartsTable.ShowRowErrors = false;
            ProductPartsTable.Size = new Size(607, 299);
            ProductPartsTable.TabIndex = 36;
            // 
            // dataGridViewTextBoxColumn1
            // 
            PartID1.HeaderText = "Part ID";
            PartID1.Name = "PartID1";
            PartID1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            Name2.HeaderText = "Name";
            Name2.Name = "Name2";
            Name2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            InStock1.HeaderText = "Inventory";
            InStock1.Name = "InStock1";
            InStock1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            Price1.HeaderText = "Price";
            Price1.Name = "Price1";
            Price1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            Min1.HeaderText = "Min";
            Min1.Name = "Min1";
            Min1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            Max1.HeaderText = "Max";
            Max1.Name = "Max1";
            Max1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            MachineID1.HeaderText = "Machine ID";
            MachineID1.Name = "MachineID1";
            MachineID1.ReadOnly = true;
            MachineID1.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            CompanyName1.HeaderText = "Company Name";
            CompanyName1.Name = "CompanyName1";
            CompanyName1.Visible = false;
            // 
            // PartsDeleteButton
            // 
            PartsDeleteButton.Location = new Point(784, 705);
            PartsDeleteButton.Name = "PartsDeleteButton";
            PartsDeleteButton.Size = new Size(75, 29);
            PartsDeleteButton.TabIndex = 38;
            PartsDeleteButton.Text = "Delete";
            PartsDeleteButton.UseVisualStyleBackColor = true;
            // 
            // PartsAddButton
            // 
            PartsAddButton.Location = new Point(782, 352);
            PartsAddButton.Name = "PartsAddButton";
            PartsAddButton.Size = new Size(75, 29);
            PartsAddButton.TabIndex = 37;
            PartsAddButton.Text = "Add";
            PartsAddButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(784, 743);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 40;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            SaveButton.Enabled = false;
            SaveButton.Location = new Point(703, 743);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 39;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // ProductPartsLabel
            // 
            ProductPartsLabel.AutoSize = true;
            ProductPartsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProductPartsLabel.Location = new Point(252, 376);
            ProductPartsLabel.Name = "ProductPartsLabel";
            ProductPartsLabel.Size = new Size(243, 21);
            ProductPartsLabel.TabIndex = 41;
            ProductPartsLabel.Text = "Parts Associated with this Product";
            // 
            // AddProductModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 773);
            Controls.Add(ProductPartsLabel);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(PartsDeleteButton);
            Controls.Add(PartsAddButton);
            Controls.Add(ProductPartsTable);
            Controls.Add(SearchButton);
            Controls.Add(SearchBar);
            Controls.Add(PartsLabel);
            Controls.Add(PartsTable);
            Controls.Add(MinTextBox);
            Controls.Add(MinLabel);
            Controls.Add(MaxTextBox);
            Controls.Add(PartCostTextBox);
            Controls.Add(InventoryTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(IDTextBox);
            Controls.Add(MaxLabel);
            Controls.Add(PartCostLabel);
            Controls.Add(InventoryLabel);
            Controls.Add(NameLabel);
            Controls.Add(IDLabel);
            Controls.Add(AddProductLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddProductModal";
            Text = "Product";
            ((System.ComponentModel.ISupportInitialize)PartsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductPartsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddProductLabel;
        private TextBox MinTextBox;
        private Label MinLabel;
        private TextBox MaxTextBox;
        private TextBox PartCostTextBox;
        private TextBox InventoryTextBox;
        private TextBox NameTextBox;
        private TextBox IDTextBox;
        private Label MaxLabel;
        private Label PartCostLabel;
        private Label InventoryLabel;
        private Label NameLabel;
        private Label IDLabel;
        private Button SearchButton;
        private TextBox SearchBar;
        private Label PartsLabel;
        private DataGridView PartsTable;
        private DataGridViewTextBoxColumn PartID;
        private DataGridViewTextBoxColumn Name1;
        private DataGridViewTextBoxColumn InStock;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Min;
        private DataGridViewTextBoxColumn Max;
        private DataGridViewTextBoxColumn MachineID;
        private DataGridViewTextBoxColumn CompanyName;
        private DataGridView ProductPartsTable;
        private DataGridViewTextBoxColumn PartID1;
        private DataGridViewTextBoxColumn Name2;
        private DataGridViewTextBoxColumn InStock1;
        private DataGridViewTextBoxColumn Price1;
        private DataGridViewTextBoxColumn Min1;
        private DataGridViewTextBoxColumn Max1;
        private DataGridViewTextBoxColumn MachineID1;
        private DataGridViewTextBoxColumn CompanyName1;
        private Button PartsDeleteButton;
        private Button PartsAddButton;
        private Button CancelButton;
        private Button SaveButton;
        private Label ProductPartsLabel;
    }
}