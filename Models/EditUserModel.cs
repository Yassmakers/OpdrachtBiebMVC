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
    }
}
