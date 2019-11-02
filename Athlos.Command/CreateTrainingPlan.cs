using Kledex.Domain;

namespace Athlos.Command
{
    public class CreateTrainingPlan : DomainCommand
    {
        public string Name { get; set; }
    }
}
