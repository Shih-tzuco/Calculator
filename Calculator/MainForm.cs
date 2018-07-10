using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        private string operation = "";
        private bool operationPressed = false;
        private double value = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ActiveButton()
        {
            divideButton.Enabled = true;
            minusButton.Enabled = true;
            multiplyButton.Enabled = true;
            plusButton.Enabled = true;
        }

        private void ActionDivide()
        {
            textBox.Text = (value / double.Parse(textBox.Text)).ToString();
        }

        private void ActionMinus()
        {
            textBox.Text = (value - double.Parse(textBox.Text)).ToString();
        }

        private void ActionMultiply()
        {
            textBox.Text = (value * double.Parse(textBox.Text)).ToString();
        }

        private void ActionPlus()
        {
            textBox.Text = (value + double.Parse(textBox.Text)).ToString();
        }

        private void ButtonCEClick(object sender, EventArgs e)
        {
            Button buttonFirst = (Button)sender;
            Button buttonSecond = (Button)sender;
            if (operation != string.Empty)
            {
                textBox.Text = textBox.Text + buttonSecond.Text;
                textBox.Text = string.Empty;
                resultButton.Enabled = false;
                NotActiveButton();
            }
            else if (operation == string.Empty)
            {
                textBox.Text = textBox.Text + buttonFirst;
                textBox.Text = string.Empty;
                NotActiveButton();
                label.Text = "";
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if ((textBox.Text == "0") || (operationPressed))
            {
                textBox.Clear();
            }
            ActiveButton();
            Button button = (Button)sender;
            textBox.Text = textBox.Text + button.Text;
            if (operationPressed)
            {
                NotActiveButton();
                resultButton.Enabled = true;
            }
        }

        private void ButtonOperationClick(object sender, EventArgs e)
        {
            label.Text = "";
            switch (operation)
            {
                case "*":
                    ActionMultiply();
                    break;
                case "/":
                    ActionDivide();
                    break;
                case "+":
                    ActionPlus();
                    break;
                case "-":
                    ActionMinus();
                    break;
            }
            operationPressed = false;
            resultButton.Enabled = false;
        }

        private void NotActiveButton()
        {
            divideButton.Enabled = false;
            minusButton.Enabled = false;
            multiplyButton.Enabled = false;
            plusButton.Enabled = false;
        }

        private void OperatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            
            NotActiveButton();
            value = double.Parse(textBox.Text);
            label.Text = value + " " + operation;
            NotActiveButton();
            operationPressed = true;
        }

        private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 0 || e.KeyChar < 9)
            {
                e.Handled = true;
            }
        }
    }
}