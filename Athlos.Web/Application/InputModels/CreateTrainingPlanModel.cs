using System.ComponentModel.DataAnnotations;

namespace Athlos.Application.InputModels
{
    public class CreateTrainingPlanModel
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
    }
}
