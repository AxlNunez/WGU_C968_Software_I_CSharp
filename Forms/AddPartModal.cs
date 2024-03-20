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
    public partial class AddPartModal : Form
    {
        public string PartID { get; private set; }
        public string PartName { get; private set; }
        public string Inventory { get; private set; }
        public string Price { get; private set; }
        public string Min { get; private set; }
        public string Max { get; private set; }

        public AddPartModal(int nextPartID)
        {
            InitializeComponent();
            IDTextBox.Text = nextPartID.ToString();
            InHouseRadio.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            OutsourceRadio.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            CancelButton.Click += new EventHandler(cancelButton_Click);
            NameTextBox.TextChanged += (sender, e) => UpdateSaveButtonState();
            InventoryTextBox.TextChanged += (sender, e) => UpdateSaveButtonState();
            PartCostTextBox.TextChanged += (sender, e) => UpdateSaveButtonState();
            MinTextBox.TextChanged += (sender, e) => UpdateSaveButtonState();
            MaxTextBox.TextChanged += (sender, e) => UpdateSaveButtonState();
            CompanyNameTextBox.TextChanged += (sender, e) => UpdateSaveButtonState();
            MachineIDTextBox.TextChanged += (sender, e) => UpdateSaveButtonState();
            InHouseRadio.CheckedChanged += (sender, e) => UpdateSaveButtonState();
            OutsourceRadio.CheckedChanged += (sender, e) => UpdateSaveButtonState();
            UpdateSaveButtonState();
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
            // Assume all fields are initially considered filled
            bool allFieldsFilled = true;

            // List of all mandatory textboxes except the conditional ones
            TextBox[] mandatoryTextboxes = new TextBox[]
            {
        NameTextBox, InventoryTextBox, PartCostTextBox, MinTextBox, MaxTextBox
            };

            // Check if any mandatory textbox is empty
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

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            PartID = IDTextBox.Text;
            PartName = NameTextBox.Text;
            Inventory = InventoryTextBox.Text;
            Price = PartCostTextBox.Text;
            Min = MinTextBox.Text;
            Max = MaxTextBox.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
