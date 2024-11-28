using tyuiu.cources.programming.interfaces.Sprint5;
{
    public class DataService : ISprint5Task1V30
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            string strY;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(Math.Cos(x) + (Math.Sin(x) / (2 - 2 * x)) - 4 * x);

                strY = Convert.ToString(y);
                if ((2 - 2 * x) == 0)
                {
                    strY = "0";
                }


                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;
        }
    }
}