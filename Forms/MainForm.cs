using C968.Classes;
using C968.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace C968
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            ProductAddButton.Click += addProduct;
            ProductModifyButton.Click += updateProduct;
            ProductDeleteButton.Click += removeProduct;
            ProductSearchButton.Click += searchProductButton_Click;

            PartsAddButton.Click += addPart;
            PartsModifyButton.Click += updatePart;
            PartsDeleteButton.Click += deletePart;
            PartsSearchButton.Click += searchPartButton_Click;

            ExitButton.Click += ExitButton_Click;

            LoadPartsTable();
        }

        private void LoadPartsTable()
        {
            PartsTable.Rows.Clear();
            foreach (var part in Inventory.AllParts)
            {
                int index = PartsTable.Rows.Add();
                SetPartRow(index, part);
            }
        }
        private void LoadProductsTable()
        {
            ProductsTable.Rows.Clear();
            foreach (var product in Inventory.Products)
            {
                int index = ProductsTable.Rows.Add();
                SetProductRow(index, product);
            }
        }


        private void SetPartRow(int index, Part part)
        {
            PartsTable.Rows[index].Cells["PartID"].Value = part.PartID.ToString();
            PartsTable.Rows[index].Cells["Name1"].Value = part.Name;
            PartsTable.Rows[index].Cells["InStock"].Value = part.InStock.ToString();
            PartsTable.Rows[index].Cells["Price"].Value = part.Price.ToString();
            PartsTable.Rows[index].Cells["Min"].Value = part.Min.ToString();
            PartsTable.Rows[index].Cells["Max"].Value = part.Max.ToString();

            if (part is Inhouse inhousePart)
            {
                PartsTable.Rows[index].Cells["MachineID"].Value = inhousePart.MachineID.ToString();
            }
            else if (part is Outsourced outsourcedPart)
            {
                PartsTable.Rows[index].Cells["CompanyName"].Value = outsourcedPart.CompanyName;
            }
            PartsTable.Rows[index].Tag = part;
        }

        private void SetProductRow(int index, Product product)
        {
            ProductsTable.Rows[index].Cells["ProductID"].Value = product.ProductID.ToString();
            ProductsTable.Rows[index].Cells["Name2"].Value = product.Name;
            ProductsTable.Rows[index].Cells["InStock1"].Value = product.InStock.ToString();
            ProductsTable.Rows[index].Cells["Price1"].Value = product.Price.ToString();
            ProductsTable.Rows[index].Cells["Min1"].Value = product.Min.ToString();
            ProductsTable.Rows[index].Cells["Max1"].Value = product.Max.ToString();
            ProductsTable.Rows[index].Tag = product;
        }


        public void addProduct(object sender, EventArgs e)
        {
            if (PartsTable.Rows.Count == 0)
            {
                MessageBox.Show("There are no parts available to add to a product. Please add parts before adding a product.", "No Parts Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                AddProductModal addProductModal = new AddProductModal(Inventory.Products.Any() ? Inventory.Products.Max(p => p.ProductID) + 1 : 1);
                if (addProductModal.ShowDialog(this) == DialogResult.OK)
                {
                    Inventory.AddProduct(addProductModal.CreatedProduct);
                }
                LoadProductsTable();
            }
        }

        public void removeProduct(object sender, EventArgs e)
        {
            if (ProductsTable.SelectedRows.Count > 0)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in ProductsTable.SelectedRows)
                    {
                        Product product = item.Tag as Product;
                        if (product != null)
                        {
                            Inventory.RemoveProduct(product);
                        }
                    }
                    LoadProductsTable();
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }
        }

        public Product lookupProduct(int productID)
        {
            return Inventory.LookupProduct(productID);
        }

        private void updateProduct(object sender, EventArgs e)
        {
            if (ProductsTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ProductsTable.SelectedRows[0];
                Product selectedProduct = selectedRow.Tag as Product;
                if (selectedProduct == null)
                {
                    MessageBox.Show("No product selected or product information is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                EditProductModal editProductModal = new EditProductModal(selectedProduct);
                if (editProductModal.ShowDialog() == DialogResult.OK)
                {
                    LoadProductsTable();
                }
            }
            else
            {
                MessageBox.Show("Please select a product to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void addPart(object sender, EventArgs e)
        {

            AddPartModal addPartModal = new AddPartModal(Inventory.AllParts.Any() ? Inventory.AllParts.Max(p => p.PartID) + 1 : 1);
            if (addPartModal.ShowDialog(this) == DialogResult.OK)
            {
                Inventory.AddPart(addPartModal.CreatedPart);
                LoadPartsTable();
            }
        }

        private void deletePart(object sender, EventArgs e)
        {
            if (PartsTable.SelectedRows.Count > 0)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this part?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in PartsTable.SelectedRows)
                    {
                        Part part = item.Tag as Part;
                        if (part != null)
                        {
                            Inventory.DeletePart(part);
                        }
                    }
                    LoadPartsTable();
                }
            }
            else
            {
                MessageBox.Show("Please select a part to delete.");
            }
        }

        public Part lookupPart(int partID)
        {
            return Inventory.LookupPart(partID);
        }

        private void updatePart(object sender, EventArgs e)
        {
            if (PartsTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = PartsTable.SelectedRows[0];
                Part selectedPart = selectedRow.Tag as Part;
                if (selectedPart == null)
                {
                    MessageBox.Show("No part selected or part information is missing.");
                    return;
                }

                EditPartModal editPartModal = new EditPartModal(selectedPart);
                if (editPartModal.ShowDialog() == DialogResult.OK)
                {
                    LoadPartsTable();
                }
            }
            else
            {
                MessageBox.Show("Please select a part to edit.");
            }
        }


        private void searchPartButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(PartsSearchTextBox.Text, out int partID))
            {
                Part foundPart = lookupPart(partID);

                if (foundPart != null)
                {
                    MessageBox.Show($"Part found: ID = {foundPart.PartID}, Name = {foundPart.Name}", "Part Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No part found with the specified ID.", "Part Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid part ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchProductButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(ProductSearchTextBox.Text, out int productID))
            {
                Product foundProduct = lookupProduct(productID);

                if (foundProduct != null)
                {
                    MessageBox.Show($"Product found: ID = {foundProduct.ProductID}, Name = {foundProduct.Name}", "Product Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No product found with the specified ID.", "Product Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid product ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
