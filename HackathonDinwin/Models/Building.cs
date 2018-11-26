using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace HackathonDinwin.Models
{
    public class Building: IValidatableObject
    {
        public string UserName { get; set; }

        public string BuildingName { get; set; }

        public List<Categorie> Categories { get; set; }

        public Building()
        {
            Categories = GlobalVariables.Categories;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext context)
        {
            if (GlobalVariables.Buildings.Any(x => x.BuildingName == BuildingName))
            {
                yield return new ValidationResult($"Er bestaat al een gebouw met de naam: { BuildingName }");
            }
        }
    }
}