//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineRecruitment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Register
    {
        public int RId { get; set; }
        [Required(ErrorMessage = "FirstName is required.")]
        [StringLength(15, ErrorMessage = "Name must be between 1 and 15 characters.", MinimumLength = 1)]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Invalid name format. Only letters and spaces are allowed.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName is required.")]
        [StringLength(15, ErrorMessage = "Name must be between 1 and 15 characters.", MinimumLength = 1)]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Invalid name format. Only letters and spaces are allowed.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string EmailId { get; set; }
        [Required(ErrorMessage = "Mobile number is required.")]
        [RegularExpression(@"^\+?[1-9]\d{1,14}$", ErrorMessage = "Invalid mobile number format.")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please confirm your password.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
