using System;
using System.Threading.Tasks;
using Athlos.Api.InputModels;
using Athlos.Application.Commands;
using Kledex;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Athlos.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrainingPlansController : ControllerBase
    {
        private readonly ILogger<TrainingPlansController> _logger; 
        private readonly IDispatcher _dispatcher;

        public TrainingPlansController(ILogger<TrainingPlansController> logger, IDispatcher dispatcher)
        {
            _logger = logger;
            _dispatcher = dispatcher;
        }

        [HttpPost]
        public async Task Create([FromBody] CreateTrainingPlanModel model)
        {
            await _dispatcher.SendAsync<CreateTrainingPlan, Domain.TrainingPlan>(new CreateTrainingPlan
            {
                AggregateRootId = Guid.NewGuid(),
                Name = model.Name
            });
        }
    }
}
