namespace Digital_Notes_Manager_App
{
    partial class AddNoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNoteForm));
            labelTitle = new Label();
            txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            labelContent = new Label();
            labelCategory = new Label();
            cmbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            dtpReminder = new Guna.UI2.WinForms.Guna2DateTimePicker();
            btnImportFile = new Guna.UI2.WinForms.Guna2Button();
            RemenderDate = new Label();
            btnSaveToFile = new Guna.UI2.WinForms.Guna2Button();
            rtbContent = new RichTextBox();
            tsbBold = new ToolStrip();
            tsbItalic = new ToolStripButton();
            tsbColor = new ToolStripButton();
            tsbUnderline = new ToolStripButton();
            tsBold = new ToolStripButton();
            tsbBold.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(30, 94);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(46, 23);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.BorderRadius = 8;
            txtTitle.CustomizableEdges = customizableEdges1;
            txtTitle.DefaultText = "";
            txtTitle.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTitle.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTitle.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTitle.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTitle.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTitle.Font = new Font("Segoe UI", 9F);
            txtTitle.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTitle.Location = new Point(30, 119);
            txtTitle.Margin = new Padding(3, 4, 3, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Enter note title";
            txtTitle.SelectedText = "";
            txtTitle.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtTitle.Size = new Size(320, 40);
            txtTitle.TabIndex = 1;
            // 
            // labelContent
            // 
            labelContent.AutoSize = true;
            labelContent.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelContent.Location = new Point(30, 212);
            labelContent.Name = "labelContent";
            labelContent.Size = new Size(74, 23);
            labelContent.TabIndex = 2;
            labelContent.Text = "Content";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCategory.Location = new Point(30, 452);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(84, 23);
            labelCategory.TabIndex = 4;
            labelCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.Transparent;
            cmbCategory.BorderRadius = 8;
            cmbCategory.CustomizableEdges = customizableEdges3;
            cmbCategory.DrawMode = DrawMode.OwnerDrawFixed;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbCategory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbCategory.Font = new Font("Segoe UI", 10F);
            cmbCategory.ForeColor = Color.FromArgb(68, 88, 112);
            cmbCategory.ItemHeight = 30;
            cmbCategory.Location = new Point(30, 477);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cmbCategory.Size = new Size(320, 36);
            cmbCategory.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.BorderRadius = 10;
            btnSave.CustomizableEdges = customizableEdges5;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(30, 643);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSave.Size = new Size(140, 40);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BorderRadius = 10;
            btnCancel.CustomizableEdges = customizableEdges7;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.IndianRed;
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(210, 643);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnCancel.Size = new Size(140, 40);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click_1;
            // 
            // dtpReminder
            // 
            dtpReminder.BackColor = Color.Transparent;
            dtpReminder.BorderRadius = 10;
            dtpReminder.Checked = true;
            dtpReminder.CustomFormat = "dd/MM/yyyy hh:mm tt";
            dtpReminder.CustomizableEdges = customizableEdges9;
            dtpReminder.FillColor = SystemColors.WindowFrame;
            dtpReminder.Font = new Font("Segoe UI", 9F);
            dtpReminder.Format = DateTimePickerFormat.Custom;
            dtpReminder.Location = new Point(33, 560);
            dtpReminder.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpReminder.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpReminder.Name = "dtpReminder";
            dtpReminder.ShadowDecoration.CustomizableEdges = customizableEdges10;
            dtpReminder.ShowUpDown = true;
            dtpReminder.Size = new Size(320, 36);
            dtpReminder.TabIndex = 8;
            dtpReminder.Value = new DateTime(2025, 10, 10, 16, 25, 1, 319);
            // 
            // btnImportFile
            // 
            btnImportFile.BorderRadius = 10;
            btnImportFile.CustomizableEdges = customizableEdges11;
            btnImportFile.DisabledState.BorderColor = Color.DarkGray;
            btnImportFile.DisabledState.CustomBorderColor = Color.DarkGray;
            btnImportFile.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnImportFile.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnImportFile.FillColor = Color.SteelBlue;
            btnImportFile.Font = new Font("Segoe UI", 9F);
            btnImportFile.ForeColor = Color.White;
            btnImportFile.Location = new Point(20, 23);
            btnImportFile.Name = "btnImportFile";
            btnImportFile.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnImportFile.Size = new Size(140, 45);
            btnImportFile.TabIndex = 9;
            btnImportFile.Text = "Import from file";
            btnImportFile.Click += btnImportFile_Click;
            // 
            // RemenderDate
            // 
            RemenderDate.AutoSize = true;
            RemenderDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RemenderDate.Location = new Point(30, 529);
            RemenderDate.Name = "RemenderDate";
            RemenderDate.Size = new Size(130, 23);
            RemenderDate.TabIndex = 10;
            RemenderDate.Text = "RemenderDate";
            // 
            // btnSaveToFile
            // 
            btnSaveToFile.BorderRadius = 10;
            btnSaveToFile.CustomizableEdges = customizableEdges13;
            btnSaveToFile.DisabledState.BorderColor = Color.DarkGray;
            btnSaveToFile.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSaveToFile.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSaveToFile.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSaveToFile.FillColor = Color.SteelBlue;
            btnSaveToFile.Font = new Font("Segoe UI", 9F);
            btnSaveToFile.ForeColor = Color.White;
            btnSaveToFile.Location = new Point(241, 23);
            btnSaveToFile.Name = "btnSaveToFile";
            btnSaveToFile.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnSaveToFile.Size = new Size(140, 45);
            btnSaveToFile.TabIndex = 11;
            btnSaveToFile.Text = "Save To File";
            btnSaveToFile.Click += btnSaveToFile_Click;
            // 
            // rtbContent
            // 
            rtbContent.Location = new Point(30, 237);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(320, 200);
            rtbContent.TabIndex = 12;
            rtbContent.Text = "";
            // 
            // tsbBold
            // 
            tsbBold.Dock = DockStyle.None;
            tsbBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tsbBold.GripStyle = ToolStripGripStyle.Hidden;
            tsbBold.ImageScalingSize = new Size(20, 20);
            tsbBold.Items.AddRange(new ToolStripItem[] { tsbItalic, tsbColor, tsbUnderline, tsBold });
            tsbBold.Location = new Point(211, 207);
            tsbBold.Name = "tsbBold";
            tsbBold.Size = new Size(125, 27);
            tsbBold.TabIndex = 13;
            tsbBold.Text = "B";
            // 
            // tsbItalic
            // 
            tsbItalic.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbItalic.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            tsbItalic.Image = (Image)resources.GetObject("tsbItalic.Image");
            tsbItalic.ImageTransparentColor = Color.Magenta;
            tsbItalic.Name = "tsbItalic";
            tsbItalic.Size = new Size(29, 24);
            tsbItalic.Text = "/";
            tsbItalic.Click += tsbItalic_Click;
            // 
            // tsbColor
            // 
            tsbColor.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbColor.Image = (Image)resources.GetObject("tsbColor.Image");
            tsbColor.ImageTransparentColor = Color.Magenta;
            tsbColor.Name = "tsbColor";
            tsbColor.Size = new Size(35, 24);
            tsbColor.Text = "🎨";
            tsbColor.Click += tsbColor_Click;
            // 
            // tsbUnderline
            // 
            tsbUnderline.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbUnderline.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            tsbUnderline.ImageTransparentColor = Color.Magenta;
            tsbUnderline.Name = "tsbUnderline";
            tsbUnderline.Size = new Size(29, 24);
            tsbUnderline.Text = "U";
            tsbUnderline.Click += tsbUnderline_Click;
            // 
            // tsBold
            // 
            tsBold.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsBold.Image = (Image)resources.GetObject("tsBold.Image");
            tsBold.ImageTransparentColor = Color.Magenta;
            tsBold.Name = "tsBold";
            tsBold.Size = new Size(29, 24);
            tsBold.Text = "B";
            tsBold.Click += tsBold_Click;
            // 
            // AddNoteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(394, 713);
            Controls.Add(tsbBold);
            Controls.Add(rtbContent);
            Controls.Add(btnSaveToFile);
            Controls.Add(RemenderDate);
            Controls.Add(btnImportFile);
            Controls.Add(dtpReminder);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbCategory);
            Controls.Add(labelCategory);
            Controls.Add(labelContent);
            Controls.Add(txtTitle);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddNoteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New Note";
            tsbBold.ResumeLayout(false);
            tsbBold.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private Label labelContent;
        private Label labelCategory;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCategory;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpReminder;
        private Guna.UI2.WinForms.Guna2Button btnImportFile;
        private Label RemenderDate;
        private Guna.UI2.WinForms.Guna2Button btnSaveToFile;
        private RichTextBox rtbContent;
        private ToolStrip tsbBold;
        private ToolStripButton tsbItalic;
        private ToolStripButton tsbUnderline;
        private ToolStripButton tsbColor;
        private ToolStripButton tsBold;
    }
}