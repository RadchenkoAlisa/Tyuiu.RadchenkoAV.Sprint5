using System.IO;
using Tyuiu.RadchenkoAV.Sprint5.Task0.V2.Lib;
namespace Tyuiu.RadchenkoAV.Sprint5.Task0.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.GetTempFileName();
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
