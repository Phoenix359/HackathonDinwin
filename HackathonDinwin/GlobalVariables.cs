using System.Collections.Generic;
using HackathonDinwin.Models;

namespace HackathonDinwin
{
    public static class GlobalVariables
    {
        public static List<Models.User> Users { get; set; }
            = new List<User>();
    }
}