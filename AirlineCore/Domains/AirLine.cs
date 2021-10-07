using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AirlineCore.Domains
{
    public class AirLine
    {
        [Key]
        public int Id { get; set; }
        [StringLength(10, MinimumLength = 3)]
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        [Range(100, 100000)]
        public decimal AnnualAverage { get; set; }
    }
}
