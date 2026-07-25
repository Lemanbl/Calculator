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
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox.Text = (textBox.Text == "0") ? button.Text : textBox.Text+button.Text;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Text)
            {
                case "+":
                    currentOperation = Operation.Add;
                    break;
                case "-":
                    currentOperation = Operation.Subtract;
                    break;
                case "x":
                    currentOperation = Operation.Multiply;
                    break;
                case "/":
                    currentOperation = Operation.Divide;
                    break;
            }
            if (currentOperation != Operation.None)
            {
                if(textBox.Text.EndsWith("+") || textBox.Text.EndsWith("-") || textBox.Text.EndsWith("/")|| textBox.Text.EndsWith("x"))
                {
                    textBox.Text = textBox.Text.Remove(textBox.TextLength-1);
                }
                textBox.Text += button.Text;
            }
        }

        private void equalButton_Click(object sender, EventArgs e)
        {

        }
    }
}
