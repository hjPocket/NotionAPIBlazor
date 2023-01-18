using JsonSubTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NotionAPIBlazor.Shared.Notion.Models.Pages.Properties
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(PageTitleConfig), PagePropertyType.Title)]
    [JsonSubtypes.KnownSubType(typeof(PageTextConfig), PagePropertyType.RichText)]
    [JsonSubtypes.KnownSubType(typeof(PageNumberConfig), PagePropertyType.Number)]
    [JsonSubtypes.KnownSubType(typeof(PageSelectConfig), PagePropertyType.Select)]
    [JsonSubtypes.KnownSubType(typeof(PageStatusConfig), PagePropertyType.Status)]
    [JsonSubtypes.KnownSubType(typeof(PageMultiSelectConfig), PagePropertyType.MultiSelect)]
    [JsonSubtypes.KnownSubType(typeof(PageDateConfig), PagePropertyType.Date)]
    [JsonSubtypes.KnownSubType(typeof(PagePeopleConfig), PagePropertyType.People)]
    [JsonSubtypes.KnownSubType(typeof(PageFilesConfig), PagePropertyType.Files)]
    [JsonSubtypes.KnownSubType(typeof(PageCheckboxConfig), PagePropertyType.Checkbox)]
    [JsonSubtypes.KnownSubType(typeof(PageURLConfig), PagePropertyType.Url)]
    [JsonSubtypes.KnownSubType(typeof(PageEmailConfig), PagePropertyType.Email)]
    [JsonSubtypes.KnownSubType(typeof(PagePhoneNumberConfig), PagePropertyType.PhoneNumber)]
    [JsonSubtypes.KnownSubType(typeof(PageFormulaConfig), PagePropertyType.Formula)]
    [JsonSubtypes.KnownSubType(typeof(PageRelationConfig), PagePropertyType.Relation)]
    [JsonSubtypes.KnownSubType(typeof(PageRollupConfig), PagePropertyType.Rollup)]
    [JsonSubtypes.KnownSubType(typeof(PageCreatedTimeConfig), PagePropertyType.CreatedTime)]
    [JsonSubtypes.KnownSubType(typeof(PageCreatedByConfig), PagePropertyType.CreatedBy)]
    [JsonSubtypes.KnownSubType(typeof(PageLastEditedTimeConfig), PagePropertyType.LastEditedTime)]
    [JsonSubtypes.KnownSubType(typeof(PageLastEditedByConfig), PagePropertyType.LastEditedBy)]
    public class PageProperty
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public virtual PagePropertyType Type { get; set; }
    }
}
