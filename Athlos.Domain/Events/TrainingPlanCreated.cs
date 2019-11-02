using Kledex.Domain;

namespace Athlos.Domain.Events
{
    public class TrainingPlanCreated : DomainEvent
    {
        public string Name { get; set; }
    }
}
