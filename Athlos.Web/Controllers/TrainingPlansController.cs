using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Athlos.Api.Models;
using Athlos.Command;
using Athlos.Query;
using Kledex;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Athlos.Api.Controllers
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

        [HttpGet]
        public async Task<IEnumerable<TrainingPlanModel>> GetAllForAthlete()
        {
            return (await _dispatcher.GetResultAsync(new GetTrainingPlansForAthlete
            {
                AthleteId = Guid.Parse("7a0ac2d6-56b8-4e9c-b616-6a2234560860") //TODO: provide athlete id from context
            })).Select(p => new TrainingPlanModel
            {
                Id = p.Id,
                Name = p.Name
            });
        }

        [HttpPost]
        public async Task Create([FromBody] CreateTrainingPlanModel model)
        {
            await _dispatcher.SendAsync<CreateTrainingPlan, Domain.TrainingPlan>(new CreateTrainingPlan
            {
                UserId = "7a0ac2d6-56b8-4e9c-b616-6a2234560860",
                Name = model.Name
            });
        }
    }
}
