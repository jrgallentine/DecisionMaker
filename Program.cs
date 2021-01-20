using System;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string name;
                int input = 0;
                string cont;

                Console.Clear();

                Console.Write("Enter your name: ");
                name = Console.ReadLine();

                

                Console.Write($"{name}, enter an integer between 1 and 100: ");

                Int32.TryParse(Console.ReadLine(), out input);

                if (input > 100 || input < 1)
                {
                    Console.WriteLine($"{name}... {input} is not between 1 and 100. ");
                }



                if (input % 2 == 0 && input <= 25 && 1 < input && input < 101)
                {
                    Console.WriteLine($"{name }, that is even and less than 25");
                }

                else if (input % 2 == 0 && input >= 26 && input <= 60 && 1 < input && input < 101)
                {
                    Console.WriteLine($"{name }, that is even");
                }


                else if (input % 2 == 0 && input > 60 && 1 < input && input < 101)
                {
                    Console.WriteLine($"{name }, {input} is even");
                }
                else if (input % 2 != 0 && 1 < input && input < 101)
                {
                    Console.WriteLine($"{name }, {input} is odd");
                }

                Console.WriteLine();
                Console.WriteLine($"Would you like to try again, {name}? (y/n)");
                cont = Console.ReadLine();

                if (cont != "y") break;
            }
        }

    }
}
