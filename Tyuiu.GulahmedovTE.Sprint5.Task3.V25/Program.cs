using Tyuiu.GulahmedovTE.Sprint5.Task3.V25.Lib;
namespace Tyuiu.GulahmedovTE.Sprint5.Task3.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x = 3;
            var res = ds.SaveToFileTextData(x);
            Console.WriteLine("x = " + x);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Файл " + res);
            Console.WriteLine("Создан");
            Console.ReadKey();
        }
    }
}