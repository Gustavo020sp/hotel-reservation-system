using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_reservation_system.Interfaces
{
    internal interface IBooking
    {

        //methods
        public int CalculatePrice(int days);
        public bool IsAvailable();
    }
}
