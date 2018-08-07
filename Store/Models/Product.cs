using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public long UPC { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}