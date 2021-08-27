using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void operandButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            outputLabel.Append(button);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.D1 || keyData == Keys.NumPad1)
            {
                operandButton1.PerformClick();
                return true;
            }
            else if (keyData == Keys.D2 || keyData == Keys.NumPad2)
            {
                operandButton2.PerformClick();
                return true;
            }
            else if (keyData == Keys.D3 || keyData == Keys.NumPad3)
            {
                operandButton3.PerformClick();
                return true;
            }
            else if (keyData == Keys.D4 || keyData == Keys.NumPad4)
            {
                operandButton4.PerformClick();
                return true;
            }
            else if (keyData == Keys.D5 || keyData == Keys.NumPad5)
            {
                operandButton5.PerformClick();
                return true;
            }
            else if (keyData == Keys.D6 || keyData == Keys.NumPad6)
            {
                operandButton6.PerformClick();
                return true;
            }
            else if (keyData == Keys.D7 || keyData == Keys.NumPad7)
            {
                operandButton7.PerformClick();
                return true;
            }
            else if (keyData == Keys.D8 || keyData == Keys.NumPad8)
            {
                operandButton8.PerformClick();
                return true;
            }
            else if (keyData == Keys.D9 || keyData == Keys.NumPad9)
            {
                operandButton9.PerformClick();
                return true;
            }
            else if (keyData == Keys.D0 || keyData == Keys.NumPad0)
            {
                operandButton0.PerformClick();
                return true;
            }
            else if (keyData == Keys.Decimal || keyData == Keys.OemPeriod)
            {
                button1.PerformClick();
                return true;
            }
            else if (keyData == Keys.D0 || keyData == Keys.NumPad0)
            {
                operandButton0.PerformClick();
                return true;
            }
            else if (keyData == Keys.Back || keyData == Keys.Delete)
            {
                buttonDel.PerformClick();
                return true;
            }
            else if (keyData == Keys.Add)
            {
                operatorPlus.PerformClick();
                return true;
            }
            else if (keyData == Keys.Multiply)
            {
                operatorMultiply.PerformClick();
                return true;
            }
            else if (keyData == Keys.Subtract || keyData == Keys.OemMinus)
            {
                operatorMinus.PerformClick();
                return true;
            }
            else if (keyData == Keys.Divide)
            {
                operatorDivide.PerformClick();
                return true;
            }
            else if (keyData == Keys.Enter)
            {
                operatorEquals.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void operatorButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button == operatorPlus)
            {
                Controller.OperatorButtonClick((num1, num2) => { return num1 + num2; });
            }
            else if (button == operatorMinus)
            {
                Controller.OperatorButtonClick((num1, num2) => { return num1 - num2; });
            }
            else if (button == operatorMultiply)
            {
                Controller.OperatorButtonClick((num1, num2) => { return num1 * num2; });
            }
            else if (button == operatorDivide)
            {
                Controller.OperatorButtonClick((num1, num2) => { return num1 / num2; });
            }
            else if (button == operatorSquare)
            {
                Controller.OperatorButtonClickInPlace((num1, num2) => { return num1 * num1; });
            }
            else if (button == operatorSqrt)
            {
                Controller.OperatorButtonClickInPlace((num1, num2) => 
                {
                    double result = (Math.Sqrt(num1));
                    return result;
                });
            }
            else if (button == operatorEquals)
            {
                Controller.OperatorButtonClick();
            }

        }

        private void memoryButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button == buttonM)
            {
                Controller.MemoryAdd();
            }
            else if (button == buttonMR)
            {
                Controller.MemoryRecall();
            }
            else if (button == buttonMC)
            {
                Controller.MemoryClear();
            }
        }


        private void View_KeyDown(object sender, EventArgs e)
        {

        }

        private void cancelButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button == buttonC)
            {
                outputLabel.Clear();
                Controller.ResetOperation();
            }
            else if (button == buttonCE)
            {
                outputLabel.Clear();
            }
        }

        private void symbolButton(object sender, EventArgs e)
        {
            outputLabel.ChangeSign();
        }

        private void View_Load(object sender, EventArgs e)
        {

        }

        private void deleteButton(object sender, EventArgs e)
        {
            outputLabel.DeleteSymbol();
        }

        public double GetLabeldouble()
        {
            return outputLabel.value;
        }

        public void ResetLabel()
        {
            outputLabel.Clear();            
        }
        public void ShowResult(double result)
        {
            outputLabel.SetText(result);
        }
        public void SetFlag()
        {
            outputLabel.clearSumFlag = true;
        }

    }
}
