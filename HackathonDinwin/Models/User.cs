using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace HackathonDinwin.Models
{
    public class User
    {
        public string Name { get; set; }
            = "<anonymous>";
        public double FootPrint { get; set; }
            = 10;

        public static User Create(string userName)
        {
            User user = GetAll().Find(u => u.Name == userName);

            if (string.IsNullOrEmpty(userName))
            {
                user = user = new User();
            }
            else if (user == null)
            {
                user = new User { Name = userName, StartCount = 1 };
                GetAll().Add(user);
            }
            else
            {
                user.StartCount++;
            }

            return user;
        }

        public int StartCount { get; set; }

        public string Status
        {
            get
            {
                if (StartCount < 3) return "Beginner";
                if (StartCount < 6) return "Gevorderd";
                if (StartCount < 9) return "Expert";
                return "Jedi master";
            }
        }

        static Color GetColorFromRedYellowGreenGradient(double percentage)
        {
            var red = (percentage > 50 ? 1 - 2 * (percentage - 50) / 100.0 : 1.0) * 255;
            var green = (percentage > 50 ? 1.0 : 2 * percentage / 100.0) * 255;
            var blue = 0.0;
            Color result = Color.FromArgb((int)red, (int)green, (int)blue);
            return result;
        }
        private static string HexConverter(System.Drawing.Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        public string ScoreColor()
        {
            var max = GlobalVariables.ActiveSession.AllUsers.Max(usr => usr.FootPrint);
            return HexConverter(GetColorFromRedYellowGreenGradient(100 - FootPrint*10));
        }

        public static List<User> GetAll()
        {
            return GlobalVariables.ActiveSession.AllUsers;
        }
    }
}