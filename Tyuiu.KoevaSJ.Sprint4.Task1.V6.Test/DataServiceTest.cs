using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KoevaSJ.Sprint4.Task1.V6.Lib;

namespace Tyuiu.KoevaSJ.Sprint4.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[] sumArray = { 2, 4, 4, 7, 2, 5, 4, 3, 3, 4 };
            int res = ds.Calculate(sumArray); 
            int wait = 20;

            Assert.AreEqual(wait, res);
        }
    }
}
