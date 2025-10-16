using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Digital_Notes_Manager_App.Models;

namespace Digital_Notes_Manager_App
{
    public partial class DashboardPage : UserControl
    {
        public Guna2Panel NotesCard { get; private set; }
        public Guna2Panel CategoriesCard { get; private set; }
        public Guna2Panel RemindersCard { get; private set; }
        public Guna2Panel TasksCard { get; private set; }

        private readonly DigitalNotesDbContext _dbContext;
        private readonly int _userId;

        public DashboardPage(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _dbContext = new DigitalNotesDbContext();
            InitializeDashboardLayout();
        }

        private void InitializeDashboardLayout()
        {
            // إعداد الواجهة العامة
            this.Controls.Clear();
            this.BackColor = Color.White;
            this.Dock = DockStyle.Fill;

            // ✅ لوحة مرنة للكروت (تمنع التقطيع وتوزع تلقائيًا)
            var table = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 2,
                Padding = new Padding(50, 40, 50, 40),
                BackColor = Color.White,
                AutoScroll = true
            };

            // توزيع متساوٍ للأعمدة والصفوف
            for (int i = 0; i < 2; i++)
            {
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                table.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            }

            this.Controls.Add(table);

            // جلب الأرقام من قاعدة البيانات
            string[] counts = GetCountsFromDatabase();

            string[] titles = { "Notes", "Categories", "Reminders", "Tasks" };
            Color[] colors =
            {
                Color.FromArgb(0, 120, 215),   // أزرق
                Color.FromArgb(0, 180, 140),   // أخضر
                Color.FromArgb(255, 140, 0),   // برتقالي
                Color.FromArgb(128, 0, 128)    // بنفسجي
            };

            // إنشاء الكروت
            for (int i = 0; i < 4; i++)
            {
                var card = new Guna2Panel
                {
                    BorderRadius = 20,
                    FillColor = Color.White,
                    Margin = new Padding(25),
                    Dock = DockStyle.Fill,
                    ShadowDecoration = { Enabled = true, Depth = 10, Shadow = new Padding(2) }
                };

                // ✅ العدد (متمركز وواضح)
                var lblCount = new Label
                {
                    Text = counts[i],
                    Font = new Font("Segoe UI", 48, FontStyle.Bold),
                    ForeColor = colors[i],
                    Dock = DockStyle.Top,
                    Height = 120,
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    UseCompatibleTextRendering = true
                };

                // ✅ العنوان (تحت العدد بمسافة بسيطة)
                var lblTitle = new Label
                {
                    Text = titles[i],
                    Font = new Font("Segoe UI", 18, FontStyle.Regular),
                    ForeColor = Color.Gray,
                    Dock = DockStyle.Top,
                    Height = 60,
                    AutoSize = false,
                    TextAlign = ContentAlignment.TopCenter,
                    UseCompatibleTextRendering = true
                };

                // ✅ Panel داخلي لترتيب المحتوى وسط الكارت
                var innerPanel = new Panel
                {
                    Dock = DockStyle.Fill,
                    Padding = new Padding(10),
                    BackColor = Color.Transparent
                };

                // الترتيب: العدد فوق، العنوان تحته
                innerPanel.Controls.Add(lblTitle);
                innerPanel.Controls.Add(lblCount);

                // إضافة إلى الكارت
                card.Controls.Add(innerPanel);
                table.Controls.Add(card, i % 2, i / 2);

                // حفظ في الخصائص العامة
                switch (i)
                {
                    case 0: NotesCard = card; break;
                    case 1: CategoriesCard = card; break;
                    case 2: RemindersCard = card; break;
                    case 3: TasksCard = card; break;
                }
            }
        }

        // ✅ جلب البيانات من قاعدة البيانات
        //private string[] GetCountsFromDatabase()
        //{
        //    try
        //    {
        //        var notesCount = _dbContext.Notes.Count(n => n.UserId == _userId);
        //        var categoriesCount = _dbContext.Categories.Count(c => c.UserId == _userId);
        //        var remindersCount = (from r in _dbContext.Reminders
        //                              join n in _dbContext.Notes on r.NoteId equals n.NoteId
        //                              where n.UserId == _userId
        //                              select r).Count();
        //        var tasksCount = 0;

        //        return new[]
        //        {
        //            notesCount.ToString(),
        //            categoriesCount.ToString(),
        //            remindersCount.ToString(),
        //            tasksCount.ToString()
        //        };
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("⚠️ خطأ أثناء جلب البيانات:\n" + ex.Message,
        //            "Database Error",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Error);

        //        return new[] { "0", "0", "0", "0" };
        //    }
        //}

        private string[] GetCountsFromDatabase()
        {
            try
            {
                var notesCount = _dbContext.Notes.Count(n => n.UserId == _userId);
                var categoriesCount = _dbContext.Categories.Count(c => c.UserId == _userId);

                var remindersCount = (from r in _dbContext.Reminders
                                      join n in _dbContext.Notes on r.NoteId equals n.NoteId
                                      where n.UserId == _userId
                                      select r).Count();

                // ✅ التعديل هنا: احسب عدد الملاحظات التي تنتمي لفئة "Tasks"
                var tasksCount = _dbContext.Notes.Count(n => n.UserId == _userId && n.Category != null && n.Category.CategoryName == "Tasks");

                return new[]
                {
            notesCount.ToString(),
            categoriesCount.ToString(),
            remindersCount.ToString(),
            tasksCount.ToString() // القيمة الجديدة
        };
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠️ خطأ أثناء جلب البيانات:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return new[] { "0", "0", "0", "0" };
            }
        }
    }
}
