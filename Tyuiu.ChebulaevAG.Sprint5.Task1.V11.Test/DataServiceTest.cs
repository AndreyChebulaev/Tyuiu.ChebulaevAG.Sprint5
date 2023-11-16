using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.ChebulaevAG.Sprint5.Task1.V11.Lib;

namespace Tyuiu.ChebulaevAG.Sprint5.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\acheb\source\repos\Tyuiu.ChebulaevAG.Sprint5\Tyuiu.ChebulaevAG.Sprint5.Task1.V11\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
