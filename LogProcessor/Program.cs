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
            using(StreamReader sr = new StreamReader("ViewLog.txt"))
            {
                List<string> log = new List<string>();

                string line = sr.ReadLine();

                while (line != null)
                {
                    log.Add(line);
                    
                    Console.WriteLine(line);
                }

                sr.Close();
            }


        }
    }
}
