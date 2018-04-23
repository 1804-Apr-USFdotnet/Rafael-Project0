using NLog;
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

        ResterauntRepository resteraunt = new ResterauntRepository();
        ReviewsRepository reviews = new ReviewsRepository();

        public void GetAverageOfAllResterauntReviews()
        {
           
            throw new NotImplementedException();
        }

        public void GetAverageResterauntReviews(int ResterauntId)
        {
          try
            {
                int zero = 0;
                int result = 5 / zero;
            }
            catch (DivideByZeroException ex) { 
            
                Logger logger = LogManager.GetLogger("databaseLogger");

                // add custom message and pass in the exception
                logger.Error(ex, " ");


            }
        }

        public void GetResterauntReviews(int ResterauntId)
        {
            throw new NotImplementedException();
        }

    
    }
}
