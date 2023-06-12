using System.ComponentModel.DataAnnotations;

namespace BiebWebApp.Models
{
    public class CreateItemModel
    {
        // Property representing the title of the item
        [Required(ErrorMessage = "Please enter the title.")]
        public string Title { get; set; }

        // Property representing the author of the item
        [Required(ErrorMessage = "Please enter the author.")]
        public string Author { get; set; }

        // Property representing the type of the item
        [Required(ErrorMessage = "Please select the item type.")]
        public ItemType ItemType { get; set; }

        // Property representing the year of the item
        [Required(ErrorMessage = "Please enter the year.")]
        public int Year { get; set; }

        // Property representing the location of the item
        [Required(ErrorMessage = "Please enter the location.")]
        public string Location { get; set; }

        // Property representing the status of the item
        [Required(ErrorMessage = "Please specify the status.")]
        public ItemStatus Status { get; set; }
    }
}
