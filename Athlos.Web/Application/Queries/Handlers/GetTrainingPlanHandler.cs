using System.Threading.Tasks;
using Athlos.Application.Data;
using Kledex.Queries;

namespace Athlos.Application.Queries.Handlers
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
