namespace TempConverterZafar
{
    partial class Form1
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
            this.TempTextBox = new System.Windows.Forms.TextBox();
            this.TempLabel = new System.Windows.Forms.Label();
            this.CelsiusButton = new System.Windows.Forms.Button();
            this.FahrenheitButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TempTextBox
            // 
            this.TempTextBox.Location = new System.Drawing.Point(158, 70);
            this.TempTextBox.Name = "TempTextBox";
            this.TempTextBox.Size = new System.Drawing.Size(162, 22);
            this.TempTextBox.TabIndex = 0;
            // 
            // TempLabel
            // 
            this.TempLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TempLabel.Location = new System.Drawing.Point(158, 132);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new System.Drawing.Size(162, 23);
            this.TempLabel.TabIndex = 1;
            // 
            // CelsiusButton
            // 
            this.CelsiusButton.Location = new System.Drawing.Point(274, 182);
            this.CelsiusButton.Name = "CelsiusButton";
            this.CelsiusButton.Size = new System.Drawing.Size(174, 45);
            this.CelsiusButton.TabIndex = 2;
            this.CelsiusButton.Text = "Convert To Celsius";
            this.CelsiusButton.UseVisualStyleBackColor = true;
            this.CelsiusButton.Click += new System.EventHandler(this.CelsiusButton_Click);
            // 
            // FahrenheitButton
            // 
            this.FahrenheitButton.Location = new System.Drawing.Point(12, 182);
            this.FahrenheitButton.Name = "FahrenheitButton";
            this.FahrenheitButton.Size = new System.Drawing.Size(174, 45);
            this.FahrenheitButton.TabIndex = 3;
            this.FahrenheitButton.Text = "Convert To Fahrenheit";
            this.FahrenheitButton.UseVisualStyleBackColor = true;
            this.FahrenheitButton.Click += new System.EventHandler(this.FahrenheitButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(184, 245);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(95, 42);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(184, 305);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(95, 42);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Your Number Here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(470, 374);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.FahrenheitButton);
            this.Controls.Add(this.CelsiusButton);
            this.Controls.Add(this.TempLabel);
            this.Controls.Add(this.TempTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TempTextBox;
        private System.Windows.Forms.Label TempLabel;
        private System.Windows.Forms.Button CelsiusButton;
        private System.Windows.Forms.Button FahrenheitButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

