using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
    public static class Controller
    {
        private static bool firstOperandExists = false;
        private static bool secondOperandExists = false;
        public static View view;
        public delegate decimal Operation(decimal num1, decimal num2);
        static Operation operation;
        static Operation reservedOperaion;
        public static void OperatorButtonClick(Operation operation)
        {
            if (reservedOperaion != null)
            {
                reservedOperaion = null;
                Model.SetFirstOperand(0);
                Model.SetSecondOperand(0);
                firstOperandExists = false;
                secondOperandExists = false;
            }
            if (!firstOperandExists)
            {
                Model.SetFirstOperand(view.GetLabelDecimal());
                firstOperandExists = true;
                view.SetFlag();
                //view.ResetLabel();
            }
            else
            {
                decimal result = Controller.operation(Model.firstOperand, view.GetLabelDecimal());
                view.ShowResult(result);
                Model.SetFirstOperand(result);
                view.SetFlag();
            }
            Controller.operation = operation;
        }

        public static void OperatorButtonClickInPlace(Operation operation)
        {
            if (reservedOperaion != null)
            {
                reservedOperaion = null;
                Model.SetFirstOperand(0);
                Model.SetSecondOperand(0);
                firstOperandExists = false;
                secondOperandExists = false;
            }
            decimal operand;
            decimal result;

            if (!firstOperandExists)
            {
                operand = view.GetLabelDecimal();

            }
            else
            {
                operand = Model.firstOperand;
            }
            result = operation(operand, operand);
            firstOperandExists = false;
            view.ShowResult(result);
            Model.SetFirstOperand(result);
            view.SetFlag();
            Controller.operation = null;
        }

        public static void OperatorButtonClick()
        {
            if (reservedOperaion == null)
            {
                Controller.reservedOperaion = Controller.operation;
                Controller.operation = null;
            }
            if (!firstOperandExists)

            {
                return;
            }
            else
            {
                if (!secondOperandExists)
                {
                    Model.SetSecondOperand(view.GetLabelDecimal());
                    secondOperandExists = true;
                }
                decimal result = Controller.reservedOperaion(Model.firstOperand, Model.secondOperand);
                view.ShowResult(result);
                Model.SetFirstOperand(result);
                view.SetFlag();
            }
        }

        public static void ResetOperation()
        {
            Controller.operation = null;
            Model.SetFirstOperand(0);
            Model.SetSecondOperand(0);
            firstOperandExists = false;
            secondOperandExists = false;
        }


    }
}

