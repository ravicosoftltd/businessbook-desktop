﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIAB_Restaurent_Management_System.data.viewmodel
{
    public class productsaleorpurchase
    {
        public int id { set; get; }
        public string name { set; get; }
        public double price { set; get; }
        public double quantity { set; get; }
        public double total { set; get; }
    }
}
