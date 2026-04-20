using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KopylskikhVM.Sprint5.Task2.V22.Lib
{
    public class DataService : ISprint5Task2V22
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    string[] values = new string[cols];

                    for (int j = 0; j < cols; j++)
                    {
                        if (matrix[i, j] > 0)
                        {
                            values[j] = "1";
                        }
                        else if (matrix[i, j] < 0)
                        {
                            values[j] = "0";
                        }
                        else
                        {
                            values[j] = "0";
                        }
                    }

                    writer.WriteLine(string.Join(";", values));
                }
            }

            return path;
        }
    }
}