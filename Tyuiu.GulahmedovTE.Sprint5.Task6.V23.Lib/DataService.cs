using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GulahmedovTE.Sprint5.Task6.V23.Lib
{
    public class DataService : ISprint5Task6V23
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            char[] chars = File.ReadAllText(path).ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '-')
                {
                    count += 1;
                }
            }
            return count;
        }
    }
}