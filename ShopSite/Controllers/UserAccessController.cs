using ShopSite.Models;
using ShopSite.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopSite.Controllers
{
    public class UserAccessController : Controller
    {
        [HttpGet]
        public ActionResult UserLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserLogin(MyUser userClass)
        {
            if (userClass.Email != null && userClass.Pass != null)
            {
                using (MyDbEntity db = new MyDbEntity())
                {
                    foreach (var userInDb in db.Users)
                    {
                        if (userInDb.Email == userClass.Email && userInDb.Pass == userClass.Pass)
                        {
                                                        HttpCookie cookie2 = new HttpCookie("UserId", userInDb.UserId.ToString());
                            cookie2.Expires = DateTime.Now.AddMinutes(10);
                            Response.Cookies.Add(cookie2);
                            return View("StatusUser", userClass);
                        }
                    }
                }
            }
            return View();
        }
        //public ActionResult Logout()
        //{
        //    if (Request.Cookies["StudentCookies"] != null)
        //    {
        //        HttpCookie StudentCookies = new HttpCookie("StudentCookies", userClass.UserEmail);
        //        StudentCookies.Expires = DateTime.Now.AddMinutes(-10);
        //        Response.Cookies.Add(StudentCookies);
        //    }
        //    return RedirectToAction("Index", controllerName: "Home");
        //}


        public ActionResult StatusUserBar()
        {
            HttpCookie cookie = Request.Cookies["UserId"];
            long longCookie;
            CookieCheker TheCheker = new CookieCheker();

            if (TheCheker.Cheker(cookie, out longCookie))
            {
                MyUser userClass = new MyUser();
                using (MyDbEntity db = new MyDbEntity())
                {
                    foreach (var userInDb in db.Users)
                    {
                        if (userInDb.UserId == longCookie)
                        {
                            userClass.UserName = userInDb.FirstName + " " + userInDb.LastName;
                        }
                    }
                    return View("StatusUserBar", userClass);
                }
            }
            return View("NoUserLogedIn");
        }
    }
}
