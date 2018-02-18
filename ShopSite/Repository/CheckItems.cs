using ShopSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopSite.Repository
{
    public class CheckItems
    {
        MyDbEntity db = new MyDbEntity();
        public IEnumerable<Item> GetItems()
        {
            List<Item> itemList = new List<Item>();
            foreach (var item in db.Items)
            {
                Item itemclass = new Item()
                {
                    UserId = item.UserId,
                    ItemId = item.ItemId,
                    LongDescription = item.LongDescription,
                    PicLink1 = item.PicLink1,
                    PicLink2 = item.PicLink2,
                    PicLink3 = item.PicLink3,
                    Price = Convert.ToDecimal(item.Price),
                    ShortDescription = item.ShortDescription,
                    Title = item.Title,
                    Date = Convert.ToDateTime(item.Date)
                };
                itemList.Add(itemclass);
            }
            return itemList;
        }
    }
}