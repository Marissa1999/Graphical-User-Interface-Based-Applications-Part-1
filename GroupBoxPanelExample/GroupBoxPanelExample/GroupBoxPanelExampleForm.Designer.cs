namespace GroupBoxPanelExample
{
    partial class GroupBoxPanelExampleForm
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
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.byeButton = new System.Windows.Forms.Button();
            this.hiButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.mainGroupBox.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Controls.Add(this.byeButton);
            this.mainGroupBox.Controls.Add(this.hiButton);
            this.mainGroupBox.Location = new System.Drawing.Point(36, 26);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Size = new System.Drawing.Size(374, 86);
            this.mainGroupBox.TabIndex = 0;
            this.mainGroupBox.TabStop = false;
            this.mainGroupBox.Text = "Main GroupBox";
            // 
            // byeButton
            // 
            this.byeButton.Location = new System.Drawing.Point(213, 30);
            this.byeButton.Name = "byeButton";
            this.byeButton.Size = new System.Drawing.Size(143, 43);
            this.byeButton.TabIndex = 1;
            this.byeButton.Text = "Bye";
            this.byeButton.UseVisualStyleBackColor = true;
            this.byeButton.Click += new System.EventHandler(this.byeButton_Click);
            // 
            // hiButton
            // 
            this.hiButton.Location = new System.Drawing.Point(22, 30);
            this.hiButton.Name = "hiButton";
            this.hiButton.Size = new System.Drawing.Size(142, 43);
            this.hiButton.TabIndex = 0;
            this.hiButton.Text = "Hi";
            this.hiButton.UseVisualStyleBackColor = true;
            this.hiButton.Click += new System.EventHandler(this.hiButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Controls.Add(this.rightButton);
            this.mainPanel.Controls.Add(this.leftButton);
            this.mainPanel.Location = new System.Drawing.Point(36, 134);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(380, 100);
            this.mainPanel.TabIndex = 1;
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(3, 3);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(102, 46);
            this.leftButton.TabIndex = 0;
            this.leftButton.Text = "Far Left";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(351, 3);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(112, 46);
            this.rightButton.TabIndex = 1;
            this.rightButton.Text = "Far Right";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.messageLabel.Location = new System.Drawing.Point(36, 258);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(380, 37);
            this.messageLabel.TabIndex = 2;
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GroupBoxPanelExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(474, 337);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.mainGroupBox);
            this.Name = "GroupBoxPanelExample";
            this.Text = "GroupBox and Panels";
            this.mainGroupBox.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.Button byeButton;
        private System.Windows.Forms.Button hiButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Label messageLabel;
    }
}

