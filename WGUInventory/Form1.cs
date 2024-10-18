using WGUInventory.Classes;

namespace WGUInventory
{
    public partial class HomeForm : Form
    {
        private Inventory inventory;
        public HomeForm()
        {
            InitializeComponent();
          
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inventory = new Inventory();
            var productsData = inventory.Products;
            var partsData = inventory.AllParts;
            ProductsGrid.DataSource = productsData;
            PartsGrid.DataSource = partsData;
            PartsGrid.ClearSelection();
            ProductsGrid.ClearSelection();
        }

        private void PartsAdd_Click(object sender, EventArgs e)
        {
            AddPart addPart = new AddPart(this, inventory, true, 0);
            addPart.Show();
            this.Hide();
        }

        private void ProdsAdd_Click(object sender, EventArgs e)
        {
            AddProduct addProd = new AddProduct(this, inventory, true, 0);
            addProd.Show();
            this.Hide();
        }
        private void PartsMod_Click(object sender, EventArgs e)
        {
            int rowIndex = PartsGrid.CurrentCell.RowIndex;
            int idValue = (int)PartsGrid.Rows[rowIndex].Cells["PartID"].Value;
            AddPart addPart = new AddPart(this, inventory, false, idValue);
            addPart.Show();
            this.Hide();
        }

        private void PartsDelete_Click(object sender, EventArgs e)
        {
            if (PartsGrid.CurrentCell != null)
            {
                int rowIndex = PartsGrid.CurrentCell.RowIndex;
                int idValue = (int)PartsGrid.Rows[rowIndex].Cells["PartID"].Value;
                Part partToDelete = inventory.lookupPart(idValue);
                if (partToDelete != null)
                {
                    string message = "Are you sure you want to delete this part?";
                    string caption = "Are you sure?";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    result = MessageBox.Show(message, caption, buttons);
                    if (result == DialogResult.Yes)
                    {
                        bool used;
                        foreach(Product product in inventory.Products)
                        {
                            var searchedParts = product.AssociatedParts
                                        .Where(Part => Part.PartID.Equals(idValue))
                                        .ToList();
                            if(searchedParts.Count > 0)
                            {
                                MessageBox.Show("Sorry! You can't delete a part if a product is associated with it");
                                return;
                            }
                        }
                        inventory.deletePart(partToDelete);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please select a part to delete");
                }
            }
        }

        private void ProdsDelete_Click(object sender, EventArgs e)
        {
            if (ProductsGrid.CurrentCell != null)
            {

                int rowIndex = ProductsGrid.CurrentCell.RowIndex;
                int idValue = (int)ProductsGrid.Rows[rowIndex].Cells["ProductID"].Value;
                if (idValue is int)
                {
                    string message = "Are you sure you want to delete this product?";
                    string caption = "Are you sure?";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    result = MessageBox.Show(message, caption, buttons);
                    if (result == DialogResult.Yes)
                    {
                        inventory.removeProduct(idValue);

                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please select a part to delete");
                }
            }
        }

        private void PartsSearchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string searchText = PartsSearchBar.Text;
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                var searchedParts = inventory.AllParts
                                        .Where(Part => Part.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                                        .ToList();
                PartsGrid.DataSource = searchedParts;
            }
            else
            {
                PartsGrid.DataSource = inventory.AllParts;
            }
        }

        private void PartsSearchButton_Click(object sender, EventArgs e)
        {
            string searchText = PartsSearchBar.Text;
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                var searchedParts = inventory.AllParts
                                        .Where(Part => Part.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                                        .ToList();
                PartsGrid.DataSource = searchedParts;
            }
            else
            {
                PartsGrid.DataSource = inventory.AllParts;
            }
        }

        private void ProdsSearchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string searchText = ProdsSearchBar.Text;
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                var searchedProds = inventory.Products
                                        .Where(Product => Product.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                                        .ToList();
                ProductsGrid.DataSource = searchedProds;
            }
            else
            {
                ProductsGrid.DataSource = inventory.Products;
            }
        }

        private void ProdsSearchButton_Click(object sender, EventArgs e)
        {
            string searchText = ProdsSearchBar.Text;
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                var searchedProds = inventory.Products
                                        .Where(Product => Product.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                                        .ToList();
                ProductsGrid.DataSource = searchedProds;
            }
            else
            {
                ProductsGrid.DataSource = inventory.Products;
            }
        }

        private void ProdsMod_Click(object sender, EventArgs e)
        {
            int rowIndex = ProductsGrid.CurrentCell.RowIndex;
            int idValue = (int)ProductsGrid.Rows[rowIndex].Cells["ProductID"].Value;
            AddProduct addProd = new AddProduct(this, inventory, false, idValue);
            addProd.Show();
            this.Hide();
        }
    }
}
