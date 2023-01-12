using Newtonsoft.Json;
using static NotionAPIBlazor.Shared.Notion.Models.Filter.FilterCondition;

namespace NotionAPIBlazor.Shared.Notion.Models.Filter.Property
{
    public class FormulaFilter : PropertyFilter
    {
        public FormulaFilter(
            string propertyName,
            TextCondition? _string = null,
            CheckboxCondition? _checkbox = null,
            NumberCondition? _number = null,
            DateCondition? _date = null) 
        {
            Property= propertyName;

            Formula = new FormulaCondition(_string, _checkbox, _number, _date);
        }

        [JsonProperty("formula")]
        public FormulaCondition? Formula { get; set; }
    }
}
