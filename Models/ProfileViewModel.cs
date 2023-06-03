using BiebWebApp.Models;
using System.Collections.Generic;

namespace BiebWebApp.Models
{
    public class ProfileViewModel
    {
        public User User { get; set; }
        public List<Reservation> Reservations { get; set; }
        public List<Loan> Loans { get; set; } // Add a list of Loans
        public decimal ReservationFine { get; set; }
        public decimal ReservationCharge { get; set; }
        public decimal FinePerDay { get; set; }
        public bool HasSubscription { get; set; } // subscribit
        public decimal SubscriptionCharge { get; set; }
        public decimal TotalReservationCharge { get; set; }

        public string SubscriptionType { get; set; } // Add this property to store the subscription type
    }
}
