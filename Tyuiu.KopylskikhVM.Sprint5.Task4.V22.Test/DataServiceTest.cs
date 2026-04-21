namespace Tyuiu.KopylskikhVM.Sprint5.Task4.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V22.txt";
            FileInfo ra = new FileInfo(path);
            bool fileEx = ra.Exists;
            Assert.AreEqual(true, fileEx);
        }
    }
}
