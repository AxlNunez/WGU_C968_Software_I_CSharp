using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968.Classes
{
    public abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        protected Part(int partID, string partName, int inventory, decimal price, int min, int max)
        {
            PartID = partID;
            Name = partName;
            InStock = inventory;
            Price = price;
            Min = min;
            Max = max;
        }
    }
}
