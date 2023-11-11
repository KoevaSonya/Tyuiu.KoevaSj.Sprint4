using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KoevaSJ.Sprint4.Task5.V26.Lib;

namespace Tyuiu.KoevaSJ.Sprint4.Task5.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { { -4, 2, -3, 1, 0 },
                                          { -2, -2, -4, 2, 2 },
                                          { 1, 1, 2, -4, -3 },
                                          { -2, -3, -4, 2, 0 },
                                          { 1, 2, 2, -4, 2 } };
            int[,] res = ds.Calculate(mas2);
            int[,] wait = new int[5, 5] {  { -4, 1, -3, 1, 0 },
                                          { -2, -2, -4, 1, 1 },
                                          { 1, 1, 1, -4, -3 },
                                          { -2, -3, -4, 1, 0 },
                                          { 1, 1, 1, -4, 1 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
