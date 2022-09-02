using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double result = Math.Pow(2, n);
        Console.WriteLine("{0:N0}",result);
    }
}