using System;

class Program
{
    static void Main(string[] args)
    {
        int seatNo = int.Parse(Console.ReadLine());

        Console.WriteLine((seatNo % 8) + 1);
        Console.WriteLine(((seatNo + 1) % 8) + 1);
        Console.WriteLine(((seatNo + 2) % 8) + 1);
        Console.WriteLine(((seatNo + 3) % 8) + 1);
    }
}