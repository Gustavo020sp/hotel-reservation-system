using hotel_reservation_system.Models;

namespace hotel_reservation_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room standard = new StandardRoom(1);
            Room vip = new VipRoom(2);
            Room premium = new SuitePremium(3);

            List<Room> list = new List<Room>() { standard, vip, premium };

            Console.WriteLine("Available Rooms");
            Console.WriteLine("---------------");

            foreach (Room room in list)
            {
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

            if (roomnumber == 1)
            {
                Booking booking = new Booking(standard, days);
                booking.Book();
                Console.Write($"Your room is reserved for {days} days, Total price will be {standard.Price}");
            }

        }
    }
}
