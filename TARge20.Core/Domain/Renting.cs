using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Renting
    {
        [Key]
        public Guid RentingId { get; set; }
        public string Comment { get; set; }

        public Employee Employee { get; set; }
        public ThingsToRent ThingsToRent { get; set; }
    }
}
