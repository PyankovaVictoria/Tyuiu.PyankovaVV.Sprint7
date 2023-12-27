using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

namespace Tyuiu.PyankovaVV.Sprint7.Project.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExist()
        {
            string path = @"C:\Users\User\Desktop\University.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
