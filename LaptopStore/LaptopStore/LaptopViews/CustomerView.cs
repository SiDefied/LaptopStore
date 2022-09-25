using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaptopStore.LaptopViews
{
    public class CustomerView
    {
        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}