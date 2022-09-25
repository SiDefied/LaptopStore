
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LaptopStore.LaptopViews;
using LaptopStore.Models;
namespace LaptopStore.Controllers
{
    public class HomeController : Controller
    {
        private LaptopStoreEntities1 obj;
        private List<CartView> listofCartView;

        public HomeController()
        {
            obj = new LaptopStoreEntities1();
            listofCartView = new List<CartView>();
        }
        public ActionResult Index()
        {
            IEnumerable<LaptopInfoView> listofLaptopInfoView = (from OBJitem in obj.LaptopInfoes
                                                                  select new LaptopInfoView()
                                                                  {
                                                                      Image_path = OBJitem.imgAddr,
                                                                      Model = OBJitem.Model,
                                                                      Processor = OBJitem.Processor,
                                                                      Price = OBJitem.Price,
                                                                      LaptopID = OBJitem.LaptopID,
                                                                      RAM = OBJitem.RAM,
                                                                      Brand = OBJitem.Brand,
                                                                  }).ToList();
            return View(listofLaptopInfoView);
        }

        [HttpPost]
        public JsonResult Index(string LaptopID)
        {

            CartView objcartview = new CartView();
            LaptopInfo objitem = obj.LaptopInfoes.Single(model => model.LaptopID.ToString() == LaptopID);
            if (Session["CartCounter"] != null)
            {
                listofCartView = Session["CartItems"] as List<CartView>;
            }
            if (listofCartView.Any(model => model.LaptopID == LaptopID))
            {
                objcartview = listofCartView.Single(model => model.LaptopID == LaptopID);
                objcartview.Quantity = objcartview.Quantity + 1;
                objcartview.Total = objcartview.Quantity * objcartview.Unit_price;
            }
            else
            {
                objcartview.LaptopID = LaptopID;
                objcartview.Brand = objitem.Brand;
                objcartview.imgAddr = objitem.imgAddr;
                objcartview.Quantity = 1;
                objcartview.Total = objitem.Price;
                objcartview.Unit_price = objitem.Price;
                listofCartView.Add(objcartview);
            }

            Session["CartCounter"] = listofCartView.Count;
            Session["CartItems"] = listofCartView;
            return Json(new { Success = true, Counter = listofCartView.Count }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Cart()
        {
            listofCartView = Session["CartItems"] as List<CartView>;
            return View(listofCartView);
        }



    }
}