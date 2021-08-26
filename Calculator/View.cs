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
            else if (button == operatorMulpiply)
            {
                Controller.OperatorButtonClick((num1, num2) => { return num1 * num2; });
            }
            else if (button == operatorDevide)
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
