using C968.Classes;
using System.Data;

namespace C968
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.PartsAddButton.Click += new System.EventHandler(addPart);
            this.PartsModifyButton.Click += new System.EventHandler(updatePart);
            this.PartsDeleteButton.Click += new System.EventHandler(deletePart);
        }

        private int GetNextPartID()
        {
            int highestID = 0;

            foreach (DataGridViewRow row in PartsTable.Rows)
            {
                if (row.Cells["PartID"].Value != null)
                {
                    int currentID = int.Parse(row.Cells["PartID"].Value.ToString());
                    if (currentID > highestID)
                    {
                        highestID = currentID;
                    }
                }
            }

            return highestID + 1;
        }

      
        private void addPart(object sender, EventArgs e)
        {
            AddPartModal addPartModal = new AddPartModal(GetNextPartID());
            if (addPartModal.ShowDialog(this) == DialogResult.OK)
            {
                Part newPart = addPartModal.CreatedPart;
                var index = PartsTable.Rows.Add();
                PartsTable.Rows[index].Cells["PartID"].Value = newPart.PartID.ToString();
                PartsTable.Rows[index].Cells["Name1"].Value = newPart.Name;
                PartsTable.Rows[index].Cells["Inventory"].Value = newPart.InStock.ToString();
                PartsTable.Rows[index].Cells["Price"].Value = newPart.Price.ToString();
                PartsTable.Rows[index].Cells["Min"].Value = newPart.Min.ToString();
                PartsTable.Rows[index].Cells["Max"].Value = newPart.Max.ToString();

                if (newPart is Inhouse inhousePart)
                {
                    PartsTable.Rows[index].Cells["MachineID"].Value = inhousePart.MachineID.ToString();
                }
                else if (newPart is Outsourced outsourcedPart)
                {
                    PartsTable.Rows[index].Cells["CompanyName"].Value = outsourcedPart.CompanyName;
                }
            }
        }

        private void deletePart(object sender, EventArgs e)
        {
            if (PartsTable.SelectedRows.Count > 0)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this part?",
                                                    "Confirm Delete",
                                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in this.PartsTable.SelectedRows)
                    {
                        PartsTable.Rows.RemoveAt(item.Index);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a part to delete.");
            }
        }

        private void updatePart(object sender, EventArgs e)
        {
            if (PartsTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = PartsTable.SelectedRows[0];
                EditPartModal editPartModal = new EditPartModal(
                    selectedRow.Cells["PartID"].Value.ToString(),
                    selectedRow.Cells["Name1"].Value.ToString(),
                    selectedRow.Cells["Inventory"].Value.ToString(),
                    selectedRow.Cells["Price"].Value.ToString(),
                    selectedRow.Cells["Min"].Value.ToString(),
                    selectedRow.Cells["Max"].Value.ToString(),
                    selectedRow.Cells["MachineID"]?.Value?.ToString(),
                    selectedRow.Cells["CompanyName"]?.Value?.ToString()
                );

                if (editPartModal.ShowDialog() == DialogResult.OK)
                {
                    selectedRow.Cells["PartID"].Value = editPartModal.PartID;
                    selectedRow.Cells["Name1"].Value = editPartModal.PartName;
                    selectedRow.Cells["Inventory"].Value = editPartModal.Inventory;
                    selectedRow.Cells["Price"].Value = editPartModal.Price;
                    selectedRow.Cells["Min"].Value = editPartModal.Min;
                    selectedRow.Cells["Max"].Value = editPartModal.Max;

                    if (editPartModal.MachineID != null)
                    {
                        selectedRow.Cells["MachineID"].Value = editPartModal.MachineID;
                    }
                    else if (editPartModal.CompanyName != null)
                    {
                        selectedRow.Cells["CompanyName"].Value = editPartModal.CompanyName;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a part to edit.");
            }
        }
    }
}