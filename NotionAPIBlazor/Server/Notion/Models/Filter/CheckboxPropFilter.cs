using Newtonsoft.Json;

namespace NotionAPIBlazor.Server.Notion.Models.Filter
{
    public class CheckboxPropFilter
    {
        public class Condition
        {
            public Condition(
                bool? equals = null,
                bool? does_not_equal = null)
            {
                Equals = equals;
                DoesNotEqual = does_not_equal;
            }

            [JsonProperty("equals")]
            public bool? Equals { get; set; }

            [JsonProperty("does_not_equal")]
            public bool? DoesNotEqual { get; set; }
        }
    }
}
