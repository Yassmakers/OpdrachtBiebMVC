
using BiebWebApp.Models;
namespace BiebWebApp.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
        public DateTime ReservationDate { get; set; }
    }


}