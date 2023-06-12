using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BiebWebApp.Models
{
    // View model for user registration
    public class RegisterModel
    {
        // The email address of the user
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        // The name of the user
        public string Name { get; set; }

        // The type of the user (e.g., Member, Librarian, Administrator)
        [Required]
        public UserType Type { get; set; }

        // The password for the user
        [Required(ErrorMessage = "The Password field is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        // The confirmation password for the user
        [Required(ErrorMessage = "The Confirm Password field is required.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        // The selected subscription option for the user
        [Required(ErrorMessage = "Please select a subscription.")]
        public int SelectedSubscription { get; set; }

        // The list of subscription options for the user to choose from
        public List<SelectListItem> SubscriptionOptions { get; set; }
    }
}
