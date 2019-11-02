using System.Collections.Generic;
using System.Threading.Tasks;
using Athlos.Query.Data;
using Kledex.Queries;

namespace Athlos.Query.QueryHandlers
{
    public class GetAthletesHandler : IQueryHandlerAsync<GetAthletes, IEnumerable<AthleteEntity>>
    {
        private readonly AthlosDbContext _db;

        public GetAthletesHandler(AthlosDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<AthleteEntity>> HandleAsync(GetAthletes query)
        {
            return await Task.FromResult(_db.Athletes);
        }
    }
}
