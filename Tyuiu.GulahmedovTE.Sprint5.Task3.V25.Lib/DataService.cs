using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GulahmedovTE.Sprint5.Task3.V25.Lib
{
    public class DataService : ISprint5Task3V25
    {
        public string SaveToFileTextData(int x)
        {
            
            double res = (3 * Math.Pow(x, 4) + 1) / Math.Pow(x, 3);
            res = Math.Round(res, 3);

            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask3.bin" });

            FileInfo f = new FileInfo(path);
            if (f.Exists)
            {
                File.Delete(path);
            }

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(res));
            }
            return path;
        }
    }
}