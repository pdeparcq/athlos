using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Athlos.Api.Models;
using Athlos.Command;
using Athlos.Domain;
using Athlos.Query;
using Kledex;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Athlos.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AthletesController : ControllerBase
    {

        private readonly ILogger<AthletesController> _logger;
        private readonly IDispatcher _dispatcher;

        public AthletesController(ILogger<AthletesController> logger, IDispatcher dispatcher)
        {
            _logger = logger;
            _dispatcher = dispatcher;
        }

        [HttpGet]
        public async Task<IEnumerable<AthleteListModel>> GetAll()
        {
            return (await _dispatcher.GetResultAsync(new GetAthletes())).Select(a => new AthleteListModel()
            {
                Id = a.Id,
                StravaId = a.StravaId,
                FullName = a.FullName
            });
        }

        [HttpPost]
        [Route("")]
        public async Task Register([FromBody] RegisterAthleteModel model)
        {
            await _dispatcher.SendAsync<RegisterAthlete, Athlete>(new RegisterAthlete
            {
                StravaId = model.StravaId,
                FullName = model.FullName
            });
        }
    }
}
