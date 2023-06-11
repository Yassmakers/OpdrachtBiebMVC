using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BiebWebApp.Models
{
    public class EditUserModel
    {
        // Property representing the ID of the user
        public int Id { get; set; }

        // Property representing the name of the user
        [Required(ErrorMessage = "Please enter the user's name.")]
        public string Name { get; set; }

        // Property representing the email of the user
        [Required(ErrorMessage = "Please enter the user's email.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        // Property representing the type of the user
        [Required(ErrorMessage = "Please select the user's type.")]
        public UserType Type { get; set; }

        // Property representing the subscription type of the user
        [Required(ErrorMessage = "Please select the subscription type.")]
        public string SubscriptionType { get; set; }

        // Property representing the selected subscription (used for display)
        public int SelectedSubscription { get; set; }

        // Property representing the new password for the user
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }

        // Property representing the confirmation of the new password
        [Display(Name = "Confirm New Password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmNewPassword { get; set; }

        // Property representing the list of subscription options (used for dropdown)
        public List<SelectListItem> SubscriptionOptions { get; set; }

    }
}
