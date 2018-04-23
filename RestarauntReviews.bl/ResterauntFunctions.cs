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
        public void GetResterauntDetails()
        {
            ResterauntRepository resteraunt = new ResterauntRepository();
            var Rest = resteraunt.GetAllResteraunts();
            foreach (var item in Rest)
            {
                Console.WriteLine($" Resteraunt Name: {item.Name}");
            }
        }

    
    }
}
