using JsonSubTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace NotionAPIBlazor.Shared.Notion.Models.Databases.Properties
{
    public class RelationObject
    {
        public string database_id { get; set; }

        public string type { get; set; }
    }

    public class RelationType
    {
        public string? single_property { get; set; }

        public DualProperty? dual_property { get; set; }
    }

    public class DualProperty
    {
        public string synced_property_name { get; set; }

        public string synced_property_id { get; set; }
    }
}