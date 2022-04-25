using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace CSV.ComparingTool
{
    [DelimitedRecord(",")]
    public class Domain
    {
        [FieldOptional]
        public string ID { get; set; }
        //[FieldOptional]
        //public int Worker { get; set; }
        [FieldOptional]
        public string Name { get; set; }
        //[FieldOptional]
        //public bool IsDisalloweded { get; set; }
        //[FieldHidden]
        //[FieldOptional]
        //public Dictionary<string, int> DisallowedWords { get; set; }
        //[FieldOptional]
        //public string Words { get; set; }
        //[FieldOptional]
        //public string Error { get; set; }
    }
}
