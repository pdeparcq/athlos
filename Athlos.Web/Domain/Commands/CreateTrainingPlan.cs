using Kledex.Domain;

namespace Athlos.Domain.Commands
{
    public class CreateTrainingPlan : DomainCommand
    {
        public string Name { get; set; }
    }
}
