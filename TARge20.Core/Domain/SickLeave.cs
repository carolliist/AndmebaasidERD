using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class SickLeave
    {
        public Guid Id { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime EndDate { get; set; }
        public string comment { get; set; }

        public Employee Employee { get; set; }
    }
}
