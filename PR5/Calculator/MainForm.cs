using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Calculator
{
    public partial class MainForm : Form
    {
        string input_number = "";
        bool bracketOpen = false;
        List<double> operands = new List<double>();
        List<string> operations = new List<string>();
        string[] priorities = { "^", "*/", "+-" };
        string mathFunction = "null";
        List<int> brackets = new List<int>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            changeFunctionsAvailability(false);
            string text = ((Button)sender).Text;
            switch (text)
            {
                case "PI":
                    input_number += "3,141592";
                    txtConsole.Text += "3,141592";
                    break;
                case "e":
                    input_number += "2,718281828";
                    txtConsole.Text += "2,718281828";
                    break;
                default:
                    input_number += text;
                    txtConsole.Text += text;
                    break;
            }
            
            if (text == ",")
            {
                btnPoint.Enabled = false;
            }
        }

        private void btnMathFunction_Click(object sender, EventArgs e)
        {
            changeFunctionsAvailability(true);
            string text = ((Button)sender).Text;
            txtConsole.Text += $"{text}(";
            brackets.Add(operands.Count);
            bracketOpen = true;
            mathFunction = text;
        }

        private void btnMathOperation_Click(object sender, EventArgs e)
        {
            string text = ((Button)sender).Text;
            changeFunctionsAvailability(true);
            txtConsole.Text += text;
            operations.Add(text);
            addOperand();
        }

        private void changeFunctionsAvailability(bool state)
        {
            btnRoot.Enabled = btnLn.Enabled = btnAbs.Enabled = btnSin.Enabled = btnCos.Enabled = btnTan.Enabled = btnOpenBracket.Enabled  = state;
        }

        private void addOperand()
        {
            if (input_number == "")
            {
                return;
            }
            double operand = Convert.ToDouble(input_number);
            if (mathFunction == "null")
            {
                operands.Add(operand);
                btnPoint.Enabled = true;
                input_number = "";
            }
            else
            {
                switch (mathFunction)
                {
                    case "root":
                        operands.Add(Math.Sqrt(operand));
                        break;
                    case "ln":
                        operands.Add(Math.Log(operand));
                        break;
                    case "Abs":
                        operands.Add(Math.Abs(operand));
                        break;
                    case "sin":
                        operands.Add(Math.Sin(operand));
                        break;
                    case "cos":
                        operands.Add(Math.Cos(operand));
                        break;
                    case "tan":
                        operands.Add(Math.Tan(operand));
                        break;
                }
                mathFunction = "null";
            }
        }

        void calculate(int firstNumber, int lastNumber)
        {
            foreach (string op in priorities)
            {
                for (int i = firstNumber; i < lastNumber; i++)
                {
                    if (op.Contains(operations[i]))
                    {
                        switch (operations[i])
                        {
                            case "^":
                                operands[i + 1] = Math.Pow(operands[i], operands[i + 1]);
                                break;
                            case "*":
                                operands[i + 1] = operands[i] * operands[i + 1];
                                break;
                            case "/":
                                operands[i + 1] = operands[i] / operands[i + 1];
                                break;
                            case "+":
                                operands[i + 1] = operands[i] + operands[i + 1];
                                break;
                            case "-":
                                operands[i + 1] = operands[i] - operands[i + 1];
                                break;
                        }
                        operands.RemoveAt(i);
                        operations.RemoveAt(i);
                        calculate(firstNumber, lastNumber - 1);
                        return;
                    }
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            addOperand();
            while (brackets.Count > 0)
            {
                calculate(brackets[brackets.Count - 1], operations.Count);
                brackets.RemoveAt(brackets.Count - 1);
            }
            calculate(0, operations.Count);
            txtConsole.Text = Math.Round(operands[0], 4).ToString();
            input_number = txtConsole.Text;
            operands.Clear();
            operations.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtConsole.Text = "";
            operands.Clear();
            operations.Clear();
            input_number = "";
            changeFunctionsAvailability(true);
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            txtConsole.Text = txtConsole.Text.Substring(0, txtConsole.Text.Length - input_number.Length + 1);
            changeFunctionsAvailability(true);
            input_number = "";
        }

        private void btnOpenBracket_Click(object sender, EventArgs e)
        {
            txtConsole.Text += "(";
            brackets.Add(operands.Count);
            bracketOpen = true;
        }

        private void btnCloseBracket_Click(object sender, EventArgs e)
        {
            if (bracketOpen)
            {
                txtConsole.Text += ")";
                addOperand();
                calculate(brackets[brackets.Count - 1], operations.Count);
                brackets.RemoveAt(brackets.Count - 1);
                bracketOpen = brackets.Count != 0;
            }
        }
    }
}
