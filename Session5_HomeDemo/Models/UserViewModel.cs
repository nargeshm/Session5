using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Session5_HomeDemo.Models
{
    public class UserViewModel
    {

        [Required]
        //[System.Web.Mvc.Remote("ValidationUser","Home")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(12, ErrorMessage = "Must be 8-20 characters long.")]
        [MinLength(8, ErrorMessage = "Must be 8-20 characters long.")]
        public string PassWord { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"09[0 9 3 1]\d{8}", ErrorMessage = "Invalid number")]
        public string PhoneNumber { get; set; }
        [Required]
        [RegularExpression(@"[0][1 2 3 4 5 6 7 8 9][1 2 3 4 5 6 7 8 9]\d{8}", ErrorMessage = "Please type the number in the requested format!")]
        public string HomePhone { get; set; }
        [Required]
        [RegularExpression(@"[0]\d{9}", ErrorMessage = "Must be 10 characters long.")]
        public string IdentificationCode { get; set; }
        [Required]
        [RegularExpression(@"\d{10}", ErrorMessage = "Must be 10 characters long.")]
        public string PostalCode { get; set; }
        [Required]
        //[Range(typeof(DateTime), "1/1/1901", "1/1/2018",
        //ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public DateTime BirthDate { get; set; }

        public string HowToFind { get; set; }

        [Required]
        [StringLength(6, ErrorMessage = "Must have a maximum of 6 letters.")]
        public string CaptchaCode { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string CopanyCode { get; set; }
        [Required]
        public string EconomyCode { get; set; }

        [Required]
        public string UserPanel { get; set; }
        [Required]
        public bool Reg_terms { get; set; }

    }
}
