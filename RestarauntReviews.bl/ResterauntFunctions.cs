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
        ResterauntRepository resteraunt = new ResterauntRepository();
        public ResterauntFunctions()
        {

            //addResteraunts();


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

            var Rest = resteraunt.GetAllResteraunts();
            foreach (var item in Rest)
            {
                Console.WriteLine($" Resteraunt Name: {item.Name} ");
            }
        }


        public  string ConvertToJson()
        {

            string json = "";
            try
            {

                var Rest = resteraunt.GetAllResteraunts();

                 json = JsonConvert.SerializeObject(resteraunt.GetAllResteraunts());

            }

            catch
            {


            }

            return json;
        }
    
    }
}
