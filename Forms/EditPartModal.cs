using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968
{
    public partial class EditPartModal : Form
    {
        public string PartID { get; private set; }
        public string PartName { get; private set; }
        public string Inventory { get; private set; }
        public string Price { get; private set; }
        public string Min { get; private set; }
        public string Max { get; private set; }
        public string? MachineID { get; private set; }
        public string? CompanyName { get; private set; }

        public EditPartModal(string partID, string name, string inventory, string price, string min, string max, string machineID, string companyName)
        {
            InitializeComponent();
            IDTextBox.Text = partID;
            NameTextBox.Text = name;
            InventoryTextBox.Text = inventory;
            PartCostTextBox.Text = price;
            MinTextBox.Text = min;
            MaxTextBox.Text = max;
            MachineIDTextBox.Text = machineID;
            CompanyNameTextBox.Text = companyName;
            if (machineID != null)
            {
                MachineIDTextBox.Visible = true;
                MachineIDLabel.Visible = true;
                CompanyNameTextBox.Visible = false;
                CompanyNameLabel.Visible = false;
                InHouseRadio.Checked = true;
            }
            else if (companyName != null)
            {
                CompanyNameTextBox.Visible = true;
                CompanyNameLabel.Visible = true;
                MachineIDLabel.Visible = false;
                MachineIDTextBox.Visible = false;
                OutsourceRadio.Checked = true;
            }
            InHouseRadio.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            OutsourceRadio.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            SaveButton.Click += new EventHandler(SaveButton_Click);
            CancelButton.Click += new EventHandler(cancelButton_Click);
        }
        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (InHouseRadio.Checked)
            {
                MachineIDLabel.Visible = true;
                MachineIDTextBox.Visible = true;
                MachineIDTextBox.Enabled = true;
                CompanyNameLabel.Visible = false;
                CompanyNameTextBox.Visible = false;
            }
            else if (OutsourceRadio.Checked)
            {
                MachineIDLabel.Visible = false;
                MachineIDTextBox.Visible = false;
                CompanyNameLabel.Visible = true;
                CompanyNameTextBox.Visible = true;
                CompanyNameTextBox.Enabled = true;
            }
            NameTextBox.Enabled = true;
            InventoryTextBox.Enabled = true;
            PartCostTextBox.Enabled = true;
            MinTextBox.Enabled = true;
            MaxTextBox.Enabled = true;

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int machineID = 0;
            bool isMachineIDParsed = false;

            if (InHouseRadio.Checked)
            {
                isMachineIDParsed = int.TryParse(MachineIDTextBox.Text, out machineID);
            }

            if (!int.TryParse(IDTextBox.Text, out int partID) ||
                string.IsNullOrWhiteSpace(NameTextBox.Text) ||
                !int.TryParse(InventoryTextBox.Text, out int inventory) ||
                !decimal.TryParse(PartCostTextBox.Text, out decimal price) ||
                !int.TryParse(MinTextBox.Text, out int min) ||
                !int.TryParse(MaxTextBox.Text, out int max) ||
                (InHouseRadio.Checked && !isMachineIDParsed) ||
                (OutsourceRadio.Checked && string.IsNullOrWhiteSpace(CompanyNameTextBox.Text)))
            {
                MessageBox.Show("Please correct your input. Ensure all fields are filled out correctly and numerical fields contain valid numbers.", "Input Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (min > max)
            {
                MessageBox.Show("Minimum value cannot be greater than maximum value.", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PartID = IDTextBox.Text;
            PartName = NameTextBox.Text;
            Inventory = InventoryTextBox.Text;
            Price = PartCostTextBox.Text;
            Min = MinTextBox.Text;
            Max = MaxTextBox.Text;
            if (InHouseRadio.Checked)
            {
                MachineID = machineID.ToString();
                CompanyName = null;
            }
            else if (OutsourceRadio.Checked)
            {
                CompanyName = CompanyNameTextBox.Text;
                MachineID = null;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
