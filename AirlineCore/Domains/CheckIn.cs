using System;
using System.Collections.Generic;
using System.Text;

namespace AirlineCore.Domains
{
    public class CheckIn
    {
        public Plane LicensePlate { get; set; }
        public Passenger Dni { get; set; }
        public DateTime FlyDate { get; set; }
        public decimal Cost { get; set; }
    }
}
