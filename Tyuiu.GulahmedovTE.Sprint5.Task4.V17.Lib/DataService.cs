using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GulahmedovTE.Sprint5.Task4.V17.Lib
{
    public class DataService : ISprint5Task4V17
    {
        public double LoadFromDataFile(string path)
        {
            // Чтение данных из файла
            string strX = File.ReadAllText(path);

            // Заменяем точку на запятую, если это необходимо
            strX = strX.Replace('.', ',');

            // Пытаемся конвертировать строку в double, используя CultureInfo.InvariantCulture
            double x = double.Parse(strX, CultureInfo.InvariantCulture);
            double res = (Math.Sin(2 / (3 * x)) + Math.Pow(x, 2));
            return Math.Round(res, 3);
        }
    }
}