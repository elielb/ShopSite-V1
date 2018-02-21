using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShopSite.Models
{
    public class MyItem
    {
        [ScaffoldColumn(false)]
        [Key]
        public long ItemId { get; set; }
        [ScaffoldColumn(false)]
        public long OwnerId { get; set; }
        [ScaffoldColumn(false)]
        public long? UserId { get; set; }
        [Required]
        [Display(Name = "Titel:")]
        [MaxLength(10, ErrorMessage = "10 chars maximum")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Short description ")]
        public string ShortDescription { get; set; }

        [Required]
        [Display(Name = "Long description")]
        [DataType(DataType.MultilineText)]
        [StringLength(500, ErrorMessage = "500 chars maximum")]
        public string LongDescription { get; set; }

        [Required]
        [Display(Name = "Price:")]
        public decimal Price { get; set; }
        
            
        [Display(Name = "Picture 1")]
        public HttpPostedFileBase PicLink1 { get; set; }
        
        [Display(Name = "Picture 2")]
        public HttpPostedFileBase PicLink2 { get; set; }
        
        [Display(Name = "Picture 3")]
        public HttpPostedFileBase PicLink3 { get; set; }

        [ScaffoldColumn(false)]
        public byte StatusSail { get; set; }

        [ScaffoldColumn(false)]
        public DateTime Date { get; set; }
    }
}


