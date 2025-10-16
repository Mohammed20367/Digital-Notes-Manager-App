using System.Collections.Generic;

namespace Digital_Notes_Manager_App.Models
{
    public partial class User
    {
        public int UserId { get; set; }

        public string Username { get; set; } = null!;

        public string UserPassword { get; set; } = null!;

        public virtual ICollection<Note> Notes { get; set; } = new List<Note>();

        public virtual ICollection<Category> Categories { get; set; } = new List<Category>();
    }
}
