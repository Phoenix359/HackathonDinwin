using System.Collections.Generic;
using HackathonDinwin.Models;

namespace HackathonDinwin
{
    public static class GlobalVariables
    {
        public static Session ActiveSession { get; set; }
            = new Session();
    }
}