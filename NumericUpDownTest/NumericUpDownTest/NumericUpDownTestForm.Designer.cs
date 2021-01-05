namespace NumericUpDownTest
{
    partial class NumericUpDownTestForm
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
            this.principalLabel = new System.Windows.Forms.Label();
            this.interestRateLabel = new System.Windows.Forms.Label();
            this.yearsLabel = new System.Windows.Forms.Label();
            this.yearlybalanceLabel = new System.Windows.Forms.Label();
            this.principalTextBox = new System.Windows.Forms.TextBox();
            this.interestTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.yearUpDown = new System.Windows.Forms.NumericUpDown();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // principalLabel
            // 
            this.principalLabel.AutoSize = true;
            this.principalLabel.Location = new System.Drawing.Point(55, 16);
            this.principalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.principalLabel.Name = "principalLabel";
            this.principalLabel.Size = new System.Drawing.Size(50, 13);
            this.principalLabel.TabIndex = 0;
            this.principalLabel.Text = "Principal:";
            // 
            // interestRateLabel
            // 
            this.interestRateLabel.AutoSize = true;
            this.interestRateLabel.Location = new System.Drawing.Point(32, 48);
            this.interestRateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.interestRateLabel.Name = "interestRateLabel";
            this.interestRateLabel.Size = new System.Drawing.Size(71, 13);
            this.interestRateLabel.TabIndex = 1;
            this.interestRateLabel.Text = "Interest Rate:";
            // 
            // yearsLabel
            // 
            this.yearsLabel.AutoSize = true;
            this.yearsLabel.Location = new System.Drawing.Point(67, 80);
            this.yearsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yearsLabel.Name = "yearsLabel";
            this.yearsLabel.Size = new System.Drawing.Size(37, 13);
            this.yearsLabel.TabIndex = 2;
            this.yearsLabel.Text = "Years:";
            // 
            // yearlybalanceLabel
            // 
            this.yearlybalanceLabel.AutoSize = true;
            this.yearlybalanceLabel.Location = new System.Drawing.Point(20, 124);
            this.yearlybalanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yearlybalanceLabel.Name = "yearlybalanceLabel";
            this.yearlybalanceLabel.Size = new System.Drawing.Size(124, 13);
            this.yearlybalanceLabel.TabIndex = 3;
            this.yearlybalanceLabel.Text = "Yearly Account Balance:";
            // 
            // principalTextBox
            // 
            this.principalTextBox.Location = new System.Drawing.Point(107, 16);
            this.principalTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.principalTextBox.Name = "principalTextBox";
            this.principalTextBox.Size = new System.Drawing.Size(118, 20);
            this.principalTextBox.TabIndex = 5;
            // 
            // interestTextBox
            // 
            this.interestTextBox.Location = new System.Drawing.Point(107, 46);
            this.interestTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.interestTextBox.Name = "interestTextBox";
            this.interestTextBox.Size = new System.Drawing.Size(118, 20);
            this.interestTextBox.TabIndex = 6;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(239, 20);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(82, 25);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // yearUpDown
            // 
            this.yearUpDown.Location = new System.Drawing.Point(107, 79);
            this.yearUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yearUpDown.Name = "yearUpDown";
            this.yearUpDown.ReadOnly = true;
            this.yearUpDown.Size = new System.Drawing.Size(117, 20);
            this.yearUpDown.TabIndex = 9;
            // 
            // displayTextBox
            // 
            this.displayTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.displayTextBox.Location = new System.Drawing.Point(23, 147);
            this.displayTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.displayTextBox.Multiline = true;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displayTextBox.Size = new System.Drawing.Size(300, 87);
            this.displayTextBox.TabIndex = 10;
            // 
            // NumericUpDownTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 249);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.yearUpDown);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.interestTextBox);
            this.Controls.Add(this.principalTextBox);
            this.Controls.Add(this.yearlybalanceLabel);
            this.Controls.Add(this.yearsLabel);
            this.Controls.Add(this.interestRateLabel);
            this.Controls.Add(this.principalLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NumericUpDownTestForm";
            this.Text = "Interest Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label principalLabel;
        private System.Windows.Forms.Label interestRateLabel;
        private System.Windows.Forms.Label yearsLabel;
        private System.Windows.Forms.Label yearlybalanceLabel;
        private System.Windows.Forms.TextBox principalTextBox;
        private System.Windows.Forms.TextBox interestTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.NumericUpDown yearUpDown;
        private System.Windows.Forms.TextBox displayTextBox;
    }
}

