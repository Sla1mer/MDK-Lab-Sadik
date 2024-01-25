using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Sadik
{
    public class Add : Calculation
    {

        private readonly double valueToAdd;

        public Add(double value)
        {
            valueToAdd = value;
        }
        public override double Perform(double x)
        {
            return x + valueToAdd;
        }
    }
}
