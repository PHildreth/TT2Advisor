using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TT2Advisor.Artifacts;
using TT2Advisor.PlayerBuild;
using static TT2Advisor.Artifacts.ArtifactsRepo;

namespace TT2Advisor.UI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyBuildController : ControllerBase
    {

        private readonly ILogger<MyBuildController> _logger;

        public MyBuildController(ILogger<MyBuildController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Build Get()
        {
            using var reader = new StreamReader("C:\\Users\\phild\\source\\repos\\TT2Advisor\\Common\\Deber.json");
            var rawJson = reader.ReadToEnd();

            JObject json = JObject.Parse(rawJson);

            var myBuild = new Build(json);

            return myBuild;
        }
    }
}
