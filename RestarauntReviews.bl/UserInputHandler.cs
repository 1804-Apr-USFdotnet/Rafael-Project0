using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestarauntReviews.bl
{
    public static class UserInputHandler
    {
        public static void UserCommandOptions()
        {

            ResterauntFunctions resterauntFunctions = new ResterauntFunctions();
            ReviewFunctions reviewFunctions = new ReviewFunctions();


            Console.WriteLine("Enter ? for a list of possible commands.");

            string selection = string.Empty;
            while (selection != "q" && selection != "Q")
            {
                Console.Write(" to search for a resteraunt details press search ");
                selection = Console.ReadLine();


                selection = selection.ToLower().Trim();

                switch (selection)
                {




                    case "?":

                        Console.Write("Enter search or s to search for a resteraunt");

                     
                        break;










                    case "search":
                    case "s":

                        Console.Write("Please enter at least the first two letters of a  resteraunt to search for a resteraunt: ");
                        resterauntFunctions.GetResterauntDetails();

                        break;

                    case "F":
                    case "f":
                        Console.Write("Please enter the Farentheit temperature that you want converted to a Celsius temperature: ");

                        break;

                    case "Q":
                    case "q":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid entry Please enter a valid command. To see a list of commands press ? ");
                        break;

                }


            }




        }
    }
}
