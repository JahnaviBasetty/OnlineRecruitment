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

    public partial class Profile
    {
        public int c_id { get; set; }
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
        [Required(ErrorMessage = "Date of Birth is required.")]
        [DataType(DataType.Date, ErrorMessage = "Invalid date format.")]
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public Nullable<int> Age { get; set; }
        [Required(ErrorMessage = "Please enter gender.")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }
        public string Desired_job_title { get; set; }
        [Required(ErrorMessage = "Skills are required.")]
        public string Skills { get; set; }
        [Required(ErrorMessage = "Education details is required.")]
        public string Education { get; set; }
        [Required(ErrorMessage = "Experience is required.")]
        public string Experience { get; set; }
        [Required(ErrorMessage = "Please upload your resume.")]
        public string Resume { get; set; }
    }
}
