using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Assignment2.Models
{
    public class ContactModel
    {
        [DisplayName("Name")]
        [Required(ErrorMessage = "The name is required")]
        public string name { get; set; }

        [DisplayName("Phone Number")]
        [Required(ErrorMessage = "The phone number is required")]
        public string phoneNumber { get; set; }

        [DisplayName("Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string email { get; set; }

        [DisplayName("Message")]
        [Required(ErrorMessage = "The message is required")]
        public string message { get; set; }

    }
}
