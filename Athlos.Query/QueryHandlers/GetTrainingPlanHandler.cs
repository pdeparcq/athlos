using System.Threading.Tasks;
using Athlos.Query.Data;
using Kledex.Queries;

namespace Athlos.Query.QueryHandlers
{
    public class GetTrainingPlanHandler : IQueryHandlerAsync<GetTrainingPlan, TrainingPlanEntity>
    {
        private readonly AthlosDbContext _db;

        public GetTrainingPlanHandler(AthlosDbContext db)
        {
            _db = db;
        }

        public async Task<TrainingPlanEntity> HandleAsync(GetTrainingPlan query)
        {
            return await _db.TrainingPlans.FindAsync(query.Id);
        }
    }
}
