using Tyuiu.GulahmedovTE.Sprint5.Task0.V26.Lib;
namespace Tyuiu.GulahmedovTE.Sprint5.Task0.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();

            int x = 2;

            Console.WriteLine($"x = {2}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x);
            Console.WriteLine($"Файл: {res}");
            Console.WriteLine("Создан");
            Console.ReadKey();
        }
    }
}