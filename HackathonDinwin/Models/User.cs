using System.Collections.Generic;

namespace HackathonDinwin.Models
{
    public class User
    {
        public string Name { get; set; }
            = "<anonymous>";
        public int FootPrint { get; set; }
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

        public static List<User> GetAll()
        {
            return GlobalVariables.ActiveSession.AllUsers;
        }
    }
}