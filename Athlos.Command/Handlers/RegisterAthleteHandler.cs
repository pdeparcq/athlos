using System.Collections.Generic;
using System.Threading.Tasks;
using Athlos.Domain;
using Kledex.Domain;

namespace Athlos.Command.Handlers
{
    public class RegisterAthleteHandler : IDomainCommandHandlerAsync<RegisterAthlete>
    {
        public async Task<IEnumerable<IDomainEvent>> HandleAsync(RegisterAthlete command)
        {
            var athlete = new Athlete(command.StravaId, command.FullName);

            return await Task.FromResult(athlete.Events);
        }
    }
}
