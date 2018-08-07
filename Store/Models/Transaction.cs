using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.Models
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }

        public virtual Product Product { get; set; }
        public virtual Customer Customer { get; set; }
    }
}