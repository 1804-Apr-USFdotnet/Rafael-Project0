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
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

            return json;
        }
        public static  List<Resteraunt> ConvertJsonToList(string JsonObject)
        {
            List<Resteraunt> deserializedObj = new List<Resteraunt>();
            try
            {
                deserializedObj = JsonConvert.DeserializeObject<IEnumerable<Resteraunt>>(JsonObject).ToList();

                //foreach (var item in deserializedObj)
                //{
                //    Console.WriteLine(item);
                //}

            }
            catch (Exception)
            {


            }

            //Console.ReadLine();
            return deserializedObj;

        }

    }
}