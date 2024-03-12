namespace Calculator
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
            this.IoBox = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Substract = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Equals = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.History = new System.Windows.Forms.TextBox();
            this.Modulus = new System.Windows.Forms.Button();
            this.Factorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IoBox
            // 
            this.IoBox.BackColor = System.Drawing.Color.CornflowerBlue;
            this.IoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IoBox.ForeColor = System.Drawing.SystemColors.Info;
            this.IoBox.Location = new System.Drawing.Point(12, 12);
            this.IoBox.Multiline = true;
            this.IoBox.Name = "IoBox";
            this.IoBox.Size = new System.Drawing.Size(326, 98);
            this.IoBox.TabIndex = 0;
            this.IoBox.TextChanged += new System.EventHandler(this.IoBox_TextChanged);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.Menu;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Add.Location = new System.Drawing.Point(22, 141);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(57, 50);
            this.Add.TabIndex = 1;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Substract
            // 
            this.Substract.BackColor = System.Drawing.SystemColors.Menu;
            this.Substract.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Substract.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Substract.Location = new System.Drawing.Point(122, 141);
            this.Substract.Name = "Substract";
            this.Substract.Size = new System.Drawing.Size(57, 50);
            this.Substract.TabIndex = 2;
            this.Substract.Text = "-";
            this.Substract.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Substract.UseVisualStyleBackColor = false;
            this.Substract.Click += new System.EventHandler(this.Substract_Click);
            // 
            // Multiply
            // 
            this.Multiply.BackColor = System.Drawing.SystemColors.Menu;
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiply.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Multiply.Location = new System.Drawing.Point(22, 227);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(57, 50);
            this.Multiply.TabIndex = 3;
            this.Multiply.Text = "X";
            this.Multiply.UseVisualStyleBackColor = false;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.SystemColors.Menu;
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Divide.Location = new System.Drawing.Point(122, 227);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(57, 50);
            this.Divide.TabIndex = 4;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = false;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // One
            // 
            this.One.BackColor = System.Drawing.SystemColors.Menu;
            this.One.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.One.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.One.Location = new System.Drawing.Point(246, 141);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(57, 50);
            this.One.TabIndex = 5;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = false;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Two
            // 
            this.Two.BackColor = System.Drawing.SystemColors.Menu;
            this.Two.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Two.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Two.Location = new System.Drawing.Point(350, 141);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(57, 50);
            this.Two.TabIndex = 6;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = false;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // Three
            // 
            this.Three.BackColor = System.Drawing.SystemColors.Menu;
            this.Three.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Three.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Three.Location = new System.Drawing.Point(457, 141);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(57, 50);
            this.Three.TabIndex = 7;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = false;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Four
            // 
            this.Four.BackColor = System.Drawing.SystemColors.Menu;
            this.Four.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Four.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Four.Location = new System.Drawing.Point(246, 227);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(57, 50);
            this.Four.TabIndex = 8;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = false;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Five
            // 
            this.Five.BackColor = System.Drawing.SystemColors.Menu;
            this.Five.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Five.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Five.Location = new System.Drawing.Point(350, 227);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(57, 50);
            this.Five.TabIndex = 9;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = false;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Six
            // 
            this.Six.BackColor = System.Drawing.SystemColors.Menu;
            this.Six.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Six.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Six.Location = new System.Drawing.Point(457, 227);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(57, 50);
            this.Six.TabIndex = 10;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = false;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Seven
            // 
            this.Seven.BackColor = System.Drawing.SystemColors.Menu;
            this.Seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seven.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Seven.Location = new System.Drawing.Point(246, 307);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(57, 50);
            this.Seven.TabIndex = 11;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = false;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Eight
            // 
            this.Eight.BackColor = System.Drawing.SystemColors.Menu;
            this.Eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eight.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Eight.Location = new System.Drawing.Point(350, 307);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(57, 50);
            this.Eight.TabIndex = 12;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = false;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Nine
            // 
            this.Nine.BackColor = System.Drawing.SystemColors.Menu;
            this.Nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nine.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Nine.Location = new System.Drawing.Point(457, 307);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(57, 50);
            this.Nine.TabIndex = 13;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = false;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Zero
            // 
            this.Zero.BackColor = System.Drawing.SystemColors.Menu;
            this.Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zero.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Zero.Location = new System.Drawing.Point(350, 388);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(57, 50);
            this.Zero.TabIndex = 14;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = false;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Equals
            // 
            this.Equals.BackColor = System.Drawing.SystemColors.Menu;
            this.Equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equals.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Equals.Location = new System.Drawing.Point(457, 388);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(57, 50);
            this.Equals.TabIndex = 15;
            this.Equals.Text = "=";
            this.Equals.UseVisualStyleBackColor = false;
            this.Equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.Menu;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Clear.Location = new System.Drawing.Point(246, 388);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(57, 50);
            this.Clear.TabIndex = 16;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(6, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Calculator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // History
            // 
            this.History.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.History.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.History.ForeColor = System.Drawing.SystemColors.Window;
            this.History.Location = new System.Drawing.Point(394, 43);
            this.History.Multiline = true;
            this.History.Name = "History";
            this.History.ReadOnly = true;
            this.History.Size = new System.Drawing.Size(120, 67);
            this.History.TabIndex = 18;
            this.History.TextChanged += new System.EventHandler(this.History_TextChanged);
            // 
            // Modulus
            // 
            this.Modulus.BackColor = System.Drawing.SystemColors.Menu;
            this.Modulus.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modulus.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Modulus.Location = new System.Drawing.Point(22, 307);
            this.Modulus.Name = "Modulus";
            this.Modulus.Size = new System.Drawing.Size(57, 50);
            this.Modulus.TabIndex = 19;
            this.Modulus.Text = "%";
            this.Modulus.UseVisualStyleBackColor = false;
            this.Modulus.Click += new System.EventHandler(this.Modulus_Click);
            // 
            // Factorial
            // 
            this.Factorial.BackColor = System.Drawing.SystemColors.Menu;
            this.Factorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Factorial.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Factorial.Location = new System.Drawing.Point(122, 307);
            this.Factorial.Name = "Factorial";
            this.Factorial.Size = new System.Drawing.Size(57, 50);
            this.Factorial.TabIndex = 20;
            this.Factorial.Text = "!";
            this.Factorial.UseVisualStyleBackColor = false;
            this.Factorial.Click += new System.EventHandler(this.Factorial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(518, 446);
            this.Controls.Add(this.Factorial);
            this.Controls.Add(this.Modulus);
            this.Controls.Add(this.History);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Equals);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Substract);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.IoBox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IoBox;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Substract;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Zero;
        private new System.Windows.Forms.Button Equals;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox History;
        private System.Windows.Forms.Button Modulus;
        private System.Windows.Forms.Button Factorial;
    }
}

