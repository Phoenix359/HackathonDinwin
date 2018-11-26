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
                new User {Name = "Kees", FootPrint = 10, StartCount = 2},
                new User {Name = "Harry", FootPrint = 6, StartCount = 7},
                new User {Name = "Chewbacca", FootPrint = 0.1, StartCount = 5},
                new User {Name = "Albert", FootPrint = 1, StartCount = 11},
            };
    }
}