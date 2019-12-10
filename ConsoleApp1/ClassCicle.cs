using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   public class ClassCicle
    {
        private double radius;
        public double Area 
        { 
            get 
            {
                return Area;
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
        public ClassCicle(double radius)
        {
            Radius = radius;
        }
    }
}
