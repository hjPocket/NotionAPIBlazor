using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NotionAPIBlazor.Shared.Notion.Models.Common;

namespace NotionAPIBlazor.Shared.Notion.Models.Databases.Properties
{
    public class RollupConfig : Property
    {
        public override PropertyType Type => PropertyType.Rollup;

        [JsonProperty("rollup")]
        public RollupType RollUp { get; set; }
    }

    public class RollupType
    {
        [JsonProperty("relation_property_name")]
        public string RelationName { get; set; }

        [JsonProperty("relation_property_id")]
        public string RelationId { get; set; }

        [JsonProperty("rollup_property_name")]
        public string RollupName { get; set; }

        [JsonProperty("rollup_property_id")]
        public string RullupId { get; set; }

        [JsonProperty("function")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FunctionValue Function { get; set; }
    }
}
