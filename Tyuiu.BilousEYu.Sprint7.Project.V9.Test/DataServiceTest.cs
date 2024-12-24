using System.IO;
using Tyuiu.BilousEYu.Sprint7.Project.V9.Lib;
namespace Tyuiu.BilousEYu.Sprint7.Project.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\Елизавета\source\repos\Tyuiu.BilousEYu.Sprint7\Tyuiu.BilousEYu.Sprint7.Project.V9";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
   
    }
}