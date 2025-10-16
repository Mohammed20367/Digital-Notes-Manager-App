using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Digital_Notes_Manager_App.About
{
    public partial class AboutForm : UserControl
    {
        private Panel backgroundPanel;
        private Panel contentCard;
        private Panel logoCircle;
        private Label logoIcon;
        private Label appTitle;
        private Label appSubtitle;
        private Panel infoSection;
        private Button btnUpdates;
        private Button btnClose;

        public AboutForm()
        {
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.Transparent;
            this.DoubleBuffered = true;

            CreateControls();
        }

        private void CreateControls()
        {
            backgroundPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent
            };
            backgroundPanel.Paint += BackgroundPanel_Paint;

            contentCard = new Panel
            {
                Size = new Size(460, 580),
                Anchor = AnchorStyles.None,
                BackColor = Color.White,
            };
            contentCard.Paint += (s, e) => DrawRoundedRectangle(e.Graphics, contentCard.ClientRectangle, 15, contentCard.BackColor);

            contentCard.Location = new Point(
                (this.Width - contentCard.Width) / 2,
                (this.Height - contentCard.Height) / 2
            );
            this.Resize += (s, e) =>
            {
                contentCard.Location = new Point(
                    (this.Width - contentCard.Width) / 2,
                    (this.Height - contentCard.Height) / 2
                );
            };

            // دائرة اللوجو
            logoCircle = new Panel
            {
                Size = new Size(80, 80),
                Location = new Point((contentCard.Width - 80) / 2, 30),
                BackColor = Color.White
            };
            logoCircle.Paint += (s, e) => DrawRoundedRectangle(e.Graphics, logoCircle.ClientRectangle, 20, Color.White);

            logoIcon = new Label
            {
                Text = "📝",
                Font = new Font("Segoe UI Emoji", 35),
                Size = new Size(80, 80),
                TextAlign = ContentAlignment.MiddleCenter
            };
            logoCircle.Controls.Add(logoIcon);

            appTitle = new Label
            {
                Text = "NoteEase",
                Font = new Font("Segoe UI", 28, FontStyle.Bold),
                ForeColor = Color.FromArgb(102, 126, 234),
                Size = new Size(contentCard.Width, 50),
                Location = new Point(0, 115),
                TextAlign = ContentAlignment.MiddleCenter
            };

            appSubtitle = new Label
            {
                Text = "Your Digital Companion for Notes",
                Font = new Font("Segoe UI", 12, FontStyle.Italic),
                ForeColor = Color.Gray,
                Size = new Size(contentCard.Width, 30),
                Location = new Point(0, 175),
                TextAlign = ContentAlignment.MiddleCenter
            };

            infoSection = new Panel
            {
                Size = new Size(400, 270),
                Location = new Point(30, 215),
                BackColor = Color.Transparent
            };
            CreateInfoRows();

            btnUpdates = new Button
            {
                Text = "UPDATES",
                Size = new Size(195, 45),
                Location = new Point(30, 505),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.FromArgb(102, 126, 234),
                BackColor = Color.White,
                Cursor = Cursors.Hand
            };
            btnUpdates.FlatAppearance.BorderSize = 2;
            btnUpdates.FlatAppearance.BorderColor = Color.FromArgb(102, 126, 234);
            btnUpdates.Click += (s, e) =>
            {
                MessageBox.Show("Check for updates feature coming soon!", "Updates",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            btnClose = new Button
            {
                Text = "CLOSE",
                Size = new Size(195, 45),
                Location = new Point(235, 505),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(102, 126, 234),
                Cursor = Cursors.Hand
            };
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += (s, e) => Application.Exit();

            contentCard.Controls.AddRange(new Control[] {
                logoCircle, appTitle, appSubtitle, infoSection,
                btnUpdates, btnClose
            });
            backgroundPanel.Controls.Add(contentCard);
            this.Controls.Add(backgroundPanel);
        }

        private void CreateInfoRows()
        {
            string[,] infoData =
            {
                { "⚡", "VERSION", "1.0.0" },
                { "👨‍💻", "DEVELOPER", "Mohamed Nasser" },
                { "📋", "LICENSE", "MIT License" },
                { "📅", "RELEASE DATE", "October 2025" }
            };

            for (int i = 0; i < infoData.GetLength(0); i++)
            {
                Panel row = new Panel
                {
                    Size = new Size(400, 55),
                    Location = new Point(0, i * 65),
                    BackColor = Color.FromArgb(248, 249, 250)
                };

                Label icon = new Label
                {
                    Text = infoData[i, 0],
                    Font = new Font("Segoe UI Emoji", 16),
                    Size = new Size(40, 40),
                    Location = new Point(10, 8),
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.FromArgb(102, 126, 234)
                };

                Label title = new Label
                {
                    Text = infoData[i, 1],
                    Font = new Font("Segoe UI", 8),
                    ForeColor = Color.Gray,
                    Location = new Point(60, 10),
                    AutoSize = true
                };

                Label value = new Label
                {
                    Text = infoData[i, 2],
                    Font = new Font("Segoe UI", 13, FontStyle.Bold),
                    ForeColor = Color.Black,
                    Location = new Point(60, 25),
                    AutoSize = true
                };

                row.Controls.AddRange(new Control[] { icon, title, value });
                infoSection.Controls.Add(row);
            }
        }

        private void BackgroundPanel_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                backgroundPanel.ClientRectangle,
                Color.FromArgb(102, 126, 234),
                Color.FromArgb(118, 75, 162),
                135f))
            {
                e.Graphics.FillRectangle(brush, backgroundPanel.ClientRectangle);
            }
        }

        private void DrawRoundedRectangle(Graphics g, Rectangle bounds, int radius, Color color)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (GraphicsPath path = new GraphicsPath())
            {
                int d = radius * 2;
                path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
                path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
                path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
                path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
                path.CloseFigure();
                using (SolidBrush brush = new SolidBrush(color))
                    g.FillPath(brush, path);
            }
        }
    }
}
