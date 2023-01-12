using Newtonsoft.Json;
using static NotionAPIBlazor.Shared.Notion.Models.Filter.FilterCondition;

namespace NotionAPIBlazor.Shared.Notion.Models.Filter.Property
{
    public class StatusFilter : PropertyFilter
    {
        public StatusFilter(
            string propertyName,
                string equals = null,
                string does_not_equal = null,
                bool? is_empty = null,
                bool? is_not_empty = null)
        {
            Property = propertyName;

            Status = new StatusCondition(equals, does_not_equal, is_empty, is_not_empty);
        }

        [JsonProperty("status")]
        public StatusCondition Status { get; set; }
    }
}
