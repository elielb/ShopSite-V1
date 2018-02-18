using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShopSite.Models
{
    public class MyUser
    {
        [ScaffoldColumn(false)]
        public string UserName { get; set; }
        [ScaffoldColumn(false)]
        public long? UserId { get; set; }

        [Required(ErrorMessage = "חסר שם פרטי")]
        [MaxLength(10, ErrorMessage = "מקסימום 10 תווים")]
        [Display(Name = "שם פרטי")]
        public string FirstName { get; set; }
        
        [MaxLength(10, ErrorMessage = "מקסימום 10 תווים")]
        [Required(ErrorMessage = "חסר שם משפחה")]
        [Display(Name = "שם משפחה")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "חסר דואר אלקטרוני")]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "דואר אלקטרוני")]
        public string Email { get; set; }

        [Required(ErrorMessage = "חסר סיסמה")]
        [DataType(DataType.Password)]
        [Display(Name = "סיסמה")]
        public string Pass { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "הקש שוב סיסמה")]
        [Compare("Pass", ErrorMessage = "הסיסמה לא תואמת")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "חסר תאריך לידה")]
        [Timestamp]
        [DataType(DataType.Date)]
        [Display(Name = "תאריך לידה")]
        public DateTime BirthDate { get; set; }
    }
}