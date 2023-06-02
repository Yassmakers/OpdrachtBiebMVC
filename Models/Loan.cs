using BiebWebApp.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace BiebWebApp.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
        public int? ReservationId { get; set; } // Addded ReservationId property
        public virtual Reservation Reservation { get; set; } // Addded Reservation navigation property
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
