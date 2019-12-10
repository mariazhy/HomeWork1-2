using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class RandomNumber
    {

        public static double NextDouble(this Random random, double minValue, double maxValue)
        {
            return random.NextDouble() * (maxValue - minValue) + minValue;
        }
    }
}
