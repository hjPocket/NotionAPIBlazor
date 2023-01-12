using Newtonsoft.Json;
using static NotionAPIBlazor.Shared.Notion.Models.Filter.FilterCondition;

namespace NotionAPIBlazor.Shared.Notion.Models.Filter.Property
{

    public class MultiSelectFilter : PropertyFilter
    {
        public MultiSelectFilter(
            string propertyName,
            string contains = null,
            string does_not_contain = null,
            bool? is_empty = null,
            bool? is_not_empty = null)
        {
            Property = propertyName;

            MultiSelect = new MultiSelectCondition(contains, does_not_contain, is_empty, is_not_empty);
        }

        [JsonProperty("multi_select")]
        public MultiSelectCondition MultiSelect { get; set; }
    }
}
