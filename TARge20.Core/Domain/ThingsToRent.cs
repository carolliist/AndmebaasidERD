using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class ThingsToRent
    {
        [Key]
        public Guid ThingToRentId { get; set; }

        public DateTime InitDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Comment { get; set; }

        public ICollection<Renting> Renting { get; set; }
    }
}
