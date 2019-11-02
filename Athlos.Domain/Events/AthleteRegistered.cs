using System;
using Kledex.Domain;

namespace Athlos.Domain.Events
{
    public class AthleteRegistered : DomainEvent
    {
        public string StravaId { get; set; }
        public string FullName { get; set; }
    }
}
