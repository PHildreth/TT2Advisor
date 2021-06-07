using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CraftingAdvisor.Classes.MyBuild;
using Newtonsoft.Json;
using System.IO;

namespace CraftingAdvisor.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerBuildController : ControllerBase
    {
        private readonly ILogger<PlayerBuildController> _logger;

        public PlayerBuildController(ILogger<PlayerBuildController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Build Get()
        {
            var myBuild = new Build();

            using var reader = new StreamReader("C:\\Users\\phild\\source\\repos\\TT2Advisor\\CraftingAdvisor\\Classes\\Deber.json");
            string json = reader.ReadToEnd();
            JsonConvert.DeserializeObject<Build>(json);

            return myBuild;
        }
    }
}
