namespace Digital_Notes_Manager_App
{
    partial class AddCategory
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
            lblTitle = new Label();
            txtCategoryName = new Guna.UI2.WinForms.Guna2TextBox();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            Cancel = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(56, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(265, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New Category";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCategoryName
            // 
            txtCategoryName.BackColor = Color.White;
            txtCategoryName.CustomizableEdges = customizableEdges1;
            txtCategoryName.DefaultText = "";
            txtCategoryName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCategoryName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCategoryName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCategoryName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCategoryName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCategoryName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategoryName.ForeColor = Color.DimGray;
            txtCategoryName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCategoryName.Location = new Point(44, 83);
            txtCategoryName.Margin = new Padding(4, 5, 4, 5);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.PlaceholderText = "Enter Category Name";
            txtCategoryName.SelectedText = "";
            txtCategoryName.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtCategoryName.Size = new Size(325, 44);
            txtCategoryName.TabIndex = 1;
           //
            // btnSave
            // 
            btnSave.CustomizableEdges = customizableEdges3;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(47, 156);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSave.Size = new Size(119, 45);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // Cancel
            // 
            Cancel.CustomizableEdges = customizableEdges5;
            Cancel.DisabledState.BorderColor = Color.DarkGray;
            Cancel.DisabledState.CustomBorderColor = Color.DarkGray;
            Cancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Cancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Cancel.FillColor = Color.DarkRed;
            Cancel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancel.ForeColor = Color.White;
            Cancel.Location = new Point(222, 156);
            Cancel.Name = "Cancel";
            Cancel.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Cancel.Size = new Size(119, 45);
            Cancel.TabIndex = 3;
            Cancel.Text = "Cancel";
            Cancel.Click += Cancel_Click;
            // 
            // AddCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(402, 213);
            Controls.Add(Cancel);
            Controls.Add(btnSave);
            Controls.Add(txtCategoryName);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddCategory";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Category";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtCategoryName;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button Cancel;
    }
}