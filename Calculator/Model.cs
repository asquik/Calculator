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
        public static double firstOperand { get; private set; }
        public static double secondOperand { get; private set; }
        public static double memory { get; private set; }

        public static void SetFirstOperand(double label)
        {
            firstOperand = label;
        }

        public static void SetSecondOperand(double label)
        {
            secondOperand = label;
        }
    }

}
