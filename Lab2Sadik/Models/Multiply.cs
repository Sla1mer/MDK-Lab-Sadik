using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Sadik
{
    public class Multiply : ICalculation
    {
        private readonly double coef;

        public Multiply(double coefValue)
        {
            coef = coefValue;
        }

        public double Perform(double x)
        {
            return x * coef;
        }
    }
}
