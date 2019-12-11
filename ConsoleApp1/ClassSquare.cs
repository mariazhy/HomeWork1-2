using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class ClassSquare
    {
        private double side;
        public double Area 
        {
            get 
            {
               return Math.Round(Math.Pow(side, 2), 2);
            }
        }
        public double Side 
        {
            get
            {
                return side;
            }
            private set
            {
                side = value;
            }
        }

        public ClassSquare(double side)
        {
            this.side = side;
        }

        
    }
}
