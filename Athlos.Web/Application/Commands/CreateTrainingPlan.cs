using Kledex.Domain;

namespace Athlos.Application.Commands
{
    public class CreateTrainingPlan : DomainCommand
    {
        public string Name { get; set; }
    }
}
