using BiebWebApp.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace BiebWebApp.Models
{
    public class User : IdentityUser<int>
    {
        public string Name { get; set; }
        public UserType Type { get; set; } // UserType enum
        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<Loan> Loans { get; set; }
        public bool HasSubscription { get; set; }
        public string SubscriptionType { get; set; } // Added subscription type field
        public int MaxItemsPerYear { get; set; } // Added maximum items per year field
    }
}
