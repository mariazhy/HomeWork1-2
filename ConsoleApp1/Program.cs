using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            ClassCalculation calc = new ClassCalculation();
            Console.WriteLine("Enter circle radius:");
            ClassCircle circle = new ClassCircle(calc.GetValuesFromKeyboard());
            Console.WriteLine("Your circle radius is: " + circle.Radius);
            Console.WriteLine("Circle square is " + circle.Area);

            Console.WriteLine("Enter square side:");
            ClassSquare square = new ClassSquare(calc.GetValuesFromKeyboard());
            Console.WriteLine("Your square side is: " + square.Side);
            Console.WriteLine("Square area is " + square.Area);

            //find if a circle fits inside a square
            calc.FitCircleInSquare(circle.Area, square.Area);

            //find if a square fits inside a circle
            calc.FitSquareInCircle(circle.Area, square.Area);

        }
    }
}
