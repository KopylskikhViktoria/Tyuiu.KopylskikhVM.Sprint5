using Tyuiu.KopylskikhVM.Sprint5.Task2.V22.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнила: Копыльских В. М. | НТм-24-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #22                                                             *");
        Console.WriteLine("* Выполнила: Копыльских Виктория Максимовна | НТм-24-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3, заполненный с клавиатуры.    *");
        Console.WriteLine("* Заменить положительные элементы на 1, отрицательные на 0.               *");
        Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.    *");
        Console.WriteLine("***************************************************************************");

        int[,] matrix = new int[3, 3]
        {
            { -8, -1, -9 },
            {  8,  5,  5 },
            {  9,  6, -2 }
        };

        Console.WriteLine("Исходный массив:");
        Console.WriteLine();

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j],4}");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int[,] resultMatrix = new int[3, 3];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > 0)
                {
                    resultMatrix[i, j] = 1;
                }
                else if (matrix[i, j] < 0)
                {
                    resultMatrix[i, j] = 0;
                }
                else
                {
                    resultMatrix[i, j] = 0;
                }

                Console.Write($"{resultMatrix[i, j],4}");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        string path = ds.SaveToFileTextData(matrix);
        Console.WriteLine("Файл: " + path);
        Console.WriteLine("Создан!");

        Console.ReadKey();
    }
}