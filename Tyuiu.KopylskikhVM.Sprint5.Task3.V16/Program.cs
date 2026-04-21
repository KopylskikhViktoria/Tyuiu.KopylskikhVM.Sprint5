using System;
using System.IO;
using Tyuiu.KopylskikhVM.Sprint5.Task3.V16.Lib;

namespace Tyuiu.KopylskikhVM.Sprint5.Task3.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = 2;
            double result1 = 4 * Math.Pow(x1, 3) - 3 * Math.Pow(x1, 2) + 2 * x1 - 1;
            Console.WriteLine("1) " + result1);

            double x2 = 10;
            double result2 = 2 * Math.Pow(x2, 2) + x2;
            Console.WriteLine("2) " + result2);

            double x3 = 4;
            double result3 = 10 * Math.Pow(x3, 0.5) - x3;
            Console.WriteLine("3) " + result3);

            double x4 = 2;
            double result4 = 4 * Math.Pow(x4, 4) - Math.Pow(x4, 2);
            Console.WriteLine("4) " + result4);

            double x5 = -4;
            double result5 = 5 * Math.Pow(x5, 2) + 7 * x5 + 9;
            Console.WriteLine("5) " + result5);

            double x6 = 25;
            double result6 = 10 * Math.Pow(x6, 0.5) - x6;
            Console.WriteLine("6) " + result6);

            double x7 = -1;
            double result7 = 4 * Math.Pow(x7, -2) - 3 * x7 - 2;
            Console.WriteLine("7) " + result7);

            double x8 = 36;
            double result8 = 4 * Math.Pow(x8, 0.5) - 3 * x8 - 2;
            Console.WriteLine("8) " + result8);

            double x9 = 3;
            double result9 = 3 * Math.Pow(x9, 3) - x9;
            Console.WriteLine("9) " + result9);

            double x10 = 3;
            double result10 = Math.Pow(x10, 2) - 5;
            Console.WriteLine("10) " + result10);
        }
    }
}