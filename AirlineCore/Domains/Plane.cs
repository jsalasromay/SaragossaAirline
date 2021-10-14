using System;
using System.Collections.Generic;
using System.Text;

namespace AirlineCore.Domains
{
    public class Plane
    {
        public string LicensePlate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime FabricationDate { get; set; }
        public int Revision { get; set; }
        public AirLine AirLine { get; set; }
    }
}
