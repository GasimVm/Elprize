using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prize.Models
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(50), MinLength(3)]
        public string Firstname { get; set; }

        [Required]
        [StringLength(50), MinLength(3)]
        public string Lastname { get; set; }

        [Required]
        [Display(Name = "Country", Prompt = "Country")]
        public int CountryId { get; set; }

        [Required]
        [Display(Name = "Phone Number", Prompt = "Phone Number")]
        [Phone]
        [StringLength(25, MinimumLength = 10)]
        [RegularExpression(@"\+(9[976]\d|8[987530]\d|6[987]\d|5[90]\d|42\d|3[875]\d|2[98654321]\d|9[8543210]|8[6421]|6[6543210]|5[87654321]|4[987654310]|3[9643210]|2[70]|7|1)\d{1,14}$",
            ErrorMessage = "The PhoneNumber field is not a valid phone number : + 994 50 555 55 55")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// login
        /// </summary>
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(4)]
        [Display(Name = "Username", Prompt = "Username")]
        public string Username { get; set; }

        public string PromoCode { get; set; }
        /// <summary>
        /// passwordla confirm password yoxlanmalidir
        /// </summary>
        [Required]
        [Display(Name = "Password", Prompt = "Password")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password", Prompt = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}
