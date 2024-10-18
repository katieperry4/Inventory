using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WGUInventory.Classes;

namespace WGUInventory
{
    public partial class AddProduct : Form
    {
        private Form mainForm;
        private Inventory _inventory;
        private bool _addMode;
        private int _itemID;
        public BindingList<Part> _tempParts { get; set; }

        public AddProduct(Form callingForm, Inventory inventory, bool addMode, int itemID)
        {
            mainForm = callingForm;
            _inventory = inventory;
            InitializeComponent();
            _addMode = addMode;
            _itemID = itemID;
            _tempParts = new BindingList<Part>();
        }

        private void CheckTextBoxes()
        {
            if (NameText.Text != "" &&
                InventoryText.Text != "" &&
                PriceText.Text != "" &&
                MaxText.Text != "" &&
                MinText.Text != "")
            {
                SaveButton.Enabled = true;
            }
            else
            {
                SaveButton.Enabled = false;
            }
        }



        private void NameText_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void InventoryText_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void PriceText_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void MaxText_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void MinText_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            var partsData = _inventory.AllParts;
            PartsGrid.DataSource = partsData;
            AssPartsGrid.DataSource = _tempParts;
            PartsGrid.ClearSelection();
            AssPartsGrid.ClearSelection();
            if (_addMode == false)
            {
                Product modifyingProduct = _inventory.lookupProduct(_itemID);
                if (modifyingProduct != null)
                {
                    IDText.Text = modifyingProduct.ProductID.ToString();
                    NameText.Text = modifyingProduct.Name.ToString();
                    InventoryText.Text = modifyingProduct.InStock.ToString();
                    PriceText.Text = modifyingProduct.Price.ToString();
                    MinText.Text = modifyingProduct.Min.ToString();
                    MaxText.Text = modifyingProduct.Max.ToString();
                    foreach (Part part in modifyingProduct.AssociatedParts)
                    {
                        _tempParts.Add(part);
                    }
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void InventoryText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                return;
            }
            e.Handled = true;
        }

        private void PriceText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                return;
            }
            if (e.KeyChar == '.')
            {
                if (PriceText.Text.Contains('.'))
                {
                    e.Handled = true;
                    return;
                }
                else
                {
                    e.Handled = false;
                    return;
                }
            }
            e.Handled = true;
        }

        private void MaxText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                return;
            }
            e.Handled = true;
        }

        private void MinText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                return;
            }
            e.Handled = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {


                if (_addMode == true)
                {
                    Product addingProduct = new Product(NameText.Text, Convert.ToDecimal(PriceText.Text), Convert.ToInt32(MinText.Text), Convert.ToInt32(MaxText.Text), Convert.ToInt32(InventoryText.Text));
                    addingProduct.AssociatedParts = _tempParts;
                    _inventory.addProduct(addingProduct);
                    this.Close();
                    mainForm.Show();
                }
                else if (_addMode == false)
                {
                    Product productUpdate = new Product(NameText.Text, Convert.ToDecimal(PriceText.Text), Convert.ToInt32(MinText.Text), Convert.ToInt32(MaxText.Text), Convert.ToInt32(InventoryText.Text));
                    int productId = _itemID;
                    productUpdate.AssociatedParts = _tempParts;
                    _inventory.updateProduct(productId, productUpdate);
                    this.Close();
                    mainForm.Show();
                }
            }
            catch
            {
                MessageBox.Show("There was an error adding your product, please ensure the correct values for max, min, and inventory.");
                return;
            }
        }

        private void SearchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string searchText = SearchBar.Text;
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                var searchedParts = _inventory.AllParts
                                        .Where(Part => Part.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                                        .ToList();
                PartsGrid.DataSource = searchedParts;
            }
            else
            {
                PartsGrid.DataSource = _inventory.AllParts;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchText = SearchBar.Text;
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                var searchedParts = _inventory.AllParts
                                        .Where(Part => Part.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                                        .ToList();
                PartsGrid.DataSource = searchedParts;
            }
            else
            {
                PartsGrid.DataSource = _inventory.AllParts;
            }
        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {
            int rowIndex = PartsGrid.CurrentCell.RowIndex;
            int idValue = (int)PartsGrid.Rows[rowIndex].Cells["PartID"].Value;
            Part partToStore = _inventory.lookupPart(idValue);
            _tempParts.Add(partToStore);
        }

        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            if (AssPartsGrid.CurrentCell != null)
            {
                if (AssPartsGrid.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a part to delete.");
                    return;
                }
                int rowIndex = AssPartsGrid.CurrentCell.RowIndex;
                Debug.WriteLine($"Selected Row Index: {rowIndex}");
                Debug.WriteLine($"Temp parts =  {_tempParts}");


                if (rowIndex >= 0 && rowIndex < _tempParts.Count)
                {
                    int idValue = (int)AssPartsGrid.Rows[rowIndex].Cells["PartID"].Value;
                    string partName = (string)AssPartsGrid.Rows[rowIndex].Cells["Name"].Value;
                    Part partToDelete = _tempParts[rowIndex];
                    if (partToDelete != null && partToDelete.Name == partName)
                    {
                        _tempParts.RemoveAt(rowIndex);
                        AssPartsGrid.DataSource = _tempParts;
                        AssPartsGrid.Refresh();

                    } else
                    {
                        MessageBox.Show("Part not found.");
                    }
                }
                else
                {
                    MessageBox.Show("There was an error removing this part");
                    return;
                }
            }
            else
            {
                MessageBox.Show("No part selected. Please select a part");
            }
        }
    }
}
