using Newtonsoft.Json;
using static NotionAPIBlazor.Shared.Notion.Models.Filter.FilterCondition;

namespace NotionAPIBlazor.Shared.Notion.Models.Filter.Property
{
    public class DateFilter : PropertyFilter
    {
        public DateFilter(
            string propertName,
            string equals = null,
            string before = null,
            string after = null,
            string on_or_before = null,
            bool? is_empty = null,
            bool? is_not_empty = null,
            string on_or_after = null,
            object past_week = null,
            object past_month = null,
            object past_year = null,
            object this_week = null,
            object next_week = null,
            object next_month = null,
            object next_year = null)
        {
            Property = propertName;

            Date = new DateCondition(equals, before, after, on_or_before, is_empty, is_not_empty, on_or_after,
                past_week, past_month, past_year, this_week, next_week, next_month, next_year);
        }

        [JsonProperty("date")]
        public DateCondition Date { get; set; }
    }
}
