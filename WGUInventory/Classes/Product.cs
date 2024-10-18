using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGUInventory.Classes
{
    public class Product
    {
        private int _min;
        private int _max;
        private int _inStock;
        public BindingList<Part> AssociatedParts { get; set; }
        public int ProductID {  get; set; } 
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock
        {
            get { return _inStock; }
            set
            {
                if (value < Min || value > Max)
                {
                    throw new ArgumentException("Stock must be within max and min");
                }
                _inStock = value;
            }

        }
        public int Min
        {
            get { return _min; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Min cannot be less than zero");

                if (value >= Max)
                    throw new ArgumentException("Min cannot be greater than max");
                _min = value;
            }
        }

        public int Max
        {
            get { return _max; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Max cannot be less than zero");

                if (value <= Min)
                    throw new ArgumentException("Max cannot be less than min");
                _max = value;
            }
        }

        public Product(string name, decimal price, int min, int max, int inStock)
        {
            ProductID = GenerateID.GenerateUniqueID();
            Name = name; 
            Price = price;
            Max = max;
            Min = min;
            InStock = inStock;
            AssociatedParts = new BindingList<Part>();
        }




        public void addAssociatedPart(Part associatedPart)
        {
            AssociatedParts.Add(associatedPart);
        }

        public Part lookupAssociatedPart(int partId)
        {
            Part part = AssociatedParts.SingleOrDefault(p => p.PartID == partId);
            return part;
        }
        public bool removeAssociatedPart(int partID)
        {
            Part partToRemove = lookupAssociatedPart(partID);
            if (partToRemove != null)
            {
                AssociatedParts.Remove(partToRemove);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
