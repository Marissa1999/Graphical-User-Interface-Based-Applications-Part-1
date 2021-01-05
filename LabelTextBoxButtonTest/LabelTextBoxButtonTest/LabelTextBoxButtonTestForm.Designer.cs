namespace LabelTextBoxButtonTest
{
    partial class LabelTextBoxButtonTestForm
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
            this.displayPasswordLabel = new System.Windows.Forms.Label();
            this.displayPasswordButton = new System.Windows.Forms.Button();
            this.inputPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // displayPasswordLabel
            // 
            this.displayPasswordLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayPasswordLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.displayPasswordLabel.Location = new System.Drawing.Point(39, 47);
            this.displayPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.displayPasswordLabel.Name = "displayPasswordLabel";
            this.displayPasswordLabel.Size = new System.Drawing.Size(279, 19);
            this.displayPasswordLabel.TabIndex = 0;
            this.displayPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // displayPasswordButton
            // 
            this.displayPasswordButton.Location = new System.Drawing.Point(145, 80);
            this.displayPasswordButton.Margin = new System.Windows.Forms.Padding(2);
            this.displayPasswordButton.Name = "displayPasswordButton";
            this.displayPasswordButton.Size = new System.Drawing.Size(55, 23);
            this.displayPasswordButton.TabIndex = 2;
            this.displayPasswordButton.Text = "Show Me";
            this.displayPasswordButton.UseVisualStyleBackColor = true;
            this.displayPasswordButton.Click += new System.EventHandler(this.displayPasswordButton_Click);
            // 
            // inputPasswordTextBox
            // 
            this.inputPasswordTextBox.Location = new System.Drawing.Point(39, 18);
            this.inputPasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.inputPasswordTextBox.Name = "inputPasswordTextBox";
            this.inputPasswordTextBox.PasswordChar = '$';
            this.inputPasswordTextBox.Size = new System.Drawing.Size(280, 20);
            this.inputPasswordTextBox.TabIndex = 3;
            this.inputPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LabelTextBoxButtonTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 118);
            this.Controls.Add(this.inputPasswordTextBox);
            this.Controls.Add(this.displayPasswordButton);
            this.Controls.Add(this.displayPasswordLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LabelTextBoxButtonTestForm";
            this.Text = "Labels, Textboxes and Buttons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label displayPasswordLabel;
        private System.Windows.Forms.Button displayPasswordButton;
        private System.Windows.Forms.TextBox inputPasswordTextBox;
    }
}

