using System;

class Program
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("{0:N0}", Math.Abs(x));
    }
}