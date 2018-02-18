using ShopSite.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopSite.Models
{
    public class CookieCheker
    {
        public bool Cheker(HttpCookie cookie, out long userCookieUserIdLong)
        {
                
            if (cookie != null)
            {
                if (long.TryParse(cookie.Value, out userCookieUserIdLong))
                {
                    MyUser userClass = new MyUser();
                    using (MyDbEntity db = new MyDbEntity())
                    {
                        foreach (var userInDb in db.Users)
                        {
                            if (userInDb.UserId == userCookieUserIdLong)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            userCookieUserIdLong = 0;
            return false;
        }
    }
}