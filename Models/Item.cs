using BiebWebApp.Models;
using System.ComponentModel.DataAnnotations;

namespace BiebWebApp.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public ItemType ItemType { get; set; }
        public int Year { get; set; }
        public string Location { get; set; }

        [Required(ErrorMessage = "Please specify the status.")]
        public ItemStatus Status { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<Loan> Loans { get; set; }
    }
}