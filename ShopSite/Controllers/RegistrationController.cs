using ShopSite.Models;
using ShopSite.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopSite.Controllers
{
    public class RegistrationController : Controller
    {
        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(MyUser newUser)
        {
            if (ModelState.IsValid)
            {
                User userInDB = new User()
                {
                    FirstName = newUser.FirstName,
                    LastName = newUser.LastName,
                    Email = newUser.Email,
                    Pass = newUser.Pass,
                    BirthDate = newUser.BirthDate
                };
                
                using (var context = new MyDbEntity())
                {
                    context.Users.Add(userInDB);
                    context.SaveChanges();
                }
                return View("EndRegistration", newUser);
            }
            else
            {
                return View();
            }
        }
    }
}