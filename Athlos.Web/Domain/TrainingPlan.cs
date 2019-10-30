using System;
using Athlos.Domain.Events;
using Guards;
using Kledex.Domain;

namespace Athlos.Domain
{
    public class TrainingPlan : AggregateRoot
    {
        public string Name { get; set; }

        public TrainingPlan() { }

        public TrainingPlan(Guid id, string name) : base(id)
        {
            Guard.ArgumentNotNullOrEmpty(() => name);

            AddAndApplyEvent(new TrainingPlanCreated
            {
                AggregateRootId = id,
                Name = name
            });
        }

        public void Apply(TrainingPlanCreated @event)
        {
            Id = @event.AggregateRootId;
            Name = @event.Name;
        }
    }
}
