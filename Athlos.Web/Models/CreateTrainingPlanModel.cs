using System.ComponentModel.DataAnnotations;

namespace Athlos.Api.Models
{
    public class CreateTrainingPlanModel
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
    }
}
