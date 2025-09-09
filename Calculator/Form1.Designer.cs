
namespace Calculator
{
    partial class Calculator
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
            textIO = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonAdd = new Button();
            buttonSubtract = new Button();
            buttonMultiply = new Button();
            buttonDivide = new Button();
            buttonBackspace = new Button();
            buttonClear = new Button();
            buttonEqual = new Button();
            buttonRevert = new Button();
            buttonOpen = new Button();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // textIO
            // 
            textIO.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textIO.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textIO.Location = new Point(12, 12);
            textIO.Name = "textIO";
            textIO.Size = new Size(378, 61);
            textIO.TabIndex = 0;
            textIO.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 79);
            button1.Name = "button1";
            button1.Size = new Size(90, 62);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(108, 79);
            button2.Name = "button2";
            button2.Size = new Size(90, 62);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(204, 79);
            button3.Name = "button3";
            button3.Size = new Size(90, 62);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 147);
            button4.Name = "button4";
            button4.Size = new Size(90, 62);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(108, 147);
            button5.Name = "button5";
            button5.Size = new Size(90, 62);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(204, 147);
            button6.Name = "button6";
            button6.Size = new Size(90, 62);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(12, 215);
            button7.Name = "button7";
            button7.Size = new Size(90, 62);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(108, 215);
            button8.Name = "button8";
            button8.Size = new Size(90, 62);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(204, 215);
            button9.Name = "button9";
            button9.Size = new Size(90, 62);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Location = new Point(108, 283);
            button0.Name = "button0";
            button0.Size = new Size(90, 62);
            button0.TabIndex = 10;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(300, 79);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(90, 62);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSubtract
            // 
            buttonSubtract.Location = new Point(300, 147);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(90, 62);
            buttonSubtract.TabIndex = 12;
            buttonSubtract.Text = "-";
            buttonSubtract.UseVisualStyleBackColor = true;
            buttonSubtract.Click += buttonSubtract_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(300, 215);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(90, 62);
            buttonMultiply.TabIndex = 13;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Location = new Point(300, 283);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(90, 62);
            buttonDivide.TabIndex = 14;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += buttonDivide_Click;
            // 
            // buttonBackspace
            // 
            buttonBackspace.Location = new Point(12, 283);
            buttonBackspace.Name = "buttonBackspace";
            buttonBackspace.Size = new Size(90, 62);
            buttonBackspace.TabIndex = 15;
            buttonBackspace.Text = "B";
            buttonBackspace.UseVisualStyleBackColor = true;
            buttonBackspace.Click += buttonBackspace_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(204, 283);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(90, 62);
            buttonClear.TabIndex = 16;
            buttonClear.Text = "CLEAR";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.Location = new Point(300, 351);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(90, 62);
            buttonEqual.TabIndex = 17;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = true;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // buttonRevert
            // 
            buttonRevert.Location = new Point(204, 350);
            buttonRevert.Name = "buttonRevert";
            buttonRevert.Size = new Size(90, 62);
            buttonRevert.TabIndex = 18;
            buttonRevert.Text = "REVERT";
            buttonRevert.UseVisualStyleBackColor = true;
            buttonRevert.Click += buttonRevert_Click;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(12, 350);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(90, 62);
            buttonOpen.TabIndex = 19;
            buttonOpen.Text = "(";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(108, 350);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(90, 62);
            buttonClose.TabIndex = 20;
            buttonClose.Text = ")";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 424);
            Controls.Add(buttonClose);
            Controls.Add(buttonOpen);
            Controls.Add(buttonRevert);
            Controls.Add(buttonEqual);
            Controls.Add(buttonClear);
            Controls.Add(buttonBackspace);
            Controls.Add(buttonDivide);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonSubtract);
            Controls.Add(buttonAdd);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textIO);
            Name = "Calculator";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private TextBox textIO;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonAdd;
        private Button buttonSubtract;
        private Button buttonMultiply;
        private Button buttonDivide;
        private Button buttonBackspace;
        private Button buttonClear;
        private Button buttonEqual;
        private Button buttonRevert;
        private Button buttonOpen;
        private Button buttonClose;
    }
}
