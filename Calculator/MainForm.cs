using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        private double value = 0;
        private string operation = "";
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

        private void ILabelShow(object sender, EventArgs e)
        {
            label.Text = textBox.Text;
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
            if (operation != String.Empty)
            {
                textBox.Text = textBox.Text + buttonSecond.Text;
                textBox.Text = String.Empty;
                NotActiveButton();
            }
            else if (operation == String.Empty)
            {
                textBox.Text = textBox.Text + buttonFirst;
                textBox.Text = String.Empty;
                NotActiveButton();
                label.Text = "";
            }
        }

        private void OperatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ILabelShow(sender, e);
            operation = button.Text;
            NotActiveButton();
            value = Double.Parse(textBox.Text);
            NotActiveButton();
            operationPressed = true;
        }

        private void ButtonOperationClick(object sender, EventArgs e)
        {
            label.Text = "";
            switch (operation)
            {
                case "/":
                    textBox.Text = (value / Double.Parse(textBox.Text)).ToString();
                    break;
                case "*":
                    textBox.Text = (value * Double.Parse(textBox.Text)).ToString();
                    break;
                case "-":
                    textBox.Text = (value - Double.Parse(textBox.Text)).ToString();
                    break;
                case "+":
                    textBox.Text = (value + Double.Parse(textBox.Text)).ToString();
                    break;
                default:
                    break;
            }
            operationPressed = false;
            resultButton.Enabled = false;
        }

        private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}