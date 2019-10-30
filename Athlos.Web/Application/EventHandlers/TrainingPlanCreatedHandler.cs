using System.Threading.Tasks;
using Athlos.Domain.Events;
using Kledex.Events;

namespace Athlos.Application.EventHandlers
{
    public class TrainingPlanCreatedHandler : IEventHandlerAsync<TrainingPlanCreated>
    {
        public Task HandleAsync(TrainingPlanCreated @event)
        {
            throw new System.NotImplementedException();
        }
    }
}
