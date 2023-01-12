using Newtonsoft.Json;
using static NotionAPIBlazor.Shared.Notion.Models.Filter.FilterCondition;

namespace NotionAPIBlazor.Shared.Notion.Models.Filter.Property
{
    public class SelectFilter : PropertyFilter
    {
        public SelectFilter(
            string propertyName,
            string equals = null,
            string does_not_equal = null,
            bool? is_empty = null,
            bool? is_not_empty = null)
        {
            Property = propertyName;

            Select = new SelectCondition(equals, does_not_equal, is_empty, is_not_empty);
        }

        [JsonProperty("select")]
        public SelectCondition Select { get; set; }
    }
}
