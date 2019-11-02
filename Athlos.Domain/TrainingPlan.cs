using System;
using Athlos.Domain.Events;
using Guards;
using Kledex.Domain;

namespace Athlos.Domain
{
    public class TrainingPlan : AggregateRoot
    {
        public Guid AthleteId { get; private set; }
        public string Name { get; private set; }

        public TrainingPlan() { }

        public TrainingPlan(Guid athleteId, string name) : base(Guid.NewGuid())
        {
            Guard.ArgumentCondition(() => athleteId, guid => guid != Guid.Empty);
            Guard.ArgumentNotNullOrEmpty(() => name);

            AddAndApplyEvent(new TrainingPlanCreated
            {
                AggregateRootId = Id,
                AthleteId = athleteId,
                Name = name
            });
        }

        public void Apply(TrainingPlanCreated e)
        {
            Id = e.AggregateRootId;
            AthleteId = e.AthleteId;
            Name = e.Name;
        }
    }
}
