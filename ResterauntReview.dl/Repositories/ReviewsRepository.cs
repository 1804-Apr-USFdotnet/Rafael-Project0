using ResterauntReview.dl.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ResterauntReview.dl.Repositories
{
   public class ReviewsRepository
    {
        public  void TableToXml()

        {
            SqlConnection con;

            SqlCommand cmd;

            SqlDataAdapter sda;

            try

            {
                //get connection string
                var ConString = ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString;

                // command
                string CmdString = "select * from [dbo].[Resteraunts]";




                DataTable dt;
                DataSet ds = new DataSet();
                XmlReader reader;
                using (con = new SqlConnection(ConString))
                {
                    con.Open();
                    cmd = new SqlCommand(CmdString, con);
                    SqlDataReader rd = cmd.ExecuteReader();

                    while (rd.HasRows)
                    {

                        while (rd.Read())
                        {
                            Console.WriteLine(rd["Name"]);
                        }

                    }

                    con.Close();



                }
            }


            catch (Exception ex)

            {

                Console.WriteLine(ex.Message);

            }

        }















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
