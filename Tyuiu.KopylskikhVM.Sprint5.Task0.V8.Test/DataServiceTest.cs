using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.KopylskikhVM.Sprint5.Task0.V8.Lib;

namespace Tyuiu.KopylskikhVM.Sprint5.Task0.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();

            int x = 3;
            string path = ds.SaveToFileTextData(x);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}