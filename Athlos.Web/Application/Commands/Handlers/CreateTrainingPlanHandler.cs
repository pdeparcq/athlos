using System.Collections.Generic;
using System.Threading.Tasks;
using Kledex.Domain;

namespace Athlos.Application.Commands.Handlers
{
    public class CreateTrainingPlanHandler : IDomainCommandHandlerAsync<CreateTrainingPlan>
    {
        public async Task<IEnumerable<IDomainEvent>> HandleAsync(CreateTrainingPlan command)
        {
            return await Task.FromResult(new Domain.TrainingPlan(command.AggregateRootId, command.Name).Events);
        }
    }
}
