using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint6.Task1.V7.Lib;

namespace Tyuiu.GalyameevMR.Sprint6.Task1.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalcValid()
        {
            DataService DataService = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] wait = new double[len];
            wait[0] = 7.76;
            wait[1] = 7.36;
            wait[2] = 7.26;
            wait[3] = 7.9;
            wait[4] = 15.88;
            wait[5] = 2;
            wait[6] = 4.35;
            wait[7] = 5.63;
            wait[8] = 6.49;
            wait[9] = 6.49;
            wait[10] = 6.32;
            double[] res = DataService.GetMassFunction(-5, 5);
            CollectionAssert.AreEqual(res, wait);

        }
    }
}
