using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   public class Circle
    {
        private double radius;
        public double Area 
        { 
            get 
            {
                return Math.Round((Math.PI * Math.Pow(radius, 2)), 2);
            }
        }
        public double Radius
        {
            get 
            { 
                return radius; 
            }
             set
            {
                    radius = value;
            }
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
    }
}
