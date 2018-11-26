using System.Collections.Generic;

namespace HackathonDinwin.Models
{
    public class Categorie
    {
        public string Name { get; set; }

        public List<CategorieRule> Rules { get; set; }
    }
}