using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KopylskikhVM.Sprint5.Task0.V8.Lib
{
    public class DataService : ISprint5Task0V8
    {
        public string SaveToFileTextData(int x)
        {
            x = 3;

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            double z = (Math.Pow((double)x, 3) - 1) / (4 * Math.Pow((double)x, 2));

            z = Math.Round(z, 3);

            File.WriteAllText(path, Convert.ToString(z));

            return path;
        }
    }
}