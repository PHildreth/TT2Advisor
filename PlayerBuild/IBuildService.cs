using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TT2Advisor.Import;

namespace TT2Advisor.PlayerBuild
{
    public interface IBuildService
    {
        Task<Build> CreateFromImport(ImportBuild importBuild);
    }
}
