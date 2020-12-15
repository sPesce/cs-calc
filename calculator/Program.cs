using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0; double y = 0;

            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("-------------------------\n");

            Console.WriteLine("Type a number, then press Enter");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type another number, then press Enter");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\t+ - Add");
            Console.WriteLine("\t- - Subtract");
            Console.WriteLine("\t* - Multiply");
            Console.WriteLine("\t/ - Divide");
            Console.Write("Your option? ");

            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine($"Result: {x} + {y} = " + (x + y));break;
                case "-":
                    Console.WriteLine($"Result: {x} - {y} = " + (x - y));break;
                case "*":
                    Console.WriteLine($"Result: {x} * {y} = " + (x * y));break;
                case "/":
                    Console.WriteLine($"Result: {x} / {y} = " + (x / y));break;
                default:
                    Console.WriteLine("Bad Input");break;
            }


        }
    }
}
