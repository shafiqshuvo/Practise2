﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAppPractice2
{
    public partial class CalculatorUi : Form
    {
        public CalculatorUi()
        {
            InitializeComponent();
        }
        Calculator calculator = new Calculator();

       

        private void AddButton_Click(object sender, EventArgs e)
        {
            calculator.FirstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            calculator.SecondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            resultTextBox.Text = calculator.Add().ToString();
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            calculator.FirstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            calculator.SecondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            resultTextBox.Text = calculator.Subtract().ToString();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            calculator.FirstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            calculator.SecondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            resultTextBox.Text = calculator.Multiply().ToString();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(secondNumberTextBox.Text) != 0)
            {
                calculator.FirstNumber = Convert.ToDouble(firstNumberTextBox.Text);
                calculator.SecondNumber = Convert.ToDouble(secondNumberTextBox.Text);
                resultTextBox.Text = calculator.Divide().ToString();
            }

            else
            {
                MessageBox.Show("Math Error !!!!");
             
            }
        }
        private void ClearTextBox()
        {
            firstNumberTextBox.Clear();
            secondNumberTextBox.Clear();
        }
    }
}
