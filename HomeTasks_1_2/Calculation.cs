using System;

namespace ConsoleApp1
{
    class Calculation
    {
        public double GetValuesFromKeyboard()
        {
            for (int i = 0; i < 3; i++)
            {
                bool isValidated = double.TryParse(Console.ReadLine(), out double input) && input > 0;

                if (isValidated)
                {
                    return Math.Round(input, 2);
                }
                else
                {
                    Console.WriteLine($"Please try again{input}");
                }
            }            
         
            Random random = new Random();
            return Math.Round(random.NextDouble() * (5 - 0.5) + 0.5);
        }

        public void FitSquareInCircle(Circle circle, Square square)
        {
            if (2* circle.Radius >= square.Side*Math.Sqrt(2))
            {
                Console.WriteLine("Yes. A square fits in a circle");
            }
            else Console.WriteLine("No. A square doesn't fit in a circle");
        }

        public void FitCircleInSquare(Circle circle, Square square)
        {
            if ((2 * circle.Radius) <= square.Side)
            {
                Console.WriteLine("Yes.  A circle fits in a square");
            }
            else
            { 
                Console.WriteLine("No. A circle doesn't fit in a square"); 
            }
        }
    }
}
