using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGUInventory.Classes
{
    public class InHouse : Part
    {
        public int MachineID { get; set; }
        public InHouse(int machineID, string name, decimal price, int inStock, int min, int max)
        {
            MachineID = machineID;
            Name = name;
            Price = price;
            Max = max;
            Min = min;
            InStock = inStock;
        }
    }
}
