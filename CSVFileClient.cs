using FileHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV.ComparingTool
{
    internal class CSVFileClient
    {
       // private readonly FileHelperAsyncEngine<Domain> outputFileEngine;

        public List<Domain> ReadFileDomains(string file)
        {
            var records = (new FileHelperEngine<Domain>()).ReadFile(file);
            return records != null ? records.ToList() : new List<Domain>();
        }

        public List<CompletedDomain> ReadFileDomainsCompleted(string file)
        {
            var records = (new FileHelperEngine<CompletedDomain>()).ReadFile(file);
            return records != null ? records.ToList() : new List<CompletedDomain>();
        }

        // write to file
        public void WriteFile(List<Domain> domainList)
        {
            var engine = new FileHelperAsyncEngine<Domain>();
            using (engine.BeginWriteFile("Output.csv"))

            {
                Domain domain = new Domain();
                foreach (Domain dom in domainList)
                {
                    engine.WriteNext(dom);
                }
            }
            engine.Close();
        }
    }
}
