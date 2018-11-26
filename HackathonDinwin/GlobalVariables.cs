using System.Collections.Generic;
using HackathonDinwin.Models;

namespace HackathonDinwin
{
    public static class GlobalVariables
    {
        public static Session ActiveSession { get; set; }
            = new Session();

        public static List<Building> Buildings { get; set; }
            = new List<Building>();

        public static List<Categorie> Categories {
            get
            {
                return new List<Categorie>()
                {
                    new Categorie()
                    {
                        Name = "Isolatie",
                        Rules = new List<CategorieRule>()
                        {
                            new CategorieRule()
                            {
                                Name = "Vloer isolatie"
                            },
                            new CategorieRule()
                            {
                                Name = "Duurzame vloer isolatie"
                            },
                            new CategorieRule()
                            {
                                Name = "Dak isolatie"
                            },
                            new CategorieRule()
                            {
                                Name = "Duurzame dak isolatie"
                            },
                            new CategorieRule()
                            {
                                Name = "Spouw isolatie"
                            },
                            new CategorieRule()
                            {
                                Name = "Duurzame spouw isolatie"
                            },
                        }
                    },
                    new Categorie()
                    {
                        Name = "Gas, water, licht",
                        Rules = new List<CategorieRule>()
                        {
                            new CategorieRule(){
                                Name = "Stroom - Bruinkool"
                            },
                            new CategorieRule()
                            {
                                Name = "Stroom - Kernsplijting"
                            },
                            new CategorieRule()
                            {
                                Name = "Stroom - Duurzame bronnen (wind, water, zon)"
                            },
                            new CategorieRule()
                            {
                                Name = "Verwarming - Gas"
                            },
                            new CategorieRule()
                            {
                                Name = "Verwarming - Warmtepomp"
                            }
                        }
                    }
                };
            }
        }
    }
}