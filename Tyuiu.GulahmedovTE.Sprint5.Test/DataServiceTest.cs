using Tyuiu.GulahmedovTE.Sprint5.Lib;
namespace Tyuiu.GulahmedovTE.Sprint5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\gytim\source\repos\Tyuiu.GulahmedovTE.Sprint5\Tyuiu.GulahmedovTE.Sprint5\bin\Debug\net8.0\OutPutFileTask0.txt";
            
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}