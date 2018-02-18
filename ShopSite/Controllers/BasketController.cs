using ShopSite.Models;
using ShopSite.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopSite.Controllers
{
    public class BasketController : Controller
    {
        public ActionResult Basket()
        {
            HttpCookie cookie = Request.Cookies["UserId"];
            long longCookie;
            CookieCheker TheCheker = new CookieCheker();

            List<Item> itemList = new List<Item>();

            if (TheCheker.Cheker(cookie, out longCookie))
            {
                using (MyDbEntity db = new MyDbEntity())
                {
                    foreach (var itemInDb in db.Items)
                    {
                        if (itemInDb.UserId == longCookie)
                        {
                            itemList.Add(itemInDb);
                        }
                    }
                }
                return View("Basket", itemList);
                // return View("NoItemInBasket");
            }
            return View("NoUser");
        }

        public ActionResult AddClick(long? itemId)
        {
            MyItem itemName = new MyItem();

            HttpCookie cookie = Request.Cookies["UserId"];
            long longCookie;
            CookieCheker TheCheker = new CookieCheker();

            if (TheCheker.Cheker(cookie, out longCookie))
            {
                using (MyDbEntity db = new MyDbEntity())
                {
                    foreach (var itemDb in db.Items)
                    {
                        if (itemId == itemDb.ItemId)
                            itemDb.UserId = longCookie;
                    }
                    db.SaveChanges();
                }
                return View("AddToBasket");
            }
            return View("NoUser");
        }
    }
}
