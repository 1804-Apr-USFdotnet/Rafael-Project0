using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestarauntReviews.bl;
using ResterauntReview.dl.Models;

namespace RestarauntReviewsTest
{
    [TestClass]
    public class UnitTest1
    {
        ResterauntFunctions resterauntFunc = new ResterauntFunctions();

        Resteraunt resteraunt1 = new Resteraunt();

        Resteraunt resteraunt2 = new Resteraunt();
        List<Resteraunt> restList;
        List<Resteraunt> TestrestList;





        [TestMethod]
        public void TestGetAverages()
        {


            resteraunt1.Address = " 345 frank Ave";
            resteraunt1.City = "Tampa";
            resteraunt1.Name = "";
            resteraunt1.ResterauntId = 1;
           
            

            resteraunt2.Address = "456 Terry Ave";
            resteraunt2.City = "Miami";
            

            restList = new List<Resteraunt>
            {

                resteraunt1,
                resteraunt2
            };

            restList.TrimExcess();
            TestrestList = new List<Resteraunt>
            {

                resteraunt1,
                resteraunt2
            };

       //         string serializedList = JsonConvert.SerializeObject(TestrestList);
            //string serializedList = string.Empty;
       //   List<Resteraunt> v =  SerializeAndDeserialize.ConvertJsonToList(serializedList);



            CollectionAssert.AreEqual(restList, TestrestList);



        }
    }
}
