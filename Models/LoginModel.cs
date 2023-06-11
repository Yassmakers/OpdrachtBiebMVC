using System.ComponentModel.DataAnnotations;

namespace BiebWebApp.Models
{
    // Model representing the login form
    public class LoginModel
    {
        // The email of the user (required)
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        // The password of the user (required)
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
