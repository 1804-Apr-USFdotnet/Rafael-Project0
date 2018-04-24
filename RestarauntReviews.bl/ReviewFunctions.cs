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

        public void GetAveragesOfAllResterauntReviews()
        {

            reviewsRepo.GetReviews();
        }


        public void GetAverageResterauntReviews(int ResterauntId)
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

        public void GetResterauntReviews(string name)
        {
            var resteraunts = resterauntRepo.GetAllResteraunts();
            var reviewsList = reviewsRepo.GetReviews();


            var resterauntReviews = from res in resteraunts
                                    join rev in reviewsList
                                    on res.ResterauntId equals rev.ResterauntId
                                    where res.Name.StartsWith(name)
                                    group new { rev = rev, res = res } by rev.ResterauntId;                                  ;

            foreach (var item in resterauntReviews)
            {
                //Console.WriteLine(item.Key);

                foreach (var x in item)
                {
                    Console.WriteLine($"{x.res.Name} has a rating of {x.rev.Rating}");
                 
                }
            }
        }

    }
    }

        


