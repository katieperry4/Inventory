using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGUInventory.Classes
{
    public abstract class Part
    {
        private int _min;
        private int _max;
        private int _inStock;

        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock {
            get { return _inStock; }
            set
            {
                if(value < Min || value > Max)
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
                    throw new ArgumentException("Min cannot be less than max");
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
        public Part()
        {
            PartID = GenerateID.GenerateUniqueID();
        }
    }
}
