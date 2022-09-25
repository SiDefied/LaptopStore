using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaptopStore.LaptopViews
{
    public class CartView
    {
        public string LaptopID { get; set; }
        public decimal Quantity { get; set; }
        public decimal Unit_price { get; set; }
        public decimal Total { get; set; }
        public string imgAddr { get; set; }
        public string Brand { get; set; }


        //public string CustomerName { get; set; }
        //public string Address { get; set; }
        //public string Phone { get; set; }
    }
}