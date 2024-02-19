using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ProgOOP_Midterm_Part2_MatthewVargas
{
    internal class Closet
    {
        //Is ItemDatabase, but I'm too far in to change it

        //Stores Upper Body Clothing Objects
        // Objective: Add support for the following; Current configuration, Wardrobe, Shop, Store, Storage

        // Next steps, add functionality for list of items person has (Finished)
        // add functionality for viewing a shop (Unfinished)
        // add functionality for unequipping items (*almost* finished, context in method)
        // add functionality for equipping items (*almost* finished, context in method)
        // add functionality for accessing a storage that holds unwanted things (Abandoned)



        static List<UpperBody> UpperBodyOwned = new List<UpperBody>();
        static List<UpperBody> UpperBodyUnowned = new List<UpperBody>();
        static List<InventoryItem> inventoryItems = new List<InventoryItem>();
        //For shop and wardrobe

        private List<Person> Configurations = new List<Person>();

        static Person currentConfiguration = new Person(noneouter, noneinner);
        public Closet()
        {

            Tshirt tshirt = new Tshirt("Blue", 20.00, "Tshirt");
            Sweater sweater = new Sweater("Blue", 10.15, "Sweater");

            inventoryItems.Add(new InventoryItem(tshirt, false));
            inventoryItems.Add(new InventoryItem(sweater, true));

            Person lisa = new Person(inventoryItems[0].ClothingItem, inventoryItems[1].ClothingItem);

            //UpperBodyOwned.Add(tshirt);
            //UpperBodyOwned.Add(sweater);

            //--------------------------------

            Suit suit = new Suit("Black", 49.99, "Suit");
            Jacket jacket = new Jacket("Grey", 59.99, "Jacket");
            LongSleeve longSleeve = new LongSleeve("White", 39.99, "Long Sleeve");

            UpperBody none = new UpperBody("None", "None");

            UpperBodyUnowned.Add(suit);
            UpperBodyUnowned.Add(jacket);
            UpperBodyUnowned.Add(longSleeve);


            //--------------------------------

            Person person = new Person(none, none);
        }


        public void turntoint() 
        {
            string numberword = Console.ReadLine();
            int numbernum = int.Parse(numberword);

            if ( numbernum is < 0 || numbernum == null) 
            {

            }
            else 
            {
                Console.WriteLine("Invalid selection, type in another number");
                turntoint();
            };

            
        
        }
        // Current Objective: Solve how to apply a selected piece of clothing to it's corresponding slot (context below commented in equip and unequip methods)

        static OuterWear noneouter = new OuterWear("none", 0, "none");
        static InnerWear noneinner = new InnerWear("none", 0, "none");

        public void EquipClothing()
        {
            Console.WriteLine($"Type the number corresponding to the item you want to equip");
            turntoint();

            string numberword = Console.ReadLine();
            int slotindex = int.Parse(numberword);

            if (slotindex < 0 || slotindex >= UpperBodyOwned.Count)
            {
                Console.Write("\nInvalid item");
                return;
            }    
            
            Person tempcurrentConfiguration = currentConfiguration;
            

            if (UpperBodyOwned[slotindex] is OuterWear)
            {
                //Issue area, tempcurrentConfiguration (copy of currentConfiguration) doesn't fit into upperbody specifications
                UpperBody tempholder = tempcurrentConfiguration[1];
                Person tempnewConfiguration = new Person(UpperBodyOwned[slotindex], tempholder);
                
                currentConfiguration = tempnewConfiguration;
                Console.WriteLine($"Clothing equipped successfully to outer wear!\n");
                //Issue area, tempcurrentConfiguration doesn't work

            }
            else if (UpperBodyOwned[slotindex] is InnerWear)
            {
                //Issue area, tempcurrentConfiguration (copy of current configuration) doesn't fit into the upperbody specifications
                UpperBody tempholder = tempcurrentConfiguration[2];
                Person tempnewConfiguration = new Person(tempholder, UpperBodyOwned[slotindex]);

                currentConfiguration = tempnewConfiguration;
                Console.WriteLine($"Clothing equipped successfully to inner wear!\n");
                //Issue area, tempcurrentConfiguration doesn't work


            }

        }
        public void AskForRemoved() 
        {
            Console.WriteLine("(1) - Remove Outer clothing\n" +
            "(2) - Remove Inner clothing\n" +
            "(3) - Return to menu\n");
            Console.WriteLine("Which piece of clothing would you like to remove? (ex: 1, 2, 3)");
        }
        public void RemoveClothing()
        {
            AskForRemoved();
            turntoint();
            string numberword = Console.ReadLine();
            int slotindex = int.Parse(numberword);


            Person removedclothing = null;

            if (slotindex > 0)
            {
                switch (slotindex)
                {
                    //Issue here, unsure of what would replace outer effectively for currentConfiguration
                    case 1:
                        currentConfiguration[1] = noneouter;
                        break;
                    case 2:
                        currentConfiguration[2] = noneinner;
                        break;
                    case 3:
                        Commands.MenuExploration();
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a valid option.");
                        RemoveClothing();
                        break;
                    //Issue here, unsure of what would replace currentConfiguration to the effect I intend
                }
            }
        }


        /// <summary>
        /// ^Above is the issue area, I stuctured it so that as long as the one piece in the equip clothing section is fixed, then it works completely
        /// Also Closet.EquipClothing is no longer a valid way to call the method for some reason, I think this occured somewhere along the changes I was making
        /// </summary>


        //Option in main menu
        internal static void Wardrobe()
        {
            WardrobeListOfItems();
        }

        //For when the main menu is all you've got
        internal static void BasicTextNav()
        {
            Console.WriteLine("(1) - Current configuration\n" +
                "(2) - Wardrobe\n" +
                "(3) - Shop\n");
            Commands.MenuExploration();
        }
        internal static void CurrentConfiguration()
        {
            Console.Write("Current Configuration was called, placeholder for function annotated out");
            //Console.Write($" (Outer Wear) - {currentConfiguration[1]}\n"); currenConfiguration is also broken here, annotated out for usability
            //Console.Write($" (Inner Wear) - {currentConfiguration[2}}\n\n");
        }
        internal static void WardrobeListOfItems()
        {
            int startcount = 0;

            Console.Write($"\n\nThere are {UpperBodyOwned.Count} items in your wardrobe, viewing below:\n\n");
            foreach (UpperBody upperBody in UpperBodyOwned)
            {
                Console.Write($"   Item {startcount + 1}: ");
                if (upperBody is InnerWear innerWear)
                {
                    Console.Write($" {innerWear.color}");
                    Console.Write($" {upperBody.name} - ${innerWear.cost}\n");
                }
                else if (upperBody is OuterWear outerWear)
                {
                    Console.Write($" {outerWear.color}");
                    Console.Write($" {upperBody.name} - ${outerWear.cost}\n");
                }



                startcount++;
            }
            Console.Write("\n" +
                "   (1) - Current configuration\n" +
                "   (2) - Shop\n" +
                "   (3) - Equip clothing\n" );



            string UserInput = Console.ReadLine();

            switch (UserInput)
            {
                //Equip an item, remove an item, and search for an item
                case "1":
                    Closet.CurrentConfiguration();
                    break;
                case "2":
                    Commands.Shop();
                    break;
                case "3":
                    Closet.EquipClothing();
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a valid option.");
                    Commands.MenuExploration();
                    break;
            }

        }

        internal static void ListOfShopItems()
        {
            int startcount = 0;

            Console.Write($"\n\nThere are {UpperBodyUnowned.Count} items in the shop, viewing below:\n\n");
            foreach (UpperBody upperBody in UpperBodyUnowned)
            {
                Console.Write($"   Item {startcount + 1}: ");
                if (upperBody is InnerWear innerWear)
                {
                    Console.Write($" {innerWear.color}");
                    Console.Write($" {upperBody.name} - ${innerWear.cost}\n");
                }
                else if (upperBody is OuterWear outerWear)
                {
                    Console.Write($" {outerWear.color}");
                    Console.Write($" {upperBody.name} - ${outerWear.cost}\n");
                }

                startcount++;
            }
            Console.Write("\n" +
                "   (1) - Current configuration\n" +
                "   (2) - Owned items\n" +
                "   (3) - View shop\n");

            string UserInput = Console.ReadLine();

            switch (UserInput)
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
                //case "4":
                //    Commands.Storage();
                //    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a valid option.");
                    Commands.MenuExploration();
                    break;
            }
        }
    }
}
