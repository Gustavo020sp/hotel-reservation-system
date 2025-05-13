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

        public override string ToString() 
        {
            return $"Your room is reserved for {Days} days, Total price will be ${RoomBooked.Price.ToString("F2")}";
        }

    }
}
