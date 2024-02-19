namespace ProgOOP_Midterm_Part2_MatthewVargas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Closet closet = new Closet();

            //Classes Inheritance Static

            //While tracking rotations and other things through steam is good, that's a little out of scope for me right now.
            //Regardless, sometimes a game requires customization for a player to feel integrated, this is my motivaion I'll be using to pursue this project

            //Parent Class:
            // -Upper Body Clothing


            //Derived Classes            
            // -LongSleeves
            // -Tshirts
            // -Jackets
            // -Suits
            // -Sweaters

            Console.WriteLine("Welcome to the wardrobe, what is your name?");
            Console.Write("");

            string name = Console.ReadLine();

            if (string.IsNullOrEmpty(name) == false)
            {
                Console.WriteLine($"\nPerfect! Welcome to your wardrobe {name}\n");

                Console.WriteLine("Currently your only options are Upper body clothing, look up and move your configuration with the listed commands below\n" +
                                  "   (1) - Current configuration\n" +
                                  "   (2) - Wardrobe\n" +
                                  "   (3) - Shop\n");
                //"   (4) - Store\n" +
                //"   (5) - Storage"
                // Features I felt were too over the top for time
            }
            else 
            { invalidname(); }


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
                //case "4":
                //    Commands.Storage();
                //    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a valid option.");
                    Commands.MenuExploration();
                    break;
            }


            static void invalidname()
            {
                Console.WriteLine("Sorry, that's invalid. What is your name?\n");
                string text = Console.ReadLine();

                if (string.IsNullOrEmpty(text))
                {
                    invalidname();
                }
                else
                {
                    string newname = text;
                    string name = newname;

                    Console.Write($"Perfect! Welcome to your wardrobe {name}");

                    Console.Write("Currently your only options are Upper body clothing, look up and move your configuration with the listed commands below\n" +
                                      "   (1) - Current configuration\n" +
                                      "   (2) - Wardrobe\n" +
                                      "   (3) - Shop\n");
                    //"   (4) - Store\n" +
                    //"   (5) - Storage"
                    // Features I felt were too over the top for time
                }

            }
        }

            // if 1 then look at configuration, if 2 then look at wardrobe and so on and so forth




        }
    }

