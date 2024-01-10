namespace TesteBRQ
{
    partial class Teste03
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
            celcius = new TextBox();
            kelvin = new TextBox();
            button1 = new Button();
            label1 = new Label();
            fahrenheit = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // celcius
            // 
            celcius.Location = new Point(18, 40);
            celcius.Name = "celcius";
            celcius.Size = new Size(58, 23);
            celcius.TabIndex = 0;
            // 
            // kelvin
            // 
            kelvin.Location = new Point(18, 84);
            kelvin.Name = "kelvin";
            kelvin.ReadOnly = true;
            kelvin.Size = new Size(58, 23);
            kelvin.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(18, 167);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Converter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 18);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 3;
            label1.Text = "Celcius";
            // 
            // fahrenheit
            // 
            fahrenheit.Location = new Point(18, 129);
            fahrenheit.Name = "fahrenheit";
            fahrenheit.ReadOnly = true;
            fahrenheit.Size = new Size(58, 23);
            fahrenheit.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 111);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 5;
            label2.Text = "Fahrenheit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 66);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 6;
            label3.Text = "Kelvin";
            // 
            // Teste03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 224);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(fahrenheit);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(kelvin);
            Controls.Add(celcius);
            Name = "Teste03";
            Text = "Teste03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox kelvin;
        private Button button1;
        internal TextBox celcius;
        private Label label1;
        private TextBox fahrenheit;
        private Label label2;
        private Label label3;
    }
}