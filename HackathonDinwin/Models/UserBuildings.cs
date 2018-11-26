using System.Collections.Generic;
using System.Linq;

namespace HackathonDinwin.Models
{
    public class UserBuildings
    {
        public User ActiveUser { get; set; }

        public List<Building> Buildings { get; set; }

        public UserBuildings() { }

        public UserBuildings(string username)
        {
            ActiveUser = GlobalVariables.ActiveSession.AllUsers.FirstOrDefault(x => x.Name == username);
            Buildings = GlobalVariables.Buildings.Where(x => x.UserName == username).ToList();
        }
    }
}