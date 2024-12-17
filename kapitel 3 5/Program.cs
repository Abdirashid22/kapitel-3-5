using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Ange det första talet: ");
        double tal1 = double.Parse(Console.ReadLine());

        Console.Write("Ange det andra talet: ");
        double tal2 = double.Parse(Console.ReadLine());

        
        Console.WriteLine("\nVälj ett räknesätt:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraktion");
        Console.WriteLine("3. Multiplikation");
        Console.WriteLine("4. Division");

        
        Console.Write("Skriv siffran för ditt val: ");
        int val = int.Parse(Console.ReadLine());

        
        switch (val)
        {
            case 1:
                Console.WriteLine($"Resultatet av addition är: {tal1 + tal2}");
                break;

            case 2:
                Console.WriteLine($"Resultatet av subtraktion är: {tal1 - tal2}");
                break;

            case 3:
                Console.WriteLine($"Resultatet av multiplikation är: {tal1 * tal2}");
                break;

            case 4:
                
                if (tal2 != 0)
                {
                    Console.WriteLine($"Resultatet av division är: {tal1 / tal2}");
                }
                else
                {
                    Console.WriteLine("Division med 0 är inte tillåten.");
                }
                break;

            default:
                Console.WriteLine("Ogiltigt val, vänligen välj mellan 1 och 4.");
                break;
        }
    }
}

