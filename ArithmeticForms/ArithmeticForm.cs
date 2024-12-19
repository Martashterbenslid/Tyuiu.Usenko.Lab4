using Microsoft.VisualBasic.ApplicationServices;
using ArithmeticCalc.Lib;
using OrdinaryCalc.Lib;
namespace ArithmeticForms
{
    public partial class ArithmeticForm : Form
    {
        private readonly Arithmetic calculator = new Arithmetic();
        private readonly Ordinary math = new Ordinary();
        private Stack<double> operandsStack;
        private Stack<string> operationsStack;
        public ArithmeticForm()
        {
            InitializeComponent();
            operandsStack = new Stack<double>();
            operationsStack = new Stack<string>();
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

        private double CountResult(string operation, double operand1, double operand2)
        {
            switch (operation)
            {
                case "+":
                    return math.CalculateSumma(operand1, operand2);
                case "-":
                    return math.CalculateDifference(operand1, operand2);
                case "*":
                    return math.CalculateMultiplication(operand1, operand2);
                case "/":
                    return math.CalculateQuotient(operand1, operand2);
                case "+-":
                    return -operand1;
                case "pow":
                    return calculator.CalcPower(operand1, operand2);
                case "square":
                    return calculator.SquareRoot(operand1);
                case "log":
                    return calculator.CalcLog(operand1, operand2);
                case "sin":
                    return calculator.CalcSin(operand1);
                case "cos":
                    return calculator.CalcCos(operand1);
                default:
                    throw new InvalidOperationException("Ошибка");
            }
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

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            AppendOperation("+");
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

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            AppendOperation("-");
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

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            AppendOperation("*");
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

        private void buttonErase_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void buttonQuotient_Click(object sender, EventArgs e)
        {
            AppendOperation("/");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            AppendOperation("pow");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            AppendOperation("square");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            AppendOperation("log");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            AppendOperation("sin");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AppendOperation("cos");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AppendOperand("π");
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = !panelMenu.Visible;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            ArithmeticForm arithmeticForm = new ArithmeticForm();
            arithmeticForm.Show();
        }


    }
}