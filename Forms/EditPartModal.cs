using C968.Classes;
using System;
using System.Windows.Forms;

namespace C968
{
    public partial class EditPartModal : Form
    {
        private Part currentPart;

        public EditPartModal(Part partToEdit)
        {
            InitializeComponent();
            currentPart = partToEdit;
            PopulateFormFields(partToEdit);
            InHouseRadio.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            OutsourceRadio.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            SaveButton.Click += new EventHandler(SaveButton_Click);
            CancelButton.Click += new EventHandler(cancelButton_Click);
        }

        private void PopulateFormFields(Part part)
        {
            IDTextBox.Text = part.PartID.ToString();
            NameTextBox.Text = part.Name;
            InventoryTextBox.Text = part.InStock.ToString();
            PartCostTextBox.Text = part.Price.ToString();
            MinTextBox.Text = part.Min.ToString();
            MaxTextBox.Text = part.Max.ToString();

            if (part is Inhouse inhousePart)
            {
                MachineIDTextBox.Text = inhousePart.MachineID.ToString();
                MachineIDLabel.Visible = true;
                MachineIDTextBox.Visible = true;
                CompanyNameLabel.Visible = false;
                CompanyNameTextBox.Visible = false;
                InHouseRadio.Checked = true;
            }
            else if (part is Outsourced outsourcedPart)
            {
                CompanyNameTextBox.Text = outsourcedPart.CompanyName;
                MachineIDLabel.Visible = false;
                MachineIDTextBox.Visible = false;
                CompanyNameLabel.Visible = true;
                CompanyNameTextBox.Visible = true;           
                OutsourceRadio.Checked = true;
            }
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            bool isInHouseSelected = InHouseRadio.Checked;

            MachineIDLabel.Visible = isInHouseSelected;
            MachineIDTextBox.Visible = isInHouseSelected;
            MachineIDTextBox.Enabled = isInHouseSelected;

            CompanyNameLabel.Visible = !isInHouseSelected;
            CompanyNameTextBox.Visible = !isInHouseSelected;
            CompanyNameTextBox.Enabled = !isInHouseSelected;

            if (isInHouseSelected)
            {
                CompanyNameTextBox.Text = string.Empty;
            }
            else
            {
                MachineIDTextBox.Text = string.Empty;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out var part))
            {
                MessageBox.Show("Please correct your input. Ensure all fields are filled out correctly and numerical fields contain valid numbers.", "Input Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else {
                Inventory.UpdatePart(currentPart.PartID, part);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool ValidateInput(out Part part)
        {
            part = null;
            if (!int.TryParse(IDTextBox.Text, out int partID) ||
                string.IsNullOrWhiteSpace(NameTextBox.Text) ||
                !int.TryParse(InventoryTextBox.Text, out int inventory) ||
                !decimal.TryParse(PartCostTextBox.Text, out decimal price) ||
                !int.TryParse(MinTextBox.Text, out int min) ||
                !int.TryParse(MaxTextBox.Text, out int max))
            {
                return false;
            }

            if (min > max)
            {
                MessageBox.Show("Minimum value cannot be greater than maximum value.", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (InHouseRadio.Checked && int.TryParse(MachineIDTextBox.Text, out int machineID))
            {
                part = new Inhouse(partID, NameTextBox.Text, inventory, price, min, max, machineID);
            }
            else if (OutsourceRadio.Checked && !string.IsNullOrWhiteSpace(CompanyNameTextBox.Text))
            {
                part = new Outsourced(partID, NameTextBox.Text, inventory, price, min, max, CompanyNameTextBox.Text);
            }
            else
            {
                return false;
            }

            return true;
        }
    }
}
