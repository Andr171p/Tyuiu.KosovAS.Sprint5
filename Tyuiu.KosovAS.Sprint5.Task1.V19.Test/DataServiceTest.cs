using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Tyuiu.KosovAS.Sprint5.Task1.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\andre\source\repos\Tyuiu.KosovAS.Sprint5\Tyuiu.KosovAS.Sprint5.Task1.V19\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;

            Assert.AreEqual(true, fileExist);
        }
    }
}
