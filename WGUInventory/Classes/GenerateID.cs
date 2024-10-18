using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGUInventory.Classes
{
    public static class GenerateID
    {
        private static HashSet<int> usedIDs = new HashSet<int>();
        public static int GenerateUniqueID()
        {
            Random random = new Random();
            int id; 
            do
            {
                id = random.Next(1000,10000);

            } while (usedIDs.Contains(id));
            
            usedIDs.Add(id);
            return id;
        }
    }
}
