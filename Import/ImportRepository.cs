using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TT2Advisor.Import
{
    public class ImportRepository : IImportRepository
    {
        //private readonly ILogger _logger;

        public ImportRepository()//ILogger logger)
        {
            //_logger = logger;
        }

        public async Task<JObject> ParseJson(string rawJson)
        {
            return (JObject)JsonConvert.DeserializeObject(rawJson);
        }

        public async Task<ImportBuild> ImportBuildFromJson(JObject json)
        {
            return JsonConvert.DeserializeObject<ImportBuild>(json.ToString());
        }
    }
}
