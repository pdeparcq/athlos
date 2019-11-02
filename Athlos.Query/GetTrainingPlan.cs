using System;
using Athlos.Query.Data;
using Kledex.Queries;

namespace Athlos.Query
{
    public class GetTrainingPlan : IQuery<TrainingPlanEntity>
    {
        public Guid Id { get; set; }
    }
}
