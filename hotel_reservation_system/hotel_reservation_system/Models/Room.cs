using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hotel_reservation_system.Interfaces;

namespace hotel_reservation_system.Models
{
    //base class
    internal abstract class Room : IBooking
    {
        public double Price {  get; set; }
        public int RoomNumber { get; set; }
        public bool IsAvailable {get; set; }

        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
            IsAvailable = true;
        }

        public virtual double CalculatePrice(int days)
        {
            Price = Price * days;
            return Price;
        }

        public bool VerifyAvailability(out string message)
        {
            message = "This room is available";
            Console.WriteLine(message);
            return true; //mostrar e/ou retornar "disponivel"
        }
    }
}
