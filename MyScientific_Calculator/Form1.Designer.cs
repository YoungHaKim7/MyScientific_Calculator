namespace MyScientific_Calculator
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
            label1 = new Label();
            txtResult = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtResultHex = new TextBox();
            txtResultBinary = new TextBox();
            txtResultOct = new TextBox();
            btnBS = new Button();
            btnClearEntry = new Button();
            btnClear = new Button();
            btnPM = new Button();
            button5 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnMult = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            button13 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnDiv = new Button();
            btnEquals = new Button();
            btnDot = new Button();
            btn0 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("BatangChe", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 120);
            label1.Name = "label1";
            label1.Size = new Size(86, 19);
            label1.TabIndex = 0;
            label1.Text = "10_Deci";
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtResult.Location = new Point(104, 108);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(510, 35);
            txtResult.TabIndex = 1;
            txtResult.Text = "0";
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("BatangChe", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(23, 76);
            label3.Name = "label3";
            label3.Size = new Size(75, 19);
            label3.TabIndex = 3;
            label3.Text = "16_Hex";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("BatangChe", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(34, 41);
            label2.Name = "label2";
            label2.Size = new Size(64, 19);
            label2.TabIndex = 4;
            label2.Text = "8_Oct";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("BatangChe", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(23, 6);
            label4.Name = "label4";
            label4.Size = new Size(75, 19);
            label4.TabIndex = 5;
            label4.Text = "2_Bina";
            // 
            // txtResultHex
            // 
            txtResultHex.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtResultHex.Location = new Point(104, 69);
            txtResultHex.Name = "txtResultHex";
            txtResultHex.Size = new Size(510, 33);
            txtResultHex.TabIndex = 6;
            txtResultHex.TextAlign = HorizontalAlignment.Right;
            // 
            // txtResultBinary
            // 
            txtResultBinary.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtResultBinary.Location = new Point(104, 2);
            txtResultBinary.Name = "txtResultBinary";
            txtResultBinary.Size = new Size(510, 29);
            txtResultBinary.TabIndex = 7;
            txtResultBinary.TextAlign = HorizontalAlignment.Right;
            // 
            // txtResultOct
            // 
            txtResultOct.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtResultOct.Location = new Point(104, 37);
            txtResultOct.Name = "txtResultOct";
            txtResultOct.Size = new Size(510, 29);
            txtResultOct.TabIndex = 8;
            txtResultOct.TextAlign = HorizontalAlignment.Right;
            // 
            // btnBS
            // 
            btnBS.Font = new Font("DotumChe", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnBS.Location = new Point(23, 149);
            btnBS.Name = "btnBS";
            btnBS.Size = new Size(75, 66);
            btnBS.TabIndex = 9;
            btnBS.Text = "⌫";
            btnBS.UseVisualStyleBackColor = true;
            btnBS.Click += btnBS_Click;
            // 
            // btnClearEntry
            // 
            btnClearEntry.Font = new Font("DotumChe", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearEntry.Location = new Point(104, 149);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(75, 66);
            btnClearEntry.TabIndex = 10;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = true;
            btnClearEntry.Click += btnClearEntry_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("DotumChe", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(185, 149);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 66);
            btnClear.TabIndex = 11;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnPM
            // 
            btnPM.Font = new Font("DotumChe", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnPM.Location = new Point(266, 149);
            btnPM.Name = "btnPM";
            btnPM.Size = new Size(75, 66);
            btnPM.TabIndex = 12;
            btnPM.Text = "±";
            btnPM.UseVisualStyleBackColor = true;
            btnPM.Click += btnPM_Click;
            // 
            // button5
            // 
            button5.Font = new Font("DotumChe", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(266, 221);
            button5.Name = "button5";
            button5.Size = new Size(75, 66);
            button5.TabIndex = 16;
            button5.Text = "+";
            button5.UseVisualStyleBackColor = true;
            button5.Click += numberOper;
            // 
            // btn9
            // 
            btn9.Font = new Font("DotumChe", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(185, 221);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 66);
            btn9.TabIndex = 15;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += EnterNumbers;
            // 
            // btn8
            // 
            btn8.Font = new Font("DotumChe", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(104, 221);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 66);
            btn8.TabIndex = 14;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += EnterNumbers;
            // 
            // btn7
            // 
            btn7.Font = new Font("DotumChe", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(23, 221);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 66);
            btn7.TabIndex = 13;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += EnterNumbers;
            // 
            // btnMult
            // 
            btnMult.Font = new Font("DotumChe", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnMult.Location = new Point(266, 365);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(75, 66);
            btnMult.TabIndex = 24;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += numberOper;
            // 
            // btn3
            // 
            btn3.Font = new Font("DotumChe", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(185, 365);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 66);
            btn3.TabIndex = 23;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += EnterNumbers;
            // 
            // btn2
            // 
            btn2.Font = new Font("DotumChe", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(104, 365);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 66);
            btn2.TabIndex = 22;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += EnterNumbers;
            // 
            // btn1
            // 
            btn1.Font = new Font("DotumChe", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(23, 365);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 66);
            btn1.TabIndex = 21;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += EnterNumbers;
            // 
            // button13
            // 
            button13.Font = new Font("DotumChe", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button13.Location = new Point(266, 293);
            button13.Name = "button13";
            button13.Size = new Size(75, 66);
            button13.TabIndex = 20;
            button13.Text = "-";
            button13.UseVisualStyleBackColor = true;
            button13.Click += numberOper;
            // 
            // btn6
            // 
            btn6.Font = new Font("DotumChe", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(185, 293);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 66);
            btn6.TabIndex = 19;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += EnterNumbers;
            // 
            // btn5
            // 
            btn5.Font = new Font("DotumChe", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(104, 293);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 66);
            btn5.TabIndex = 18;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += EnterNumbers;
            // 
            // btn4
            // 
            btn4.Font = new Font("DotumChe", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(23, 293);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 66);
            btn4.TabIndex = 17;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += EnterNumbers;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("DotumChe", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiv.Location = new Point(266, 437);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(75, 66);
            btnDiv.TabIndex = 28;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += numberOper;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("DotumChe", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnEquals.Location = new Point(185, 437);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(75, 66);
            btnEquals.TabIndex = 27;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("DotumChe", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDot.Location = new Point(104, 437);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(75, 66);
            btnDot.TabIndex = 26;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += EnterNumbers;
            // 
            // btn0
            // 
            btn0.Font = new Font("DotumChe", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(23, 437);
            btn0.Name = "btn0";
            btn0.Size = new Size(75, 66);
            btn0.TabIndex = 25;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += EnterNumbers;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 511);
            Controls.Add(btnDiv);
            Controls.Add(btnEquals);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btnMult);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(button13);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(button5);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnPM);
            Controls.Add(btnClear);
            Controls.Add(btnClearEntry);
            Controls.Add(btnBS);
            Controls.Add(txtResultOct);
            Controls.Add(txtResultBinary);
            Controls.Add(txtResultHex);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txtResult);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtResult;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox txtResultHex;
        private TextBox txtResultBinary;
        private TextBox txtResultOct;
        private Button btnBS;
        private Button btnClearEntry;
        private Button btnClear;
        private Button btnPM;
        private Button button5;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnMult;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button button13;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnDiv;
        private Button btnEquals;
        private Button btnDot;
        private Button btn0;
    }
}