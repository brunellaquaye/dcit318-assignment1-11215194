// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose which calculator to use");
            Console.WriteLine("A. Grade Calculator");
            Console.WriteLine("B. Ticket Price Calculator"); Console.WriteLine("C. Triangle Type Identifier");

            Console.WriteLine("D. End");

            Console.Write("\nChoose by typing A,B orC\n");

            string decision = Console.ReadLine();

            switch (decision)
            {
                case "A":
                    GradeCalculator();
                    break;
                // case "B":
                //     TicketPriceCalculator();
                //     break;
                // case "C":
                //     TriangleTypeIdentifier();
                //     break;
                // case "D":
                    Console.WriteLine("Current Program is ");
                    return;
                // default:
                //     Console.WriteLine("Invalid decision. Have a go at it again!");

            }

            void GradeCalculator()
            {
                Console.Write("\nWhat are your grades? (0-100)\n");
                if (int.TryParse(Console.ReadLine(), out int grade))
                {
                    if (grade < 0 || grade > 100)
                    {
                        Console.WriteLine("Your grade should be from 1 to 100");
                        return;
                    }

                    string letterGrade = grade switch
                    {
                        >= 90 => "A",
                        >= 80 => "B",
                        >= 70 => "C",
                        >= 60 => "D",
                        _ => "F",

                    };

                    Console.WriteLine($" \nYour Converted grade is {letterGrade}\n");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a grade in the range");
                }
            }

        }
    }
}
