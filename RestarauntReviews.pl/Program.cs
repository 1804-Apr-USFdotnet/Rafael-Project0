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


            Console.WriteLine(rest.ConvertToJson());
            rev.GetAverageResterauntReviews(2);
            rev.getResterauntAverages();
            rev.GetResterauntReviews("Har");
            Console.ReadLine();

        }
    }
}
