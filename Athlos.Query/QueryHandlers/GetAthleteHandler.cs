using System.Threading.Tasks;
using Athlos.Query.Data;
using Kledex.Queries;

namespace Athlos.Query.QueryHandlers
{
    public class GetAthleteHandler : IQueryHandlerAsync<GetAthlete, AthleteEntity>
    {
        private readonly AthlosDbContext _db;

        public GetAthleteHandler(AthlosDbContext db)
        {
            _db = db;
        }
        public async Task<AthleteEntity> HandleAsync(GetAthlete query)
        {
            return await _db.Athletes.FindAsync(query.Id);
        }
    }
}
