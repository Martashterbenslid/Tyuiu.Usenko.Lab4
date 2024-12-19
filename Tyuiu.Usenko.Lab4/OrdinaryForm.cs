using Microsoft.VisualBasic.ApplicationServices;
using OrdinaryCalc.Lib;
using ArithmeticForms;
using Tyuiu.Usenko.Lab4;


namespace Tyuiu.Usenko.Lab4
{
    public partial class OrdinaryForm : Form
    {
        private readonly Ordinary calculator = new Ordinary();
        private Stack<double> operandsStack;
        private Stack<string> operationsStack;

        public OrdinaryForm()
        {
            InitializeComponent();
            operandsStack = new Stack<double>();
            operationsStack = new Stack<string>();
        }

        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonPlusMinus = new Button();
            buttonComma = new Button();
            buttonErase = new Button();
            buttonMultiplication = new Button();
            buttonMinus = new Button();
            buttonPlus = new Button();
            buttonEquals = new Button();
            label1 = new Label();
            buttonMenu = new Button();
            panelMenu = new Panel();
            button10 = new Button();
            buttonQuotient = new Button();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Pink;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 60F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(0, 34);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(413, 107);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(2, 398);
            button1.Name = "button1";
            button1.Size = new Size(102, 65);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(107, 398);
            button2.Name = "button2";
            button2.Size = new Size(102, 65);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(212, 398);
            button3.Name = "button3";
            button3.Size = new Size(102, 65);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(2, 330);
            button4.Name = "button4";
            button4.Size = new Size(102, 65);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonHighlight;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(107, 330);
            button5.Name = "button5";
            button5.Size = new Size(102, 65);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonHighlight;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(212, 330);
            button6.Name = "button6";
            button6.Size = new Size(102, 65);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ButtonHighlight;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(2, 262);
            button7.Name = "button7";
            button7.Size = new Size(102, 65);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ButtonHighlight;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(107, 262);
            button8.Name = "button8";
            button8.Size = new Size(102, 65);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ButtonHighlight;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(212, 262);
            button9.Name = "button9";
            button9.Size = new Size(102, 65);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.BackColor = SystemColors.ButtonHighlight;
            button0.FlatAppearance.BorderSize = 0;
            button0.FlatStyle = FlatStyle.Flat;
            button0.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            button0.Location = new Point(107, 466);
            button0.Name = "button0";
            button0.Size = new Size(102, 65);
            button0.TabIndex = 10;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += button0_Click;
            // 
            // buttonPlusMinus
            // 
            buttonPlusMinus.BackColor = SystemColors.ButtonHighlight;
            buttonPlusMinus.FlatAppearance.BorderSize = 0;
            buttonPlusMinus.FlatStyle = FlatStyle.Flat;
            buttonPlusMinus.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPlusMinus.Location = new Point(2, 466);
            buttonPlusMinus.Name = "buttonPlusMinus";
            buttonPlusMinus.Size = new Size(102, 65);
            buttonPlusMinus.TabIndex = 11;
            buttonPlusMinus.Text = "+/-";
            buttonPlusMinus.UseVisualStyleBackColor = false;
            buttonPlusMinus.Click += buttonPlusMinus_Click;
            // 
            // buttonComma
            // 
            buttonComma.BackColor = SystemColors.ButtonHighlight;
            buttonComma.FlatAppearance.BorderSize = 0;
            buttonComma.FlatStyle = FlatStyle.Flat;
            buttonComma.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            buttonComma.Location = new Point(212, 466);
            buttonComma.Name = "buttonComma";
            buttonComma.Size = new Size(102, 65);
            buttonComma.TabIndex = 12;
            buttonComma.Text = ",";
            buttonComma.UseVisualStyleBackColor = false;
            buttonComma.Click += buttonComma_Click;
            // 
            // buttonErase
            // 
            buttonErase.BackColor = Color.HotPink;
            buttonErase.FlatAppearance.BorderSize = 0;
            buttonErase.FlatStyle = FlatStyle.Flat;
            buttonErase.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            buttonErase.Location = new Point(317, 194);
            buttonErase.Name = "buttonErase";
            buttonErase.Size = new Size(102, 65);
            buttonErase.TabIndex = 17;
            buttonErase.Text = "⌫";
            buttonErase.UseVisualStyleBackColor = false;
            buttonErase.Click += buttonErase_Click;
            // 
            // buttonMultiplication
            // 
            buttonMultiplication.BackColor = Color.HotPink;
            buttonMultiplication.FlatAppearance.BorderSize = 0;
            buttonMultiplication.FlatStyle = FlatStyle.Flat;
            buttonMultiplication.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMultiplication.Location = new Point(317, 262);
            buttonMultiplication.Name = "buttonMultiplication";
            buttonMultiplication.Size = new Size(102, 65);
            buttonMultiplication.TabIndex = 18;
            buttonMultiplication.Text = "×";
            buttonMultiplication.UseVisualStyleBackColor = false;
            buttonMultiplication.Click += buttonMultiplication_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.BackColor = Color.HotPink;
            buttonMinus.FlatAppearance.BorderSize = 0;
            buttonMinus.FlatStyle = FlatStyle.Flat;
            buttonMinus.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMinus.Location = new Point(317, 330);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(102, 65);
            buttonMinus.TabIndex = 19;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = false;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.BackColor = Color.HotPink;
            buttonPlus.FlatAppearance.BorderSize = 0;
            buttonPlus.FlatStyle = FlatStyle.Flat;
            buttonPlus.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPlus.Location = new Point(317, 398);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(102, 65);
            buttonPlus.TabIndex = 20;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = false;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.BackColor = Color.HotPink;
            buttonEquals.FlatAppearance.BorderSize = 0;
            buttonEquals.FlatStyle = FlatStyle.Flat;
            buttonEquals.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEquals.Location = new Point(317, 466);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(102, 65);
            buttonEquals.TabIndex = 21;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = false;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(41, 4);
            label1.Name = "label1";
            label1.Size = new Size(105, 28);
            label1.TabIndex = 22;
            label1.Text = "Обычный";
            // 
            // buttonMenu
            // 
            buttonMenu.FlatAppearance.BorderSize = 0;
            buttonMenu.FlatStyle = FlatStyle.Flat;
            buttonMenu.Font = new Font("Segoe UI Symbol", 15F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMenu.ImageAlign = ContentAlignment.TopCenter;
            buttonMenu.Location = new Point(2, -1);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(33, 44);
            buttonMenu.TabIndex = 23;
            buttonMenu.Text = "≡";
            buttonMenu.TextAlign = ContentAlignment.TopCenter;
            buttonMenu.UseVisualStyleBackColor = true;
            buttonMenu.Click += buttonMenu_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.InactiveBorder;
            panelMenu.Controls.Add(button10);
            panelMenu.Location = new Point(12, 49);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(209, 40);
            panelMenu.TabIndex = 24;
            panelMenu.Visible = false;
            // 
            // button10
            // 
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Location = new Point(3, 3);
            button10.Name = "button10";
            button10.Size = new Size(204, 29);
            button10.TabIndex = 0;
            button10.Text = "Инженерный калькулятор";
            button10.TextAlign = ContentAlignment.MiddleLeft;
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // buttonQuotient
            // 
            buttonQuotient.BackColor = Color.HotPink;
            buttonQuotient.FlatAppearance.BorderSize = 0;
            buttonQuotient.FlatStyle = FlatStyle.Flat;
            buttonQuotient.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            buttonQuotient.Location = new Point(212, 194);
            buttonQuotient.Name = "buttonQuotient";
            buttonQuotient.Size = new Size(102, 65);
            buttonQuotient.TabIndex = 25;
            buttonQuotient.Text = "/";
            buttonQuotient.UseVisualStyleBackColor = false;
            buttonQuotient.Click += buttonQuotient_Click;
            // 
            // OrdinaryForm
            // 
            BackColor = Color.Pink;
            ClientSize = new Size(421, 533);
            Controls.Add(buttonQuotient);
            Controls.Add(panelMenu);
            Controls.Add(buttonMenu);
            Controls.Add(label1);
            Controls.Add(buttonEquals);
            Controls.Add(buttonPlus);
            Controls.Add(buttonMinus);
            Controls.Add(buttonMultiplication);
            Controls.Add(buttonErase);
            Controls.Add(buttonComma);
            Controls.Add(buttonPlusMinus);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "OrdinaryForm";
            Load += OrdinaryForm_Load;
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void AppendOperation(string operation)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && double.TryParse(textBox1.Text, out double currentValue))
            {
                operandsStack.Push(currentValue);
                operationsStack.Push(operation);
                textBox1.Text = "0";
            }
        }
        private void AppendOperand(string digit)
        {
            if (textBox1.Text == "0" && digit != ",")
            {
                textBox1.Text = digit;
            }
            else
            {
                textBox1.Text += digit;
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = !panelMenu.Visible;
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            AppendOperand("0");
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            AppendOperation("+/-");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppendOperand("3");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AppendOperand("2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppendOperand("1");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AppendOperand("6");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AppendOperand("5");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AppendOperand("4");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AppendOperand("9");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AppendOperand("8");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AppendOperand("7");
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            AppendOperation("*");
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            AppendOperation("-");

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            AppendOperation("+");
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            double currentValue = Convert.ToDouble(textBox1.Text);
            operandsStack.Push(currentValue);

            while (operationsStack.Count > 0)
            {
                string operation = operationsStack.Pop();
                double operand2 = operandsStack.Pop();
                double operand1 = operandsStack.Pop();
                double result = CountResult(operation, operand1, operand2);
                operandsStack.Push(result);
            }

            double finalResult = operandsStack.Pop();
            textBox1.Text = finalResult.ToString();
        }
        private double CountResult(string operation, double operand1, double operand2)
        {
            switch (operation)
            {
                case "+":
                    return calculator.CalculateSumma(operand1, operand2);
                case "-":
                    return calculator.CalculateDifference(operand1, operand2);
                case "*":
                    return calculator.CalculateMultiplication(operand1, operand2);
                case "/":
                    return calculator.CalculateQuotient(operand1, operand2);
                case "+-":
                    return -operand1;
                default:
                    throw new InvalidOperationException("Ошибка");
            }
        }

        private void buttonQuotient_Click(object sender, EventArgs e)
        {
            AppendOperation("/");
        }

        private void buttonErase_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            ArithmeticForm arithmeticForm = new ArithmeticForm();
            arithmeticForm.Show();
        }

        private void OrdinaryForm_Load(object sender, EventArgs e)
        {

        }
    }
}