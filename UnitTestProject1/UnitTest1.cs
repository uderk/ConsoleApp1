using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //Test the Add Method
        [TestMethod]
        public void TestMethod_Add()
        {
            BasicMath bm1 = new BasicMath();
            double res = bm1.Add(10, 15);
            Assert.AreEqual(res, 25);
        }

        // Test the SubstractMethod
        [TestMethod]
        public void TestMethod_Substract()
        {
            BasicMath bm2 = new BasicMath();
            double res = bm2.Substract(30, 15);
            Assert.AreEqual(res, 15);
        }

        //Test the Divide Method
        [TestMethod]
        public void TestMethod_Divide()
        {
            BasicMath bm = new BasicMath();
            double res = bm.Divide(20, 5);
            Assert.AreEqual(res, 4);
        }

        //Testing the Multilplay method
        [TestMethod]
        public void TestMethod_Multiply()
        {
            BasicMath bm = new BasicMath();
            double res = bm.Multiply(10, 15);
            Assert.AreEqual(res, 150);
        }


    }
}
