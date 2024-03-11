namespace ChatApplication
{
    partial class Home
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
            BTN_Server = new Button();
            BTN_Client = new Button();
            SuspendLayout();
            // 
            // BTN_Server
            // 
            BTN_Server.FlatAppearance.BorderColor = Color.Black;
            BTN_Server.FlatAppearance.BorderSize = 3;
            BTN_Server.FlatStyle = FlatStyle.Popup;
            BTN_Server.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            BTN_Server.ForeColor = Color.DarkCyan;
            BTN_Server.Location = new Point(246, 198);
            BTN_Server.Name = "BTN_Server";
            BTN_Server.Size = new Size(133, 53);
            BTN_Server.TabIndex = 10;
            BTN_Server.Text = "SERVER";
            BTN_Server.UseVisualStyleBackColor = true;
            BTN_Server.Click += BTN_Server_Click;
            // 
            // BTN_Client
            // 
            BTN_Client.FlatAppearance.BorderColor = Color.Black;
            BTN_Client.FlatAppearance.BorderSize = 3;
            BTN_Client.FlatStyle = FlatStyle.Popup;
            BTN_Client.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            BTN_Client.ForeColor = Color.DarkCyan;
            BTN_Client.Location = new Point(385, 198);
            BTN_Client.Name = "BTN_Client";
            BTN_Client.Size = new Size(133, 53);
            BTN_Client.TabIndex = 11;
            BTN_Client.Text = "CLIENT";
            BTN_Client.UseVisualStyleBackColor = true;
            BTN_Client.Click += BTN_Client_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTN_Client);
            Controls.Add(BTN_Server);
            Name = "Home";
            Text = "HomePage";
            ResumeLayout(false);
        }

        #endregion

        private Button BTN_Server;
        private Button BTN_Client;
    }
}