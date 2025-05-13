using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_reservation_system.Models
{
    internal class Booking
    {
        public Room RoomBooked { get; set; }
        public int Days { get; set; }


        public Booking(Room roombooked, int days) 
        {
            RoomBooked = roombooked;
            Days = days;
        }

        public bool Book()
        {
            if (!RoomBooked.IsAvailable)
            {
                return false;
            }
            else
            {
                RoomBooked.CalculatePrice(Days);
                return true;
            }
        }
    }
}
