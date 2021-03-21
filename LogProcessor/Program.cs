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
            List<string> log = ImportLog();

            for (int i = 0; i < log.Count; i++)

            ExportLog(log);

            Console.ReadLine();
        {
            List<string> log = new List<string>();
            
            using (StreamReader sr = new StreamReader(fileLocation))
            {
                string line = sr.ReadLine();
                }

                sr.Close();
            }

            return log;
        {
            bool placedDivider = false;

            logEntry = logEntry.Trim();

            StringBuilder stringBuilder = new StringBuilder(logEntry);
        }
    }
}
