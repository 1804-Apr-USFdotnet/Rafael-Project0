using Newtonsoft.Json;
using NLog;
using ResterauntReview.dl.Models;
using ResterauntReview.dl.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestarauntReviews.bl
{

    public static class SerializeAndDeserialize
    {
        #region Declaration of Variables
        static ResterauntRepository resterauntRepo = new ResterauntRepository();
        static ReviewsRepository reviewsRepo = new ReviewsRepository();
        static ErrorManager errorManager = new ErrorManager();
        #endregion

        public static string ConvertToJson()
        {

            string json = string.Empty;
            try
            {
                var Rest = resterauntRepo.GetAllResteraunts();
                json = JsonConvert.SerializeObject(resterauntRepo.GetAllResteraunts());
            }

            catch (Exception ex)
            {

                Logger logger = LogManager.GetLogger("databaseLogger");

                // add custom message and pass in the exception
                logger.Error(ex, "Error");
            }

            return json;
        }
        public static  List<Resteraunt> ConvertJsonToList(string JsonObject)
        {
            List<Resteraunt> deserializedObj = new List<Resteraunt>();
            try
            {
                deserializedObj = JsonConvert.DeserializeObject<IEnumerable<Resteraunt>>(JsonObject).ToList();

           

            }
            catch (Exception ex)
            {

                Logger logger = LogManager.GetLogger("databaseLogger");

                // add custom message and pass in the exception
                logger.Error(ex, "Error");

            }

            //Console.ReadLine();
            return deserializedObj;

        }




     


    }


}