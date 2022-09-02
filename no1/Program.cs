using System;

class Program
{
    static void Main(string[] args)
    {
        int sum;
        Console.Write("Please input number 1: ");
        sum = int.Parse(Console.ReadLine());
        Console.Write("Please input number 2: ");
        sum += int.Parse(Console.ReadLine());
        Console.Write("Please input number 3: ");
        sum += int.Parse(Console.ReadLine());
        Console.WriteLine("Sum: {0}", sum);
    }
}