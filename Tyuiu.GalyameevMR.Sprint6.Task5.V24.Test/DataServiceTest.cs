using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint6.Task5.V24.Lib;
using System.IO;

namespace Tyuiu.GalyameevMR.Sprint6.Task5.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService DataService = new DataService();
        [TestMethod]
        public void ExistsFile()
        {
            string path = @"C:\visual studio\Sprint6Task5\InPutFileTask5V24.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
        [TestMethod]
        public void CheckArrayInValid()
        {
            double[] array = { 0, 0 };
            string path = @"C:\visual studio\Sprint6Task5\InPutFileTask5V24.txt";
            double[] wait = DataService.LoadFromDataFile(path);
            CollectionAssert.AreEqual(array, wait);
        }
    }
}
