using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AirlineCore.Domains
{
    public class Plane
    {
        [StringLength(10)]
        public string LicensePlate { get; set; }
        [StringLength(100, MinimumLength = 3)]
        public string Brand { get; set; }
        [StringLength(100, MinimumLength = 3)]
        public string Model { get; set; }
        public DateTime FabricationDate { get; set; }
        [Range(1, 100)]
        public int Revision { get; set; }
        public int AirLine { get; set; }
    }
}
