using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovSI.Sprint5.Review.V14.Lib;
using System.IO;
namespace Tyuiu.IvanovSI.Sprint5.Review.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = $@"C:\Users\yarik\source\repos\Tyuiu.IvanovSI.Sprint5.Review\Tyuiu.IvanovSI.Sprint5.Review.V14\bin\Debug\OutPutDataFileTask7V14.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
