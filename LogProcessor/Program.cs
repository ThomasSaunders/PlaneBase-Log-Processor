using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleMenu;

namespace LogProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mainMenuItems = new string[] { "Import Log", "View Cleaned Log", "Export Log", "Exit" };

            Log log;

            Menu mainMenu = new Menu(mainMenuItems, "PlaneBase Log Processor");

            switch (mainMenu.displayMenu())
            {
                case 0:
                    log = importLog();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }

        static Log importLog()
        {
            Console.WriteLine("Please enter the file name of the log, excluding the txt extension.");

            string fileLocation = Console.ReadLine();

            return new Log(fileLocation);
        }
    }
}
