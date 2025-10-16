namespace Digital_Notes_Manager_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            loginbt = new Button();
            signupbt = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Minimize = new PictureBox();
            closeApp = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeApp).BeginInit();
            SuspendLayout();
            // 
            // loginbt
            // 
            loginbt.BackColor = Color.SkyBlue;
            loginbt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbt.ForeColor = Color.White;
            loginbt.Location = new Point(285, 25);
            loginbt.Margin = new Padding(0);
            loginbt.Name = "loginbt";
            loginbt.Size = new Size(120, 40);
            loginbt.TabIndex = 6;
            loginbt.Text = "Login";
            loginbt.UseVisualStyleBackColor = false;
            loginbt.Click += loginbt_Click;
            // 
            // signupbt
            // 
            signupbt.BackColor = Color.White;
            signupbt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signupbt.ForeColor = Color.DodgerBlue;
            signupbt.Location = new Point(429, 25);
            signupbt.Name = "signupbt";
            signupbt.Size = new Size(120, 40);
            signupbt.TabIndex = 5;
            signupbt.Text = "Sign Up";
            signupbt.UseVisualStyleBackColor = false;
            signupbt.Click += signupbt_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(signupbt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(loginbt);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(148, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(564, 317);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(158, 83);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 0);
            label2.Location = new Point(87, 191);
            label2.Name = "label2";
            label2.Size = new Size(429, 19);
            label2.TabIndex = 3;
            label2.Text = "Your smart and simple way to organize and manage notes";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.InactiveCaptionText;
            label1.Location = new Point(96, 103);
            label1.Name = "label1";
            label1.Size = new Size(403, 50);
            label1.TabIndex = 2;
            label1.Text = "Welcome to NoteEase";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-30, -3);
            pictureBox1.MaximumSize = new Size(915, 456);
            pictureBox1.MinimumSize = new Size(915, 456);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(915, 456);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Minimize
            // 
            Minimize.BackColor = Color.SkyBlue;
            Minimize.Image = (Image)resources.GetObject("Minimize.Image");
            Minimize.Location = new Point(784, 12);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(33, 26);
            Minimize.SizeMode = PictureBoxSizeMode.Zoom;
            Minimize.TabIndex = 3;
            Minimize.TabStop = false;
            Minimize.Click += Minimize_Click;
            // 
            // closeApp
            // 
            closeApp.BackColor = Color.SkyBlue;
            closeApp.Image = (Image)resources.GetObject("closeApp.Image");
            closeApp.Location = new Point(833, 12);
            closeApp.Name = "closeApp";
            closeApp.Size = new Size(36, 26);
            closeApp.SizeMode = PictureBoxSizeMode.Zoom;
            closeApp.TabIndex = 4;
            closeApp.TabStop = false;
            closeApp.Click += closeApp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(881, 450);
            Controls.Add(closeApp);
            Controls.Add(Minimize);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Digital Notes Manager";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeApp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button signupbt;
        private Button loginbt;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox Minimize;
        private PictureBox closeApp;
    }
}
