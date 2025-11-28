using System.IO;
using Tyuiu.RadchenkoAV.Sprint5.Task7.V22.Lib;
namespace Tyuiu.RadchenkoAV.Sprint5.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V22.txt");
            FileInfo inf = new FileInfo(path);
            bool ex = inf.Exists;
            bool wait = true;
            Assert.AreEqual(wait, ex);
        }
    }
}
