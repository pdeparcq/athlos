using System.Collections.Generic;
using System.Threading.Tasks;
using Athlos.Query.Data;
using Kledex.Queries;

namespace Athlos.Query.QueryHandlers
{
    public class GetTrainingPlansForAthleteHandler : IQueryHandlerAsync<GetTrainingPlansForAthlete, IEnumerable<TrainingPlanEntity>>
    {
        private readonly AthlosDbContext _db;

        public GetTrainingPlansForAthleteHandler(AthlosDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<TrainingPlanEntity>> HandleAsync(GetTrainingPlansForAthlete query)
        {
            return await Task.FromResult(_db.TrainingPlans);
        }
    }
}
