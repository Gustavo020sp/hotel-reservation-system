using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hotel_reservation_system.Models;

namespace hotel_reservation_system
{
    internal class BookingHandler
    {
        public void Display()
        {
            Room standard = new StandardRoom(1);
            Room vip = new VipRoom(2);
            Room premium = new SuitePremium(3);

            List<Room> list = new List<Room>() { standard, vip, premium };

            Console.WriteLine("Available Rooms");
            Console.WriteLine("---------------");

            foreach (Room room in list)
            {
                // --- could implement a swicth case if rooms quantity grows in list //
                if (room.RoomNumber == 1)
                {
                    Console.WriteLine("Standard Room [1]");
                }
                else if (room.RoomNumber == 2)
                {
                    Console.WriteLine("Vip Room [2]");
                }
                else
                {
                    Console.WriteLine("Premium Room [3]");
                }
            }

            Console.WriteLine("Choose a room number: ");
            int roomnumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-------------------");
            Console.Write("Type number of days: ");
            int days = Convert.ToInt32(Console.ReadLine());

            switch (roomnumber)
            {
                case 1:
                    Booking b1 = new Booking(standard, days);
                    b1.Book();
                    Console.Write($"Your room is reserved for {days} days, Total price will be {standard.Price}");
                    break;
                case 2:
                    Booking b2 = new Booking(vip, days);
                    b2.Book();
                    Console.Write($"Your room is reserved for {days} days, Total price will be {vip.Price}");
                    break;
                case 3:
                    Booking b3 = new Booking(premium, days);
                    b3.Book();
                    Console.Write($"Your room is reserved for {days} days, Total price will be {premium.Price}");
                    break;
                default:
                    Console.WriteLine("Please enter a valid room number.");
                    break;
            }
        }
    }
}
