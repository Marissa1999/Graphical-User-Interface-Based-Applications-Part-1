﻿//ID: 1775227
//Name: Marissa Goncalves
//Lab 2 - “Presidential Trivia” GUI Application

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presidential_Trivia
{
    public partial class PresidentialTriviaForm : Form
    {
        public PresidentialTriviaForm()
        {
            InitializeComponent();
        }

        private void showAnswerButton_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "Theodore Roosevelt";
        }
    }
}