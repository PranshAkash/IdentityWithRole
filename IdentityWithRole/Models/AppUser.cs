//using Microsoft.AspNetCore.Identity;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations;
//using System.Xml.Linq;

//namespace IdentityWithRole.Models
//{
//    //public class AppUser : IdentityUser
//    //{
//    //    [Required(ErrorMessage ="Enter Name")]
//    //    public string? Name { get; set; }

//    //    [Display(Name = "Mobile No.")]
//    //    [StringLength(10, MinimumLength = 10)]
//    //    [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
//    //    public override string PhoneNumber { get; set; }

//    //    [Required]
//    //    [EmailAddress]
//    //    [Display(Name = "Email Id")]
//    //    public override string Email { get; set; }

//    //    [Required]
//    //    [NotMapped]
//    //    [DataType(DataType.Password)]
//    //    [Display(Name = "Password")]
//    //    public string Password { get; set; }

//    //    [Required]
//    //    [NotMapped]
//    //    [DataType(DataType.Password)]
//    //    [Display(Name = "Confirm password")]
//    //    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
//    //    public string ConfirmPassword { get; set; }
//    //    public override string UserName { get; set; }
//    //    [NotMapped]
//    //    public List<string> Roles { get; set; }
//    //}

//    public class AppUser : IdentityUser
//    {
//        [Required(ErrorMessage = "Enter Name")]
//        public string Name { get; set; }

//        [Required(ErrorMessage = "Enter Mobile No.")]
//        [Display(Name = "Mobile No.")]
//        [StringLength(10, MinimumLength = 10)]
//        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
//        public override string PhoneNumber { get; set; }

//        [Required(ErrorMessage = "Enter Email Id")]
//        [EmailAddress]
//        [Display(Name = "Email Id")]
//        public override string Email { get; set; }

//        [Required(ErrorMessage = "Enter Password")]
//        [DataType(DataType.Password)]
//        [Display(Name = "Password")]
//        public string Password { get; set; }

//        [Required(ErrorMessage = "Confirm Password")]
//        [DataType(DataType.Password)]
//        [Display(Name = "Confirm password")]
//        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
//        public string ConfirmPassword { get; set; }

//        // If you still want to store UserName in the database, uncomment the following line:
//        public override string UserName { get; set; }

//        [NotMapped]
//        public List<string> Roles { get; set; }
//    }

//}
