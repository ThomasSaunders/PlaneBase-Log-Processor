using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogProcessor
{
    class Log
    {
        public string Location { get; set; }
        public string Date { get; set; }
        public List<string> Entries { get; set; }

        public Log(string fileLocation = "viewlog.txt", bool displayInput = false, bool displayOutput = false)
        {
            Entries = ImportLog(fileLocation);

            for (int i = 0; i < Entries.Count; i++)
            {
                Entries[i] = RemoveWhiteSpace(Entries[i]);
            }
        }

        static List<string> ImportLog(string fileLocation)
        {
            List<string> log = new List<string>();

            using (StreamReader sr = new StreamReader(fileLocation))
            {
                string line = sr.ReadLine();

                while (line != null)
                {
                    log.Add(line);

                    //Console.WriteLine(line);

                    line = sr.ReadLine();
                }

                sr.Close();
            }

            return log;
        }

        static string RemoveWhiteSpace(string logEntry)
        {
            bool placedDivider = false;
            int logLength = logEntry.Length;

            logEntry = logEntry.Trim();

            StringBuilder stringBuilder = new StringBuilder(logEntry);

            for (int i = 1; i < logLength - 1; i++)
            {
                if (char.IsWhiteSpace(logEntry[i]) && char.IsWhiteSpace(logEntry[i - 1]) && char.IsWhiteSpace(logEntry[i + 1]) && !placedDivider)
                {
                    stringBuilder[i] = '-';

                    placedDivider = true;
                }
                else if (char.IsWhiteSpace(logEntry[i]) && char.IsWhiteSpace(logEntry[i - 1]) && char.IsWhiteSpace(logEntry[i + 1]) && placedDivider)
                {
                    stringBuilder.Replace(" ", "☔", i, 1);

                    logLength = stringBuilder.Length;

                }
                else if (!char.IsWhiteSpace(logEntry[i]) && char.IsWhiteSpace(logEntry[i - 1]) && placedDivider)
                {
                    placedDivider = false;
                }
            }

            stringBuilder.Replace("☔", "");

            logEntry = stringBuilder.ToString();

            Console.WriteLine(logEntry);

            return logEntry;
        }

        public bool ExportCleanLog(string location = "CleanViewLog.txt")
        {
            using (StreamWriter streamWriter = new StreamWriter(location))
            {
                foreach (var entry in this.Entries)
                {
                    streamWriter.WriteLine(entry);
                }
            }

            return true;
        }

        public void ViewCleanLog()
        {
            foreach (var entry in this.Entries)
            {
                Console.WriteLine(entry);
            }

            Console.WriteLine("\n Press any key to continue");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
