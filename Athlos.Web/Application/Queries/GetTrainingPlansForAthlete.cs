using System;
using System.Collections.Generic;
using Athlos.Application.Data;
using Kledex.Queries;

namespace Athlos.Application.Queries
{
    public class GetTrainingPlansForAthlete : IQuery<IEnumerable<TrainingPlanEntity>>
    {
        public Guid AthleteId { get; set; }
    }
}
