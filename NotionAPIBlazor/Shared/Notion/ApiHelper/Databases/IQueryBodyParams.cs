using Newtonsoft.Json;
using NotionAPIBlazor.Shared.Notion.Models.Filter;
using NotionAPIBlazor.Shared.Notion.Models.Sort;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Databases
{
    public interface IQueryBodyParams : ICommonBody
    {
        [JsonProperty("filter")]
        public Filter Filter { get; set; }

        [JsonProperty("sort")]
        public Sort Sort { get; set; }
    }
}
