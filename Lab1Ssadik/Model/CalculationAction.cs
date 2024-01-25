using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Sadik.Model
{
    public class CalculationAction
    {
        public string? NameAction { get; set; }
        public Calculation? action { get; set; }

        public CalculationAction(string? nameAction, Calculation? action)
        {
            NameAction = nameAction;
            this.action = action;
        }
    }
}
