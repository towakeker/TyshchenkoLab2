using System;

namespace Lab_2_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Anton Tyshchenko LAB2";
            double side1, side2;
            while (true)
            {
                Console.Write("Enter the length of the first side: ");
                if (double.TryParse(Console.ReadLine(), out side1) && side1 > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid positive number.");
                }
            }

            while (true)
            {
                Console.Write("Enter the length of the second side: ");
                if (double.TryParse(Console.ReadLine(), out side2) && side2 > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid positive number.");
                }
            }

            Rectangle rect = new Rectangle(side1, side2);

            Console.WriteLine($"Area of the rectangle: {rect.CalculateArea()}");
            Console.WriteLine($"Perimeter of a rectangle: {rect.CalculatePerimeter()}");
        }
    }
}