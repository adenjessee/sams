using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeroesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<HeroesController> _logger;

        public HeroesController(ILogger<HeroesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Hero> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Hero
            {
                Name = "Hero#" + index.ToString(),
                id = index
            })
            .ToArray();
        }

        [HttpGet("{id}")]
        public Hero GetQuery(int id)
        {
            return new Hero
            {
                Name = "Hero#" + id.ToString(),
                id = id
            };
        }
    }
}
