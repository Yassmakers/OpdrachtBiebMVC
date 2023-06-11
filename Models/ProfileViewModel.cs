using BiebWebApp.Models;
using System.Collections.Generic;

namespace BiebWebApp.Models
{
    // View model representing the user profile
    public class ProfileViewModel
    {
        // The user information
        public User User { get; set; }

        // The list of reservations for the user
        public List<Reservation> Reservations { get; set; }

        // The list of loans for the user
        public List<Loan> Loans { get; set; }

        // The fine amount for reservations
        public decimal ReservationFine { get; set; }

        // The charge amount for reservations
        public decimal ReservationCharge { get; set; }

        // The fine amount per day for reservations
        public decimal FinePerDay { get; set; }

        // Indicates whether the user has a subscription
        public bool HasSubscription { get; set; }

        // The charge amount for the subscription
        public decimal SubscriptionCharge { get; set; }

        // The total charge amount for reservations
        public decimal TotalReservationCharge { get; set; }

        // Indicates whether the user has paid
        public bool HasPaid { get; set; }

        // The subscription type of the user
        public string SubscriptionType { get; set; }
    }
}
