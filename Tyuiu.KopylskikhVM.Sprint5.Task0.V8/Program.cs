using Tyuiu.KopylskikhVM.Sprint5.Task0.V8.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнила: Копыльских В. М. | НТм-24-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Обработка файлов                                                  *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #8                                                              *");
        Console.WriteLine("* Выполнила: Копыльских Виктория Максимовна | НТм-24-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дано выражение, вычислить его значение при x = 3,                       *");
        Console.WriteLine("* результат сохранить в текстовый файл OutPutFileTask0.txt                *");
        Console.WriteLine("* и вывести на консоль.                                                   *");
        Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x = 3;

        Console.WriteLine("Переменная x = " + x);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.SaveToFileTextData(x);

        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");

        Console.ReadKey();
    }
}