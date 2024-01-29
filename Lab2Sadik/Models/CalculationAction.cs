using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Sadik.Model
{
    public class CalculationAction
    {
        public string? NameAction { get; set; }
        public ICalculation? action { get; set; }

        public CalculationAction(string? nameAction, ICalculation? action)
        {
            NameAction = nameAction;
            this.action = action;
        }
    }
}
