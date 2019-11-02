using System.Threading.Tasks;
using Athlos.Domain.Events;
using Athlos.Query.Data;
using Kledex.Events;

namespace Athlos.Query.EventHandlers
{
    public class AthleteRegisteredHandler : IEventHandlerAsync<AthleteRegistered>
    {
        private readonly AthlosDbContext _db;

        public AthleteRegisteredHandler(AthlosDbContext db)
        {
            _db = db;
        }

        public async Task HandleAsync(AthleteRegistered e)
        {
            _db.Athletes.Add(new AthleteEntity
            {
                Id = e.AggregateRootId,
                StravaId = e.StravaId,
                FullName = e.FullName
            });

            await _db.SaveChangesAsync();
        }
    }
}
