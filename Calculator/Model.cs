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
        private static double memory = 0;
        public static double Memory 
        { get
            {
                return memory;
            }
            private set
            {
                memory = value;
            } 
        }

        public static void SetFirstOperand(double label)
        {
            firstOperand = label;
        }

        public static void SetSecondOperand(double label)
        {
            secondOperand = label;
        }

        public static void SetMemory(double label)
        {
            Memory = label;
        }

        public static void AddMemory(double label)
        {
            Memory = label;
        }
    }

}
