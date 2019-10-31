using System;
using Athlos.Application.Data;
using Kledex.Queries;

namespace Athlos.Application.Queries
{
    public class GetTrainingPlan : IQuery<TrainingPlanEntity>
    {
        public Guid Id { get; set; }
    }
}
