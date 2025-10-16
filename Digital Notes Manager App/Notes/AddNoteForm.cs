using Digital_Notes_Manager_App.Models;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace Digital_Notes_Manager_App
{
    public partial class AddNoteForm : Form
    {
        private readonly DigitalNotesDbContext _dbContext;
        private Note _editingNote;

        public AddNoteForm(DigitalNotesDbContext dbContext, Note editingNote = null)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _editingNote = editingNote;
            LoadCategories();
            InitializeReminderPicker();

            if (_editingNote != null)
                btnSave.Text = "Update Note";
            else
                btnSave.Text = "Save Note";

            LoadExistingNoteData();

            btnSaveToFile.FillColor = Color.FromArgb(0, 150, 136);
            btnSaveToFile.HoverState.FillColor = Color.FromArgb(0, 200, 180);
            btnSaveToFile.BorderRadius = 10;
            btnSaveToFile.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnSaveToFile.ForeColor = Color.White;
            btnSaveToFile.Text = "💾 Save to File";

            btnImportFile.FillColor = Color.FromArgb(251, 140, 0);
            btnImportFile.HoverState.FillColor = Color.FromArgb(255, 160, 40);
            btnImportFile.BorderRadius = 10;
            btnImportFile.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnImportFile.ForeColor = Color.White;
            btnImportFile.Text = "📂 Import File";
        }

        private void LoadCategories()
        {
            cmbCategory.Items.Clear();

            var categories = _dbContext.Categories
                .Where(c => c.UserId == AppContextManager.LoginUserId)
                .Select(c => c.CategoryName)
                .ToList();

            foreach (var cat in categories)
                cmbCategory.Items.Add(cat);

            if (cmbCategory.Items.Count > 0)
                cmbCategory.SelectedIndex = 0;
        }

        private void InitializeReminderPicker()
        {
            dtpReminder.Format = DateTimePickerFormat.Custom;
            dtpReminder.CustomFormat = "dd/MM/yyyy hh:mm tt";
            dtpReminder.ShowUpDown = true;
            dtpReminder.Value = DateTime.Now;
        }

        private void LoadExistingNoteData()
        {
            if (_editingNote != null)
            {
                this.Text = "Edit Note";
                txtTitle.Text = _editingNote.Title;

                try
                {
                    rtbContent.Rtf = _editingNote.Content;
                }
                catch (ArgumentException)
                {
                    rtbContent.Text = _editingNote.Content;
                }

                var category = _editingNote.Category?.CategoryName;
                if (!string.IsNullOrEmpty(category) && cmbCategory.Items.Contains(category))
                    cmbCategory.SelectedItem = category;

                var reminder = _dbContext.Reminders.FirstOrDefault(r => r.NoteId == _editingNote.NoteId);
                if (reminder != null)
                    dtpReminder.Value = reminder.ReminderDate;
            }
            else
            {
                this.Text = "Add New Note";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please enter a title.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var categoryName = cmbCategory.SelectedItem?.ToString();
            var category = _dbContext.Categories
                .FirstOrDefault(c => c.CategoryName == categoryName && c.UserId == AppContextManager.LoginUserId);

            if (category == null)
            {
                MessageBox.Show("Please select a valid category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_editingNote != null)
            {
                _editingNote.Title = txtTitle.Text.Trim();
                _editingNote.Content = rtbContent.Rtf;
                _editingNote.CategoryId = category.CategoryId;

                _dbContext.SaveChanges();
                SaveNoteToFile(_editingNote);

                var reminder = _dbContext.Reminders.FirstOrDefault(r => r.NoteId == _editingNote.NoteId);
                if (dtpReminder.Value > DateTime.Now)
                {
                    if (reminder == null)
                    {
                        reminder = new Reminder
                        {
                            NoteId = _editingNote.NoteId,
                            ReminderDate = dtpReminder.Value,
                            IsNotified = false
                        };
                        _dbContext.Reminders.Add(reminder);
                    }
                    else
                    {
                        reminder.ReminderDate = dtpReminder.Value;
                        reminder.IsNotified = false;
                    }
                    _dbContext.SaveChanges();
                }

                MessageBox.Show("Note updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var note = new Note
                {
                    Title = txtTitle.Text.Trim(),
                    Content = rtbContent.Rtf,
                    UserId = AppContextManager.LoginUserId,
                    CategoryId = category.CategoryId,
                    CreatedAt = DateTime.Now
                };

                _dbContext.Notes.Add(note);
                _dbContext.SaveChanges();
                SaveNoteToFile(note);

                if (dtpReminder.Value > DateTime.Now)
                {
                    var reminder = new Reminder
                    {
                        NoteId = note.NoteId,
                        ReminderDate = dtpReminder.Value,
                        IsNotified = false
                    };
                    _dbContext.Reminders.Add(reminder);
                    _dbContext.SaveChanges();
                }

                MessageBox.Show("Note added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void SaveNoteToFile(Note note)
        {
            try
            {
                string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DigitalNotes");
                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                string safeTitle = string.Join("_", note.Title.Split(Path.GetInvalidFileNameChars()));
                string filePath = Path.Combine(folderPath, $"{safeTitle}_{note.NoteId}.rtf");

                File.WriteAllText(filePath, note.Content);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving note to file:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImportFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Rich Text Files (*.rtf)|*.rtf|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                ofd.Title = "Select a file to import";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string ext = Path.GetExtension(ofd.FileName).ToLower();
                        if (ext == ".rtf")
                            rtbContent.Rtf = File.ReadAllText(ofd.FileName);
                        else
                            rtbContent.Text = File.ReadAllText(ofd.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error reading file:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please enter a title before saving to file.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string folderPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "DigitalNotes"
                );

                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                string safeTitle = string.Join("_", txtTitle.Text.Split(Path.GetInvalidFileNameChars()));
                string filePath = Path.Combine(folderPath, $"{safeTitle}_manual.rtf");

                File.WriteAllText(filePath, rtbContent.Rtf);

                MessageBox.Show($"Note saved successfully to:\n{filePath}", "Saved to File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbColor_Click(object sender, EventArgs e)
        {
            using (var colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    rtbContent.SelectionColor = colorDialog.Color;
                }
            }
        }

        private void ToggleStyle(FontStyle style)
        {
            if (rtbContent.SelectionFont == null) return;
            var current = rtbContent.SelectionFont;
            FontStyle newStyle = current.Style;

            if (current.Style.HasFlag(style))
                newStyle &= ~style;
            else
                newStyle |= style;

            rtbContent.SelectionFont = new Font(current.FontFamily, current.Size, newStyle);
        }

        private void ApplyFontSizeToSelection(int size)
        {
            if (rtbContent.SelectionFont == null)
            {
                rtbContent.SelectionFont = new Font("Segoe UI", size);
                return;
            }

            var f = rtbContent.SelectionFont;
            rtbContent.SelectionFont = new Font(f.FontFamily, size, f.Style);
        }

        private void TsbColor_Click(object sender, EventArgs e)
        {
            using (var cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                    rtbContent.SelectionColor = cd.Color;
            }
        }

        private void tsBold_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Bold);
        }

        private void tsbItalic_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Italic);
        }

        private void tsbUnderline_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Underline);
        }
    }
}
