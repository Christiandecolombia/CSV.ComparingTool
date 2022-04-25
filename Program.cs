using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.

namespace CSV.ComparingTool
{
    internal class Program
    {
        private const string OutputFileName = "Output.csv";
        private const string OutputDomains = "OutputDomains.txt";
        static void Main(string[] args)
        {
            // Reading files
            Console.WriteLine("CSV Comparing Tool");
            string file1 = @"C:\Users\chris\OneDrive\Desktop\UK_Domains_Last_900.csv";
            string file2 = @"C:\Users\chris\OneDrive\Desktop\UK_Domains_Last_900.csv";
            Console.WriteLine("Reading files");

            // CSV Client, creating lists
            CSVFileClient csvClient = new CSVFileClient();
            List<Domain> file1Domains = csvClient.ReadFile(file1);
            List<Domain> file2Domains = csvClient.ReadFile(file2);
            Console.WriteLine(file1Domains.Count + " In file 1.");
            Console.WriteLine(file2Domains.Count + " In file 2.");

            // Comparing lists
            //List<Domain> outputDomains = new List<Domain>(file1Domains);
            foreach (Domain domain1 in file1Domains)
            {
                foreach (Domain domain2 in file2Domains)
                {
                    if(domain1.Name == domain2.Name)
                    {

                    }

                }
            }


            Console.WriteLine("Press any key to close");
            Console.ReadLine();



        }
    }
}
