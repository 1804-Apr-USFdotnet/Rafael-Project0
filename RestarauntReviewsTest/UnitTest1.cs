using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestarauntReviews.bl;
using ResterauntReview.dl.Models;

namespace RestarauntReviewsTest
{
    [TestClass]
    public class UnitTest1
    {
        ResterauntFunctions resterauntFunc = new ResterauntFunctions();

        Resteraunt resterauntTest1;
        Resteraunt resterauntTest2;
        List<Resteraunt> actualList;



        [TestMethod]
        public void TestGetAverages()
        {
            resterauntFunc.GetResterauntDetails();





            //CollectionAssert.AreEqual()



        }
    }
}
