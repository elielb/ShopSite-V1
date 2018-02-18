using ShopSite.Models;
using ShopSite.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopSite.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Master()
        {
            CheckItems ListOfItems = new CheckItems();

            return View(ListOfItems.GetItems());
        }


        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}