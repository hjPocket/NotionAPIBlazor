using Newtonsoft.Json;
using static NotionAPIBlazor.Shared.Notion.Models.Filter.FilterCondition;

namespace NotionAPIBlazor.Shared.Notion.Models.Filter.Property
{
    public class NumberFilter : PropertyFilter
    {
        public NumberFilter(
            string propertyName,
            int? equals = null,
            int? does_not_equal = null,
            int? greater_than = null,
            int? less_than = null,
            int? greater_than_or_equal_to = null,
            int? less_than_or_equal_to = null,
            bool? is_empty = null,
            bool? is_not_empty = null)
        {
            Property = propertyName;

            Number = new NumberCondition(
                equals,
                does_not_equal,
                greater_than,
                less_than,
                greater_than_or_equal_to,
                less_than_or_equal_to,
                is_empty,
                is_not_empty);
        }

        [JsonProperty("number")]
        public NumberCondition Number { get; set; }
    }
}
