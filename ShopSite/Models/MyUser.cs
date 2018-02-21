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

        [Required(ErrorMessage = "Please enter first name")]
        [MaxLength(10, ErrorMessage = "10 chars maximum")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        
        [MaxLength(10, ErrorMessage = "10 chars maximum")]
        [Required(ErrorMessage = "Please enter last name")]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter email ")]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "miss password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Pass { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Please enter again password")]
        [Compare("Pass", ErrorMessage = "The password didnt match")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please enter Birth date")]
        [Timestamp]
        [DataType(DataType.Date)]
        [Display(Name = "Birth date")]
        public DateTime BirthDate { get; set; }
    }
}