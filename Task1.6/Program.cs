using System;
class Program
{
    static void Main()
    {

        Console.WriteLine("23");
        int number = int.Parse(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine($"Число {number} є парним");
        }
        else
        {
            Console.WriteLine($"Число {number} не є парним");
        }
    }
}