using Digital_Notes_Manager_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Notes_Manager_App
{
    public partial class SignUp : Form
    {
        public SignUp()
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

            textBoxConfirmPassword.Height = 35;
            textBoxConfirmPassword.Text = "Password";
            textBoxConfirmPassword.ForeColor = Color.Gray;
            textBoxConfirmPassword.UseSystemPasswordChar = false; 
            textBoxConfirmPassword.GotFocus += RemoveTexConfirmtPassword;
            textBoxConfirmPassword.LostFocus += AddTextConfirmPassword;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        // Email Events
        public void RemoveTextEmail(object sender, EventArgs e)
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
        public void RemoveTextPassword(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Black;
                textBoxPassword.UseSystemPasswordChar = true; 
            }
        }
        public void AddTextPassword(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                textBoxPassword.UseSystemPasswordChar = false; 
                textBoxPassword.Text = "Password";
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        //Confirm
        public void RemoveTexConfirmtPassword(object sender, EventArgs e)
        {
            if (textBoxConfirmPassword.Text == "Password")
            {
                textBoxConfirmPassword.Text = "";
                textBoxConfirmPassword.ForeColor = Color.Black;
                textBoxConfirmPassword.UseSystemPasswordChar = true; 
            }
        }
        public void AddTextConfirmPassword(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxConfirmPassword.Text))
            {
                textBoxConfirmPassword.UseSystemPasswordChar = false; 
                textBoxConfirmPassword.Text = "Password";
                textBoxConfirmPassword.ForeColor = Color.Gray;
            }
        }

        private void closeApp_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != textBoxConfirmPassword.Text)
            {
                MessageBox.Show("Invalid Password");
            }
            else
            {
                User username = new User()
                {
                    Username = textBoxUserName.Text,
                    UserPassword = textBoxPassword.Text
                };

                using (var context = AppContextManager.CreateContext())
                {
                    context.Users.Add(username);
                    context.SaveChanges();
                }

                MessageBox.Show("Sign up is Success");
                this.Hide();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Log form = new Log();
            form.ShowDialog();
        }
    }
}
