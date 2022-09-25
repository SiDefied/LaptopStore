using LaptopStore.Models;
using LaptopStore.LaptopViews;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineLaptopStore.Controllers
{
    public class ItemController : Controller
    {
        private LaptopStoreEntities1 obj;
        public ItemController()
        {
            obj = new LaptopStoreEntities1();
        }

        // GET: Item
        public ActionResult Index()
        {
            LaptopInfoView objitem = new LaptopInfoView();
            objitem.CategorySelectListItem = (from objCat in obj.LaptopInfoes
                    select new SelectListItem()
                          {
                               Text = objCat.Brand,
                               Value = objCat.Model,
                               Selected = true
                           });
            return View(objitem);
        }

        [HttpPost]
        public JsonResult Index(LaptopInfoView objitem)
        {
            string NewImg = Guid.NewGuid() + Path.GetExtension(objitem.imgAddr.FileName);
            objitem.imgAddr.SaveAs(Server.MapPath("~/Images/" + NewImg));

            LaptopInfo ObjItem = new LaptopInfo();
            ObjItem.imgAddr = "~/Images/" + NewImg;
            ObjItem.Brand = objitem.Brand;
            ObjItem.Model = objitem.Model;
            ObjItem.LaptopID = objitem.LaptopID;
            ObjItem.RAM = objitem.RAM;
            ObjItem.Price = objitem.Price;
            ObjItem.Processor = objitem.Processor;
            obj.LaptopInfoes.Add(ObjItem);
            obj.SaveChanges();

            return Json(new { Success = true, Message = "Laptop added successfully!" }, JsonRequestBehavior.AllowGet);
        }
    }
}