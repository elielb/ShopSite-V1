//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopSite.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item
    {
        public long ItemId { get; set; }
        public Nullable<long> OwnerId { get; set; }
        public Nullable<long> UserId { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public byte[] PicLink1 { get; set; }
        public byte[] PicLink2 { get; set; }
        public byte[] PicLink3 { get; set; }
        public Nullable<bool> StatusSail { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
