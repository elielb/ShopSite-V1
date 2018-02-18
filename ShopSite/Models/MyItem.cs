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
        [Display(Name = "כותרת:")]
        [MaxLength(10, ErrorMessage = "מקסימום 10 תווים")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "תיאור קצר")]
        public string ShortDescription { get; set; }

        [Required]
        [Display(Name = "תיאור ארוך")]
        [DataType(DataType.MultilineText)]
        [StringLength(500, ErrorMessage = "מקסימום 500 תווים")]
        public string LongDescription { get; set; }

        [Required]
        [Display(Name = "מחיר:")]
        public decimal Price { get; set; }
        
            
        //[DataType(DataType.Upload)]
        [Display(Name = "תמונה 1")]
        public HttpPostedFileBase PicLink1 { get; set; }

        //[DataType(DataType.Text)]
        [Display(Name = "תמונה 2")]
        public HttpPostedFileBase PicLink2 { get; set; }

        //[DataType(DataType.Upload)]
        [Display(Name = "תמונה 3")]
        public HttpPostedFileBase PicLink3 { get; set; }

        [ScaffoldColumn(false)]
        public byte StatusSail { get; set; }

        [ScaffoldColumn(false)]
        public DateTime Date { get; set; }
    }
}


