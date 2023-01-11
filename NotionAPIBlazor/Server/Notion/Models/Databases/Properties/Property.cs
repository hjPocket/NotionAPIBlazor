using JsonSubTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NotionAPIBlazor.Server.Notion.Models.Databases.Properties
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(TitleConfig), PropertyType.Title)]
    [JsonSubtypes.KnownSubType(typeof(TextConfig), PropertyType.RichText)]
    [JsonSubtypes.KnownSubType(typeof(NumberConfig), PropertyType.Number)]
    [JsonSubtypes.KnownSubType(typeof(SelectConfig), PropertyType.Select)]
    [JsonSubtypes.KnownSubType(typeof(StatusConfig), PropertyType.Status)]
    [JsonSubtypes.KnownSubType(typeof(MultiSelectConfig), PropertyType.MultiSelect)]
    [JsonSubtypes.KnownSubType(typeof(DateConfig), PropertyType.Date)]
    [JsonSubtypes.KnownSubType(typeof(PeopleConfig), PropertyType.People)]
    [JsonSubtypes.KnownSubType(typeof(FilesConfig), PropertyType.Files)]
    [JsonSubtypes.KnownSubType(typeof(CheckboxConfig), PropertyType.Checkbox)]
    [JsonSubtypes.KnownSubType(typeof(URLConfig), PropertyType.Url)]
    [JsonSubtypes.KnownSubType(typeof(EmailConfig), PropertyType.Email)]
    [JsonSubtypes.KnownSubType(typeof(PhoneNumberConfig), PropertyType.PhoneNumber)]
    [JsonSubtypes.KnownSubType(typeof(FormulaConfig), PropertyType.Formula)]
    [JsonSubtypes.KnownSubType(typeof(RelationConfig), PropertyType.Relation)]
    [JsonSubtypes.KnownSubType(typeof(RollupConfig), PropertyType.Rollup)]
    [JsonSubtypes.KnownSubType(typeof(CreatedTimeConfig), PropertyType.CreatedTime)]
    [JsonSubtypes.KnownSubType(typeof(CreatedByConfig), PropertyType.CreatedBy)]
    [JsonSubtypes.KnownSubType(typeof(LastEditedTimeConfig), PropertyType.LastEditedTime)]
    [JsonSubtypes.KnownSubType(typeof(LastEditedByConfig), PropertyType.LastEditedBy)]
    public class Property
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")] 
        public string Name { get;set; }

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public virtual PropertyType Type { get; set; }
    }
}
