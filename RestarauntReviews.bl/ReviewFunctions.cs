using NLog;
using ResterauntReview.dl.Models;
using ResterauntReview.dl.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestarauntReviews.bl
{
    public class ReviewFunctions : IReviewFunctions
    {

        ResterauntRepository resterauntRepo = new ResterauntRepository();
        ReviewsRepository reviewsRepo = new ReviewsRepository();
        ErrorManager errorManager = new ErrorManager();

        public void GetAveragesOfAllResterauntReviews()
        {

            reviewsRepo.GetReviews();
        }

        #region GetAverageReviews
        public void GetAverageResterauntReviews(int ResterauntId)
        {
            try
            {


                try
                {
                    int zero = 0;
                    int result = 5 / zero;
                }
                catch (DivideByZeroException ex)
                {

                    Logger logger = LogManager.GetLogger("databaseLogger");

                    // add custom message and pass in the exception
                    logger.Error(ex, " ");


                }


            }
            catch (Exception ex)
            {
                errorManager.logError(ex, "");
            }


        }
        #endregion


        public void GetResterauntReviews(string name)
        {

            try
            {
                var resteraunts = resterauntRepo.GetAllResteraunts();
                var reviewsList = reviewsRepo.GetReviews();
                foreach (var res in resteraunts)
                {
                    Console.WriteLine($"{res.Name} has a rating of {res.reviews.Rating}");
                }


                //var resterauntReviews = from res in resteraunts
                //                        join rev in reviewsList
                //                        on res.ResterauntId equals rev.ResterauntId
                //                        where res.Name.StartsWith(name)
                //                        group new { rev = rev, res = res } by rev.ResterauntId; 

                //foreach (var item in resterauntReviews)
                //{
                   

                //    foreach (var x in item)
                //    {
                //        Console.WriteLine($"{x.res.Name} has a rating of {x.rev.Rating}");

                //    }
                //}

            }
            catch (Exception ex)
            {


            }
        }

        #region TopReviews
        public void getResterauntAverages()
        {



            var resteraunts = resterauntRepo.GetAllResteraunts();
            var reviewsList = reviewsRepo.GetReviews();

            var result = reviewsList.GroupBy(s => s.ResterauntId)
                     .Select(g => new { Id = g.Key, Avg = g.Average(s => s.Rating) });

            foreach (var res in result)
            {
                string name = "";
                foreach (var rest in resteraunts)
                {
                    if (res.Id == rest.ResterauntId)
                    {
                        name = rest.Name;
                        break;
                    }
                }
                Console.WriteLine($"{name} has a rating of {res.Avg}");
            }
   
            }
        }
        #endregion
    }






