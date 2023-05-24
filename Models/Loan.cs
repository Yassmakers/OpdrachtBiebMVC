public class Loan
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public int ItemId { get; set; }
    public Item Item { get; set; }
    public DateTime LoanDate { get; set; }
    public DateTime ReturnDate { get; set; }
}
