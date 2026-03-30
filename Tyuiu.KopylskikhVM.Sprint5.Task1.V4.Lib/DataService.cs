using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KopylskikhVM.Sprint5.Task1.V4.Lib
{
    public class DataService : ISprint5Task1V4
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            File.WriteAllText(path, string.Empty);

            for (int x = startValue; x <= stopValue; x++)
            {
                double result;

                if (x + 1 == 0)
                {
                    result = 0;
                }
                else
                {
                    result = Math.Cos(x) / (x + 1) - Math.Cos(x) * 1.3 + 3 * x;

                    if (double.IsInfinity(result) || double.IsNaN(result))
                    {
                        result = 0;
                    }
                }

                result = Math.Round(result, 2);

                File.AppendAllText(path, result + Environment.NewLine);
            }

            return path;
        }
    }
}