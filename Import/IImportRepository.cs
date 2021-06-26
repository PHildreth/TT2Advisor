using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TT2Advisor.Import
{
    public interface IImportRepository
    {
        Task<JObject> ParseJson(string rawJson);
        Task<ImportBuild> ImportBuildFromJson(JObject json);
    }
}
