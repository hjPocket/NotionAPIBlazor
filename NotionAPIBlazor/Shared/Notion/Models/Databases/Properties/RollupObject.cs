using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NotionAPIBlazor.Shared.Notion.Models.Common;

namespace NotionAPIBlazor.Shared.Notion.Models.Databases.Properties
{
    public class RollupObject
    {
        public string relation_property_name { get; set; }

        public string relation_property_id { get; set; }

        public string rollup_property_name { get; set; }

        public string rollup_property_id { get; set; }

        public FunctionValue function { get; set; }
    }
}
