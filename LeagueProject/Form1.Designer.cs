namespace LeagueProject
{
    partial class HomePage
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
            nameTextbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            DataBox = new GroupBox();
            statusBox = new TextBox();
            label9 = new Label();
            WinRateBox = new TextBox();
            label3 = new Label();
            RankBox = new TextBox();
            LevelBox = new TextBox();
            getDataButton = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            flexToggleButton = new Button();
            sdToggleButton = new Button();
            DataBox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // nameTextbox
            // 
            nameTextbox.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point);
            nameTextbox.ForeColor = Color.Turquoise;
            nameTextbox.Location = new Point(187, 36);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(155, 30);
            nameTextbox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(4, 26);
            label1.Name = "label1";
            label1.Size = new Size(55, 22);
            label1.TabIndex = 1;
            label1.Text = "Level";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 59);
            label2.Name = "label2";
            label2.Size = new Size(50, 22);
            label2.TabIndex = 2;
            label2.Text = "Rank";
            // 
            // DataBox
            // 
            DataBox.BackColor = Color.Transparent;
            DataBox.Controls.Add(sdToggleButton);
            DataBox.Controls.Add(flexToggleButton);
            DataBox.Controls.Add(statusBox);
            DataBox.Controls.Add(label9);
            DataBox.Controls.Add(WinRateBox);
            DataBox.Controls.Add(label3);
            DataBox.Controls.Add(RankBox);
            DataBox.Controls.Add(LevelBox);
            DataBox.Controls.Add(label1);
            DataBox.Controls.Add(label2);
            DataBox.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            DataBox.Location = new Point(187, 80);
            DataBox.Name = "DataBox";
            DataBox.Size = new Size(589, 205);
            DataBox.TabIndex = 4;
            DataBox.TabStop = false;
            DataBox.Text = "Data";
            // 
            // statusBox
            // 
            statusBox.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point);
            statusBox.ForeColor = Color.Turquoise;
            statusBox.Location = new Point(350, 47);
            statusBox.Name = "statusBox";
            statusBox.ReadOnly = true;
            statusBox.Size = new Size(239, 30);
            statusBox.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(255, 51);
            label9.Name = "label9";
            label9.Size = new Size(57, 22);
            label9.TabIndex = 9;
            label9.Text = "Status";
            // 
            // WinRateBox
            // 
            WinRateBox.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point);
            WinRateBox.ForeColor = Color.Turquoise;
            WinRateBox.Location = new Point(84, 91);
            WinRateBox.Name = "WinRateBox";
            WinRateBox.ReadOnly = true;
            WinRateBox.Size = new Size(143, 30);
            WinRateBox.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 95);
            label3.Name = "label3";
            label3.Size = new Size(78, 22);
            label3.TabIndex = 7;
            label3.Text = "WinRate";
            // 
            // RankBox
            // 
            RankBox.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point);
            RankBox.ForeColor = Color.Turquoise;
            RankBox.Location = new Point(84, 55);
            RankBox.Name = "RankBox";
            RankBox.ReadOnly = true;
            RankBox.Size = new Size(143, 30);
            RankBox.TabIndex = 6;
            // 
            // LevelBox
            // 
            LevelBox.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point);
            LevelBox.ForeColor = Color.Turquoise;
            LevelBox.Location = new Point(84, 22);
            LevelBox.Name = "LevelBox";
            LevelBox.ReadOnly = true;
            LevelBox.Size = new Size(143, 30);
            LevelBox.TabIndex = 5;
            // 
            // getDataButton
            // 
            getDataButton.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            getDataButton.Location = new Point(376, 34);
            getDataButton.Name = "getDataButton";
            getDataButton.Size = new Size(75, 34);
            getDataButton.TabIndex = 9;
            getDataButton.Text = "Get";
            getDataButton.UseVisualStyleBackColor = true;
            getDataButton.Click += getDataButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(DataBox);
            groupBox1.Controls.Add(getDataButton);
            groupBox1.Controls.Add(nameTextbox);
            groupBox1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(791, 436);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "League";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(57, 36);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 9;
            label4.Text = "Player";
            // 
            // flexToggleButton
            // 
            flexToggleButton.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            flexToggleButton.Location = new Point(83, 139);
            flexToggleButton.Name = "flexToggleButton";
            flexToggleButton.Size = new Size(72, 31);
            flexToggleButton.TabIndex = 10;
            flexToggleButton.Text = "Flex";
            flexToggleButton.UseVisualStyleBackColor = true;
            flexToggleButton.Click += flexToggleButton_Click;
            // 
            // sdToggleButton
            // 
            sdToggleButton.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            sdToggleButton.Location = new Point(161, 139);
            sdToggleButton.Name = "sdToggleButton";
            sdToggleButton.Size = new Size(72, 31);
            sdToggleButton.TabIndex = 11;
            sdToggleButton.Text = "S/D";
            sdToggleButton.UseVisualStyleBackColor = true;
            sdToggleButton.Click += sdToggleButton_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "HomePage";
            Text = "League";
            Load += HomePage_Load;
            DataBox.ResumeLayout(false);
            DataBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox nameTextbox;
        private TextBox RankBox;
        private Label label2;
        private GroupBox DataBox;
        private TextBox LevelBox;
        private TextBox WinRateBox;
        private Label label3;
        private Button getDataButton;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox statusBox;
        private Label label9;
        private Button sdToggleButton;
        private Button flexToggleButton;
    }
}