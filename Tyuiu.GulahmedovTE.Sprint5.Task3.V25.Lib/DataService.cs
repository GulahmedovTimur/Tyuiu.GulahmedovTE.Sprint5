using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GulahmedovTE.Sprint5.Task3.V25.Lib
{
    public class DataService : ISprint5Task3V25
    {
        public string SaveToFileTextData(int X)
        {
            string Path = @$"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin";
            double Y = (3 * Math.Pow(X, 4) + 1) / Math.Pow(X, 3);
            Y = Math.Round(Y, 3);
            string Y_ = Convert.ToString(Y);

            using (BinaryWriter A = new BinaryWriter(File.Open(Path, FileMode.OpenOrCreate), Encoding.Unicode))
            {
                A.Write(BitConverter.GetBytes(Y));
            }

            return Path;
        }
    }
}