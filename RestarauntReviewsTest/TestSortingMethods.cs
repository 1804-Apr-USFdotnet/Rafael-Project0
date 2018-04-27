using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestarauntReviews.bl;
using ResterauntReview.dl.Models;

namespace RestarauntReviewsTest
{
    [TestClass]
    public class TestSortingMethods
    {
        ResterauntFunctions resterauntFunctions = new ResterauntFunctions();
        Resteraunt resteraunt = new Resteraunt();
        Resteraunt resteraunt1 = new Resteraunt();
        List<Resteraunt> TestRestList;
        List<Resteraunt> ExpectedResult;



        [TestMethod]
        public void TestSortByCity()
        {

            resteraunt.City = "Tampa";
            resteraunt1.City = "Miami";
            TestRestList = new List<Resteraunt>{

                resteraunt,
                resteraunt1
            };
            ExpectedResult = new List<Resteraunt>
            {

                resteraunt1
            };




            TestRestList = resterauntFunctions.SortbyCity("Mi");
            foreach (var item in TestRestList)
            {
                Assert.AreEqual(item.City, "Miami");

            }
          
        }
    }
}
