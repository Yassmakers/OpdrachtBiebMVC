using System;

namespace BiebWebApp.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public bool IsPaid { get; set; }
        public DateTime PaymentDate { get; set; }
        // Other properties...

        // Navigation properties
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
