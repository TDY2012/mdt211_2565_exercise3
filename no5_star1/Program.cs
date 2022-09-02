using System;

class Program
{
    static void Main(string[] args)
    {
        int seatNo = int.Parse(Console.ReadLine());

        if(seatNo + 1 > 8)
        {
            Console.WriteLine(seatNo + 1 - 8);
        }
        else
        {
            Console.WriteLine(seatNo + 1);
        }

        if(seatNo + 2 > 8)
        {
            Console.WriteLine(seatNo + 2 - 8);
        }
        else
        {
            Console.WriteLine(seatNo + 2);
        }

        if(seatNo + 3 > 8)
        {
            Console.WriteLine(seatNo + 3 - 8);
        }
        else
        {
            Console.WriteLine(seatNo + 3);
        }

        if(seatNo + 4 > 8)
        {
            Console.WriteLine(seatNo + 4 - 8);
        }
        else
        {
            Console.WriteLine(seatNo + 4);
        }
    }
}