namespace BiebWebApp.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public decimal Amount { get; set; }
        public InvoiceType InvoiceType { get; set; } // InvoiceType is een Enum met waarden als SubscriptionFee, LoanFee, ReservationFee, Fine, etc.
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
    }
}

