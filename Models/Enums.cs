using BiebWebApp.Models;
namespace BiebWebApp.Models
{
    public enum ItemType
    {
        Book,
        Magazine,
        Newspaper,
        DVD
    }

    public enum ItemStatus
    {
        Available,
        Reserved,
        Loaned
    }


    public enum InvoiceType
    {
        SubscriptionFee,
        LoanFee,
        ReservationFee,
        Fine
    }

    public enum UserType
    {
        Member,
        Librarian,
        Administrator
    }
}
