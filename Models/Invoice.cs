using BiebWebApp.Models;
namespace BiebWebApp.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public decimal Amount { get; set; }
        public InvoiceType InvoiceType { get; set; } // InvoiceType is an Enum with values such as SubscriptionFee, LoanFee, ReservationFee, Fine, etc.
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
    }
}

