namespace Digital_Notes_Manager_App
{
    partial class Log
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log));
            BackgroungLog = new PictureBox();
            loginPanel = new Panel();
            loginbt = new Button();
            textBoxPassword = new TextBox();
            textBoxUserName = new TextBox();
            pictureBox1 = new PictureBox();
            closeApp = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)BackgroungLog).BeginInit();
            loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeApp).BeginInit();
            SuspendLayout();
            // 
            // BackgroungLog
            // 
            BackgroungLog.Image = (Image)resources.GetObject("BackgroungLog.Image");
            BackgroungLog.Location = new Point(1, -2);
            BackgroungLog.Name = "BackgroungLog";
            BackgroungLog.Size = new Size(428, 553);
            BackgroungLog.TabIndex = 0;
            BackgroungLog.TabStop = false;
            // 
            // loginPanel
            // 
            loginPanel.BackColor = SystemColors.ButtonHighlight;
            loginPanel.Controls.Add(loginbt);
            loginPanel.Controls.Add(textBoxPassword);
            loginPanel.Controls.Add(textBoxUserName);
            loginPanel.Controls.Add(pictureBox1);
            loginPanel.Location = new Point(25, 49);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(375, 440);
            loginPanel.TabIndex = 1;
            // 
            // loginbt
            // 
            loginbt.BackColor = Color.SkyBlue;
            loginbt.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbt.ForeColor = Color.White;
            loginbt.Location = new Point(72, 350);
            loginbt.Name = "loginbt";
            loginbt.Size = new Size(213, 42);
            loginbt.TabIndex = 6;
            loginbt.Text = "Log in";
            loginbt.UseVisualStyleBackColor = false;
            loginbt.Click += loginbt_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(51, 261);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(280, 29);
            textBoxPassword.TabIndex = 5;
            textBoxPassword.Text = "Password";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(51, 185);
            textBoxUserName.Multiline = true;
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(280, 29);
            textBoxUserName.TabIndex = 4;
            textBoxUserName.Text = "User Name";
            textBoxUserName.TextChanged += textBoxUserName_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(72, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // closeApp
            // 
            closeApp.BackColor = Color.SkyBlue;
            closeApp.Image = (Image)resources.GetObject("closeApp.Image");
            closeApp.Location = new Point(388, 4);
            closeApp.Name = "closeApp";
            closeApp.Size = new Size(36, 26);
            closeApp.SizeMode = PictureBoxSizeMode.Zoom;
            closeApp.TabIndex = 5;
            closeApp.TabStop = false;
            closeApp.Click += closeApp_Click_1;
            // 
            // Log
            // 
            AcceptButton = loginbt;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = loginbt;
            ClientSize = new Size(429, 553);
            Controls.Add(closeApp);
            Controls.Add(loginPanel);
            Controls.Add(BackgroungLog);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Log";
            Text = "Log";
            ((System.ComponentModel.ISupportInitialize)BackgroungLog).EndInit();
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeApp).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox BackgroungLog;
        private Panel loginPanel;
        private PictureBox pictureBox1;
        private Button loginbt;
        private TextBox textBoxPassword;
        private TextBox textBoxUserName;
        private PictureBox closeApp;
    }
}