using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations
using System.Text;

namespace AirlineCore.Domains
{
    public class AirLine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public decimal AnnualAverage { get; set; }
        public List<Plane> Planes { get; set; }
    }
}
