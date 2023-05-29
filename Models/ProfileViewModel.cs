using BiebWebApp.Models;
using System.Collections.Generic;

namespace BiebWebApp.Models
{
    public class ProfileViewModel
    {
        public User User { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
