namespace Digital_Notes_Manager_App
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            textBoxConfirmPassword = new TextBox();
            button1 = new Button();
            textBoxPassword = new TextBox();
            textBoxUserName = new TextBox();
            pictureBox2 = new PictureBox();
            closeApp = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeApp).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(431, 523);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(textBoxConfirmPassword);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxUserName);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(460, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(404, 442);
            panel1.TabIndex = 1;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.RoyalBlue;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.White;
            linkLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = Color.White;
            linkLabel1.LinkColor = Color.SkyBlue;
            linkLabel1.Location = new Point(104, 401);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(177, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already have an accout?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Location = new Point(56, 265);
            textBoxConfirmPassword.Multiline = true;
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(302, 29);
            textBoxConfirmPassword.TabIndex = 7;
            textBoxConfirmPassword.Text = "Confirm Password";
            // 
            // button1
            // 
            button1.BackColor = Color.SkyBlue;
            button1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(86, 340);
            button1.Name = "button1";
            button1.Size = new Size(213, 42);
            button1.TabIndex = 6;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(56, 198);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(302, 29);
            textBoxPassword.TabIndex = 5;
            textBoxPassword.Text = "Password";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(56, 139);
            textBoxUserName.Multiline = true;
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(302, 29);
            textBoxUserName.TabIndex = 4;
            textBoxUserName.Text = "User Name";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(131, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(142, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // closeApp
            // 
            closeApp.BackColor = Color.SkyBlue;
            closeApp.Image = (Image)resources.GetObject("closeApp.Image");
            closeApp.Location = new Point(860, 10);
            closeApp.Name = "closeApp";
            closeApp.Size = new Size(36, 26);
            closeApp.SizeMode = PictureBoxSizeMode.Zoom;
            closeApp.TabIndex = 6;
            closeApp.TabStop = false;
            closeApp.Click += closeApp_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(908, 520);
            Controls.Add(closeApp);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUp";
            Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeApp).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button button1;
        private TextBox textBoxPassword;
        private TextBox textBoxUserName;
        private TextBox textBoxConfirmPassword;
        private PictureBox closeApp;
        private LinkLabel linkLabel1;
    }
}