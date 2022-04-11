using Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Core.Helper
{
    public static class SessionHelper
    {
        public static string UserId { get; set; }
        public static string UserName { get; set; }
        public static string NameAr { get; set; }
        public static string NameEn { get; set; }
        public static string Email { get; set; }
        public static string RoleName { get; set; }
        public static bool IsArabic { get; set; }
        public static bool IsAdmin { get; set; }
        public static List<Notification> Notifications { get; set; }
        public static string NotificationsCount { get; set; }
    }
}
