using Tyuiu.GulahmedovTE.Sprint5.Task4.V17.Lib;
namespace Tyuiu.GulahmedovTE.Sprint5.Task4.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask4V17.txt";

            Console.WriteLine("Данные находится в файле: " + path);
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}