﻿//ID: 1775227
//Name: Marissa Goncalves
//Lab 2 - GUI Application with Label, TextBox and Button Controls

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelTextBoxButtonTest
{
    public partial class LabelTextBoxButtonTestForm : Form
    {
        public LabelTextBoxButtonTestForm()
        {
            InitializeComponent();
        }

        private void displayPasswordButton_Click(object sender, EventArgs e)
        {
            displayPasswordLabel.Text = inputPasswordTextBox.Text;
        }
    }
}
