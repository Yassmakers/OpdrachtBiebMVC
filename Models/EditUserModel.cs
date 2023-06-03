using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BiebWebApp.Models
{
    public class EditUserModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the user's name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please select the user's type.")]
        public UserType Type { get; set; }

        [Display(Name = "New Password")]
        public string NewPassword { get; set; }

        [Display(Name = "Confirm New Password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmNewPassword { get; set; }

        [Display(Name = "Subscription Type")]
        public string SubscriptionType { get; set; }

        public List<SelectListItem> SubscriptionOptions { get; set; }
    }
}
