﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IdentityWithRole.Models.ViewModels
{
    public class RegisterVM
    {

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and confirmation password not match.")]
        public string ConfirmPassword { get; set; }

    }
}
