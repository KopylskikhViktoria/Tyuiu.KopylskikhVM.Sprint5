using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.KopylskikhVM.Sprint5.Task3.V16.Lib;

namespace Tyuiu.KopylskikhVM.Sprint5.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            double x = 3;
            string path = ds.SaveToFileTextData(x);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}