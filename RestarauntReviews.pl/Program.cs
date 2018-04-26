using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestarauntReviews;
using RestarauntReviews.bl;
using ResterauntReview.dl.Repositories;

namespace RestarauntReviews.pl
{
   public class Program
    {
        static void Main(string[] args)
        {
            ResterauntFunctions rest = new ResterauntFunctions();
            ReviewFunctions rev = new ReviewFunctions();
      
            rest.GetResterauntDetails();
            Console.WriteLine("search a resteraunt");

            string input = Console.ReadLine();
          //  rev.GetResterauntReviews(input);
            rest.searchByPartialName(input);
           
            Console.WriteLine(rest.ConvertToJson());
         
            rev.GetResterauntReviews("Har");
            Console.ReadLine();

        }
    }
}
