using System;

class Program
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        if(x >= 0)
        {
            Console.WriteLine(x);
        }
        else
        {
            Console.WriteLine(-x);
        }
    }
}