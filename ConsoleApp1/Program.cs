using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            ClassCalculation cicleCalc = new ClassCalculation();
            Console.WriteLine("Enter cicle radius:");
            ClassCicle circle = new ClassCicle(cicleCalc.GetValuesFromKeyboard);
            Console.WriteLine("Your cicle radius is: " + circle.Radius);
            double radiusTemp = circle.Radius;
            Console.WriteLine("Circle square is " + cicleCalc.CountCicleArea(radiusTemp));

            ClassCalculation squareCalc = new ClassCalculation();
            Console.WriteLine("Enter square side:");
            ClassSquare square = new ClassSquare(squareCalc.GetValuesFromKeyboard);
            Console.WriteLine("Your square side is: " + square.Side);
            double sideTemp = square.Side;
            Console.WriteLine("Square area is " + squareCalc.CountSquareArea(sideTemp));

            //find if a circle fits inside a square
            cicleCalc.FitCircleInSquare(cicleCalc.CountCicleArea(radiusTemp), squareCalc.CountSquareArea(sideTemp));

            //find if a square fits inside a circle
            squareCalc.FitSquareInCircle(squareCalc.CountSquareArea(sideTemp), cicleCalc.CountCicleArea(radiusTemp));

        }
    }
}
