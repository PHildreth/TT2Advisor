using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace TT2Advisor.Import
{
    public interface IImportService
    {
        Task<JObject> ParseJson(string rawJson);
        Task<ImportBuild> ImportBuildFromJson(JObject json);
    }
}