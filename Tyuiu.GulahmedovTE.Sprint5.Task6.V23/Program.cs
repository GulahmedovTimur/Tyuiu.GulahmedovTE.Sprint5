using Tyuiu.GulahmedovTE.Sprint5.Task6.V23.Lib;
namespace Tyuiu.GulahmedovTE.Sprint5.Task6.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask6V23.txt";
            Console.WriteLine("Данные файла находятся в " + path);
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}