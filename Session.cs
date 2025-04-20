using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalldbproject
{
    internal class Session
    {
        public static int UserID { get; set; }

        // Additional properties can be added as needed
        public static string UserName { get; set; }
        public static string UserRole { get; set; }

        // Method to clear the session (e.g., for logout)
        public static void Clear()
        {
            UserID = 0;
            UserName = string.Empty;
            UserRole = string.Empty;
        }
    }
}
