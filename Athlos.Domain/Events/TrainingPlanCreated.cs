using System;
using Kledex.Domain;

namespace Athlos.Domain.Events
{
    public class TrainingPlanCreated : DomainEvent
    {
        public Guid AthleteId { get; set; }
        public string Name { get; set; }
    }
}
