using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgOOP_Midterm_Part2_MatthewVargas
{
    internal class Commands
    {
        internal static void Shop()
        {
            Closet.ListOfShopItems();
            
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
                    Closet.CurrentConfiguration();
                    break;
                case "2":
                    Closet.Wardrobe();
                    break;
                case "3":
                    Commands.Shop();
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a valid option.");
                    MenuExploration();
                    break;
            }

        }
    }
}
