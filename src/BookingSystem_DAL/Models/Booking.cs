using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem_DAL.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int GuestId { get; set; }
        public Guest Guest { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
