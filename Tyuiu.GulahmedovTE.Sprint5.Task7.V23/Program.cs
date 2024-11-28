using Tyuiu.GulahmedovTE.Sprint5.Task7.V23.Lib;
namespace Tyuiu.GulahmedovTE.Sprint5.Task7.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = $@"C:\Users\gytim\source\repos\Tyuiu.GulahmedovTE.Sprint5\Tyuiu.GulahmedovTE.Sprint5.Task7.V23\bin\Debug\net8.0\InPutDataFileTask7V23.txt";
            string pathSaveFile = $@"C:\Users\gytim\source\repos\Tyuiu.GulahmedovTE.Sprint5\Tyuiu.GulahmedovTE.Sprint5.Task7.V23\bin\Debug\net8.0\OutPutDataFileTask7V23.txt";

            Console.WriteLine("Данные находяться в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Находится в файле : ");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);
            Console.ReadKey();

        }
    }
}