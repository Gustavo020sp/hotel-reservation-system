using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_reservation_system.Models
{
    internal class StandardRoom : Room
    {
        public override double CalculatePrice(int days)
        {
            Price = 100.80 * days;
            return Price;
        }

        public StandardRoom(int roomNumber) : base(roomNumber)
        {
        }
    }
}
