using ShopSite.Models;
using ShopSite.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopSite.Controllers
{
    public class UploadItemController : Controller
    {
        [HttpGet]
        public ActionResult UpdateItem()
        {
            HttpCookie cookie = Request.Cookies["UserId"];
            long longCookie;
            CookieCheker TheCheker = new CookieCheker();

            if (TheCheker.Cheker(cookie, out longCookie))
                return View();
            else
                return View("NoUser");
        }


        [HttpPost]
        public ActionResult UpdateItem(MyItem newItem)
        {
            MyUser userClass = new MyUser();
            Item sendItem = new Item();

            HttpCookie cookie = Request.Cookies["UserId"];
            long longCookie;
            CookieCheker TheCheker = new CookieCheker();

            if (TheCheker.Cheker(cookie, out longCookie))
            {
                if (ModelState.IsValid)
                {
                    Item itemInDb = new Item()
                    {
                        StatusSail = false,
                        OwnerId = longCookie,

                        Title = newItem.Title,
                        Price = Convert.ToDecimal(newItem.Price),
                        ShortDescription = newItem.ShortDescription,
                        LongDescription = newItem.LongDescription,
                        Date = DateTime.Now,
                        PicLink1 = Converter(newItem.PicLink1),
                        PicLink2 = Converter(newItem.PicLink2),
                        PicLink3 = Converter(newItem.PicLink3)
                    };
                    sendItem = itemInDb;
                }

                using (MyDbEntity dbUpdate = new MyDbEntity())
                {
                    dbUpdate.Items.Add(sendItem);
                    dbUpdate.SaveChanges();
                }
                return View("EndUpdateItem", newItem);
            }
            return View("NoUser");
        }


        private Byte[] Converter(HttpPostedFileBase image)
        {
            if (image != null)
            {
                byte[] imageBytes = new byte[image.ContentLength];
                using (var stream = image.InputStream)
                {
                    stream.Read(imageBytes, 0, image.ContentLength);
                }

                return imageBytes;
            }
            return null;
        }
    }
}