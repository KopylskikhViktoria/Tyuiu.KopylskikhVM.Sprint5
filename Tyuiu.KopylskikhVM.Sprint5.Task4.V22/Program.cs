using System;

internal class Program
{
    static void Main(string[] args)
    {
        // 1)
        string content1 = "2gUU63sf82s1Ul7";
        content1 = content1.Replace('U', '*');
        Console.WriteLine("1) " + String.Join("\n", content1));

        // 2)
        string content2 = "H65jSV5Dk8s";
        content2 = content2.Replace('5', '8');
        Console.WriteLine("2) " + String.Join("\n", content2));

        // 3)
        string content3 = "KbhYvhFp";
        content3 = content3.Replace('h', '#');
        Console.WriteLine("3) " + String.Join("\n", content3));

        // 4)
        string content4 = "J8sdsaj8an8SA";
        content4 = content4.Replace('8', 'a');
        Console.WriteLine("4) " + String.Join("\n", content4));

        // 5)
        string content5 = "HSdsmandsHsk";
        content5 = content5.Replace('H', 'h');
        Console.WriteLine("5) " + String.Join("\n", content5));

        // 6)
        string content6 = "sayhdkysanjhy";
        content6 = content6.Replace('y', '0');
        Console.WriteLine("6) " + String.Join("\n", content6));

        // 7)
        string content7 = "326198432994";
        content7 = content7.Replace('9', 'K');
        Console.WriteLine("7) " + String.Join("\n", content7));

        // 8)
        string content8 = "S&N*DK*s2d7";
        content8 = content8.Replace('*', '#');
        Console.WriteLine("8) " + String.Join("\n", content8));

        // 9)
        string content9 = "K*nHd**lS7l";
        content9 = content9.Replace('*', '#');
        Console.WriteLine("9) " + String.Join("\n", content9));

        // 10)
        string content10 = "dkGsHHSadGnsHa";
        content10 = content10.Replace('H', 'h');
        Console.WriteLine("10) " + String.Join("\n", content10));
    }
}