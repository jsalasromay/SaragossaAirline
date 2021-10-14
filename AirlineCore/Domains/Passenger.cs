using System;
using System.Collections.Generic;
using System.Text;

namespace AirlineCore.Domains
{
    public class Passenger
    {
        public string Dni { get; set; }
        public string CompletedName { get; set; }
        public DateTime Birthday { get; set; }
        public bool Retired { get; set; }
    }
}
