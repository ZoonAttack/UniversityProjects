namespace ChatApplication.Server
{
    partial class ServerHomePage
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
            BTN_ServerStart = new Button();
            SuspendLayout();
            // 
            // BTN_ServerStart
            // 
            BTN_ServerStart.FlatAppearance.BorderSize = 3;
            BTN_ServerStart.FlatStyle = FlatStyle.Popup;
            BTN_ServerStart.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point);
            BTN_ServerStart.ForeColor = Color.DarkCyan;
            BTN_ServerStart.Location = new Point(348, 208);
            BTN_ServerStart.Name = "BTN_ServerStart";
            BTN_ServerStart.Size = new Size(108, 35);
            BTN_ServerStart.TabIndex = 12;
            BTN_ServerStart.Text = "START";
            BTN_ServerStart.UseVisualStyleBackColor = true;
            BTN_ServerStart.Click += BTN_ServerStart_Click;
            // 
            // ServerHomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTN_ServerStart);
            Name = "ServerHomePage";
            Text = "ServerHomePage";
            FormClosed += ServerHomePage_FormClosed;
            ResumeLayout(false);
        }

        #endregion
        private Button BTN_ServerStart;
    }
}