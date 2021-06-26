using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TT2Advisor.Import;

namespace TT2Advisor.PlayerBuild
{
    public class BuildRepository : IBuildRepository
    {
        //private readonly ILogger _logger;

        public BuildRepository()//ILogger logger)
        {
            //_logger = logger;
        }

        public async Task<Build> CreateFromImport(ImportBuild importBuild)
        {
            return new Build(importBuild);
        }
    }
}
