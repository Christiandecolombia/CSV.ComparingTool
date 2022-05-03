using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace CSV.ComparingTool
{
    [DelimitedRecord(",")]
    public class CompletedDomain
    {
        public string ID { get; set; }
        public string Worker { get; set; }
        public string Name { get; set; }
        public string IsDisalloweded { get; set; }
    }
}
