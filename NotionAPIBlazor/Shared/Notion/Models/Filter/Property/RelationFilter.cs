using Newtonsoft.Json;
using static NotionAPIBlazor.Shared.Notion.Models.Filter.FilterCondition;

namespace NotionAPIBlazor.Shared.Notion.Models.Filter.Property
{
    public class RelationFilter : PropertyFilter
    {
        public RelationFilter(
            string propertyName,
            string contains = null,
            string does_not_contain = null,
            bool? is_empty = null,
            bool? is_not_empty = null)
        {
            Property = propertyName;

            Relation = new RelationCondition(contains, does_not_contain, is_empty, is_not_empty);
        }

        [JsonProperty("relation")]
        public RelationCondition Relation { get; set; }
    }
}
