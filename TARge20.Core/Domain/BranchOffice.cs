using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class BranchOffice
    {
        [Key]
        public Guid Id { get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }

        public Company Company { get; set; }
    }
}
