using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Active_Button()
        {
            devideButton.Enabled = true;
            multiplyButton.Enabled = true;
            minusButton.Enabled = true;
            plusButton.Enabled = true;
        }

        private void Not_Active_Button()
        {
            devideButton.Enabled = false;
            multiplyButton.Enabled = false;
            minusButton.Enabled = false;
            plusButton.Enabled = false;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox.Text == "0") || (operation_pressed))
            {
                textBox.Clear();
            }
            Active_Button();
            Button button = (Button)sender;
            textBox.Text = textBox.Text + button.Text;
           if (operation_pressed == true)
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
            operation_pressed = true; 
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
            operation_pressed = false;
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