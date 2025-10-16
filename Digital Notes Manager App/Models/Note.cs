using System;
using System.Collections.Generic;

namespace Digital_Notes_Manager_App.Models
{
    public partial class Note
    {
        public int NoteId { get; set; }

        public string Title { get; set; } = null!;

        public string Content { get; set; } = null!;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? ReminderDate { get; set; }

        public int UserId { get; set; }

        public int? CategoryId { get; set; }

        public virtual Category? Category { get; set; }

        public virtual ICollection<Reminder> Reminders { get; set; } = new List<Reminder>();

        public virtual User User { get; set; } = null!;
    }
}
