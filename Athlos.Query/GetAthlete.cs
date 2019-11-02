using System;
using Athlos.Query.Data;
using Kledex.Queries;

namespace Athlos.Query
{
    public class GetAthlete : IQuery<AthleteEntity>
    {
        public Guid Id { get; set; }
    }
}
