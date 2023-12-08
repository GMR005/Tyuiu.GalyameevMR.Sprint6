using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint6.Task2.V30.Lib;

namespace Tyuiu.GalyameevMR.Sprint6.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalcValid()
        {
            DataService DataService = new DataService();
            double[] wait = { -15.4, -13.31, -11.36, -8.00, -2.62, 1.83, 4.49, 6.78, 10.58, 17.38, 23.76 };
            double[] array = DataService.GetMassFunction(-5, 5);
            CollectionAssert.AreEqual(wait, array);
        }
    }
}
