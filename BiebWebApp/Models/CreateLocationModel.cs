using System.ComponentModel.DataAnnotations;

namespace BiebWebApp.Models
{
    public class CreateLocationModel
    {
        // Property representing the name of the location
        [Required(ErrorMessage = "Please enter the location name.")]
        public string LocationName { get; set; }
    }

    public class Location
    {
        // Property representing the ID of the location
        public int Id { get; set; }

        // Property representing the name of the location
        public string LocationName { get; set; }
    }
}
