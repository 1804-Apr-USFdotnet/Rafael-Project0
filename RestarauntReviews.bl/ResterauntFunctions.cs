using Newtonsoft.Json;
using ResterauntReview.dl.Models;
using ResterauntReview.dl.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RestarauntReviews.bl
{
    public  class ResterauntFunctions : IResterauntFunctions
    {
        #region Declaration of Variables
        ResterauntRepository resterauntRepo = new ResterauntRepository();
        ReviewsRepository reviewsRepo = new ReviewsRepository();
        ErrorManager errorManager = new ErrorManager();
        List<Resteraunt> resterauntList;
        List<Review> reviewList;

        #endregion
        public ResterauntFunctions()
        {
         
                resterauntList = resterauntRepo.GetAllResteraunts().ToList();

                reviewList = reviewsRepo.GetReviews().ToList();
           

        }

        //public  void addResteraunts()
        //{
        //    resterauntList.Add(resteraunt1);

        //    resterauntList.Add(resteraunt2);
        //    resterauntList.Add(resteraunt3);
        //    resterauntList.Add(resteraunt4);
        //    resterauntList.Add(resteraunt5);
        //    resterauntList.Add(resteraunt5);
        //    resterauntList.Add(resteraunt6);
        //    resterauntList.Add(resteraunt7);

        //}


        public void GetResterauntDetails()
        {

            

            //var Rest = resteraunt.GetAllResteraunts();
            //foreach (var item in Rest)
            //{
            //    Console.WriteLine($" Resteraunt Name: {item.Name} ");
            //}
        }


        public  string ConvertToJson()
        {

            string json = "";
            try
            {

                var Rest = resterauntRepo.GetAllResteraunts();

                 json = JsonConvert.SerializeObject(resterauntRepo.GetAllResteraunts());

            }

            catch
            {


            }

            return json;
        }
    

        public void searchByPartialName(string userInput)
        {
          var resteraunt =   resterauntList.Where(x => x.Name.StartsWith(userInput));

            foreach (var item in resteraunt)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}
