using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFPlanningApi.domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AFPlanningApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomController 
        : ControllerBase
    {
        private readonly ILogger<RoomController> _logger;

        public RoomController(ILogger<RoomController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var sprint22 = new Sprint
            {
                Name = "Sprint 22",
                Goal = "Entregar o Planning Poker",
                StartDate = new DateTime(2021,07,12),
                EndDate = new DateTime(2021,08,02),
                StackHolders = new List<User>
                {
                    new Observer
                    {
                        Name = "RLFilho",
                        FullName = "Ronaldo Luiz Pinto Filho",
                        Role = UserRole.QualityAssurance

                    },
                    new Player
                    {
                        Name = "Eansanto",
                        FullName = "Elvis de Andrade Santos",
                        Role = UserRole.Developer
                    },
                    new Player
                    {
                        Name = "RGDutra",
                        FullName = "Raphael Garcia Dutra",
                        Role = UserRole.TechLead,
                        Host = true
                    }

                }
            };
            var room = new Room
            {
                Sprint = sprint22,
                Timebox = 120,
                SchedulePlanningDateStart = new DateTime(2021,7,11,9,30,0),
                SchedulePlanningDateEnd = new DateTime(2021,7,11,11,30,0),
                PlanningPoker = new PlanningPoker
                {
                    Card = new ScrumCard(),
                    AllowRevealVotes = true,
                    AllowChangeVotes = true,
                    ActiveCountdownTimer = false
                }
            };

            return Ok(room);
        }
    }
}
