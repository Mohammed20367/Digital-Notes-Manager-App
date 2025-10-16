using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Digital_Notes_Manager_App
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Email Placeholder
            textBoxUserName.Height = 35;
            textBoxUserName.Text = "User Name";
            textBoxUserName.ForeColor = Color.Gray;
            textBoxUserName.GotFocus += RemoveTextEmail;
            textBoxUserName.LostFocus += AddTextEmail;

            // Password Placeholder
            textBoxPassword.Height = 35;
            textBoxPassword.Text = "Password";
            textBoxPassword.ForeColor = Color.Gray;
            textBoxPassword.UseSystemPasswordChar = false;
            textBoxPassword.GotFocus += RemoveTextPassword;
            textBoxPassword.LostFocus += AddTextPassword;
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e) { }

        public void RemoveTextEmail(object? sender, EventArgs e)
        {
            if (textBoxUserName.Text == "User Name")
            {
                textBoxUserName.Text = "";
                textBoxUserName.ForeColor = Color.Black;
            }
        }

        public void AddTextEmail(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUserName.Text))
            {
                textBoxUserName.Text = "User Name";
                textBoxUserName.ForeColor = Color.Gray;
            }
        }

        // Password Events
        public void RemoveTextPassword(object? sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Black;
                textBoxPassword.UseSystemPasswordChar = true; // يكتب نجوم
            }
        }

        public void AddTextPassword(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                textBoxPassword.UseSystemPasswordChar = false; // يظهر Placeholder
                textBoxPassword.Text = "Password";
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void closeApp_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginbt_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text.Trim();
            string password = textBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter user name");
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter password");
                return;
            }

            using (var context = AppContextManager.CreateContext())
            {
                
                var user = context.Users
                    .FirstOrDefault(u => u.Username == username && u.UserPassword == password);

                if (user != null)
                {
                    
                    AppContextManager.loginuser = user.Username;
                    AppContextManager.LoginUserId = user.UserId;
                    Main main = new Main();
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
        }

        private void closeApp_Click_1(object sender, EventArgs e)
        {
          Close();
        }
    }
}
