using Tyuiu.GulahmedovTE.Sprint5.Task1.V30.Lib;
namespace Tyuiu.GulahmedovTE.Sprint5.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\gytim\source\repos\Tyuiu.GulahmedovTE.Sprint5\Tyuiu.GulahmedovTE.Sprint5.Task1.V30\bin\Debug\net8.0\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}