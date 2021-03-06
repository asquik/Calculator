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
    public partial class OutputLabel : Label
    {
        const int MaxLength = 15;
        bool isNegative = false;
        bool isdouble = false;
        public bool clearSumFlag = false;
        public double value
        {
            get
            {
                return Convert.ToDouble(Text.Replace(",", ""));
            }
            private set
            {

            }
        }
        public OutputLabel()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public void Append(Button button)
        {
            if (clearSumFlag)
            {
                Clear();
                clearSumFlag = false;
            }

            RemoveSigns();

            if(button.Text == ".")
            {
                if (isdouble)
                {
                    AddSigns();
                    return;
                }
                isdouble = true;
            }
            
            if (Text == "0")
            {
                Text = button.Text;
            }
            else if (Text.Length < MaxLength)
            {
                Text += button.Text;
            }
            if (Text == ".")
            {
                Text = "0.";
                return;
            }

            AddSigns();
        }

        private void RemoveSigns()
        {
            Text = Text.Replace(",", "");
            Text = Text.Replace("-", "");
        }

        private void AddSigns()
        {
            if (!isdouble)
            {
                for (int i = Text.Length - 3; i >= 1; i -= 3)
                {
                    Text = Text.Insert(i, ",");
                }
                
            }
            else
            {
                int point = Text.IndexOf('.');
                for (int i = Text.Length - 3; i >= point + 2; i -= 3)
                {
                    Text = Text.Insert(i, ",");
                }
                for (int i = point - 3; i >= 1; i -= 3)
                {
                    Text = Text.Insert(i, ",");
                }
            }
            if (isNegative)
            {
                Text = Text.Insert(0, "-");
            }
        }

        public void ChangeSign()
        { 
            if (isNegative)
            {
                
                if (Text.Length == 1)
                {
                    Text = "0";
                }
                else
                {
                    Text = Text.Remove(0, 1);
                }
            }
            else
            {
                Text = Text.Insert(0, "-");
            }
            isNegative = !isNegative;
        }

        public void DeleteSymbol()
        {

            if (clearSumFlag)
            {
                return;
            }
            RemoveSigns();
            if (isdouble && Text[Text.Length - 1] == '.')
            {
                isdouble = false;
            }
            if (Text.Length == 1)
            {
                Text = "0";
                isNegative = false;
                return;
            }


            Text = Text.Remove(Text.Length - 1);
            AddSigns();
        }

        public void Clear()
        {
            Text = "0";
            isdouble = false;
            isNegative = false;
        }

        public void SetText(double number)
        {
            isNegative = number < 0;            
            isdouble = number % 1 != 0;
            string text = number.ToString();
            text = text.Replace("-", "");
            if (number.ToString("G17").Length > 15)
            {
                Text = String.Format("{0:E10}", number);
            }
            else
            {
                Text = text;
                AddSigns();
            }
        }

    }
}
