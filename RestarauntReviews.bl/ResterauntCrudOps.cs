using NLog;
using ResterauntReview.dl;
using ResterauntReview.dl.Models;
using ResterauntReview.dl.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestarauntReviews.bl
{
    public static  class ResterauntCrudOps
    {

        private static readonly ApplicationDbContext dataContext = new ApplicationDbContext();






        public static void AddResteraunt(Resteraunt res)
        {
            ResterauntRepository resterauntRepository = new ResterauntRepository();

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString);


            SqlCommand cmd;

            SqlDataAdapter da;

            try
            {
                using (con)
                {

                    string cmdText = $"Insert into Resteraunts(Name, City )values(' {res.Name}', '{res.City}')";
                    con.Open();



                    cmd = new SqlCommand(cmdText , con);
                    cmd.ExecuteNonQuery();




                }

            }
            catch (Exception ex)
            {
   
                Console.WriteLine(ex.Message);

            }
            finally
            {
                con.Close();

            }



        


        }

        public static void AddReview(Review review, int resterauntid)
        {

            Review _review = new Review() {

                EmailOfReviewer = review.EmailOfReviewer,
                Rating = review.Rating,
                ReviewComment = review.ReviewComment,
                ResterauntId = resterauntid


            };



            dataContext.Reviews.Add(_review);
           

        }

    }
}
