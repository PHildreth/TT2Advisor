using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;
using System.Web;

namespace TT2Advisor.Import
{
    public class ImportService : IImportService
    {
        private readonly IImportRepository _importRepository;
        //private readonly ILogger _logger;

        public ImportService(IImportRepository importRepository)//, ILogger logger)
        {
            _importRepository = importRepository;
            //_logger = logger;
        }

        public async Task<JObject> ParseJson(string rawJson)
        {
            return await _importRepository.ParseJson(rawJson);
        }

        public async Task<ImportBuild> ImportBuildFromJson(JObject json)
        {
            return await _importRepository.ImportBuildFromJson(json);
        }
    }
}
