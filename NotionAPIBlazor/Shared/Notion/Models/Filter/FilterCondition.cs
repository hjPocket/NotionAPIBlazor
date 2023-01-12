using Newtonsoft.Json;

namespace NotionAPIBlazor.Shared.Notion.Models.Filter
{
    public class FilterCondition
    {
        //text condition
        public class TextCondition
        {
            public TextCondition(
                string equals = null,
                string does_not_equals = null,
                string contains = null,
                string does_not_contain = null,
                string starts_with = null,
                string ends_with = null,
                bool? is_empty = null,
                bool? is_not_empty = null)
            {
                Equals = equals;
                DoesNotEquals = does_not_equals;
                Contains = contains;
                DoesNotContain = does_not_contain;
                StartsWith = starts_with;
                EndsWith = ends_with;
                IsEmpty = is_empty;
                IsNotEmpty = is_not_empty;
            }

            [JsonProperty("equals")]
            public string Equals { get; set; }

            [JsonProperty("does_not_equals")]
            public string DoesNotEquals { get; set; }

            [JsonProperty("contains")]
            public string Contains { get; set; }

            [JsonProperty("does_not_contain")]
            public string DoesNotContain { get; set; }

            [JsonProperty("starts_with")]
            public string StartsWith { get; set; }

            [JsonProperty("ends_with")]
            public string EndsWith { get; set; }

            [JsonProperty("is_empty")]
            public bool? IsEmpty { get; set; }

            [JsonProperty("is_not_empty")]
            public bool? IsNotEmpty { get; set; }
        }

        //status condition
        public class StatusCondition
        {
            public StatusCondition(
                string equals = null,
                string does_not_equal = null,
                bool? is_empty = null,
                bool? is_not_empty = null)
            {
                Equals = equals;
                DoesNotEqual = does_not_equal;
                IsEmpty = is_empty;
                IsNotEmpty = is_not_empty;
            }

            [JsonProperty("equals")]
            public string Equals { get; set; }

            [JsonProperty("does_not_equal")]
            public string DoesNotEqual { get; set; }

            [JsonProperty("is_empty")]
            public bool? IsEmpty { get; set; }

            [JsonProperty("is_not_empty")]
            public bool? IsNotEmpty { get; set; }
        }

        //select condition
        public class SelectCondition
        {
            public SelectCondition(
                string equals = null,
                string does_not_equal = null,
                bool? is_empty = null,
                bool? is_not_empty = null)
            {
                Equals = equals;
                DoesNotEqual = does_not_equal;
                IsEmpty = is_empty;
                IsNotEmpty = is_not_empty;
            }

            [JsonProperty("equals")]
            public string Equals { get; set; }

            [JsonProperty("does_not_equal")]
            public string DoesNotEqual { get; set; }

            [JsonProperty("is_empty")]
            public bool? IsEmpty { get; set; }

            [JsonProperty("is_not_empty")]
            public bool? IsNotEmpty { get; set; }
        }

        public class RelationCondition
        {
            public RelationCondition(
                string contains = null,
                string does_not_contain = null,
                bool? is_empty = null,
                bool? is_not_empty = null)
            {
                Contains = contains;
                DoesNotContain = does_not_contain;
                IsEmpty = is_empty;
                IsNotEmpty = is_not_empty;
            }

            [JsonProperty("contains")]
            public string Contains { get; set; }

            [JsonProperty("does_not_contain")]
            public string DoesNotContain { get; set; }

            [JsonProperty("is_empty")]
            public bool? IsEmpty { get; set; }

            [JsonProperty("is_not_empty")]
            public bool? IsNotEmpty { get; set; }
        }

        //number condition
        public class NumberCondition
        {
            public NumberCondition(
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

        public class MultiSelectCondition
        {
            public MultiSelectCondition(
                string contains = null,
                string does_not_contain = null,
                bool? is_empty = null,
                bool? is_not_empty = null)
            {
                Contains = contains;
                DoesNotContain = does_not_contain;
                IsEmpty = is_empty;
                IsNotEmpty = is_not_empty;
            }

            [JsonProperty("contains")]
            public string Contains { get; set; }

            [JsonProperty("does_not_contain")]
            public string DoesNotContain { get; set; }

            [JsonProperty("is_empty")]
            public bool? IsEmpty { get; set; }

            [JsonProperty("is_not_empty")]
            public bool? IsNotEmpty { get; set; }
        }

        //file condition
        public class FileCondition
        {
            public FileCondition(
                bool? is_empty = null,
                bool? is_not_empty = null)
            {
                IsEmpty = is_empty;
                IsNotEmpty = is_not_empty;
            }

            [JsonProperty("is_empty")]
            public bool? IsEmpty { get; set; }

            [JsonProperty("is_not_empty")]
            public bool? IsNotEmpty { get; set; }
        }

        public class DateCondition
        {
            public DateCondition(
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
                Equals = equals;
                Before = before;
                After = after;
                OnOrBefore = on_or_before;
                IsEmpty = is_empty;
                IsNotEmpty = is_not_empty;
                OnOrAfter = on_or_after;
                PastWeek = past_week;
                PastMonth = past_month;
                PastYear = past_year;
                ThisWeek = this_week;
                NextWeek = next_week;
                NextMonth = next_month;
                NextYear = next_year;
            }

            [JsonProperty("equals")]
            public string Equals { get; set; }

            [JsonProperty("before")]
            public string Before { get; set; }

            [JsonProperty("after")]
            public string After { get; set; }

            [JsonProperty("on_or_before")]
            public string OnOrBefore { get; set; }

            [JsonProperty("is_empty")]
            public bool? IsEmpty { get; set; }

            [JsonProperty("is_not_empty")]
            public bool? IsNotEmpty { get; set; }

            [JsonProperty("on_or_after")]
            public string OnOrAfter { get; set; }

            [JsonProperty("past_week")]
            public object PastWeek { get; set; }

            [JsonProperty("past_month")]
            public object PastMonth { get; set; }

            [JsonProperty("past_year")]
            public object PastYear { get; set; }

            [JsonProperty("this_week")]
            public object ThisWeek { get; set; }

            [JsonProperty("next_week")]
            public object NextWeek { get; set; }

            [JsonProperty("next_month")]
            public object NextMonth { get; set; }

            [JsonProperty("next_year")]
            public object NextYear { get; set; }
        }

        public class CheckboxCondition
        {
            public CheckboxCondition(
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

        public class RollUpCondition
        {
            public RollUpCondition(
                object? any = null, 
                object? every = null, 
                object? none = null,
                NumberCondition? number = null,
                DateCondition? date = null)
            {
                Any = any;
                Every = every;
                None = none;
                Number = number;
                Date = date;
            }

            [JsonProperty("any")]
            public object? Any { get; set; }

            [JsonProperty("every")]
            public object? Every { get; set; }

            [JsonProperty("none")]
            public object? None { get; set; }

            [JsonProperty("number")]
            public NumberCondition? Number { get; set; }

            [JsonProperty("date")]
            public DateCondition? Date { get; set; }
        }

        public class FormulaCondition
        {
            public FormulaCondition(
                TextCondition? _string = null,
                CheckboxCondition? _checkbox = null,
                NumberCondition? _number = null,
                DateCondition? _date = null)
            {
                String = _string;
                Checkbox = _checkbox;
                Number = _number;
                Date = _date;
            }

            [JsonProperty("string")]
            public TextCondition? String { get; set; }

            [JsonProperty("checkbox")]
            public CheckboxCondition? Checkbox { get; set; }

            [JsonProperty("number")]
            public NumberCondition? Number { get; set; }

            [JsonProperty("date")]
            public DateCondition? Date { get; set; }
        }
    }
}
