using System.ComponentModel.DataAnnotations;

namespace Athlos.Api.InputModels
{
    public class CreateTrainingPlanModel
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
    }
}
