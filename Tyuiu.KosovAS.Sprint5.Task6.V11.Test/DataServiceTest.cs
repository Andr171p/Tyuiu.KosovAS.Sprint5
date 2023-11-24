using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Web;
using Tyuiu.KosovAS.Sprint5.Task6.V11.Lib;

namespace Tyuiu.KosovAS.Sprint5.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\andre\source\repos\Tyuiu.KosovAS.Sprint5\DataSprint5\Sprint5Task6\InPutDataFileTask6V11.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\andre\source\repos\Tyuiu.KosovAS.Sprint5\DataSprint5\Sprint5Task6\InPutDataFileTask6V11.txt";

            var result = ds.LoadFromDataFile(path);

            Assert.AreEqual(3, result);
        }
    }
}
