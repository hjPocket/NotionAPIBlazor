using Newtonsoft.Json;
using static NotionAPIBlazor.Shared.Notion.Models.Filter.FilterCondition;

namespace NotionAPIBlazor.Shared.Notion.Models.Filter.Property
{
    public class CheckboxFilter : PropertyFilter
    {
        public CheckboxFilter(
            string propertyName,
            bool? equals = null,
            bool? does_not_equal = null)
        {
            Property = propertyName;

            Checkbox = new CheckboxCondition(equals, does_not_equal);
        }

        [JsonProperty("checkbox")]
        public CheckboxCondition Checkbox { get; set; }
    }
}
