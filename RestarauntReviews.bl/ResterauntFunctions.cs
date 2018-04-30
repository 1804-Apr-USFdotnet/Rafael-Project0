using Newtonsoft.Json;
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

            catch(Exception ex)
            {
                Logger logger = LogManager.GetLogger("databaseLogger");

                // add custom message and pass in the exception
                logger.Error(ex, "Error");


            }

            return json;
        }
    

        public List<Resteraunt>  searchByPartialName(string userInput)
        {
            List<Resteraunt> resteraunt = new List<Resteraunt>();
            try
            {
                 resteraunt = resterauntList.Where(x => x.Name.StartsWith(userInput)).ToList();

                foreach (var item in resteraunt)
                {
                    Console.WriteLine(item.Name);
                }

                if (resteraunt.Count < 1)
                {
                    Console.WriteLine("No resteraunts matched your search");

                }
            }

            catch (Exception ex)
            {

                Logger logger = LogManager.GetLogger("databaseLogger");

                // add custom message and pass in the exception
                logger.Error(ex, "Error");
            }
            return resteraunt;
        }

        #region Sorting Resteraunts



    
        public List<Resteraunt>  SortbyCity(string city)
        {
            List<Resteraunt> resteraunts = new List<Resteraunt>();
            try
            {
              


                    resteraunts = resterauntList.Where(x => x.City.StartsWith(city)).ToList();



            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Sorry there are no resteraunts matching your request, please try another");
                SortbyCity(Console.ReadLine());
     

                Logger logger = LogManager.GetLogger("databaseLogger");

                // add custom message and pass in the exception
                logger.Error(ex, "Error");
            


        }

            return resteraunts;


        }
        #endregion
    }






}
