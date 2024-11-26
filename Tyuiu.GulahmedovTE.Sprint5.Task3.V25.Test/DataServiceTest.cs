using Tyuiu.GulahmedovTE.Sprint5.Task3.V25.Lib;
namespace Tyuiu.GulahmedovTE.Sprint5.Task3.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s = @"C:\Users\gytim\source\repos\Tyuiu.GulahmedovTE.Sprint5\Tyuiu.GulahmedovTE.Sprint5.Task3.V25\bin\Debug\net8.0\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(s);
            bool file = fileInfo.Exists;
            Assert.AreEqual(true, file);
        }
    }
}