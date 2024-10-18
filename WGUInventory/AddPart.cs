using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WGUInventory.Classes;

namespace WGUInventory
{
    public partial class AddPart : Form
    {
        private Form mainForm;
        private Inventory inventory;
        private bool _addMode;
        private int _itemID;

        public AddPart(Form callingForm, Inventory passedInventory, bool addMode, int itemID)
        {
            mainForm = callingForm;
            InitializeComponent();
            inventory = passedInventory;
            _addMode = addMode;
            _itemID = itemID;
        }

        

        private void InHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (InHouseRadio.Checked)
            {
                MachineIDLabel.Visible = true;
                MachineIDText.Enabled = true;
                MachineIDText.Visible = true;

                CompanyLabel.Visible = false;
                CompanyNameText.Enabled = false;
                CompanyNameText.Visible = false;

            }
        }

        private void OutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (OutsourcedRadio.Checked)
            {
                MachineIDLabel.Visible = false;
                MachineIDText.Enabled = false;
                MachineIDText.Visible = false;

                CompanyLabel.Visible = true;
                CompanyNameText.Visible = true;
                CompanyNameText.Enabled = true;
            }
        }

        private void CheckTextBoxes()
        {
            if (NameText.Text != "" &&
                InventoryText.Text != "" &&
                PriceText.Text != "" &&
                MaxText.Text != "" &&
                MinText.Text != "" &&
                (CompanyNameText.Text != "" || MachineIDText.Text != ""))
            {
                SaveButton.Enabled = true;
            }
            else
            {
                SaveButton.Enabled = false;
            }
        }

        private void InventoryText_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void MachineIDText_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void IDText_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void NameText_TextChanged(object sender, EventArgs e)
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

        private void CompanyNameText_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void AddPart_Load(object sender, EventArgs e)
        {
            if (_addMode == false) 
            {
                Part modifyingPart = inventory.lookupPart(_itemID);
                if (modifyingPart != null)
                {
                    IDText.Text = modifyingPart.PartID.ToString();
                    NameText.Text = modifyingPart.Name.ToString();
                    InventoryText.Text = modifyingPart.InStock.ToString();
                    PriceText.Text = modifyingPart.Price.ToString();
                    MaxText.Text = modifyingPart.Max.ToString();
                    MinText.Text = modifyingPart.Min.ToString();
                    if(modifyingPart is Outsourced outsourcedPart)
                    {
                        MachineIDLabel.Visible = false;
                        MachineIDText.Enabled = false;
                        MachineIDText.Visible = false;

                        CompanyLabel.Visible = true;
                        CompanyNameText.Visible = true;
                        CompanyNameText.Enabled = true;
                        CompanyNameText.Text = outsourcedPart.CompanyName.ToString();
                    } else if (modifyingPart is InHouse inHousePart)
                    {
                        MachineIDLabel.Visible = true;
                        MachineIDText.Enabled = true;
                        MachineIDText.Visible = true;

                        CompanyLabel.Visible = false;
                        CompanyNameText.Enabled = false;
                        CompanyNameText.Visible = false;
                        MachineIDText.Text = inHousePart.MachineID.ToString();
                    }

                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {

            
            if(_addMode == true)
            {
                if (MachineIDLabel.Visible == true)
                {
                    InHouse inHousePart = new InHouse(Convert.ToInt32(MachineIDText.Text), NameText.Text, Convert.ToDecimal(PriceText.Text), Convert.ToInt32(InventoryText.Text), Convert.ToInt32(MinText.Text), Convert.ToInt32(MaxText.Text));
                    inventory.addPart(inHousePart);
                    this.Close();
                    mainForm.Show();
                }
                else
                {
                    Outsourced outsourcedPart = new Outsourced(CompanyNameText.Text, NameText.Text, Convert.ToDecimal(PriceText.Text), Convert.ToInt32(InventoryText.Text), Convert.ToInt32(MinText.Text), Convert.ToInt32(MaxText.Text));
                    inventory.addPart(outsourcedPart);
                    this.Close();
                    mainForm.Show();
                }
            } else if (_addMode == false)
            {
                if (MachineIDLabel.Visible == true)
                {
                    InHouse inHousePart = new InHouse(Convert.ToInt32(MachineIDText.Text), NameText.Text, Convert.ToDecimal(PriceText.Text), Convert.ToInt32(InventoryText.Text), Convert.ToInt32(MinText.Text), Convert.ToInt32(MaxText.Text));
                    int partId = _itemID;
                    inventory.updatePart(partId, inHousePart);
                    this.Close();
                    mainForm.Show();
                }
                else if (CompanyLabel.Visible == true)
                {
                    Outsourced outsourcedPart = new Outsourced(CompanyNameText.Text, NameText.Text, Convert.ToDecimal(PriceText.Text), Convert.ToInt32(InventoryText.Text), Convert.ToInt32(MinText.Text), Convert.ToInt32(MaxText.Text));
                    int partId = _itemID;
                    inventory.updatePart(partId, outsourcedPart);
                    this.Close();
                    mainForm.Show();
                }
            }
            }catch
            {
                MessageBox.Show("There was an error adding your product, please ensure the correct values for max, min, and inventory.");
            }


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

        private void MachineIDText_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
