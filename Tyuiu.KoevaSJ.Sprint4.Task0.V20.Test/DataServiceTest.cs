﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KoevaSJ.Sprint4.Task0.V20.Lib;

namespace Tyuiu.KoevaSJ.Sprint4.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultOddArrEl()
        {
            DataService ds = new DataService();

            int[] numsArray = {4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };

            int res = ds.GetMultEvenArrEl(numsArray);

            int wait = 24576;

            Assert.AreEqual(wait, res);
        }
    }
}
