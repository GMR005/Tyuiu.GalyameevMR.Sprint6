using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint6.Task3.V18.LIb;

namespace Tyuiu.GalyameevMR.Sprint6.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckArray()
        {
            DataService DataService = new DataService();
            int[,] wait = { { -19, -19, 1, 18, 7 }, { 5, 3, -4, -6, -12 }, { -15, 6, 2, 2, -14 }, { -9, -10, 15, -5, -6 }, { -13, -15, -9, 7, 1 } };
            int[,] mtrx = { { -19, -19, 1, 18, 7 }, { 5, 3, -4, -6, -12 }, { -15, 6, 2, 2, -14 }, { -9, 0, 15, -5, 0 }, { -13, -15, -9, 7, 1 } };
            int [,] array = DataService.Calculate(mtrx);
            CollectionAssert.AreEqual(mtrx, array);

        }
    }
}
