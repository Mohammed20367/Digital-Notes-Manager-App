using Digital_Notes_Manager_App.Models;

namespace Digital_Notes_Manager_App
{
    internal static class AppContextManager
    {
        public static string loginuser { get; set; }
        public static int LoginUserId { get; set; }

        public static DigitalNotesDbContext CreateContext()
        {
            return new DigitalNotesDbContext();
        }
    }
}
