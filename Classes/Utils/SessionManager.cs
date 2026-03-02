using SmartStock.Classes.Models;

namespace SmartStock.Classes.Utils
{
    public static class SessionManager
    {
        public static User CurrentUser { get; set; }

        public static bool IsAuthenticated => CurrentUser != null;

        public static void Clear()
        {
            CurrentUser = null;
        }
    }
}
