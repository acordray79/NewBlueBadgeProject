﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBShop.Model.Transaction
{
    public class TransactionCreate
    {
        public string CustomerID { get; set; }
        public int ProductID { get; set; }
    }
}