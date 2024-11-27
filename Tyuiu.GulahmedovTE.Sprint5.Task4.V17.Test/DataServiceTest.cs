using Tyuiu.GulahmedovTE.Sprint5.Task4.V17.Lib;
namespace Tyuiu.GulahmedovTE.Sprint5.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\gytim\source\repos\Tyuiu.GulahmedovTE.Sprint5\Tyuiu.GulahmedovTE.Sprint5.Task4.V17\bin\Debug\net8.0\InPutDataFileTask4V17.txt";
            
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}