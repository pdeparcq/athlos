using System;
using Athlos.Domain.Events;
using Guards;
using Kledex.Domain;

namespace Athlos.Domain
{
    public class Athlete : AggregateRoot
    {
        public string StravaId { get; private set; }
        public string FullName { get; private set; }

        public Athlete() { }

        public Athlete(string stravaId, string fullName) : base(Guid.NewGuid())
        {
            Guard.ArgumentNotNullOrEmpty(() => stravaId);
            Guard.ArgumentNotNullOrEmpty(() => fullName);

            AddAndApplyEvent(new AthleteRegistered
            {
                AggregateRootId = Id,
                StravaId = stravaId,
                FullName = fullName
            });
        }

        public void Apply(AthleteRegistered e)
        {
            Id = e.AggregateRootId;
            StravaId = e.StravaId;
            FullName = e.FullName;
        }
    }
}
