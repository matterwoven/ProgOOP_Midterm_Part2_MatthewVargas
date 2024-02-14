using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgOOP_Midterm_Part2_MatthewVargas
{
    internal class Commands
    {
        private static string upperinner = "";
        private static string upperouter = "";
        internal static void CurrentConfiguration()
        {
            Console.WriteLine($"Current Upper Body:\n" +
                              $" (Inner Wear) - {upperinner}\n" +
                              $" (Outer Wear) - {upperouter}\n");
        }

        internal static void Shop()
        {
            Console.WriteLine("Fetching shop list");
        }
        internal static void Storage()
        {

        }
        /// <summary>
        ///  Full disclosure, the majority of this is just for the program section not to bloat
        /// </summary>
        static void Store() 
        {
        
        }

        internal static void MenuExploration() 
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Commands.CurrentConfiguration();
                    break;
                case "2":
                    Closet.Wardrobe();
                    break;
                case "3":
                    Commands.Shop();
                    break;
                case "4":
                    Commands.Storage();
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a valid option.");
                    MenuExploration();
                    break;
            }

        }
    }
}
