using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgOOP_Midterm_Part2_MatthewVargas
{
    internal class Closet
    {
        //Stores Upper Body Clothing Objects
        // Objective: Add support for the following; Current configuration, Wardrobe, Shop, Store, Storage

        // Next steps, add functionality for list of items person has
        // add functionality for viewing a shop
        // add functionality for accessing a storage that holds unwanted things

        

        static List<UpperBody> UpperBodyOwned = new List<UpperBody>();
        static List<UpperBody> UpperBodyUnowned = new List<UpperBody>();



        // Color, Cost, TieColor


        public Closet()
        {

            Tshirt tshirt = new Tshirt("Blue", 20.00, "Puma");
            Sweater sweater = new Sweater("Blue", 10.15, "Levi's");

            UpperBodyOwned.Add(tshirt);
            UpperBodyOwned.Add(sweater);
        }

        internal static void Wardrobe()
        {
            WardrobeListOfItems();
        }

        internal static void WardrobeListOfItems()
        {
            int startcount = 0;

            Console.Write($"\n\nThere are {UpperBodyOwned.Count} items in your wardrobe, viewing below:\n\n");
            foreach (UpperBody upperBody in UpperBodyOwned)
            {
                Console.Write($"Item {startcount + 1}: ");
                if (upperBody is InnerWear innerWear) 
                {
                    Console.Write($"  - {innerWear.color}");
                    Console.Write($" {upperBody.name}'s - {innerWear.cost}\n");
                }
                else if (upperBody is OuterWear outerWear) 
                {
                    Console.Write($"{outerWear.color}");
                    Console.Write($" {upperBody.name} - {outerWear.cost}");
                }
    
                
                startcount++;
            }
            

        }

        //internal static void Counting() 
        //{
        //    int startcount = 0;

        //    foreach (UpperBody upperbody in UpperBodyOwned) 
        //    {
        //        string color = upperbody.Color;
        //        int cost = upperbody.Cost;
        //        if upperbody.Cost()


        //        startcount++;

        //    }

        //}

    }
}
