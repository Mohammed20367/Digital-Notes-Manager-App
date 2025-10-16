using Digital_Notes_Manager_App.Models;
using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Digital_Notes_Manager_App
{
    public partial class NotesPage : Form
    {
        private readonly DigitalNotesDbContext _dbContext;
        private FlowLayoutPanel notesFlowPanel;
        private Guna2TextBox searchBox;
        private Guna2ComboBox categoryFilter;
        private Guna2Button addNoteBtn;

        public NotesPage()
        {
            InitializeComponent();
            _dbContext = AppContextManager.CreateContext();
            InitializeLayout();
            LoadCategories();
            LoadNotes();
        }

        private void InitializeLayout()
        {
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.FromArgb(248, 249, 250);

            Panel headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 80,
                Padding = new Padding(20, 15, 20, 10),
                BackColor = Color.FromArgb(248, 249, 250)
            };
            this.Controls.Add(headerPanel);

            searchBox = new Guna2TextBox
            {
                PlaceholderText = "Search notes...",
                BorderRadius = 10,
                Size = new Size(250, 40),
                Location = new Point(10, 15)
            };
            searchBox.TextChanged += (s, e) => LoadNotes();
            headerPanel.Controls.Add(searchBox);

            categoryFilter = new Guna2ComboBox
            {
                BorderRadius = 10,
                Size = new Size(200, 40),
                Location = new Point(270, 15),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            categoryFilter.SelectedIndexChanged += (s, e) => LoadNotes();
            headerPanel.Controls.Add(categoryFilter);

            addNoteBtn = new Guna2Button
            {
                Text = "+ Add Note",
                BorderRadius = 10,
                Size = new Size(140, 40),
                Location = new Point(490, 15),
                FillColor = Color.FromArgb(0, 120, 215),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            addNoteBtn.Click += AddNoteBtn_Click;
            headerPanel.Controls.Add(addNoteBtn);

            notesFlowPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(20, 100, 20, 20),
                BackColor = Color.FromArgb(248, 249, 250)
            };
            this.Controls.Add(notesFlowPanel);
        }

        private void LoadCategories()
        {
            try
            {
                categoryFilter.Items.Clear();
                categoryFilter.Items.Add("All Categories");

                var userCategories = _dbContext.Categories
                    .Where(c => c.UserId == AppContextManager.LoginUserId)
                    .Select(c => c.CategoryName);

                var usedCategories = _dbContext.Notes
                    .Include(n => n.Category)
                    .Where(n => n.UserId == AppContextManager.LoginUserId && n.Category != null)
                    .Select(n => n.Category.CategoryName);

                var allCategories = userCategories
                    .Union(usedCategories)
                    .Distinct()
                    .OrderBy(c => c)
                    .ToList();

                foreach (var cat in allCategories)
                    categoryFilter.Items.Add(cat);

                categoryFilter.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadNotes()
        {
            try
            {
                notesFlowPanel.Controls.Clear(); 

                string searchTerm = searchBox?.Text?.ToLower() ?? "";
                string selectedCategory = categoryFilter?.SelectedItem?.ToString() ?? "All Categories";

                var notes = _dbContext.Notes
                    .Include(n => n.Category)
                    .Where(n => n.UserId == AppContextManager.LoginUserId)
                    .OrderByDescending(n => n.CreatedAt)
                    .ToList();

                if (!string.IsNullOrEmpty(searchTerm))
                    notes = notes.Where(n =>
                        (n.Title ?? "").ToLower().Contains(searchTerm) ||
                        (n.Content ?? "").ToLower().Contains(searchTerm)
                    ).ToList();

                if (!string.IsNullOrEmpty(selectedCategory) && selectedCategory != "All Categories")
                    notes = notes.Where(n => n.Category != null && n.Category.CategoryName == selectedCategory).ToList();

                if (notes.Count == 0)
                {
                    Label noNotes = new Label
                    {
                        Text = "No notes found.",
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill,
                        Font = new Font("Segoe UI", 12, FontStyle.Italic),
                        ForeColor = Color.Gray
                    };
                    notesFlowPanel.Controls.Add(noNotes);
                    return;
                }

                foreach (var note in notes)
                {
                    var card = CreateNoteCard(note);
                    notesFlowPanel.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading notes:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Guna2Panel CreateNoteCard(Note note)
        {
            var card = new Guna2Panel
            {
                Size = new Size(410, 220),
                BorderRadius = 15,
                FillColor = Color.White,
                Margin = new Padding(15),
                ShadowDecoration = { Enabled = true, Depth = 5 }
            };

            Label lblTitle = new Label
            {
                Text = $"{(string.IsNullOrWhiteSpace(note.Title) ? "(Untitled)" : note.Title)}" +
                (note.Category != null ? $"  —  {note.Category.CategoryName}" : ""),
                Font = new Font("Segoe UI", 13, FontStyle.Bold),
                ForeColor = Color.Black,
                Location = new Point(20, 20),
                AutoSize = false,
                Size = new Size(290, 35)
            };

            RichTextBox rtbContent = new RichTextBox
            {
                ReadOnly = true,
                BorderStyle = BorderStyle.None,
                ScrollBars = RichTextBoxScrollBars.None,
                BackColor = Color.White,
                ForeColor = Color.DimGray,
                Font = new Font("Segoe UI", 9),
                Location = new Point(20, 55),
                Size = new Size(260, 60)
            };

            if (!string.IsNullOrWhiteSpace(note.Content))
            {
                try
                {
                    rtbContent.Rtf = note.Content;
                }
                catch (ArgumentException)
                {
                    rtbContent.Text = note.Content;
                }
            }

            Label lblDate = new Label
            {
                Text = $"Created: {(note.CreatedAt != DateTime.MinValue ? note.CreatedAt.ToShortDateString() : "-")}",
                Font = new Font("Segoe UI", 9, FontStyle.Italic),
                ForeColor = Color.Gray,
                Location = new Point(20, 125),
                AutoSize = true
            };

            var btnEdit = new Guna2Button
            {
                Text = "Edit",
                Size = new Size(60, 30),
                Location = new Point(170, 120),
                BorderRadius = 8,
                FillColor = Color.FromArgb(0, 120, 215),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnEdit.Click += (s, e) => EditNote(note);

            var btnDelete = new Guna2Button
            {
                Text = "Delete",
                Size = new Size(70, 30),
                Location = new Point(240, 120),
                BorderRadius = 8,
                FillColor = Color.FromArgb(220, 53, 69),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnDelete.Click += (s, e) => DeleteNote(note);

            card.Controls.Add(lblTitle);
            card.Controls.Add(rtbContent);
            card.Controls.Add(lblDate);
            card.Controls.Add(btnEdit);
            card.Controls.Add(btnDelete);

            return card;
        }

        private void EditNote(Note note)
        {
            using (var db = AppContextManager.CreateContext())
            {
               
                
                var noteToEdit = db.Notes
                    .Include(n => n.Category)
                    .FirstOrDefault(n => n.NoteId == note.NoteId);

                if (noteToEdit == null)
                {
                    MessageBox.Show("Note not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var editNoteForm = new AddNoteForm(db, noteToEdit);
                var result = editNoteForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    RefreshNotes();
                   
                }
            }
        }

        private void DeleteNote(Note note)
        {
            var confirm = MessageBox.Show($"Delete note '{note.Title}'?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                _dbContext.Reminders.RemoveRange(_dbContext.Reminders.Where(r => r.NoteId == note.NoteId));
                _dbContext.Notes.Remove(note);
                _dbContext.SaveChanges();
                LoadNotes();
            }
        }

        private void AddNoteBtn_Click(object sender, EventArgs e)
        {
            using (var db = AppContextManager.CreateContext())
            {
                var addNoteForm = new AddNoteForm(db);
                var result = addNoteForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    RefreshNotes();
                }
            }
        }

        public void RefreshNotes()
        {
            LoadNotes();
        }
    }
}
