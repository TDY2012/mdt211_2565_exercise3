using System;

class Program
{
    static void Main(string[] args)
    {
        int bitPerByte = 8;
        int x = int.Parse(Console.ReadLine());
        int mask = x >> (sizeof(int) * bitPerByte - 1);
        Console.WriteLine((mask + x)^mask);
    }
}