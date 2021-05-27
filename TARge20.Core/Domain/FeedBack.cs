using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    class FeedBack
    {
        [Key]
        public Guid Id { get; set; }
        public string AnonymousSuggestions { get; set; }
        public string Suggestions { get; set; }
        public string Comment { get; set; }
    }
}
