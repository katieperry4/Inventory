using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGUInventory.Classes
{
    public class Inventory
    {
        public BindingList<Product> Products { get; private set; }
        public BindingList<Part> AllParts { get; private set; }
        public Inventory()
        {
            Products = new BindingList<Product>();
            AllParts = new BindingList<Part>();
            Products.Add(new Product("Bike", 120, 1, 10, 4));
            Products.Add(new Product("Car", 3000, 1, 25, 7));
            AllParts.Add(new InHouse(12, "Pedal", 15, 6, 4, 20));
            AllParts.Add(new InHouse(22, "Seat", 24, 10, 2, 30));
            //Products[0].AssociatedParts.Add(AllParts[0]);
        }

        public void addProduct(Product product)
        {
            Products.Add(product);
        }
        public Product lookupProduct(int id)
        {
            Product product = Products.FirstOrDefault(p => p.ProductID == id);
            return product;
        }
        public bool removeProduct(int id) 
        { 
            Product productToRemove = lookupProduct(id);
            if (productToRemove != null)
            {
                Products.Remove(productToRemove);
                return true;
            }
            else
            {
                return false;
            }
        } 

        public void updateProduct(int id, Product product) 
        {
            Product productToUpdate = lookupProduct(id);
            if (productToUpdate != null)
            {
                productToUpdate.Name = product.Name;
                productToUpdate.Price = product.Price;
                productToUpdate.InStock = product.InStock;
                productToUpdate.Min = product.Min;
                productToUpdate.Max = product.Max;
                productToUpdate.AssociatedParts = new BindingList<Part>(product.AssociatedParts.ToList());
            }
        }

        public void addPart(Part part)
        {
            AllParts.Add(part);
        }

        public bool deletePart(Part part)
        {
            Part partToDelete = lookupPart(part.PartID);
            if (partToDelete != null)
            {
                AllParts.Remove(partToDelete);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Part lookupPart(int id)
        {
            Part part = AllParts.FirstOrDefault(p => p.PartID == id);
            return part;
        }

        public void updatePart(int id, Part part)
        {
            Part partToUpdate = lookupPart(id);
            if(partToUpdate != null)
            {
                partToUpdate.Name = part.Name;
                partToUpdate.Price = part.Price;
                partToUpdate.Min = part.Min;
                partToUpdate.Max = part.Max;
                partToUpdate.InStock = part.InStock;
                if (part is Outsourced outsourcedPart && partToUpdate is Outsourced updateOutsourced)
                {
                    updateOutsourced.CompanyName = outsourcedPart.CompanyName;
                } else if (part is InHouse inHousePart && partToUpdate is InHouse updateInHouse)
                {
                    updateInHouse.MachineID = inHousePart.MachineID;
                }
                else
                {
                    part.PartID = id;
                    deletePart(partToUpdate);
                    addPart(part);
                }

            }
        }
    }
}
