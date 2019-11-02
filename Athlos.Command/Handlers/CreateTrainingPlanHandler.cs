using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Athlos.Command.Exceptions;
using Athlos.Query;
using Kledex;
using Kledex.Domain;

namespace Athlos.Command.Handlers
{
    public class CreateTrainingPlanHandler : IDomainCommandHandlerAsync<CreateTrainingPlan>
    {
        private readonly IDispatcher _dispatcher;

        public CreateTrainingPlanHandler(IDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        public async Task<IEnumerable<IDomainEvent>> HandleAsync(CreateTrainingPlan command)
        {
            // Make sure athlete exists
            var athlete = await _dispatcher.GetResultAsync(new GetAthlete() {Id = Guid.Parse(command.UserId)});

            if(athlete == null)
                throw new AthleteNotFoundException(Guid.Parse(command.UserId));

            return new Domain.TrainingPlan(athlete.Id, command.Name).Events;
        }
    }
}
