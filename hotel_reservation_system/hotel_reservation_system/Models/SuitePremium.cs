using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_reservation_system.Models
{
    internal class SuitePremium : Room
    {
        public override double CalculatePrice(int days)
        {
            Price = 800 * days;
            return Price;
        }

        public SuitePremium(int roomNumber) : base(roomNumber)
        {
        }
    }
}
