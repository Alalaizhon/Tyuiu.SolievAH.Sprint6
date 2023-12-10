using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SolievAH.Sprint6.Task5.V23.Lib;

namespace Tyuiu.SolievAH.Sprint6.Task5.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\katag\source\repos\Tyuiu.SolievAH.Sprint6\Tyuiu.SolievAH.Sprint6.Task5.V23\bin\Debug\InPutFileTask5V23.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
