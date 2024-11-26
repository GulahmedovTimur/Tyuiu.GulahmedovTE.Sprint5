using Tyuiu.GulahmedovTE.Sprint5.Task3.V25.Lib;
namespace Tyuiu.GulahmedovTE.Sprint5.Task3.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("* Исходные данные: x = 3                                                  *");
            int x = 3;
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine(ds.SaveToFileTextData(x));
        }
    }
}