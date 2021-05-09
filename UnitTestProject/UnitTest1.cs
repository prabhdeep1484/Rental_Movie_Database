using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Rental_Movie_Database;

namespace UnitTestProject
{
    
    [TestClass]
    public class UnitTest1
    {
        Database Obj_db = new Database(); // Declare object of the Database class.
        [TestMethod]
        public void TestMethod_Positive() // Positive Test Case to check the feeCalculation function.
        {
            int Fee = Obj_db.FeeCalculation(2020, 2021);
            Assert.AreEqual(5, Fee);
        }
        [TestMethod]
        public void TestMethod_Negative() // Negative Test Case to check the feeCalculation function.
        {
            int Fee = Obj_db.FeeCalculation(2012, 2021);
            Assert.AreNotEqual(5, Fee);
        }
    }
}
