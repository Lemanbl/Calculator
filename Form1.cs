using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Operation currentOperation = Operation.None;
        private double firstOperand;
        private double secondOperand;
        private bool isNewNumber=false;
        private bool IsOperator(char character) {
            switch (character)
            {
                case '+': 
                case '-': 
                case 'x': 
                case '/':
                    return true;
                default:
                    return false;
            }
        }
        private Operation GetOperation(string str)
        {
            switch (str)
            {
                case "+":
                    return Operation.Add;
                case "-":
                    return Operation.Subtract;
                case "x":
                    return Operation.Multiply;
                case "/":
                    return Operation.Divide;
                default:
                    return Operation.None;
            }
        }
        private double Calculate(double firstOperand, double secondOperand, Operation operation)
        {
            switch (operation) { 
                case Operation.Add:
                    return firstOperand + secondOperand;
                case Operation.Subtract:
                    return firstOperand - secondOperand;
                case Operation.Divide:
                    return firstOperand / secondOperand;
                case Operation.Multiply:
                    return firstOperand * secondOperand;
                default:
                    return 0;
            }
        }
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (isNewNumber)
            {
                textBox.Clear();
                isNewNumber = false;
            }
            textBox.Text = (textBox.Text == "0") ? button.Text : textBox.Text + button.Text;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            char lastCharacter = textBox.Text[textBox.Text.Length - 1];
            if (IsOperator(lastCharacter))
            {
                textBox.Text = textBox.Text.Remove(textBox.TextLength - 1);
            }
            else {
                firstOperand = Convert.ToDouble(textBox.Text);
                currentOperation = GetOperation(button.Text);
                isNewNumber = true;
                textBox.Text += button.Text;
            }
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            secondOperand = Convert.ToDouble(textBox.Text);
            var result=Calculate(firstOperand, secondOperand,currentOperation);
            resultLabel.Text=result.ToString();
            textBox.Text =result.ToString();
            firstOperand = result;
            currentOperation=Operation.None;
            isNewNumber = true;

        }

       
    }
}
