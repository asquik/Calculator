
namespace Calculator
{
    partial class View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.operandButton1 = new Calculator.OperandButton();
            this.operatorDivide = new Calculator.OperatorButton();
            this.operandButton2 = new Calculator.OperandButton();
            this.operandButton3 = new Calculator.OperandButton();
            this.operatorPlus = new Calculator.OperatorButton();
            this.operandButton0 = new Calculator.OperandButton();
            this.operandButton4 = new Calculator.OperandButton();
            this.operatorMultiply = new Calculator.OperatorButton();
            this.operandButton5 = new Calculator.OperandButton();
            this.operandButton9 = new Calculator.OperandButton();
            this.operandButton6 = new Calculator.OperandButton();
            this.operandButton8 = new Calculator.OperandButton();
            this.operatorMinus = new Calculator.OperatorButton();
            this.operandButton7 = new Calculator.OperandButton();
            this.operatorEquals = new Calculator.OperatorButton();
            this.operatorSqrt = new Calculator.OperatorButton();
            this.operatorSquare = new Calculator.OperatorButton();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonMR = new System.Windows.Forms.Button();
            this.buttonMC = new System.Windows.Forms.Button();
            this.buttonM = new System.Windows.Forms.Button();
            this.outputLabel = new Calculator.OutputLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 262);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 61);
            this.button1.TabIndex = 14;
            this.button1.Text = ".";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.operandButtonClick);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(153, 262);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 61);
            this.button2.TabIndex = 15;
            this.button2.Text = "+/-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.symbolButton);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.operandButton1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.operatorDivide, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.operandButton2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.operandButton3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.operatorPlus, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.operandButton0, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.operandButton4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.operatorMultiply, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.operandButton5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.operandButton9, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.operandButton6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.operandButton8, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.operatorMinus, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.operandButton7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.operatorEquals, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.operatorSqrt, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.operatorSquare, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonC, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonCE, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonDel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonMR, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonMC, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonM, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 118);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(375, 325);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // operandButton1
            // 
            this.operandButton1.AutoSize = true;
            this.operandButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operandButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.operandButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operandButton1.Location = new System.Drawing.Point(3, 67);
            this.operandButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operandButton1.Name = "operandButton1";
            this.operandButton1.Size = new System.Drawing.Size(69, 61);
            this.operandButton1.TabIndex = 1;
            this.operandButton1.Text = "1";
            this.operandButton1.UseVisualStyleBackColor = true;
            this.operandButton1.Click += new System.EventHandler(this.operandButtonClick);
            // 
            // operatorDivide
            // 
            this.operatorDivide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operatorDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorDivide.Location = new System.Drawing.Point(228, 262);
            this.operatorDivide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operatorDivide.Name = "operatorDivide";
            this.operatorDivide.Size = new System.Drawing.Size(69, 61);
            this.operatorDivide.TabIndex = 16;
            this.operatorDivide.Text = "/";
            this.operatorDivide.Click += new System.EventHandler(this.operatorButtonClick);
            // 
            // operandButton2
            // 
            this.operandButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operandButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operandButton2.Location = new System.Drawing.Point(78, 67);
            this.operandButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operandButton2.Name = "operandButton2";
            this.operandButton2.Size = new System.Drawing.Size(69, 61);
            this.operandButton2.TabIndex = 2;
            this.operandButton2.Text = "2";
            this.operandButton2.UseVisualStyleBackColor = true;
            this.operandButton2.Click += new System.EventHandler(this.operandButtonClick);
            // 
            // operandButton3
            // 
            this.operandButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operandButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operandButton3.Location = new System.Drawing.Point(153, 67);
            this.operandButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operandButton3.Name = "operandButton3";
            this.operandButton3.Size = new System.Drawing.Size(69, 61);
            this.operandButton3.TabIndex = 3;
            this.operandButton3.Text = "3";
            this.operandButton3.UseVisualStyleBackColor = true;
            this.operandButton3.Click += new System.EventHandler(this.operandButtonClick);
            // 
            // operatorPlus
            // 
            this.operatorPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operatorPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorPlus.Location = new System.Drawing.Point(228, 67);
            this.operatorPlus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operatorPlus.Name = "operatorPlus";
            this.operatorPlus.Size = new System.Drawing.Size(69, 61);
            this.operatorPlus.TabIndex = 7;
            this.operatorPlus.Text = "+";
            this.operatorPlus.Click += new System.EventHandler(this.operatorButtonClick);
            // 
            // operandButton0
            // 
            this.operandButton0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operandButton0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operandButton0.Location = new System.Drawing.Point(78, 262);
            this.operandButton0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operandButton0.Name = "operandButton0";
            this.operandButton0.Size = new System.Drawing.Size(69, 61);
            this.operandButton0.TabIndex = 13;
            this.operandButton0.Text = "0";
            this.operandButton0.UseVisualStyleBackColor = true;
            this.operandButton0.Click += new System.EventHandler(this.operandButtonClick);
            // 
            // operandButton4
            // 
            this.operandButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operandButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operandButton4.Location = new System.Drawing.Point(3, 132);
            this.operandButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operandButton4.Name = "operandButton4";
            this.operandButton4.Size = new System.Drawing.Size(69, 61);
            this.operandButton4.TabIndex = 4;
            this.operandButton4.Text = "4";
            this.operandButton4.UseVisualStyleBackColor = true;
            this.operandButton4.Click += new System.EventHandler(this.operandButtonClick);
            // 
            // operatorMultiply
            // 
            this.operatorMultiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operatorMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorMultiply.Location = new System.Drawing.Point(228, 197);
            this.operatorMultiply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operatorMultiply.Name = "operatorMultiply";
            this.operatorMultiply.Size = new System.Drawing.Size(69, 61);
            this.operatorMultiply.TabIndex = 12;
            this.operatorMultiply.Text = "*";
            this.operatorMultiply.Click += new System.EventHandler(this.operatorButtonClick);
            // 
            // operandButton5
            // 
            this.operandButton5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operandButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operandButton5.Location = new System.Drawing.Point(78, 132);
            this.operandButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operandButton5.Name = "operandButton5";
            this.operandButton5.Size = new System.Drawing.Size(69, 61);
            this.operandButton5.TabIndex = 5;
            this.operandButton5.Text = "5";
            this.operandButton5.UseVisualStyleBackColor = true;
            this.operandButton5.Click += new System.EventHandler(this.operandButtonClick);
            // 
            // operandButton9
            // 
            this.operandButton9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operandButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operandButton9.Location = new System.Drawing.Point(153, 197);
            this.operandButton9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operandButton9.Name = "operandButton9";
            this.operandButton9.Size = new System.Drawing.Size(69, 61);
            this.operandButton9.TabIndex = 11;
            this.operandButton9.Text = "9";
            this.operandButton9.UseVisualStyleBackColor = true;
            this.operandButton9.Click += new System.EventHandler(this.operandButtonClick);
            // 
            // operandButton6
            // 
            this.operandButton6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operandButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operandButton6.Location = new System.Drawing.Point(153, 132);
            this.operandButton6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operandButton6.Name = "operandButton6";
            this.operandButton6.Size = new System.Drawing.Size(69, 61);
            this.operandButton6.TabIndex = 6;
            this.operandButton6.Text = "6";
            this.operandButton6.UseVisualStyleBackColor = true;
            this.operandButton6.Click += new System.EventHandler(this.operandButtonClick);
            // 
            // operandButton8
            // 
            this.operandButton8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operandButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operandButton8.Location = new System.Drawing.Point(78, 197);
            this.operandButton8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operandButton8.Name = "operandButton8";
            this.operandButton8.Size = new System.Drawing.Size(69, 61);
            this.operandButton8.TabIndex = 10;
            this.operandButton8.Text = "8";
            this.operandButton8.UseVisualStyleBackColor = true;
            this.operandButton8.Click += new System.EventHandler(this.operandButtonClick);
            // 
            // operatorMinus
            // 
            this.operatorMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operatorMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorMinus.Location = new System.Drawing.Point(228, 132);
            this.operatorMinus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operatorMinus.Name = "operatorMinus";
            this.operatorMinus.Size = new System.Drawing.Size(69, 61);
            this.operatorMinus.TabIndex = 8;
            this.operatorMinus.Text = "-";
            this.operatorMinus.Click += new System.EventHandler(this.operatorButtonClick);
            // 
            // operandButton7
            // 
            this.operandButton7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operandButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operandButton7.Location = new System.Drawing.Point(3, 197);
            this.operandButton7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operandButton7.Name = "operandButton7";
            this.operandButton7.Size = new System.Drawing.Size(69, 61);
            this.operandButton7.TabIndex = 9;
            this.operandButton7.Text = "7";
            this.operandButton7.UseVisualStyleBackColor = true;
            this.operandButton7.Click += new System.EventHandler(this.operandButtonClick);
            // 
            // operatorEquals
            // 
            this.operatorEquals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operatorEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorEquals.Location = new System.Drawing.Point(303, 262);
            this.operatorEquals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operatorEquals.Name = "operatorEquals";
            this.operatorEquals.Size = new System.Drawing.Size(69, 61);
            this.operatorEquals.TabIndex = 17;
            this.operatorEquals.Text = "=";
            this.operatorEquals.UseVisualStyleBackColor = true;
            this.operatorEquals.Click += new System.EventHandler(this.operatorButtonClick);
            // 
            // operatorSqrt
            // 
            this.operatorSqrt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operatorSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorSqrt.Location = new System.Drawing.Point(303, 197);
            this.operatorSqrt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operatorSqrt.Name = "operatorSqrt";
            this.operatorSqrt.Size = new System.Drawing.Size(69, 61);
            this.operatorSqrt.TabIndex = 18;
            this.operatorSqrt.Text = "√x";
            this.operatorSqrt.UseVisualStyleBackColor = true;
            this.operatorSqrt.Click += new System.EventHandler(this.operatorButtonClick);
            // 
            // operatorSquare
            // 
            this.operatorSquare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operatorSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorSquare.Location = new System.Drawing.Point(303, 132);
            this.operatorSquare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operatorSquare.Name = "operatorSquare";
            this.operatorSquare.Size = new System.Drawing.Size(69, 61);
            this.operatorSquare.TabIndex = 19;
            this.operatorSquare.Text = "x²";
            this.operatorSquare.UseVisualStyleBackColor = true;
            this.operatorSquare.Click += new System.EventHandler(this.operatorButtonClick);
            // 
            // buttonC
            // 
            this.buttonC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.Location = new System.Drawing.Point(303, 67);
            this.buttonC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(69, 61);
            this.buttonC.TabIndex = 20;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.cancelButton);
            // 
            // buttonCE
            // 
            this.buttonCE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCE.Location = new System.Drawing.Point(303, 2);
            this.buttonCE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(69, 61);
            this.buttonCE.TabIndex = 21;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.cancelButton);
            // 
            // buttonDel
            // 
            this.buttonDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.Location = new System.Drawing.Point(228, 2);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(69, 61);
            this.buttonDel.TabIndex = 22;
            this.buttonDel.Text = "del";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.deleteButton);
            // 
            // buttonMR
            // 
            this.buttonMR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMR.Location = new System.Drawing.Point(153, 2);
            this.buttonMR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMR.Name = "buttonMR";
            this.buttonMR.Size = new System.Drawing.Size(69, 61);
            this.buttonMR.TabIndex = 23;
            this.buttonMR.Text = "MR";
            this.buttonMR.UseVisualStyleBackColor = true;
            this.buttonMR.Click += new System.EventHandler(this.memoryButtonClick);
            // 
            // buttonMC
            // 
            this.buttonMC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMC.Location = new System.Drawing.Point(78, 2);
            this.buttonMC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMC.Name = "buttonMC";
            this.buttonMC.Size = new System.Drawing.Size(69, 61);
            this.buttonMC.TabIndex = 24;
            this.buttonMC.Text = "MC";
            this.buttonMC.UseVisualStyleBackColor = true;
            this.buttonMC.Click += new System.EventHandler(this.memoryButtonClick);
            // 
            // buttonM
            // 
            this.buttonM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonM.Location = new System.Drawing.Point(3, 2);
            this.buttonM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(69, 61);
            this.buttonM.TabIndex = 25;
            this.buttonM.Text = "M+";
            this.buttonM.UseVisualStyleBackColor = true;
            this.buttonM.Click += new System.EventHandler(this.memoryButtonClick);
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(4, 19);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(375, 64);
            this.outputLabel.TabIndex = 18;
            this.outputLabel.Text = "0";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.View_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private OperandButton operandButton1;
        private OperandButton operandButton2;
        private OperandButton operandButton3;
        private OperandButton operandButton4;
        private OperandButton operandButton5;
        private OperandButton operandButton6;
        private OperatorButton operatorPlus;
        private OperatorButton operatorMinus;
        private OperandButton operandButton7;
        private OperandButton operandButton8;
        private OperandButton operandButton9;
        private OperatorButton operatorMultiply;
        private OperandButton operandButton0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private OperatorButton operatorDivide;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private OperatorButton operatorEquals;
        private OperatorButton operatorSqrt;
        private OperatorButton operatorSquare;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonMR;
        private System.Windows.Forms.Button buttonMC;
        private System.Windows.Forms.Button buttonM;
        private OutputLabel outputLabel;
    }
}

