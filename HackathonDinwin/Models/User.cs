using System.Collections.Generic;

namespace HackathonDinwin.Models
{
    public class User
    {
        public string Name { get; set; }
            = "<anonymous>";
        public int FootPrint { get; set; }
            = 100;

        public static User Create(string userName)
        {
            var user = new User {Name = userName};
            GlobalVariables.Users.Add(user);
            return user;
        }

        public static List<User> GetAll()
        {
            return GlobalVariables.Users;
        }
    }
}