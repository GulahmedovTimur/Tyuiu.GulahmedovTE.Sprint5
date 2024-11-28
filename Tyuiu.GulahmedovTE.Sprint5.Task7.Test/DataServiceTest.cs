using Tyuiu.GulahmedovTE.Sprint5.Task7.V23.Lib;
namespace Tyuiu.GulahmedovTE.Sprint5.Task7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path1 = $@"C:\Users\gytim\source\repos\Tyuiu.GulahmedovTE.Sprint5\Tyuiu.GulahmedovTE.Sprint5.Task7.V23\bin\Debug\net8.0\InPutDataFileTask7V23.txt";
            string path = ds.LoadDataAndSave(path1);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}