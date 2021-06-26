using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Threading.Tasks;
using TT2Advisor.Common.Interfaces;
using TT2Advisor.Import;
using TT2Advisor.PlayerBuild;

namespace TT2Advisor.UI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyBuildController : ControllerBase
    {
        private readonly IBuildService _buildService;
        private readonly IImportService _importService;
        private readonly ILogger<MyBuildController> _logger;

        public MyBuildController(IBuildService buildService, IImportService importService, ILogger<MyBuildController> logger)
        {
            _buildService = buildService;
            _importService = importService;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IBuild), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> Get()
        {
            using var reader = new StreamReader("C:\\Users\\phild\\source\\repos\\TT2Advisor\\Common\\Deber.json");
            var rawJson = reader.ReadToEnd();

            JObject json = await _importService.ParseJson(rawJson); // JObject.Parse(rawJson);

            var importBuild = await _importService.ImportBuildFromJson(json); // new Build(json);

            var myBuild = await _buildService.CreateFromImport(importBuild);

            return Ok(myBuild);
        }
    }
}
