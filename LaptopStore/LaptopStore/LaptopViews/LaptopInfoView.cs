using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaptopStore.LaptopViews
{
    public class LaptopInfoView
    {
        public int LaptopID { get; set; }

        public string Brand { get; set; }

        public string Processor { get; set; }
        
        public string RAM { get; set; }
        
        public int Price { get; set; }
        
        public string Model { get; set; }

        public string Image_path { get; set; }
        public HttpPostedFileBase imgAddr { get; set; }

        public IEnumerable<SelectListItem> CategorySelectListItem { get; set; }


    }
}