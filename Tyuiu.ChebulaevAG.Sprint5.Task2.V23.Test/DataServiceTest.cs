using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.ChebulaevAG.Sprint5.Task2.V23.Lib;

namespace Tyuiu.ChebulaevAG.Sprint5.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\acheb\source\repos\Tyuiu.ChebulaevAG.Sprint5\Tyuiu.ChebulaevAG.Sprint5.Task2.V23\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
