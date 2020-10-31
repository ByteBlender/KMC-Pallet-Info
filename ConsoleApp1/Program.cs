using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fsRead = new FileStream(@"C:\Users\Gayan\Downloads\KMC sql\SQLschema.sql.txt", FileMode.Open, FileAccess.Read);
            FileStream fsWrite = new FileStream(@"C:\Users\Gayan\Downloads\KMC sql\palletStock.txt", FileMode.Create, FileAccess.Write);


            using (StreamReader reader = new StreamReader(fsRead))
            {
                string line;
                bool write = false;
                int i = 0;

                string searchString = "INSERT [dbo].[PalletLocation]";
                string searchString2 = "INSERT [dbo].[PalletDetails]";
                int l = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    i++;
                    if (line.Length > searchString.Length && line.Substring(0, searchString.Length) == searchString)
                    {
                        write = true;
                    }


                    if (write)
                    {
                        using (StreamWriter writer = new StreamWriter(fsWrite, Encoding.Default, 4096, true))
                        {
                            writer.WriteLine($"{line}\n");

                        }
                    }

                    if (write && line.Length > searchString.Length && line.Substring(0, searchString.Length) != searchString)
                    {
                        i = 0;

                    }

                    if(write && i == 10)
                    {
                        break;
                    }

                    Console.WriteLine($"{i} - {line}");
                }

                Console.ReadLine();

              
            }
        }
    }
}
