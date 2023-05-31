using System.ComponentModel.DataAnnotations;

namespace BiebWebApp.Models
{
    public class EditItemModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the title.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter the author.")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Please select the item type.")]
        public ItemType ItemType { get; set; }

        [Required(ErrorMessage = "Please enter the year.")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Please enter the location.")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Please specify the status.")]
        public ItemStatus Status { get; set; }
    }
}
