using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Athlos.Application
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrainingPlansController : ControllerBase
    {
        private readonly ILogger<TrainingPlansController> _logger;

        public TrainingPlansController(ILogger<TrainingPlansController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("{id}")]
        public TrainingPlan Get(Guid id)
        {
            _logger.LogInformation($"Getting training plan with id {id} ...");

            return new TrainingPlan();
        }
    }
}
