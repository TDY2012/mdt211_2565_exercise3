using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int result = 1;

        while(n > 0)
        {
            result *= 2;
            n--;
        }

        Console.WriteLine(result);
    }
}