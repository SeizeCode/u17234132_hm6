using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using hm6.Models;

namespace hm6.Views
{
    public class order_itemsController : Controller
    {
        private BikeStoresEntities1 db = new BikeStoresEntities1();

        // GET: order_items
        public ActionResult Index()
        {
            var order_items = db.order_items.Include(o => o.product).Include(o => o.order);
            return View(order_items.ToList());
        }

    }
}
