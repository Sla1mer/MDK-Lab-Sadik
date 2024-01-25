﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Sadik
{
    public class Multiply : Calculation
    {
        private readonly double coef;

        public Multiply(double coefValue)
        {
            coef = coefValue;
        }

        public override double Perform(double x)
        {
            return x * coef;
        }
    }
}
