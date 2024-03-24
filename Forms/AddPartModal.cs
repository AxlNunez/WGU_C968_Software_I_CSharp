using C968.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968
{
    public partial class AddPartModal : Form
    {
        public Part CreatedPart { get; private set; }

        public AddPartModal(int nextPartID)
        {
            InitializeComponent();
            IDTextBox.Text = nextPartID.ToString();
            InHouseRadio.CheckedChanged += radioButtons_CheckedChanged;
            OutsourceRadio.CheckedChanged += radioButtons_CheckedChanged;
            CancelButton.Click += cancelButton_Click;
            NameTextBox.TextChanged += (s, e) => UpdateSaveButtonState();
            InventoryTextBox.TextChanged += (s, e) => UpdateSaveButtonState();
            PartCostTextBox.TextChanged += (s, e) => UpdateSaveButtonState();
            MinTextBox.TextChanged += (s, e) => UpdateSaveButtonState();
            MaxTextBox.TextChanged += (s, e) => UpdateSaveButtonState();
            CompanyNameTextBox.TextChanged += (s, e) => UpdateSaveButtonState();
            MachineIDTextBox.TextChanged += (s, e) => UpdateSaveButtonState();
            InHouseRadio.CheckedChanged += (s, e) => UpdateSaveButtonState();
            OutsourceRadio.CheckedChanged += (s, e) => UpdateSaveButtonState();
            UpdateSaveButtonState();
            SaveButton.Click += SaveButton_Click;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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

        private void UpdateSaveButtonState()
        {
            bool allFieldsFilled = true;

            TextBox[] mandatoryTextboxes = new TextBox[]
            {
        NameTextBox, InventoryTextBox, PartCostTextBox, MinTextBox, MaxTextBox
            };

            foreach (TextBox tb in mandatoryTextboxes)
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    allFieldsFilled = false;
                    break;
                }
            }

            if (InHouseRadio.Checked)
            {
                allFieldsFilled &= !string.IsNullOrWhiteSpace(MachineIDTextBox.Text);
            }
            else if (OutsourceRadio.Checked)
            {
                allFieldsFilled &= !string.IsNullOrWhiteSpace(CompanyNameTextBox.Text);
            }

            SaveButton.Enabled = allFieldsFilled;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int machineID = 0;

            if (!int.TryParse(IDTextBox.Text, out int partID) ||
                string.IsNullOrWhiteSpace(NameTextBox.Text) ||
                !int.TryParse(InventoryTextBox.Text, out int inventory) ||
                !decimal.TryParse(PartCostTextBox.Text, out decimal price) ||
                !int.TryParse(MinTextBox.Text, out int min) ||
                !int.TryParse(MaxTextBox.Text, out int max) ||
                (InHouseRadio.Checked && !int.TryParse(MachineIDTextBox.Text, out machineID)) ||
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

            if (InHouseRadio.Checked)
            {
                CreatedPart = new Inhouse(partID, NameTextBox.Text, inventory, price, min, max, machineID);
            }
            else if (OutsourceRadio.Checked)
            {
                CreatedPart = new Outsourced(partID, NameTextBox.Text, inventory, price, min, max, CompanyNameTextBox.Text);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
