using Digital_Notes_Manager_App.Models;
using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Digital_Notes_Manager_App
{
    public partial class CategoriesPage : UserControl
    {
        public Guna2Panel CategoriesCard { get; private set; }
        private readonly DigitalNotesDbContext _dbContext;
        private readonly int _userId;

        public CategoriesPage(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _dbContext = new DigitalNotesDbContext();
            InitializeCategoriesLayout();
        }

        private void InitializeCategoriesLayout()
        {
            this.Controls.Clear();
            this.BackColor = Color.White;
            this.Dock = DockStyle.Fill;

            var btnAddCategory = new Guna2Button
            {
                Text = "+ Add Category",
                Size = new Size(160, 40),
                BorderRadius = 10,
                FillColor = Color.FromArgb(219, 238, 255), // أزرق فاتح
                ForeColor = Color.FromArgb(56, 121, 231),  // أزرق غامق
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Cursor = Cursors.Hand,
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Location = new Point(this.Width - 200, 25)
            };

            this.Resize += (s, e) =>
            {
                btnAddCategory.Location = new Point(this.Width - 210, 25);
            };

            btnAddCategory.Click += BtnAddCategory_Click;

            this.Controls.Add(btnAddCategory);

            var table = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 2,
                Padding = new Padding(50, 90, 50, 40),
                BackColor = Color.White,
                AutoScroll = true
            };

            for (int i = 0; i < 2; i++)
            {
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                table.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            }

            this.Controls.Add(table);

            int count = 0;
            string[] CategoryName = GetCategoriesFromDB();
            int length = CategoryName.Length;

            Color[] colorsCounter =
            {
                Color.FromArgb(56 ,121 ,231),
                Color.FromArgb(22, 129, 83),
                Color.FromArgb(225, 179, 115),
                Color.FromArgb(196 , 104 , 98)
            };
            Color[] colorsBackground =
            {
                Color.FromArgb(219 , 238 , 255),
                Color.FromArgb(233, 254 , 235),
                Color.FromArgb(255 , 252 , 238),
                Color.FromArgb(255  ,234  ,235)
            };

            for (int i = 0; i < length; i++)
            {
                int colorIndex = i % colorsBackground.Length;

                var card = new Guna2Panel
                {
                    BorderRadius = 20,
                    FillColor = colorsBackground[colorIndex],
                    Margin = new Padding(25),
                    Dock = DockStyle.Fill
                };

                var lblCount = new Label
                {
                    Text = (++count).ToString(),
                    Font = new Font("Segoe UI", 48, FontStyle.Bold),
                    ForeColor = colorsCounter[colorIndex],
                    Dock = DockStyle.Top,
                    Height = 120,
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    UseCompatibleTextRendering = true
                };

                var lblTitle = new Label
                {
                    Text = CategoryName[i],
                    Font = new Font("Segoe UI", 18, FontStyle.Regular),
                    ForeColor = Color.Gray,
                    Dock = DockStyle.Top,
                    Height = 60,
                    AutoSize = false,
                    TextAlign = ContentAlignment.TopCenter,
                    UseCompatibleTextRendering = true
                };

                var innerPanel = new Panel
                {
                    Dock = DockStyle.Fill,
                    Padding = new Padding(10),
                    BackColor = Color.Transparent
                };

                innerPanel.Controls.Add(lblTitle);
                innerPanel.Controls.Add(lblCount);



                card.Controls.Add(innerPanel);
                table.Controls.Add(card, i % 2, i / 2);


            }
        }

        private void BtnAddCategory_Click(object? sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory();
            addCategory.ShowDialog();
            this.Controls.Clear();
            InitializeCategoriesLayout();

        }

        private string[] GetCategoriesFromDB()
        {
            try
            {
                var categories = _dbContext.Categories
                    .Where(c => c.UserId == _userId)
                    .Select(c => c.CategoryName)
                    .ToArray();

                return categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠️ خطأ أثناء جلب البيانات:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return new[] { "Error Loading Categories" };
            }
        }
    }
}




