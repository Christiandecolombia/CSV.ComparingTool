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
        private readonly FileHelperAsyncEngine<Domain> outputFileEngine;

        public List<Domain> ReadFile(string file)
        {
            var records = (new FileHelperEngine<Domain>()).ReadFile(file);
            return records != null ? records.ToList() : new List<Domain>();
        }

        public void CloseOutput()
        {
            outputFileEngine.Close();
        }
    }
}
