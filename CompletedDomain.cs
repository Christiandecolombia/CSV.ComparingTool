using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace CSV.ComparingTool
{
    [IgnoreEmptyLines]
    [DelimitedRecord(",")]
    public class CompletedDomain
    {

        public string Id { get; set; }

        public string Worker { get; set; }

        public string Name { get; set; }

        [FieldConverter(ConverterKind.Boolean)]
        public bool IsDisalloweded { get; set; }

        [FieldOptional]

        public string Words { get; set; }

        [FieldOptional]
        public string Error { get; set; }

        [FieldOptional]
        public string Error2 { get; set; }

        [FieldOptional]
        public string Error3 { get; set; }
    }
}
