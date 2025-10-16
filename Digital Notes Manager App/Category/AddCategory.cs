using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Notes_Manager_App
{
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text.Trim();
            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Category Name is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var dbContext = new Models.DigitalNotesDbContext())
            {
                bool categoryExists = dbContext.Categories.Any(c => c.CategoryName == categoryName && c.UserId== AppContextManager.LoginUserId);
                if (categoryExists)
                {
                    MessageBox.Show("Category already exists.", "Duplicate Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var newCategory = new Models.Category
                {
                    CategoryName = categoryName,
                      UserId = AppContextManager.LoginUserId
                };
                dbContext.Categories.Add(newCategory);
                dbContext.SaveChanges();


            }
            MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();

        }
    }
}
