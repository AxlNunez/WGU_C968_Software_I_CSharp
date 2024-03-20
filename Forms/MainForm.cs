using System.Data;

namespace C968
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.AddButton.Click += new System.EventHandler(AddButton_Click);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddPartModal addPartModal = new AddPartModal(GetNextPartID());
            if (addPartModal.ShowDialog(this) == DialogResult.OK)
            {
                // Now read the public properties from addPartForm and add them to PartsTable
                var index = PartsTable.Rows.Add(); // Adds a new row and returns the index of the new row
                PartsTable.Rows[index].Cells["PartID"].Value = addPartModal.PartID;
                PartsTable.Rows[index].Cells["Name1"].Value = addPartModal.PartName;
                PartsTable.Rows[index].Cells["Inventory"].Value = addPartModal.Inventory;
                PartsTable.Rows[index].Cells["Price"].Value = addPartModal.Price;
                PartsTable.Rows[index].Cells["Min"].Value = addPartModal.Min;
                PartsTable.Rows[index].Cells["Max"].Value = addPartModal.Max;
            }
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

            return highestID + 1; // Return the next higher number
        }

    }
}