using Newtonsoft.Json;
using static NotionAPIBlazor.Shared.Notion.Models.Filter.FilterCondition;

namespace NotionAPIBlazor.Shared.Notion.Models.Filter.Property
{
    public class TitleFilter : PropertyFilter
    {
        public TitleFilter(
            string propertyName,
            string equals = null,
            string does_not_equals = null,
            string contains = null,
            string does_not_contain = null,
            string starts_with = null,
            string ends_with = null,
            bool? is_empty = null,
            bool? is_not_empty = null)
        {
            Property = propertyName;

            Title = new(
                equals,
                does_not_equals,
                contains,
                does_not_contain,
                starts_with,
                ends_with,
                is_empty,
                is_not_empty);
        }

        [JsonProperty("title")]
        public TextCondition Title { get; set; }
    }
}
