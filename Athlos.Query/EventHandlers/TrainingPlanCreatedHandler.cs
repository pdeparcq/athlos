﻿using System.Threading.Tasks;
using Athlos.Domain.Events;
using Athlos.Query.Data;
using Kledex.Events;

namespace Athlos.Query.EventHandlers
{
    public class TrainingPlanCreatedHandler : IEventHandlerAsync<TrainingPlanCreated>
    {
        private readonly AthlosDbContext _db;

        public TrainingPlanCreatedHandler(AthlosDbContext db)
        {
            _db = db;
        }

        public async Task HandleAsync(TrainingPlanCreated e)
        {
            _db.TrainingPlans.Add(new TrainingPlanEntity
            {
                Id = e.AggregateRootId,
                Name = e.Name
            });

            await _db.SaveChangesAsync();
        }
    }
}
