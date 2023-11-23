﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.ChebulaevAG.Sprint5.Task6.V17.Lib;

namespace Tyuiu.ChebulaevAG.Sprint5.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\acheb\source\repos\Tyuiu.ChebulaevAG.Sprint5\Tyuiu.ChebulaevAG.Sprint5.Task6.V17\bin\Debug\InPutDataFileTask6V17.txt";

            var res = ds.LoadFromDataFile(path);
            int wait = 4;

            Assert.AreEqual(wait, res);
        }

        public void CheckExistFile()
        {
            string path = @"C:\Users\acheb\source\repos\Tyuiu.ChebulaevAG.Sprint5\Tyuiu.ChebulaevAG.Sprint5.Task6.V17\bin\Debug\InPutDataFileTask6V17.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
