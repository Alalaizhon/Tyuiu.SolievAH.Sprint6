using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.SolievAH.Sprint6.Task6.V14.Lib;

namespace Tyuiu.SolievAH.Sprint6.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\katag\source\repos\Tyuiu.SolievAH.Sprint6\Tyuiu.SolievAH.Sprint6.Task6.V14\bin\Debug\InPutFileTask6V14.txt";
            FileInfo file = new FileInfo(path);
            bool exists = file.Exists;
            Assert.AreEqual(true, exists);
        }
       
    }
}
