using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint6.Task0.V22.Lib;


namespace Tyuiu.GalyameevMR.Sprint6.Task0.V22.Test
{
    [TestClass] 
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService DataService = new DataService();
            int x = 2;
            double wait = 11.68;
            double y = DataService.Calculate(x);
            Assert.AreEqual(wait, y);
        }
    }
}
