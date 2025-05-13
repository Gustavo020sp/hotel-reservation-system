using hotel_reservation_system.Models;

namespace hotel_reservation_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookingHandler bookingHandler = new BookingHandler();
            
            bookingHandler.Display(); //starts display in screen and logical fields


        }
    }
}
