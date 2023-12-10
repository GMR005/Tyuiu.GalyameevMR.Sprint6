using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint6.Task6.V28.Lib;
using System.IO;
namespace Tyuiu.GalyameevMR.Sprint6.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService DataService = new DataService();

        [TestMethod]
        public void ExistsFile()
        {
            string path = @"C:\visual studio\Sprint6Task6\InPutFileTask6V28.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
         [TestMethod]
        public void CheckArray()
        {
            string path = @"C:\visual studio\Sprint6Task6\InPutFileTask6V28.txt";
            string res = "wFrlYaZtHI l eAezSXF eqSGAiC wUdVEuNB ";
            string str = DataService.CollectTextFromFile(res, path);
            Assert.AreEqual(str, res);
        }
    }
}
