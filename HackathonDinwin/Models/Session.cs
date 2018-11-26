using System.Collections.Generic;

namespace HackathonDinwin.Models
{
    public class Session
    {
        public User ActiveUser { get; set; }
            = new User();

        public List<User> AllUsers { get; set; }
            = new List<User>
            {
                new User {Name = "Kees Fossiel", FootPrint = 10, StartCount = 2},
                new User {Name = "Harry Doemaar", FootPrint = 6, StartCount = 7},
                new User {Name = "Chewbacca", FootPrint = 0.1, StartCount = 5},
                new User {Name = "Albert Walvis", FootPrint = 1, StartCount = 11},
                new User {Name = "Jet Walnoot", FootPrint = 0.3, StartCount = 31},
                new User {Name = "Jose Zeester", FootPrint = 0.85, StartCount = 1},
                new User {Name = "Donald Trump", FootPrint = 45, StartCount = 6},
            };
    }
}