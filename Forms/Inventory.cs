using C968.Classes;
using System.Data;

namespace C968
{
    public partial class Inventory : Form
    {
        public Inventory()
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
                PartsTable.Rows[index].Tag = newPart;
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
                Part currentPart = selectedRow.Tag as Part;

                if (currentPart == null)
                {
                    MessageBox.Show("No part selected or part information is missing.");
                    return;
                }

                EditPartModal editPartModal = new EditPartModal(currentPart);

                if (editPartModal.ShowDialog() == DialogResult.OK)
                {
                    selectedRow.Cells["PartID"].Value = currentPart.PartID.ToString();
                    selectedRow.Cells["Name1"].Value = currentPart.Name;
                    selectedRow.Cells["Inventory"].Value = currentPart.InStock.ToString();
                    selectedRow.Cells["Price"].Value = currentPart.Price.ToString();
                    selectedRow.Cells["Min"].Value = currentPart.Min.ToString();
                    selectedRow.Cells["Max"].Value = currentPart.Max.ToString();

                    if (currentPart is Inhouse inhousePart)
                    {
                        selectedRow.Cells["MachineID"].Value = inhousePart.MachineID.ToString();
                    }
                    else if (currentPart is Outsourced outsourcedPart)
                    {
                        selectedRow.Cells["CompanyName"].Value = outsourcedPart.CompanyName;
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