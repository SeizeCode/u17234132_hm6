using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hm6.Models;
using Newtonsoft.Json;

namespace hm6.Controllers
{
    public class HomeController : Controller
    {
        private readonly BikeStoresEntities1 db = new BikeStoresEntities1();
        // public ActionResult orders()
        //{
        //    var orders = db.order_items.ToList();
        //    return View(orders);
        //}
        public ActionResult orders()
        {
            var mdl = new BikeStoresEntities1();
            var model = new Orderdetails();

            model.orders = db.orders.ToList();
            model.order_Items = db.order_items.ToList();

            return View(model);
        }

    }
}