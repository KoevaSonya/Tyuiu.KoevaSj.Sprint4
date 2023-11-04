using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KoevaSJ.Sprint4.Task2.V11.Lib;

namespace Tyuiu.KoevaSJ.Sprint4.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[] sumArray = { 3, 5, 6 , 8, 4, 5, 7, 8, 3, 4, 5, 6 ,7 , 8, 3 };
            int res = ds.Calculate(sumArray);
            int wait = 44;

            Assert.AreEqual(wait, res);
        }
    }
}
