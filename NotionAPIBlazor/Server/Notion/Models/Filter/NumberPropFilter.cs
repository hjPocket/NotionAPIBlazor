using Newtonsoft.Json;

namespace NotionAPIBlazor.Server.Notion.Models.Filter
{
    public class NumberPropFilter
    {
        public class Condition
        {
            public Condition(
                int? equals = null,
                int? does_not_equal = null,
                int? greater_than = null,
                int? less_than = null,
                int? greater_than_or_equal_to = null,
                int? less_than_or_equal_to = null,
                bool? is_empty = null,
                bool? is_not_empty = null)
            {
                Equals = equals;
                DoesNotEqual = does_not_equal;
                GreaterThan = greater_than;
                LessThan = less_than;
                GreaterThanOrEqualTo = greater_than_or_equal_to;
                LessThanOrEqualTo = less_than_or_equal_to;
                IsEmpty = is_empty;
                IsNotEmpty = is_not_empty;
            }

            [JsonProperty("equals")]
            public int? Equals { get; set; }

            [JsonProperty("does_not_equal")]
            public int? DoesNotEqual { get; set; }

            [JsonProperty("greater_than")]
            public int? GreaterThan { get; set; }

            [JsonProperty("less_than")]
            public int? LessThan { get; set; }

            [JsonProperty("greater_than_or_equal_to")]
            public int? GreaterThanOrEqualTo { get; set; }

            [JsonProperty("less_than_or_equal_to")]
            public int? LessThanOrEqualTo { get; set; }

            [JsonProperty("is_empty")]
            public bool? IsEmpty { get; set; }

            [JsonProperty("is_not_empty")]
            public bool? IsNotEmpty { get; set; }
        }
    }

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

            Number = new NumberPropFilter.Condition(
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
        public NumberPropFilter.Condition Number { get; set; }
    }
}
