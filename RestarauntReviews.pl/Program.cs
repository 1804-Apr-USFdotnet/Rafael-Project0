using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestarauntReviews;
using RestarauntReviews.bl;
using ResterauntReview.dl.Models;
using ResterauntReview.dl.Repositories;

namespace RestarauntReviews.pl
{
   public class Program
    {
        static void Main(string[] args)
        {
            ResterauntFunctions rest = new ResterauntFunctions();
            ReviewFunctions rev = new ReviewFunctions();


            Resteraunt resteraunt = new Resteraunt()
            {
                Name = "Bobs Burgers",
                City = "Ft. Lauderdale"

            };
         //   ResterauntCrudOps.AddResteraunt(resteraunt);

            ReviewsRepository revi = new ReviewsRepository();
           // revi.TableToXml();
           UserInputHandler.UserCommandOptions();

            Console.ReadLine();

        }
    }
}
