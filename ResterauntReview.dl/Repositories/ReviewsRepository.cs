using ResterauntReview.dl.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResterauntReview.dl.Repositories
{
   public class ReviewsRepository
    {

        ApplicationDbContext DataContext = new ApplicationDbContext();


        public ReviewsRepository()
        {

            
        }
        public ReviewsRepository(ApplicationDbContext DataContext)
        {

            this.DataContext = DataContext;
        }

        public List<Review> GetReviews()
        {

            return DataContext.Reviews.ToList();

          

        }


















    }
}
