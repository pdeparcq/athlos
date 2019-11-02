using System;

namespace Athlos.Command.Exceptions
{
    public class AthleteNotFoundException : ApplicationException
    {
        public AthleteNotFoundException(Guid athleteId) : base($"Athlete with id {athleteId} not found") { }
    }
}
