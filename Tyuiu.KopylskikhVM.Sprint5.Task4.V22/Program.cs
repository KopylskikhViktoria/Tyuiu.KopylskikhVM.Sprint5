using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        // 1)
        string text1 = "24, 2, 18, 4, -9, 4, 10, 18, 19, 16, 11, -3, -3, 15, 3, 18, -5, -4, 25, 19";
        string[] strings1 = text1.Split(',');
        List<string> oddNumbers1 = new List<string>();

        foreach (string str in strings1)
        {
            if (int.TryParse(str.Trim(), out int number) && number % 5 == 0)
            {
                oddNumbers1.Add(str.Trim());
            }
        }

        Console.WriteLine("1)");
        Console.WriteLine(String.Join("\n", oddNumbers1));
        Console.WriteLine();


        // 2)
        string text2 = "2, 18, 4, -9, 4, 10, 18, 19, 16";
        string[] strings2 = text2.Split(',');
        List<string> oddNumbers2 = new List<string>();

        foreach (string str in strings2)
        {
            if (int.TryParse(str.Trim(), out int number) && number % 2 != 0)
            {
                oddNumbers2.Add(str.Trim());
            }
        }

        Console.WriteLine("2)");
        Console.WriteLine(String.Join("\n", oddNumbers2));
        Console.WriteLine();


        // 3)
        string text3 = "-17, 2, 18, 4, -9, 7, 10, 18, 19, 8, 11, -3, 12, 15, 3, 18, -5, -4, 1, 19";
        string[] strings3 = text3.Split(',');
        List<string> oddNumbers3 = new List<string>();

        foreach (string str in strings3)
        {
            if (int.TryParse(str.Trim(), out int number) && number % 4 == 0)
            {
                oddNumbers3.Add(str.Trim());
            }
        }

        Console.WriteLine("3)");
        Console.WriteLine(String.Join("\n", oddNumbers3));
        Console.WriteLine();


        // 4)
        string text4 = "24, 2, 18, 4, -9, 4, 10, 18, 19, 16";
        string[] strings4 = text4.Split(',');
        List<string> oddNumbers4 = new List<string>();

        foreach (string str in strings4)
        {
            if (int.TryParse(str.Trim(), out int number) && number % 3 == 0)
            {
                oddNumbers4.Add(str.Trim());
            }
        }

        Console.WriteLine("4)");
        Console.WriteLine(String.Join("\n", oddNumbers4));
        Console.WriteLine();


        // 5)
        string text5 = "-10, 25, 17, -1, -5, 1, 5";
        string[] strings5 = text5.Split(',');
        List<string> oddNumbers5 = new List<string>();

        foreach (string str in strings5)
        {
            if (int.TryParse(str.Trim(), out int number) && number % 2 != 0)
            {
                oddNumbers5.Add(str.Trim());
            }
        }

        Console.WriteLine("5)");
        Console.WriteLine(String.Join("\n", oddNumbers5));
        Console.WriteLine();


        // 6)
        string text6 = "-17, 2, 18, 4, -9, 7, 10, 18, 19, 8, 11, -3, 12, 15, 3, 18, -5, -4, 1, 19";
        string[] strings6 = text6.Split(',');
        List<string> oddNumbers6 = new List<string>();

        foreach (string str in strings6)
        {
            if (int.TryParse(str.Trim(), out int number) && number % 6 == 0)
            {
                oddNumbers6.Add(str.Trim());
            }
        }

        Console.WriteLine("6)");
        Console.WriteLine(String.Join("\n", oddNumbers6));
        Console.WriteLine();


        // 7)
        string text7 = "-1, -5, -7, 24, 8, 21, 4, 1, 5";
        string[] strings7 = text7.Split(',');
        List<string> oddNumbers7 = new List<string>();

        foreach (string str in strings7)
        {
            if (int.TryParse(str.Trim(), out int number) && number % 2 == 0)
            {
                oddNumbers7.Add(str.Trim());
            }
        }

        Console.WriteLine("7)");
        Console.WriteLine(String.Join("\n", oddNumbers7));
        Console.WriteLine();


        // 8)
        string text8 = "14, 0, 23, 0, -10, 25, 17, 17, 15, 6, 24, -1, -5, -7, 24, 8, 21, 4, 1, 5";
        string[] strings8 = text8.Split(',');
        List<string> oddNumbers8 = new List<string>();

        foreach (string str in strings8)
        {
            if (int.TryParse(str.Trim(), out int number) && number % 3 == 0)
            {
                oddNumbers8.Add(str.Trim());
            }
        }

        Console.WriteLine("8)");
        Console.WriteLine(String.Join("\n", oddNumbers8));
        Console.WriteLine();


        // 9)
        string text9 = "16, -10, -6, -3, 15, 7, 8, -5, -4, 16, -19";
        string[] strings9 = text9.Split(',');
        List<string> oddNumbers9 = new List<string>();

        foreach (string str in strings9)
        {
            if (int.TryParse(str.Trim(), out int number) && number % 2 == 0)
            {
                oddNumbers9.Add(str.Trim());
            }
        }

        Console.WriteLine("9)");
        Console.WriteLine(String.Join("\n", oddNumbers9));
        Console.WriteLine();


        // 10)
        string text10 = "14, 23, -10, 25, 17, 17, 15, 6, 24, -1, -5, -7, 24, 8, 21, 4, 1, 5";
        string[] strings10 = text10.Split(',');
        List<string> oddNumbers10 = new List<string>();

        foreach (string str in strings10)
        {
            if (int.TryParse(str.Trim(), out int number) && number % 5 == 0)
            {
                oddNumbers10.Add(str.Trim());
            }
        }

        Console.WriteLine("10)");
        Console.WriteLine(String.Join("\n", oddNumbers10));
        Console.WriteLine();
    }
}