using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstApproach.Models
{
    public class Register
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Customer Name is Required")]
        [Display(Name ="Customer Name")]
        public string  CustName { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Password and Confirm Password is Not Match")]
        public string  ConfirmPassword { get; set; }
        [Range(18,45, ErrorMessage = "Range Should be 18-45")]
        public int Age { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid Email Id")]
        public string EmailAddress { get; set; }
        [StringLength(15, ErrorMessage = "Address cannot more then 15")]
        public string Address { get; set; }
    }
}