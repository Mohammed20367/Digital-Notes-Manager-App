using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Digital_Notes_Manager_App.Models;
using Microsoft.Toolkit.Uwp.Notifications;
using Windows.UI.Notifications; 
using Timer = System.Windows.Forms.Timer;

namespace Digital_Notes_Manager_App
{
    public partial class RemindersPage : UserControl
    {
        private readonly DigitalNotesDbContext _dbContext;
        private readonly Timer _reminderTimer;
        private readonly FlowLayoutPanel _flowPanel;
        private readonly Guna.UI2.WinForms.Guna2Button btnAddReminder;
        private readonly int _userId;

        public RemindersPage(int userId)
        {
            InitializeComponent();

            _userId = userId;
            _dbContext = new DigitalNotesDbContext(); 

           
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.WhiteSmoke;

            
            btnAddReminder = new Guna.UI2.WinForms.Guna2Button()
            {
                Text = "➕ Add Reminder",
                BorderRadius = 10,
                FillColor = Color.FromArgb(0, 150, 136),
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.White,
                Size = new Size(180, 40),
                Location = new Point(20, 20),
            };
            btnAddReminder.Click += BtnAddReminder_Click;
            this.Controls.Add(btnAddReminder);

            // 📋 فلو لعرض الكروت
            _flowPanel = new FlowLayoutPanel()
            {
                AutoScroll = true,
                WrapContents = true,
                Location = new Point(20, 80),
                Size = new Size(900, 550),
                Padding = new Padding(10),
                BackColor = Color.White,
            };
            this.Controls.Add(_flowPanel);

            LoadReminders();

            _reminderTimer = new Timer();
            _reminderTimer.Interval = 60000;
            _reminderTimer.Tick += CheckReminders;
            _reminderTimer.Start();
        }

        private void BtnAddReminder_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddNoteForm(_dbContext))
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadReminders();
                }
            }
        }

        private void LoadReminders()
        {
            _flowPanel.Controls.Clear();

            var reminders = _dbContext.Reminders
                .Where(r => r.Note.UserId == _userId)
                .OrderBy(r => r.ReminderDate)
                .ToList();

            foreach (var reminder in reminders)
            {
                var note = _dbContext.Notes.FirstOrDefault(n => n.NoteId == reminder.NoteId);
                if (note == null) continue;

                var card = CreateReminderCard(note.Title, reminder.ReminderDate, reminder.IsNotified);
                _flowPanel.Controls.Add(card);
            }
        }

        private Guna.UI2.WinForms.Guna2Panel CreateReminderCard(string title, DateTime time, bool notified)
        {
            var card = new Guna.UI2.WinForms.Guna2Panel()
            {
                Size = new Size(250, 120),
                BorderRadius = 12,
                ShadowDecoration = { Depth = 10 },
                BackColor = Color.White,
                Margin = new Padding(15),
            };

            var lblTitle = new Label()
            {
                Text = title,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Top,
                Height = 35,
                Padding = new Padding(10, 10, 10, 0)
            };

            var lblTime = new Label()
            {
                Text = $"⏰ {time:dd/MM/yyyy hh:mm tt}",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.DimGray,
                AutoSize = false,
                Dock = DockStyle.Top,
                Height = 30,
                Padding = new Padding(10, 0, 10, 0)
            };

            var lblStatus = new Label()
            {
                Text = notified ? "✅ Done" : "🕐 Pending",
                Font = new Font("Segoe UI", 9, FontStyle.Italic),
                ForeColor = notified ? Color.SeaGreen : Color.OrangeRed,
                Dock = DockStyle.Bottom,
                Height = 30,
                Padding = new Padding(10, 0, 10, 10),
                TextAlign = ContentAlignment.MiddleRight
            };

            card.Controls.Add(lblStatus);
            card.Controls.Add(lblTime);
            card.Controls.Add(lblTitle);

            return card;
        }

        private void CheckReminders(object sender, EventArgs e)
        {
            var now = DateTime.Now;

            var dueReminders = _dbContext.Reminders
                .Where(r => !r.IsNotified && r.ReminderDate <= now && r.Note.UserId == _userId)
                .ToList();

            foreach (var reminder in dueReminders)
            {
                var note = _dbContext.Notes.FirstOrDefault(n => n.NoteId == reminder.NoteId);
                if (note == null) continue;

                try
                {
                    var toastContent = new ToastContentBuilder()
                        .AddText("⏰ Reminder Alert!")
                        .AddText(note.Title)
                        .AddText($"Scheduled at: {reminder.ReminderDate:hh:mm tt}")
                        .GetToastContent();
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Reminder: {note.Title}\nAt: {reminder.ReminderDate:hh:mm tt}", "Reminder");
                    Console.WriteLine("Toast error: " + ex.Message);
                }

                reminder.IsNotified = true;
                _dbContext.SaveChanges();
            }

            if (dueReminders.Any())
                LoadReminders();
        }
    }
}
