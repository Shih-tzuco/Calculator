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

        private void Active_Button()
        {
            divideButton.Enabled = true;
            multiplyButton.Enabled = true;
            minusButton.Enabled = true;
            plusButton.Enabled = true;
        }

        private void Not_Active_Button()
        {
            divideButton.Enabled = false;
            multiplyButton.Enabled = false;
            minusButton.Enabled = false;
            plusButton.Enabled = false;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox.Text == "0") || (operationPressed))
            {
                textBox.Clear();
            }
            Active_Button();
            Button button = (Button)sender;
            textBox.Text = textBox.Text + button.Text;
            if (operationPressed == true)
            {
                Not_Active_Button();
                resultButton.Enabled = true;
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            Button buttonFirst = (Button)sender;
            Button buttonSecond = (Button)sender;
            if (operation != String.Empty)
            {
                textBox.Text = textBox.Text + buttonSecond.Text;
                textBox.Text = String.Empty;
                Not_Active_Button();
            }
            else if (operation == String.Empty)
            {
                textBox.Text = textBox.Text + buttonFirst;
                textBox.Text = String.Empty;
                Not_Active_Button();
                label.Text = "";
            }
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            label_Click(sender, e);
            operation = button.Text;
            Not_Active_Button();
            value = Double.Parse(textBox.Text);
            Not_Active_Button();
            operationPressed = true;
        }

        private void buttonOperation_Click(object sender, EventArgs e)
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

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label_Click(object sender, EventArgs e)
        {
            label.Text = textBox.Text;
        }
    }
}