using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        // 1)
        string content1 = "3fja4lksdfj2lkjl3k6j9";
        string newContent1 = "";
        foreach (char c in content1)
        {
            if (char.IsDigit(c))
            {
                newContent1 += c;
            }
        }
        Console.WriteLine("1) " + String.Join("\n", newContent1));

        // 2)
        string content2 = "s3Ssads6asGa4dsa4hhgh2dfG";
        string newContent2 = "";
        foreach (char c in content2)
        {
            if (char.IsUpper(c))
            {
                newContent2 += c;
            }
        }
        Console.WriteLine("2) " + String.Join("\n", newContent2));

        // 3)
        string content3 = "s1ah2nds4njah34nd";
        int count3 = content3.Count(c => c == 'h');
        Console.WriteLine("3) " + count3);

        // 4)
        string content4 = "SDNsSA2KgDNJ5ShAJN3DNA6SJ";
        string newContent4 = "";
        foreach (char c in content4)
        {
            if (!char.IsUpper(c))
            {
                newContent4 += c;
            }
        }
        Console.WriteLine("4) " + String.Join("\n", newContent4));

        // 5)
        string content5 = "09s87654g32123d45678a";
        string newContent5 = "";
        foreach (char c in content5)
        {
            if (!char.IsDigit(c))
            {
                newContent5 += c;
            }
        }
        Console.WriteLine("5) " + String.Join("\n", newContent5));

        // 6)
        string content6 = "sv1a6dbNJ5S2KDS53nda4nkd5s7S,D";
        int count6 = content6.Count(c => c == '5');
        Console.WriteLine("6) " + count6);

        // 7)
        string content7 = "KsjDsSsadsaFs";
        string newContent7 = "";
        foreach (char c in content7)
        {
            if (char.IsUpper(c))
            {
                newContent7 += c;
            }
        }
        Console.WriteLine("7) " + String.Join("\n", newContent7));

        // 8)
        string content8 = "DSADlJHSADGtASUIyDSrkAN";
        string newContent8 = "";
        foreach (char c in content8)
        {
            if (!char.IsUpper(c))
            {
                newContent8 += c;
            }
        }
        Console.WriteLine("8) " + String.Join("\n", newContent8));

        // 9)
        string content9 = "sdj433sakdjsa234sa3dns5ja";
        string newContent9 = "";
        foreach (char c in content9)
        {
            if (char.IsDigit(c))
            {
                newContent9 += c;
            }
        }
        Console.WriteLine("9) " + String.Join("\n", newContent9));

        // 10)
        string content10 = "r3j4658w31d1";
        string newContent10 = "";
        foreach (char c in content10)
        {
            if (!char.IsDigit(c))
            {
                newContent10 += c;
            }
        }
        Console.WriteLine("10) " + String.Join("\n", newContent10));
    }
}