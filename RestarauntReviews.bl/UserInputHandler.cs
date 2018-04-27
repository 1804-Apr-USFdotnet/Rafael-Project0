using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestarauntReviews.bl
{
    public static class UserInputHandler
    {
       static void GetSortMethodBasedOnUserInput()
        {
            ResterauntFunctions resterauntFunctions = new ResterauntFunctions();
            ReviewFunctions reviewFunctions = new ReviewFunctions();

            string input = string.Empty;
            Console.WriteLine("Press c to sort by city \n" +
                              "Presss n to sort by Name");

            input = Console.ReadLine();
            input = input.ToLower().Trim();

            switch (input)
            {

                case "c":
                    Console.WriteLine("enter a city Name");

                    resterauntFunctions.SortbyCity(Console.ReadLine());
                    break;

                case "n":
                    break;
                case "back":
                    UserCommandOptions();
                    break;
                case "q":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("enter either n or c to sort by name or city \n " +
                        "press q to exit press back to go back");
                    break;





            }



        }









        public static void UserCommandOptions()
        {

            ResterauntFunctions resterauntFunctions = new ResterauntFunctions();
            ReviewFunctions reviewFunctions = new ReviewFunctions();


            Console.WriteLine("Enter ? for a list of possible commands.");

            string selection = string.Empty;
            while (selection != "q" && selection != "Q")
            {
                selection = Console.ReadLine();


                selection = selection.ToLower().Trim();

                switch (selection)
                {

                        //                                      display top 3 restaurants by average rating
                        //display all restaurants
                        //should allow more than one method of sorting
                        //display details of a restaurant
                        //display all the reviews of a restaurant
                        //search restaurants(e.g.by partial name), and display all matching results
                        //quit application

                    case "?":

                        Console.Write("Enter search or s to search for a resteraunt. \n" + 
                    "Enter search or t to search for the resteraunt with the top 3 average reviews. \n" 
               +     " Enter d or display to display resteraunt datails   \n"
               +     " enter r or reviews to see all the resteraunt reviews   \n"
               +     "Enter sort to sort resteraunts \n"
               +     "    \n"
         
                    );
                        break;


                    case "sort":
                        GetSortMethodBasedOnUserInput();
                        break;

                    case "search":
                    case "s":
                        Console.Write("Please enter at least the first two letters of a  resteraunt to search for a resteraunt: ");
                        string input = Console.ReadLine();
                        resterauntFunctions.searchByPartialName(input);
                        break;

                    case "t":
                        reviewFunctions.getResterauntWithTop3AverageRatings();
                        break;

                    case "e":
                    case "q":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid entry Please enter a valid command. To see a list of commands press ? \n press" +
                            " press e to exit");
                        break;

                }


            }




        }
    }
}
