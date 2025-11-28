using Tyuiu.RadchenkoAV.Sprint5.Task4.V28.Lib;

namespace Tyuiu.RadchenkoAV.Sprint5.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTestBase
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutFileTask4.txt");
            File.WriteAllText(path, "2.0");
            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);
            Assert.AreEqual(6.0 / Math.Sin(2.0), result, 0.001);
        }
    }
}