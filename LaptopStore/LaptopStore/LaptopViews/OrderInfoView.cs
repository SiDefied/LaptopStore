using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaptopStore.LaptopViews
{
    public class OrderInfoView
    {
        public int OrderID { get; set; }

        public int LaptopID { get; set; }
        public  int CustomerID { get; set; }

        public int Price { get; set; }
    }
}