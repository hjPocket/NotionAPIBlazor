using Newtonsoft.Json;
using static NotionAPIBlazor.Shared.Notion.Models.Filter.FilterCondition;

namespace NotionAPIBlazor.Shared.Notion.Models.Filter.Property
{
    public class RollupFilter : PropertyFilter
    {
        public RollupFilter(
            string propertyName,
            object? any = null,
            object? every = null,
            object? none = null,
            NumberCondition? number = null,
            DateCondition? date = null)
        {
            Property = propertyName;

            RollUp = new RollUpCondition(any, every, none, number, date);
        }

        [JsonProperty("rollup")]
        public RollUpCondition RollUp { get; set; }
    }
}
