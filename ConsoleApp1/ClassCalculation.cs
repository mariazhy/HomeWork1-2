using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ClassCalculation
    {
        public double GetValuesFromKeyboard()
        {
            double input = 0;
            for (int i = 0; i < 3; i++)
            {
                Boolean validation = double.TryParse(Console.ReadLine(), out input) && input > 0;
                if (!validation && i < 3)
                {
                    Console.WriteLine("Please try again");
                    continue;
                }

                if (validation)
                {
                    break;
                }
            }
            if (input <= 0)
            {
                Random random = new Random();
                input = random.NextDouble(0.5, 5);
            }
            return Math.Round(input, 2);
        }
        public void FitSquareInCircle(double circleArea, double squareArea)
        {
            if (Math.Sqrt(circleArea / Math.PI) >= Math.Sqrt(squareArea/2))
            {
                Console.WriteLine("Yes. A circle fits in a square");
            }
            else Console.WriteLine("No. A circle doesn't fit in a square");
        }
        public void FitCircleInSquare(double circleArea, double squareArea)
        {
            if ((2 * Math.Sqrt(circleArea / Math.PI)) <= Math.Sqrt(squareArea))
            {
                Console.WriteLine("Yes. A square fits in a circle");
            }
            else Console.WriteLine("No. A square doesn't fit in a circle");
        }
    }
}
