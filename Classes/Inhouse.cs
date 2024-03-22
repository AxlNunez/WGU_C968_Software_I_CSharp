using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968.Classes
{
    public class Inhouse : Part
    {
        public int MachineID { get; set; }

        public Inhouse(int partID, string name, int inStock, decimal price, int min, int max, int machineID)
            : base(partID, name, price, inStock, min, max)
        {
            MachineID = machineID;
        }
    }
}
