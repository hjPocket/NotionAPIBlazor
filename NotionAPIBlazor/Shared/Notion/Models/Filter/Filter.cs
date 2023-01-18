using Newtonsoft.Json;

namespace NotionAPIBlazor.Shared.Notion.Models.Filter
{
    public class Filter
    {
    }

    public class PropertyFilter : Filter
    {
        [JsonProperty("property")]
        public string Property { get; set; }
    }

    public class CompoundFilter : Filter
    {
        public CompoundFilter(List<Filter>? and = null, List<Filter>? or = null) {
            and = and;
            or = or;
        }

        [JsonProperty("and")]
        public List<Filter> and { get; set; }

        [JsonProperty("or")]
        public List<Filter> or { get; set; }
    }
}
