//ID: 1775227
//Name: Marissa Goncalves
//Lab 2 - GUI Application with the NumericUpDown Control

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumericUpDownTest
{
    public partial class NumericUpDownTestForm : Form
    {
        public NumericUpDownTestForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            decimal principal = decimal.Parse(principalTextBox.Text);
            double rate = double.Parse(interestTextBox.Text);
            int year = (int)yearUpDown.Value;

            string output = "Year\tAmount on Deposit\r\n";

            for (int yearCounter = 1; yearCounter <= year; ++yearCounter)
            {
                decimal amount = principal * ((decimal)Math.Pow((1 + rate / 100), yearCounter));
                output += $"{yearCounter}\t{amount:C}\r\n";
            }

            displayTextBox.Text = output;
        }
    }
}
