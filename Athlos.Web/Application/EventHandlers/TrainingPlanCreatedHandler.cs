using System.Threading.Tasks;
using Athlos.Application.Data;
using Athlos.Domain.Events;
using Kledex.Events;

namespace Athlos.Application.EventHandlers
{
    public class TrainingPlanCreatedHandler : IEventHandlerAsync<TrainingPlanCreated>
    {
        private readonly AthlosDbContext _db;

        public TrainingPlanCreatedHandler(AthlosDbContext db)
        {
            _db = db;
        }

        public async Task HandleAsync(TrainingPlanCreated @event)
        {
            _db.TrainingPlans.Add(new TrainingPlanEntity
            {
                Id = @event.AggregateRootId,
                Name = @event.Name
            });

            await _db.SaveChangesAsync();
        }
    }
}
