using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyProj;

namespace UnitTestProject1
{
   
    [TestClass]
    public class UnitTest1
    {
        int[] array = new int[] { 1, 2, 3, 4, 5 };
        [TestMethod]
        public void TestSum()
        {
            MyMath myMath = new MyMath();
            double actual = myMath.Sum( array);
            Assert.AreEqual(15, actual);
        }

        [TestMethod]
        public void TestMax()
        {
            MyMath myMath = new MyMath();
            double actual = myMath.MaxValue(array);
            Assert.AreEqual(5, actual);
        }
        [TestMethod]
        public void TestAryf()
        {
            MyMath myMath = new MyMath();
            double actual = myMath.SerAryf(array);
            Assert.AreEqual(3, actual);
        }
    }


}


