using System.ComponentModel.DataAnnotations;

namespace BiebWebApp.Models
{
    public class CreateLocationModel
    {
        [Required(ErrorMessage = "Please enter the location name.")]
        public string LocationName { get; set; }
    }

    public class Location
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
    }
}
