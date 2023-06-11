using BiebWebApp.Models;
using System.ComponentModel.DataAnnotations;

namespace BiebWebApp.Models
{
    // Model representing an item
    public class Item
    {
        // The ID of the item
        public int Id { get; set; }

        // The title of the item
        public string Title { get; set; }

        // The author of the item
        public string Author { get; set; }

        // The type of the item (Book, Magazine, Newspaper, DVD)
        public ItemType ItemType { get; set; }

        // The year of publication of the item
        public int Year { get; set; }

        // The location of the item
        public string Location { get; set; }

        // The status of the item (Available, Reserved, Loaned)
        [Required(ErrorMessage = "Please specify the status.")]
        public ItemStatus Status { get; set; }

        // The collection of reservations associated with the item
        public virtual ICollection<Reservation> Reservations { get; set; }

        // The collection of loans associated with the item
        public virtual ICollection<Loan> Loans { get; set; }
    }
}
