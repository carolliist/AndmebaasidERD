using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Working
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime InitDate { get; set; }
        public DateTime EndDate { get; set; }

        public JobTitle JobTitle { get; set; }
        public Employee Employee { get; set; }
        public BranchOffice BranchOffice { get; set; }
    }
}
