using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Calculation calc = new Calculation();
            Console.WriteLine("Enter circle radius:");
            var circle = new Circle(calc.GetValuesFromKeyboard());
            Console.WriteLine("Your circle radius is: " + circle.Radius);
            Console.WriteLine("Circle square is " + circle.Area);

            Console.WriteLine("Enter square side:");
            Square square = new Square(calc.GetValuesFromKeyboard());
            Console.WriteLine("Your square side is: " + square.Side);
            Console.WriteLine("Square area is " + square.Area);

            //find if a circle fits inside a square
            calc.FitCircleInSquare(circle, square);

            //find if a square fits inside a circle
            calc.FitSquareInCircle(circle, square);

        }
    }
}
