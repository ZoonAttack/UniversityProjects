namespace ChatApplication.Client
{
    partial class ClientHomePage
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
            label1 = new Label();
            BTN_Connect = new Button();
            GB_ChatBox = new GroupBox();
            TB_ChatBox = new TextBox();
            TB_MessageBox = new TextBox();
            BTN_SendMessage = new Button();
            TB_PortNumber = new TextBox();
            label2 = new Label();
            TB_HostAddress = new TextBox();
            LB_connectionStatus = new Label();
            label3 = new Label();
            TB_Username = new TextBox();
            GB_ChatBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.CadetBlue;
            label1.Location = new Point(225, 9);
            label1.Name = "label1";
            label1.Size = new Size(72, 37);
            label1.TabIndex = 0;
            label1.Text = "Host";
            // 
            // BTN_Connect
            // 
            BTN_Connect.FlatAppearance.BorderSize = 3;
            BTN_Connect.FlatStyle = FlatStyle.Popup;
            BTN_Connect.Font = new Font("Times New Roman", 13F, FontStyle.Bold, GraphicsUnit.Point);
            BTN_Connect.ForeColor = Color.DarkCyan;
            BTN_Connect.Location = new Point(680, 40);
            BTN_Connect.Name = "BTN_Connect";
            BTN_Connect.Size = new Size(108, 35);
            BTN_Connect.TabIndex = 1;
            BTN_Connect.Text = "CONNECT";
            BTN_Connect.UseVisualStyleBackColor = true;
            BTN_Connect.Click += BTN_Connect_Click;
            // 
            // GB_ChatBox
            // 
            GB_ChatBox.Controls.Add(TB_ChatBox);
            GB_ChatBox.Controls.Add(TB_MessageBox);
            GB_ChatBox.Controls.Add(BTN_SendMessage);
            GB_ChatBox.Font = new Font("OCRB", 15F, FontStyle.Bold, GraphicsUnit.Point);
            GB_ChatBox.ForeColor = Color.CadetBlue;
            GB_ChatBox.Location = new Point(135, 90);
            GB_ChatBox.Name = "GB_ChatBox";
            GB_ChatBox.Size = new Size(664, 361);
            GB_ChatBox.TabIndex = 2;
            GB_ChatBox.TabStop = false;
            GB_ChatBox.Text = "ChatBox";
            // 
            // TB_ChatBox
            // 
            TB_ChatBox.BackColor = Color.White;
            TB_ChatBox.Font = new Font("OCRB", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TB_ChatBox.ForeColor = SystemColors.WindowText;
            TB_ChatBox.Location = new Point(0, 25);
            TB_ChatBox.Multiline = true;
            TB_ChatBox.Name = "TB_ChatBox";
            TB_ChatBox.ReadOnly = true;
            TB_ChatBox.Size = new Size(544, 266);
            TB_ChatBox.TabIndex = 10;
            TB_ChatBox.TextChanged += TB_ChatBox_TextChanged;
            // 
            // TB_MessageBox
            // 
            TB_MessageBox.BackColor = Color.White;
            TB_MessageBox.ForeColor = SystemColors.WindowText;
            TB_MessageBox.Location = new Point(0, 297);
            TB_MessageBox.Multiline = true;
            TB_MessageBox.Name = "TB_MessageBox";
            TB_MessageBox.Size = new Size(544, 58);
            TB_MessageBox.TabIndex = 9;
            TB_MessageBox.TextChanged += TB_MessageBox_TextChanged;
            TB_MessageBox.KeyDown += TB_MessageBox_KeyDown;
            // 
            // BTN_SendMessage
            // 
            BTN_SendMessage.FlatAppearance.BorderSize = 3;
            BTN_SendMessage.FlatStyle = FlatStyle.Popup;
            BTN_SendMessage.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point);
            BTN_SendMessage.ForeColor = Color.DarkCyan;
            BTN_SendMessage.Location = new Point(550, 313);
            BTN_SendMessage.Name = "BTN_SendMessage";
            BTN_SendMessage.Size = new Size(108, 35);
            BTN_SendMessage.TabIndex = 7;
            BTN_SendMessage.Text = "SEND";
            BTN_SendMessage.UseVisualStyleBackColor = true;
            BTN_SendMessage.Click += BTN_SendMessage_Click;
            // 
            // TB_PortNumber
            // 
            TB_PortNumber.Location = new Point(467, 49);
            TB_PortNumber.Name = "TB_PortNumber";
            TB_PortNumber.Size = new Size(149, 23);
            TB_PortNumber.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.CadetBlue;
            label2.Location = new Point(505, 9);
            label2.Name = "label2";
            label2.Size = new Size(65, 37);
            label2.TabIndex = 5;
            label2.Text = "Port";
            // 
            // TB_HostAddress
            // 
            TB_HostAddress.Location = new Point(188, 49);
            TB_HostAddress.Name = "TB_HostAddress";
            TB_HostAddress.Size = new Size(149, 23);
            TB_HostAddress.TabIndex = 6;
            // 
            // LB_connectionStatus
            // 
            LB_connectionStatus.AutoSize = true;
            LB_connectionStatus.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LB_connectionStatus.Location = new Point(701, 14);
            LB_connectionStatus.Name = "LB_connectionStatus";
            LB_connectionStatus.Size = new Size(63, 15);
            LB_connectionStatus.TabIndex = 9;
            LB_connectionStatus.Text = "Connected";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.CadetBlue;
            label3.Location = new Point(25, 14);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 11;
            label3.Text = "Username";
            // 
            // TB_Username
            // 
            TB_Username.Location = new Point(3, 48);
            TB_Username.Name = "TB_Username";
            TB_Username.Size = new Size(149, 23);
            TB_Username.TabIndex = 12;
            // 
            // ClientHomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TB_Username);
            Controls.Add(label3);
            Controls.Add(LB_connectionStatus);
            Controls.Add(TB_HostAddress);
            Controls.Add(label2);
            Controls.Add(TB_PortNumber);
            Controls.Add(GB_ChatBox);
            Controls.Add(BTN_Connect);
            Controls.Add(label1);
            Name = "ClientHomePage";
            Text = "ClientHomePage";
            FormClosed += ClientHomePage_FormClosed;
            GB_ChatBox.ResumeLayout(false);
            GB_ChatBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BTN_Connect;
        private GroupBox GB_ChatBox;
        private TextBox TB_PortNumber;
        private Label label2;
        private TextBox TB_HostAddress;
        private Button BTN_SendMessage;
        private TextBox TB_MessageBox;
        public TextBox TB_ChatBox;
        private Label LB_connectionStatus;
        private Label label3;
        private TextBox TB_Username;
    }
}