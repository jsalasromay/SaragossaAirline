using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AirlineCore.Domains
{
    public class Passenger
    {
        [Required]
        [StringLength(12, MinimumLength = 10)]
        public string Dni { get; set; }
        [StringLength(100, MinimumLength = 2)]
        public string CompletedName { get; set; }
        public DateTime Birthday { get; set; }
        public bool Retired { get; set; }
    }
}
