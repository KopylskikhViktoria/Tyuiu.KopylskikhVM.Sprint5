using Tyuiu.KopylskikhVM.Sprint5.Task1.V4.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнила: Копыльских В. М. | НТм-24-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнила: Копыльских Виктория Максимовна | НТм-24-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* F(x) = cos(x)/(x+1) - cos(x)*1,3 + 3x                                   *");
        Console.WriteLine("* Диапазон [-5;5], шаг 1                                                  *");
        Console.WriteLine("* При делении на 0 вернуть 0                                              *");
        Console.WriteLine("***************************************************************************");




        int[,] array = { { -5, 7, -4 }, { 10, -12, -4 }, { 14, 8, 3 } };
        int rowSum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSum += array[1, j];
        }

        Console.WriteLine(rowSum);
        File.WriteAllText("OutPutFileTask2.csv", rowSum.ToString());




        //int startValue = -5;
        //int stopValue = 5;

        //Console.WriteLine("Старт = " + startValue);
        //Console.WriteLine("Конец = " + stopValue);

        //Console.WriteLine("***************************************************************************");
        //Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        //Console.WriteLine("***************************************************************************");

        //Console.WriteLine("+-------+----------+");
        //Console.WriteLine("|   x   |   F(x)   |");
        //Console.WriteLine("+-------+----------+");

        //for (int x = startValue; x <= stopValue; x++)
        //{
        //    double result;

        //    if (x + 1 == 0)
        //    {
        //        result = 0;
        //    }
        //    else
        //    {
        //        result = Math.Cos(x) / (x + 1) - Math.Cos(x) * 1.3 + 3 * x;

        //        if (double.IsInfinity(result) || double.IsNaN(result))
        //        {
        //            result = 0;
        //        }
        //    }

        //    result = Math.Round(result, 2);

        //    Console.WriteLine("| {0,5} | {1,8} |", x, result);
        //}

        //Console.WriteLine("+-------+----------+");

        //string res = ds.SaveToFileTextData(startValue, stopValue);

        //Console.WriteLine("Файл: " + res);
        //Console.WriteLine("Создан!");

        //Console.ReadKey();
    }
}