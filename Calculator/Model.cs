using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
    public static class Model
    {
        public static decimal firstOperand { get; private set; }
        public static decimal secondOperand { get; private set; }
        public static decimal memory { get; private set; }

        public static void SetFirstOperand(decimal label)
        {
            firstOperand = label;
        }

        public static void SetSecondOperand(decimal label)
        {
            secondOperand = label;
        }
    }

}
