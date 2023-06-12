using BiebWebApp.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;

namespace BiebWebApp.Models
{
    // Custom user model that extends IdentityUser<int> .
    public class User : IdentityUser<int>
    {
        // The name of the user
        public string Name { get; set; }

        // The type of the user (Member, Librarian, Administrator)
        public UserType Type { get; set; }

        // The collection of reservations associated with the user
        public virtual ICollection<Reservation> Reservations { get; set; }

        // The collection of loans associated with the user
        public virtual ICollection<Loan> Loans { get; set; }

        // Indicates whether the user is blocked
        public bool IsBlocked { get; set; }

        // Indicates whether the user has a subscription
        public bool HasSubscription { get; set; }

        // The type of the user's subscription
        public string SubscriptionType { get; set; }

        // The maximum number of items the user can borrow in a year
        public int MaxItemsPerYear { get; set; }

        // Indicates whether the user has paid
        public bool HasPaid { get; set; }
    }
}
