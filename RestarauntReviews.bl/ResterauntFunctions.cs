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

            addResteraunts();


        }


        List<Resteraunt> resterauntList = new List<Resteraunt>();


        Resteraunt resteraunt1 = new Resteraunt() { };
        Resteraunt resteraunt2 = new Resteraunt() { };
        Resteraunt resteraunt3 = new Resteraunt() { Name = "Harry's Burgers" };
        Resteraunt resteraunt4 = new Resteraunt() { Name = "Harry's Burgers" };
        Resteraunt resteraunt5 = new Resteraunt() { Name = "Harry's Burgers" };
        Resteraunt resteraunt6 = new Resteraunt() { Name = "Harry's Burgers" };
        Resteraunt resteraunt7 = new Resteraunt() { Name = "Harry's Burgers" };
        Resteraunt resteraunt8 = new Resteraunt() { Name = "Harry's Burgers" };
        Resteraunt resteraunt9 = new Resteraunt() { Name = "Harry's Burgers" };
        Resteraunt resteraunt10 = new Resteraunt() { Name = "Harry's Burgers" };
        Resteraunt resteraunt11 = new Resteraunt() { Name = "Harry's Burgers" };
        Resteraunt resteraunt12 = new Resteraunt() { Name = "Harry's Burgers" };
        Resteraunt resteraunt13 = new Resteraunt() { Name = "Harry's Burgers" };

        public  void addResteraunts()
        {
            resterauntList.Add(resteraunt1);

            resterauntList.Add(resteraunt2);
            resterauntList.Add(resteraunt3);
            resterauntList.Add(resteraunt4);
            resterauntList.Add(resteraunt5);
            resterauntList.Add(resteraunt5);
            resterauntList.Add(resteraunt6);
            resterauntList.Add(resteraunt7);

        }


     

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
