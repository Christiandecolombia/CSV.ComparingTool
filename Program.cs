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
        static void Main(string[] args)
        {
            // Reading files
            Console.WriteLine("CSV Comparing Tool");

            string file1 = string.Empty;
            while (true)
            {
                Console.Write("\nEnter the unverified domain list csv file path: ");
                file1 = Console.ReadLine();

                if (File.Exists(file1))
                {
                    break;
                }

                Console.WriteLine("Invalid file path");
            }

            string file2 = string.Empty;
            while (true)
            {
                Console.Write("\nEnter the verified domain list csv file path: ");
                file2 = Console.ReadLine();

                if (File.Exists(file1))
                {
                    break;
                }

                Console.WriteLine("Invalid file path");
            }


            Console.WriteLine("Reading files");

            // CSV Client, creating lists
            CSVFileClient csvClient = new CSVFileClient();
            List<Domain> domains = csvClient.ReadFileDomains(file1);
            Console.WriteLine(domains.Count + " In file 1");
            List<CompletedDomain> completedDomains = csvClient.ReadFileDomainsCompleted(file2);
            //List<Domain> completedDomains = csvClient.ReadFileDomains(file2);
            Console.WriteLine(completedDomains.Count + " In file 2");

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
