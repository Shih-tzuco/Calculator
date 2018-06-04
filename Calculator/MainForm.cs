using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        private string operation = "";
        private double value = 0;
        private bool operationPressed = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ActiveButton()
        {
            divideButton.Enabled = true;
            multiplyButton.Enabled = true;
            minusButton.Enabled = true;
            plusButton.Enabled = true;
        }

        private void NotActiveButton()
        {
            divideButton.Enabled = false;
            multiplyButton.Enabled = false;
            minusButton.Enabled = false;
            plusButton.Enabled = false;
        }

        private void LabelShow(object sender, EventArgs e)
        {
            label.Text = textBox.Text;
        }

        private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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

        private void ButtonCEClick(object sender, EventArgs e)
        {
            Button buttonFirst = (Button)sender;
            Button buttonSecond = (Button)sender;
            if (operation != string.Empty)
            {
                textBox.Text = textBox.Text + buttonSecond.Text;
                textBox.Text = string.Empty;
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

        private void OperatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            LabelShow(sender, e);
            operation = button.Text;
            NotActiveButton();
            value = double.Parse(textBox.Text);
            NotActiveButton();
            operationPressed = true;
        }

        private void ActionMultiply()
        {
            textBox.Text = (value * double.Parse(textBox.Text)).ToString();
        }

        private void ActionDivide()
        {
            textBox.Text = (value / double.Parse(textBox.Text)).ToString();
        }

        private void ActionPlus()
        {
            textBox.Text = (value + double.Parse(textBox.Text)).ToString();
        }

        private void ActionMinus()
        {
            textBox.Text = (value - double.Parse(textBox.Text)).ToString();
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
    }
}