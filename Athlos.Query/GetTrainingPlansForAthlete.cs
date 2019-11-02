using System;
using System.Collections.Generic;
using Athlos.Query.Data;
using Kledex.Queries;

namespace Athlos.Query
{
    public class GetTrainingPlansForAthlete : IQuery<IEnumerable<TrainingPlanEntity>>
    {
        public Guid AthleteId { get; set; }
    }
}
