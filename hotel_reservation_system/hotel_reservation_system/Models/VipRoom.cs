using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_reservation_system.Models
{
    internal class VipRoom : Room
    {
        public override double CalculatePrice(int days)
        {
            Price = 300 * days;
            return Price;
        }

        public VipRoom(int roomNumber) : base(roomNumber)
        {
        }
    }
}
