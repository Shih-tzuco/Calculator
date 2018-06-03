namespace Calculator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.resultButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(73, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(134, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 126);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(73, 126);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 40);
            this.button6.TabIndex = 5;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(134, 126);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 40);
            this.button7.TabIndex = 6;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 80);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 40);
            this.button8.TabIndex = 7;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(73, 80);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(55, 40);
            this.button9.TabIndex = 8;
            this.button9.Text = "8";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(134, 80);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(55, 40);
            this.button10.TabIndex = 9;
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(12, 218);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(55, 40);
            this.button11.TabIndex = 10;
            this.button11.Text = "CE";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.ButtonCEClick);
            // 
            // resultButton
            // 
            this.resultButton.Enabled = false;
            this.resultButton.Location = new System.Drawing.Point(134, 218);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(55, 40);
            this.resultButton.TabIndex = 11;
            this.resultButton.Text = "=";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.ButtonOperationClick);
            // 
            // divideButton
            // 
            this.divideButton.Enabled = false;
            this.divideButton.Location = new System.Drawing.Point(217, 80);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(55, 40);
            this.divideButton.TabIndex = 12;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Enabled = false;
            this.multiplyButton.Location = new System.Drawing.Point(217, 126);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(55, 40);
            this.multiplyButton.TabIndex = 13;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // minusButton
            // 
            this.minusButton.Enabled = false;
            this.minusButton.Location = new System.Drawing.Point(217, 172);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(55, 40);
            this.minusButton.TabIndex = 14;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // plusButton
            // 
            this.plusButton.Enabled = false;
            this.plusButton.Location = new System.Drawing.Point(217, 218);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(55, 40);
            this.plusButton.TabIndex = 15;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(14, 38);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(258, 32);
            this.textBox.TabIndex = 16;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(225, 12);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(40, 23);
            this.label.TabIndex = 17;
            this.label.Text = "      ";
            this.label.Click += new System.EventHandler(this.ILabelShow);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 267);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label;
    }
}

