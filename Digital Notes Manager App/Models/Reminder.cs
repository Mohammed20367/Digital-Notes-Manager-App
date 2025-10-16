using System;

namespace Digital_Notes_Manager_App.Models
{
    public partial class Reminder
    {
        public int ReminderId { get; set; }

        public int NoteId { get; set; }

        public DateTime ReminderDate { get; set; }

        public bool IsNotified { get; set; }

        public virtual Note Note { get; set; } = null!;
    }
}
