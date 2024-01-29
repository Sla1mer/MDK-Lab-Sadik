using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Sadik
{
    public class Add : ICalculation
    {

        private readonly double valueToAdd;

        public Add(double value)
        {
            valueToAdd = value;
        }
        public double Perform(double x)
        {
            return x + valueToAdd;
        }
    }
}
