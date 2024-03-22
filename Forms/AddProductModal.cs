using C968.Classes;
using System;
using System.Linq;
using System.Windows.Forms;

namespace C968.Forms
{
    public partial class AddProductModal : Form
    {
        public Product CreatedProduct { get; private set; }

        public AddProductModal(int nextProductID)
        {
            InitializeComponent();
            LoadPartsTable();
            IDTextBox.Text = nextProductID.ToString();
            SaveButton.Click += SaveButton_Click;
            CancelButton.Click += CancelButton_Click;
            PartsAddButton.Click += PartsAddButton_Click;
            PartsDeleteButton.Click += PartsDeleteButton_Click;

            NameTextBox.TextChanged += (s, e) => UpdateSaveButtonState();
            InventoryTextBox.TextChanged += (s, e) => UpdateSaveButtonState();
            PartCostTextBox.TextChanged += (s, e) => UpdateSaveButtonState();
            MinTextBox.TextChanged += (s, e) => UpdateSaveButtonState();
            MaxTextBox.TextChanged += (s, e) => UpdateSaveButtonState();

            UpdateSaveButtonState();
        }

        private void LoadPartsTable()
        {
            PartsTable.Rows.Clear();
            foreach (var part in Inventory.AllParts)
            {
                int index = PartsTable.Rows.Add();
                SetPartRow(index, part, PartsTable);
            }
        }

        private void SetPartRow(int index, Part part, DataGridView table)
        {
            table.Rows[index].Cells["PartID"].Value = part.PartID.ToString();
            table.Rows[index].Cells["Name1"].Value = part.Name;
            table.Rows[index].Cells["InStock"].Value = part.InStock.ToString();
            table.Rows[index].Cells["Price"].Value = $"${part.Price}";
            table.Rows[index].Cells["Min"].Value = part.Min.ToString();
            table.Rows[index].Cells["Max"].Value = part.Max.ToString();

            if (part is Inhouse inhousePart)
            {
                table.Rows[index].Cells["MachineID"].Value = inhousePart.MachineID.ToString();
            }
            else if (part is Outsourced outsourcedPart)
            {
                table.Rows[index].Cells["CompanyName"].Value = outsourcedPart.CompanyName;
            }
            table.Rows[index].Tag = part;
        }

        private void SetAssociatedPartRow(int index, Part part, DataGridView table)
        {
            table.Rows[index].Cells["PartID1"].Value = part.PartID.ToString();
            table.Rows[index].Cells["Name2"].Value = part.Name;
            table.Rows[index].Cells["InStock1"].Value = part.InStock.ToString();
            table.Rows[index].Cells["Price1"].Value = $"${part.Price}";
            table.Rows[index].Cells["Min1"].Value = part.Min.ToString();
            table.Rows[index].Cells["Max1"].Value = part.Max.ToString();

            if (part is Inhouse inhousePart)
            {
                table.Rows[index].Cells["MachineID1"].Value = inhousePart.MachineID.ToString();
            }
            else if (part is Outsourced outsourcedPart)
            {
                table.Rows[index].Cells["CompanyName1"].Value = outsourcedPart.CompanyName;
            }
            table.Rows[index].Tag = part;
        }

        private void UpdateSaveButtonState()
        {
            bool allFieldsFilled = true;
            int inventory, min, max;
            decimal price;

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

            // Additionally validate that Inventory, Min, Max, and Price can be parsed and meet logical constraints
            bool isValidNumbers = int.TryParse(InventoryTextBox.Text, out inventory) &&
                                  decimal.TryParse(PartCostTextBox.Text, out price) &&
                                  int.TryParse(MinTextBox.Text, out min) &&
                                  int.TryParse(MaxTextBox.Text, out max) &&
                                  min <= max && inventory >= min && inventory <= max;

            SaveButton.Enabled = allFieldsFilled && isValidNumbers;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(InventoryTextBox.Text, out int inventory) ||
                !decimal.TryParse(PartCostTextBox.Text, out decimal price) ||
                !int.TryParse(MinTextBox.Text, out int min) ||
                !int.TryParse(MaxTextBox.Text, out int max) || inventory < min || inventory > max)
            {
                MessageBox.Show("Please check your input values. Inventory must be between Min and Max.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CreatedProduct = new Product(int.Parse(IDTextBox.Text), NameTextBox.Text, price, inventory, min, max);

            foreach (DataGridViewRow row in ProductPartsTable.Rows)
            {
                if (row.Tag is Part part)
                {
                    CreatedProduct.addAssociatedPart(part);
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void PartsAddButton_Click(object sender, EventArgs e)
        {
            if (PartsTable.SelectedRows.Count > 0)
            {
                var selectedRow = PartsTable.SelectedRows[0];
                if (selectedRow.Tag is Part part)
                {
                    int index = ProductPartsTable.Rows.Add();
                    SetAssociatedPartRow(index, part, ProductPartsTable);
                    ProductPartsTable.Rows[index].Tag = part;
                }
            }
        }

        private void PartsDeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ProductPartsTable.SelectedRows)
            {
                ProductPartsTable.Rows.RemoveAt(row.Index);
            }
        }
    }
}
