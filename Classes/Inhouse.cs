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

        public Inhouse(int partID, string partName, int inventory, decimal price, int min, int max, int machineID)
            : base(partID, partName, inventory, price, min, max)
        {
            MachineID = machineID;
        }
    }
}
