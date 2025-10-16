using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
namespace Digital_Notes_Manager_App
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Loginbt_MouseHover(object sender, EventArgs e)
        {
        }

        private void loginbt_Click(object sender, EventArgs e)
        {
            Log loginForm = new Log();
            loginForm.Show();
           // this.Hide();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //private void pictureBox3_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

        private void signupbt_Click(object sender, EventArgs e)
        {
            SignUp signupForm = new SignUp();
            signupForm.Show();
            this.Show();
        }

        private void closeApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
