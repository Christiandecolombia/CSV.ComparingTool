using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string file1 = @"C:\Users\v-rchristian\OneDrive - Microsoft\Desktop\UK Domains.csv";
            string file2 = @"C:\Users\v-rchristian\OneDrive - Microsoft\Desktop\UK Domain Results.csv";
            Console.WriteLine("Reading files");

            // CSV Client, creating lists
            CSVFileClient csvClient = new CSVFileClient();
            List<Domain> domains = csvClient.ReadFileDomains(file1);
            Console.WriteLine(domains.Count + " In file 1.");
            List<Domain> completedDomains = csvClient.ReadFileDomains(file2);
            Console.WriteLine(completedDomains.Count + " In file 2.");

            // Comparing lists
            for (int i = 0; i < completedDomains.Count; i++)
            {
                Console.Write($"\r                                                                                      ");
                Console.Write($"\r{completedDomains[i].Name}");
                Domain domain = domains.SingleOrDefault(p => p.Name == completedDomains[i].Name);
                if(domain != null)
                {
                    domains.Remove(domain);
                }
                     

            }

            Console.WriteLine("");
            Console.WriteLine("Unique Domains: " + domains.Count);
            csvClient.WriteFile(domains);


            Console.WriteLine("");
            Console.WriteLine("Press any key to close");
            Console.ReadLine();



        }
    }
}
