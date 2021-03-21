using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogProcessor
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static List<string> ImportLog(string fileLocation = "ViewLog.txt")
        {
            List<string> log = new List<string>();
            
            using (StreamReader sr = new StreamReader(fileLocation))
            {
                string line = sr.ReadLine();

                while (line != null)
                {
                    log.Add(line);

                    Console.WriteLine(line);
                }

                sr.Close();
            }

            return log;
        }

        }
    }
}
