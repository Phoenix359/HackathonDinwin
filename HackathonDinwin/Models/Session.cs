using System.Collections.Generic;

namespace HackathonDinwin.Models
{
    public class Session
    {
        public User ActiveUser { get; set; }
            = new User();

        public List<User> AllUsers { get; set; }
            = new List<User>();
    }
}