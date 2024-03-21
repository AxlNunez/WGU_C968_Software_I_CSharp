using C968.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
            bool isMachineIDParsed = false;
            int machineID = 0;

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

            try
            {
                if (InHouseRadio.Checked)
                {
                    machineID = int.Parse(MachineIDTextBox.Text);
                    if (currentPart is Inhouse inhousePart)
                    {
                        UpdateInhousePart(machineID);
                    }
                    else
                    {
                        currentPart = new Inhouse(partID, NameTextBox.Text, inventory, price, min, max, machineID);
                    }
                }
                else
                {
                    string companyName = CompanyNameTextBox.Text;
                    if (currentPart is Outsourced outsourcedPart)
                    {
                        UpdateOutsourcedPart(companyName);
                    }
                    else
                    {
                        currentPart = new Outsourced(partID, NameTextBox.Text, inventory, price, min, max, companyName);
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating part: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateInhousePart(int machineID)
        {
            var part = currentPart as Inhouse;
            if (part != null)
            {
                UpdatePartCommonFields(part);
                part.MachineID = machineID;
            }
        }

        private void UpdateOutsourcedPart(string companyName)
        {
            var part = currentPart as Outsourced;
            if (part != null)
            {
                UpdatePartCommonFields(part);
                part.CompanyName = companyName;
            }
        }

        private void UpdatePartCommonFields(Part part)
        {
            part.InStock = int.Parse(InventoryTextBox.Text);
            part.Price = decimal.Parse(PartCostTextBox.Text);
            part.Min = int.Parse(MinTextBox.Text);
            part.Max = int.Parse(MaxTextBox.Text);
            part.Name = NameTextBox.Text.ToString();
        }
    }
}