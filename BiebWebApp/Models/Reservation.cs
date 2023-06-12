using BiebWebApp.Models;

namespace BiebWebApp.Models
{
    // Model representing a reservation
    public class Reservation
    {
        // The unique identifier of the reservation
        public int Id { get; set; }

        // The ID of the user who made the reservation
        public int UserId { get; set; }

        // The navigation property for the user who made the reservation
        public virtual User User { get; set; }

        // The ID of the item being reserved
        public int ItemId { get; set; }

        // The navigation property for the item being reserved
        public virtual Item Item { get; set; }

        // The date of the reservation
        public DateTime ReservationDate { get; set; }

        // The collection of loans associated with the reservation
        public virtual ICollection<Loan> Loans { get; set; }
    }
}
