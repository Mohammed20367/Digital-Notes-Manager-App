using Digital_Notes_Manager_App.About;
using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Digital_Notes_Manager_App
{
    public partial class Main : Form
    {
        private Guna2Button activeButton;

        public Main()
        {
            InitializeComponent();

            StringHedar.Text = GetGreeting() + " " + AppContextManager.loginuser;
            StringHedar.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            StringHedar.ForeColor = Color.FromArgb(0, 120, 215);
            StringHedar.AutoSize = true;
            StringHedar.Location = new Point(25, 25);

            StringHedar2.Text = GetQuote();
            StringHedar2.Font = new Font("Segoe UI", 10, FontStyle.Italic);
            StringHedar2.ForeColor = Color.FromArgb(100, 100, 100);
            StringHedar2.AutoSize = true;
            StringHedar2.Location = new Point(StringHedar.Right + 10, 40);

            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is Log || openForm is Form1)
                {
                    openForm.Hide();
                }
            }

            ActivateButton(Dashboard);
            LoadPage(new DashboardPage(AppContextManager.LoginUserId));
        }

        private void ResetButtonStyles()
        {
            foreach (Control control in SideBar.Controls)
            {
                if (control is Guna2Button btn)
                {
                    btn.FillColor = Color.Transparent;
                    btn.ForeColor = Color.FromArgb(30, 60, 90);
                }
            }
        }

        private void ActivateButton(Guna2Button clickedButton)
        {
            ResetButtonStyles();
            clickedButton.FillColor = Color.FromArgb(179, 214, 255);
            clickedButton.ForeColor = Color.FromArgb(0, 80, 180);
            activeButton = clickedButton;
        }

        private void LoadPage(Control page)
        {
            if (page == null) return;

            if (page is Form frm)
            {
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
            }

            page.Dock = DockStyle.Fill;

            MainContainer.Controls.Clear();
            MainContainer.Controls.Add(page);
            page.BringToFront();

            if (page is Form formToShow)
            {
                formToShow.Show();
            }
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(Dashboard);
            LoadPage(new DashboardPage(AppContextManager.LoginUserId));
        }

        private void Notes_Click(object sender, EventArgs e)
        {
            ActivateButton(Notes);
            LoadPage(new NotesPage());
        }

        private void Categories_Click(object sender, EventArgs e)
        {
            ActivateButton(Categories);
            LoadPage(new CategoriesPage(AppContextManager.LoginUserId));
        }

        private void Reminders_Click(object sender, EventArgs e)
        {
            ActivateButton(Reminders);
            LoadPage(new RemindersPage(AppContextManager.LoginUserId));
        }

        private void Help_Click_1(object sender, EventArgs e)
        {
            ActivateButton(Help);
            LoadPage(new AboutForm());
        }

        private void logout_Click(object sender, EventArgs e)
        {
            AppContextManager.LoginUserId = 0;
            this.Hide();

            Form1 landingForm = Application.OpenForms["Form1"] as Form1;

            if (landingForm != null)
            {
                landingForm.Show();
            }
            else
            {
                Form1 newLanding = new Form1();
                newLanding.Show();
            }

            Log loginForm = new Log();
            loginForm.Show();
        }

        private string GetGreeting()
        {
            int currentHour = DateTime.Now.Hour;
            if (currentHour >= 5 && currentHour < 12)
                return "Good morning,";
            else if (currentHour >= 12 && currentHour < 18)
                return "Good afternoon,";
            else
                return "Good evening,";
        }

        private string GetQuote()
        {
            int currentHour = DateTime.Now.Hour;
            if (currentHour >= 5 && currentHour < 12)
                return "Notes are not for forgetting... they're for reminding you that you forgot!";
            else if (currentHour >= 12 && currentHour < 18)
                return "Notes have great power in organizing your life.";
            else
                return "The best way to plan for tomorrow is to write down your ideas now.";
        }
    }
}
