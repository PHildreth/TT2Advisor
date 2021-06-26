using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TT2Advisor.Import;

namespace TT2Advisor.PlayerBuild
{
    public class BuildService : IBuildService
    {
        private readonly IBuildRepository _buildRepository;
        //private readonly ILogger _logger;

        public BuildService(IBuildRepository buildRepository)//, ILogger logger)
        {
            _buildRepository = buildRepository;
            //_logger = logger;
        }

        public async Task<Build> CreateFromImport(ImportBuild importBuild)
        {
            return await _buildRepository.CreateFromImport(importBuild);
        }
    }
}
