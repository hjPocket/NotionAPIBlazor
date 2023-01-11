using JsonSubTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace NotionAPIBlazor.Server.Notion.Models.Databases.Properties
{
    public class RelationConfig : Property
    {
        public override PropertyType Type => PropertyType.Relation;

        [JsonProperty("relation")]
        public RelationType Relation { get; set; }
    }

    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(TypeValue), TypeValue.Dual)]
    [JsonSubtypes.KnownSubType(typeof(TypeValue), TypeValue.Single)]
    public class RelationType
    {
        [JsonProperty("database_id")]
        public string DatabaseId { get; set; }

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TypeValue type { get; set; }
    }

    public enum TypeValue
    {
        [EnumMember(Value = "single_property")]
        Single,

        [EnumMember(Value = "dual_property")]
        Dual
    }

    public class SingleProperty
    {
        [JsonProperty("single_property")]
        public string Single { get; set; }
    }

    public class DualProperty
    {
        [JsonProperty("synced_property_name")]
        public string SyncedName { get; set; }

        [JsonProperty("synced_property_id")]
        public string SyncedId { get; set; }
    }
}
