﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968.Classes
{
    public class Outsourced : Part
    {
        public string CompanyName { get; set; }

        public Outsourced(int partID, string name, int inStock, decimal price, int min, int max, string companyName)
            : base(partID, name, price, inStock, min, max)
        {
            CompanyName = companyName;
        }
    }
}
