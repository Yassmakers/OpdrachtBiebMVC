using BiebWebApp.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace BiebWebApp.Models
{
    // Model representing a loan
    public class Loan
    {
        // The ID of the loan
        public int Id { get; set; }

        // The ID of the user associated with the loan
        public int UserId { get; set; }

        // The user associated with the loan
        public virtual User User { get; set; }

        // The ID of the item associated with the loan
        public int ItemId { get; set; }

        // The item associated with the loan
        public virtual Item Item { get; set; }

        // The ID of the reservation associated with the loan (nullable)
        public int? ReservationId { get; set; }

        // The reservation associated with the loan (nullable)
        public virtual Reservation Reservation { get; set; }

        // The date the loan was made
        public DateTime LoanDate { get; set; }

        // The date the loan is due for return
        public DateTime ReturnDate { get; set; }
    }
}
