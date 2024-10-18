using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace WGUInventory.Classes
{
    public class Outsourced : Part
    {
        public string CompanyName { get; set; }

        public Outsourced(string companyName, string name, decimal price, int inStock, int min, int max)
        {
            CompanyName = companyName;
            Name = name;
            Price = price;
            Max = max;
            Min = min;
            InStock = inStock;
        }
    }

}
