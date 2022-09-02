using System;

class Program
{
    static void Main(string[] args)
    {
        float a, b, x;
        a = float.Parse(Console.ReadLine());
        b = float.Parse(Console.ReadLine());
        x = float.Parse(Console.ReadLine());
        Console.WriteLine(a <= x && x <= b);
    }
}