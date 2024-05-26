namespace calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            btndart = new Button();
            btnEqual = new Button();
            btnminum = new Button();
            btnPlus = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnDivide = new Button();
            btnMultiple = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMinusPlus = new Button();
            btnRemainder = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnClear = new Button();
            textBox = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 379);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 0;
            button1.Text = "0";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Any_Number_Click;
            // 
            // btndart
            // 
            btndart.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndart.Location = new Point(89, 379);
            btndart.Name = "btndart";
            btndart.Size = new Size(50, 50);
            btndart.TabIndex = 0;
            btndart.Text = ".";
            btndart.UseVisualStyleBackColor = true;
            btndart.Click += Any_Number_Click;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(166, 379);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(50, 50);
            btnEqual.TabIndex = 0;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += Equal_Click;
            // 
            // btnminum
            // 
            btnminum.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnminum.Location = new Point(243, 379);
            btnminum.Name = "btnminum";
            btnminum.Size = new Size(50, 50);
            btnminum.TabIndex = 0;
            btnminum.Text = "-";
            btnminum.UseVisualStyleBackColor = true;
            btnminum.Click += suppliedOperator;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(320, 379);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(50, 50);
            btnPlus.TabIndex = 0;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(12, 307);
            btn1.Name = "btn1";
            btn1.Size = new Size(50, 50);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += Any_Number_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(89, 307);
            btn2.Name = "btn2";
            btn2.Size = new Size(50, 50);
            btn2.TabIndex = 0;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += Any_Number_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(166, 307);
            btn3.Name = "btn3";
            btn3.Size = new Size(50, 50);
            btn3.TabIndex = 0;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += Any_Number_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(254, 307);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(50, 50);
            btnDivide.TabIndex = 0;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += suppliedOperator;
            // 
            // btnMultiple
            // 
            btnMultiple.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiple.Location = new Point(320, 307);
            btnMultiple.Name = "btnMultiple";
            btnMultiple.Size = new Size(50, 50);
            btnMultiple.TabIndex = 0;
            btnMultiple.Text = "*";
            btnMultiple.UseVisualStyleBackColor = true;
            btnMultiple.Click += suppliedOperator;
            // 
            // btn4
            // 
            btn4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(12, 234);
            btn4.Name = "btn4";
            btn4.Size = new Size(50, 50);
            btn4.TabIndex = 0;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += Any_Number_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(89, 234);
            btn5.Name = "btn5";
            btn5.Size = new Size(50, 50);
            btn5.TabIndex = 0;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += Any_Number_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(166, 234);
            btn6.Name = "btn6";
            btn6.Size = new Size(50, 50);
            btn6.TabIndex = 0;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += Any_Number_Click;
            // 
            // btnMinusPlus
            // 
            btnMinusPlus.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinusPlus.Location = new Point(243, 234);
            btnMinusPlus.Name = "btnMinusPlus";
            btnMinusPlus.Size = new Size(50, 50);
            btnMinusPlus.TabIndex = 0;
            btnMinusPlus.Text = "+/-";
            btnMinusPlus.UseVisualStyleBackColor = true;
            // 
            // btnRemainder
            // 
            btnRemainder.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemainder.Location = new Point(320, 234);
            btnRemainder.Name = "btnRemainder";
            btnRemainder.Size = new Size(50, 50);
            btnRemainder.TabIndex = 0;
            btnRemainder.Text = "%";
            btnRemainder.UseVisualStyleBackColor = true;
            btnRemainder.Click += suppliedOperator;
            // 
            // btn7
            // 
            btn7.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(12, 164);
            btn7.Name = "btn7";
            btn7.Size = new Size(50, 50);
            btn7.TabIndex = 0;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += Any_Number_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(89, 164);
            btn8.Name = "btn8";
            btn8.Size = new Size(50, 50);
            btn8.TabIndex = 0;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += Any_Number_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(166, 164);
            btn9.Name = "btn9";
            btn9.Size = new Size(50, 50);
            btn9.TabIndex = 0;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += Any_Number_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(243, 164);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(127, 50);
            btnClear.TabIndex = 0;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // textBox
            // 
            textBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox.Location = new Point(12, 119);
            textBox.Name = "textBox";
            textBox.Size = new Size(355, 29);
            textBox.TabIndex = 1;
            textBox.Text = "0";
            textBox.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 450);
            Controls.Add(textBox);
            Controls.Add(btnRemainder);
            Controls.Add(btnMultiple);
            Controls.Add(btnPlus);
            Controls.Add(btnClear);
            Controls.Add(btnMinusPlus);
            Controls.Add(btnDivide);
            Controls.Add(btnminum);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn3);
            Controls.Add(btn7);
            Controls.Add(btn2);
            Controls.Add(btn4);
            Controls.Add(btnEqual);
            Controls.Add(btn1);
            Controls.Add(btndart);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btndart;
        private Button btnEqual;
        private Button btnminum;
        private Button btnPlus;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnDivide;
        private Button btnMultiple;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnMinusPlus;
        private Button btnRemainder;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnClear;
        private TextBox textBox;
    }
}
