using Tyuiu.GulahmedovTE.Sprint5.Task1.V30.Lib;
namespace Tyuiu.GulahmedovTE.Sprint5.Task1.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите начало и конец табуляции функции");
            int start = Convert.ToInt32(Console.ReadLine());
            int end = Convert.ToInt32(Console.ReadLine());

            ds.SaveToFileTextData(start, end);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask1.txt" });
            string text = File.ReadAllText(path);
            Console.WriteLine(text);
        }
    }
}