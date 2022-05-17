using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem_DAL.Models
{
    public class BookedRoom
    {
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public int BookingId { get; set; }
        public Booking Booking { get; set; }
    }
}
