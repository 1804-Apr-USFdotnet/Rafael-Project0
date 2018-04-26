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
    public  class ReviewFunctions : IReviewFunctions
    {
        #region Declarations of Variables

        ResterauntRepository resterauntRepo = new ResterauntRepository();
        ReviewsRepository reviewsRepo = new ReviewsRepository();
        ErrorManager errorManager = new ErrorManager();
        List<Resteraunt> resterauntList;
        List<Review> reviewList;
        #endregion

        public ReviewFunctions()
        {
           resterauntList = resterauntRepo.GetAllResteraunts().ToList();

            reviewList = reviewsRepo.GetReviews().ToList();
        }

        #region GetAverageReviews
        public void GetResterauntReviews(string Name)
        {
            //Console.WriteLine("search for a resteraunt by typing a name, Press enter when you are finished");
            //Name = Console.ReadLine();

            var Ids = resterauntRepo.ConvertNameIntoId(Name);


       var requestedReterauntsReviews = reviewList.Where(x => Ids.Contains(x.ResterauntId)).GroupBy(r => r.ResterauntId,
              (key, g) => new { ResterauntId = key, Review = g.ToList() }
                      
           ).OrderBy(x => x.ResterauntId);


            foreach (var item in requestedReterauntsReviews)
            {
                foreach (var rev in item.Review)
                {
                    Console.WriteLine(rev.ReviewComment  + Name);
                }
            }
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

            Console.ReadLine();
        }
        #endregion


        //public void GetResterauntReviews(string name)
        //{

        //    try
        //    {
        //        var resteraunts = resterauntRepo.GetAllResteraunts();
        //        var reviewsList = reviewsRepo.GetReviews();
        //        foreach (var res in resteraunts)
        //        {
        //            Console.WriteLine($"{res.Name} has a rating of {res.reviews.Rating}");
        //        }


        //        //var resterauntReviews = from res in resteraunts
        //        //                        join rev in reviewsList
        //        //                        on res.ResterauntId equals rev.ResterauntId
        //        //                        where res.Name.StartsWith(name)
        //        //                        group new { rev = rev, res = res } by rev.ResterauntId; 

        //        //foreach (var item in resterauntReviews)
        //        //{
                   

        //        //    foreach (var x in item)
        //        //    {
        //        //        Console.WriteLine($"{x.res.Name} has a rating of {x.rev.Rating}");

        //        //    }
        //        //}

        //    }
        //    catch (Exception ex)
        //    {


        //    }
        //}

        #region AllResterauntAverageRatings
        public void getResterauntAverageRating()
        {

            var resteraunts = resterauntRepo.GetAllResteraunts();
            var reviewsList = reviewsRepo.GetReviews();

            var results =
                reviewsList.GroupBy(x => x.ResterauntId, x => new { x.ResterauntId, x.Rating })
                          .Join(resteraunts, x => x.Key, y => y.ResterauntId, (x, y) => new {
                              Name = y.Name,
                              AvgRating = x.Average(s => s.Rating)
                          });



            foreach (var res in results)
            {
           
                Console.WriteLine($"{res.Name} has a rating of {res.AvgRating}");
            }
   
            }

        public void GetAverageResterauntReviews(int ResterauntId)
        {
            throw new NotImplementedException();
        }

        public void GetAveragesOfAllResterauntReviews()
        {
            throw new NotImplementedException();
        }
    }
        #endregion
    }






