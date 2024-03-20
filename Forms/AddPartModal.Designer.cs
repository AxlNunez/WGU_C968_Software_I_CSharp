namespace C968
{
    partial class AddPartModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPartModal));
            InHouseRadio = new RadioButton();
            label1 = new Label();
            OutsourceRadio = new RadioButton();
            IDLabel = new Label();
            NameLabel = new Label();
            InventoryLabel = new Label();
            PartCostLabel = new Label();
            MaxLabel = new Label();
            MachineIDLabel = new Label();
            CompanyNameLabel = new Label();
            IDTextBox = new TextBox();
            NameTextBox = new TextBox();
            InventoryTextBox = new TextBox();
            PartCostTextBox = new TextBox();
            MaxTextBox = new TextBox();
            MachineIDTextBox = new TextBox();
            CompanyNameTextBox = new TextBox();
            SaveButton = new Button();
            CancelButton = new Button();
            MinTextBox = new TextBox();
            MinLabel = new Label();
            SuspendLayout();
            // 
            // InHouseRadio
            // 
            InHouseRadio.AutoSize = true;
            InHouseRadio.Location = new Point(113, 12);
            InHouseRadio.Name = "InHouseRadio";
            InHouseRadio.Size = new Size(74, 19);
            InHouseRadio.TabIndex = 0;
            InHouseRadio.Text = "In-House";
            InHouseRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 1;
            label1.Text = "Add Part";
            // 
            // OutsourceRadio
            // 
            OutsourceRadio.AutoSize = true;
            OutsourceRadio.Location = new Point(205, 12);
            OutsourceRadio.Name = "OutsourceRadio";
            OutsourceRadio.Size = new Size(87, 19);
            OutsourceRadio.TabIndex = 2;
            OutsourceRadio.Text = "Outsourced";
            OutsourceRadio.UseVisualStyleBackColor = true;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(79, 62);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(18, 15);
            IDLabel.TabIndex = 3;
            IDLabel.Text = "ID";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(58, 89);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 4;
            NameLabel.Text = "Name";
            // 
            // InventoryLabel
            // 
            InventoryLabel.AutoSize = true;
            InventoryLabel.Location = new Point(40, 116);
            InventoryLabel.Name = "InventoryLabel";
            InventoryLabel.Size = new Size(57, 15);
            InventoryLabel.TabIndex = 5;
            InventoryLabel.Text = "Inventory";
            // 
            // PartCostLabel
            // 
            PartCostLabel.AutoSize = true;
            PartCostLabel.Location = new Point(34, 146);
            PartCostLabel.Name = "PartCostLabel";
            PartCostLabel.Size = new Size(63, 15);
            PartCostLabel.TabIndex = 6;
            PartCostLabel.Text = "Part / Cost";
            // 
            // MaxLabel
            // 
            MaxLabel.AutoSize = true;
            MaxLabel.Location = new Point(67, 204);
            MaxLabel.Name = "MaxLabel";
            MaxLabel.Size = new Size(30, 15);
            MaxLabel.TabIndex = 7;
            MaxLabel.Text = "Max";
            // 
            // MachineIDLabel
            // 
            MachineIDLabel.AutoSize = true;
            MachineIDLabel.Location = new Point(30, 232);
            MachineIDLabel.Name = "MachineIDLabel";
            MachineIDLabel.Size = new Size(67, 15);
            MachineIDLabel.TabIndex = 8;
            MachineIDLabel.Text = "Machine ID";
            MachineIDLabel.Visible = false;
            // 
            // CompanyNameLabel
            // 
            CompanyNameLabel.AutoSize = true;
            CompanyNameLabel.Location = new Point(12, 232);
            CompanyNameLabel.Name = "CompanyNameLabel";
            CompanyNameLabel.Size = new Size(94, 15);
            CompanyNameLabel.TabIndex = 9;
            CompanyNameLabel.Text = "Company Name";
            CompanyNameLabel.Visible = false;
            // 
            // IDTextBox
            // 
            IDTextBox.BorderStyle = BorderStyle.FixedSingle;
            IDTextBox.Enabled = false;
            IDTextBox.Location = new Point(113, 62);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(100, 23);
            IDTextBox.TabIndex = 10;
            // 
            // NameTextBox
            // 
            NameTextBox.BorderStyle = BorderStyle.FixedSingle;
            NameTextBox.Enabled = false;
            NameTextBox.Location = new Point(113, 89);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(100, 23);
            NameTextBox.TabIndex = 11;
            // 
            // InventoryTextBox
            // 
            InventoryTextBox.BorderStyle = BorderStyle.FixedSingle;
            InventoryTextBox.Enabled = false;
            InventoryTextBox.Location = new Point(113, 116);
            InventoryTextBox.Name = "InventoryTextBox";
            InventoryTextBox.Size = new Size(100, 23);
            InventoryTextBox.TabIndex = 12;
            // 
            // PartCostTextBox
            // 
            PartCostTextBox.BorderStyle = BorderStyle.FixedSingle;
            PartCostTextBox.Enabled = false;
            PartCostTextBox.Location = new Point(113, 143);
            PartCostTextBox.Name = "PartCostTextBox";
            PartCostTextBox.Size = new Size(100, 23);
            PartCostTextBox.TabIndex = 13;
            // 
            // MaxTextBox
            // 
            MaxTextBox.BorderStyle = BorderStyle.FixedSingle;
            MaxTextBox.Enabled = false;
            MaxTextBox.Location = new Point(113, 200);
            MaxTextBox.Name = "MaxTextBox";
            MaxTextBox.Size = new Size(100, 23);
            MaxTextBox.TabIndex = 14;
            // 
            // MachineIDTextBox
            // 
            MachineIDTextBox.BorderStyle = BorderStyle.FixedSingle;
            MachineIDTextBox.Enabled = false;
            MachineIDTextBox.Location = new Point(113, 230);
            MachineIDTextBox.Name = "MachineIDTextBox";
            MachineIDTextBox.Size = new Size(100, 23);
            MachineIDTextBox.TabIndex = 15;
            MachineIDTextBox.Visible = false;
            // 
            // CompanyNameTextBox
            // 
            CompanyNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            CompanyNameTextBox.Enabled = false;
            CompanyNameTextBox.Location = new Point(113, 230);
            CompanyNameTextBox.Name = "CompanyNameTextBox";
            CompanyNameTextBox.Size = new Size(100, 23);
            CompanyNameTextBox.TabIndex = 16;
            CompanyNameTextBox.Visible = false;
            // 
            // SaveButton
            // 
            SaveButton.Enabled = false;
            SaveButton.Location = new Point(79, 268);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 17;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(173, 268);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 18;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // MinTextBox
            // 
            MinTextBox.BorderStyle = BorderStyle.FixedSingle;
            MinTextBox.Enabled = false;
            MinTextBox.Location = new Point(113, 171);
            MinTextBox.Name = "MinTextBox";
            MinTextBox.Size = new Size(100, 23);
            MinTextBox.TabIndex = 20;
            // 
            // MinLabel
            // 
            MinLabel.AutoSize = true;
            MinLabel.Location = new Point(67, 175);
            MinLabel.Name = "MinLabel";
            MinLabel.Size = new Size(28, 15);
            MinLabel.TabIndex = 19;
            MinLabel.Text = "Min";
            // 
            // AddPartModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 314);
            Controls.Add(MinTextBox);
            Controls.Add(MinLabel);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(CompanyNameTextBox);
            Controls.Add(MachineIDTextBox);
            Controls.Add(MaxTextBox);
            Controls.Add(PartCostTextBox);
            Controls.Add(InventoryTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(IDTextBox);
            Controls.Add(CompanyNameLabel);
            Controls.Add(MachineIDLabel);
            Controls.Add(MaxLabel);
            Controls.Add(PartCostLabel);
            Controls.Add(InventoryLabel);
            Controls.Add(NameLabel);
            Controls.Add(IDLabel);
            Controls.Add(OutsourceRadio);
            Controls.Add(label1);
            Controls.Add(InHouseRadio);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddPartModal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Part";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton InHouseRadio;
        private Label label1;
        private RadioButton OutsourceRadio;
        private Label IDLabel;
        private Label NameLabel;
        private Label InventoryLabel;
        private Label PartCostLabel;
        private Label MaxLabel;
        private Label MachineIDLabel;
        private Label CompanyNameLabel;
        private TextBox IDTextBox;
        private TextBox NameTextBox;
        private TextBox InventoryTextBox;
        private TextBox PartCostTextBox;
        private TextBox MaxTextBox;
        private TextBox MachineIDTextBox;
        private TextBox CompanyNameTextBox;
        private Button SaveButton;
        private Button CancelButton;
        private TextBox MinTextBox;
        private Label MinLabel;
    }
}