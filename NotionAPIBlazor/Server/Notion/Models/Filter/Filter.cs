using Newtonsoft.Json;

namespace NotionAPIBlazor.Server.Notion.Models.Filter
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
            And = and;
            Or = or;
        }

        [JsonProperty("and")]
        public List<Filter> And { get; set; }

        [JsonProperty("or")]
        public List<Filter> Or { get; set; }
    }
}
