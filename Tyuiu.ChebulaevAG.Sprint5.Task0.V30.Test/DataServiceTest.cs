using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.ChebulaevAG.Sprint5.Task0.V30.Lib;

namespace Tyuiu.ChebulaevAG.Sprint5.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\acheb\source\repos\Tyuiu.ChebulaevAG.Sprint5\Tyuiu.ChebulaevAG.Sprint5.Task0.V30\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
