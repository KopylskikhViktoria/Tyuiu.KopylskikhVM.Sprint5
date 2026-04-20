using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.KopylskikhVM.Sprint5.Task2.V22.Lib;

namespace Tyuiu.KopylskikhVM.Sprint5.Task2.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[3, 3]
            {
                { -8, -1, -9 },
                {  8,  5,  5 },
                {  9,  6, -2 }
            };

            string path = ds.SaveToFileTextData(matrix);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}