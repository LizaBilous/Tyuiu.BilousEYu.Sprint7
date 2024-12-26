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
            string path = @"C:\Users\Елизавета\source\repos\Tyuiu.BilousEYu.Sprint7\Tyuiu.BilousEYu.Sprint7.Project.V9\test_videos.csv";
            DataService ds = new DataService(path);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.IsTrue(fileExists, "Expected file does not exist at the specified path.");
        }

    }
   
}
