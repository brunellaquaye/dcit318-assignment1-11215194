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

            Console.Write("\nChoose by typing A,B orC or D\n");

            string decision = Console.ReadLine();

            switch (decision)
            {
                case "A":
                    GradeCalculator();
                    break;
                case "B":
                    TicketPriceCalculator();
                    break;
                case "C":
                    TriangleTypeIdentifier();
                    break;
                case "D":
                    Console.WriteLine("Exiting.... ");
                    return;
                    // default:
                    //         Console.WriteLine("Invalid decision. Have a go at it again!");

            }

            static void GradeCalculator()
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

            static void TicketPriceCalculator()
            {
                Console.Write("How old are you? \n");
                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    if (age <= 12 || age >= 65)
                    {
                        Console.WriteLine("Price of ticket : GHC&7\n");

                    }
                    else
                    {
                        Console.WriteLine("Price Of Ticket: GHC 10\n");

                    }
                }
                else
                {
                    Console.WriteLine("Your input is invalid. Please enter a number");
                }
            }

            static void TriangleTypeIdentifier()
            {
                Console.WriteLine("Enter the length of the three sides of the triangle : \n");

                if (
                    double.TryParse(Console.ReadLine(), out double length1) &&
                    double.TryParse(Console.ReadLine(), out double length2) &&
                    double.TryParse(Console.ReadLine(), out double length3)
                )
                {
                    if (length1 <= 0 || length2 <= 0 || length3 <= 0)
                    {
                        Console.WriteLine("There is no triangle, the length must be greater than 0");
                        return;
                    }

                    if (length1 + length2 > length3 && length1 + length3 > length2 && length2 + length3 > length1)
                    {
                        if (length1 == length2 && length2 == length3)
                            Console.WriteLine("This is an Equilateral triangle");
                        else if (length1 == length2 || length1 == length3 || length2 == length3)
                            Console.WriteLine("This is an Isosceles triangle");
                        else
                            Console.WriteLine("This is a Scalene triangle");
                    }
                    else
                    {
                        Console.WriteLine("Invalid triangle.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }

        }
    }
}
