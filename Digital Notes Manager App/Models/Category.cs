using System.Collections.Generic;

namespace Digital_Notes_Manager_App.Models
{
    public partial class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; } = null!;

        public int UserId { get; set; }

        public virtual ICollection<Note> Notes { get; set; } = new List<Note>();

        public virtual User User { get; set; } = null!;
    }
}
