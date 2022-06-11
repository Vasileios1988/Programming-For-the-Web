using System;
using System.ComponentModel.DataAnnotations;

namespace SET11105_CW2.Models
{
    public class Member
    {
        // attibutes for the member class with getters and setters and some validation
        public int ID { get; set; }

        [MaxLength(50)]
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter your first name")]
        public string name { get; set; }

        [MaxLength(50)]
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter your last name")]
        public string lastName { get; set; }

        [MaxLength(50)]
        [Display(Name = " Username")]
        [Required(ErrorMessage = "Please enter a username")]
        public string username { get; set; }

        [MaxLength(50)]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter your email")]
        public string email { get; set; }

        [DataType (DataType.Password)]
        [StringLength (100, MinimumLength = 10, ErrorMessage = "You need to provide a longer password")]
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter your password")]
        public string password { get; set; }

        

        public bool admin { get; set; }
    }
}
