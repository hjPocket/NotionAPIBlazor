using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace NotionAPIBlazor.Server.Notion.Models.Filter
{
    public class TextPropFilter
    {
        public class Condition
        {
            public Condition(
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
            public string StartsWith { get; set;}

            [JsonProperty("ends_with")]
            public string EndsWith { get; set; }

            [JsonProperty("is_empty")]
            public bool? IsEmpty { get; set; }

            [JsonProperty("is_not_empty")]
            public bool? IsNotEmpty { get; set; }
        }
    }


    public class TitleFilter : PropertyFilter
    {
        public TitleFilter(
            string propertyName,
            string equals = null,
            string does_not_equals = null,
            string contains = null,
            string does_not_contain = null,
            string starts_with = null,
            string ends_with = null,
            bool? is_empty = null,
            bool? is_not_empty = null)
        {
            Property = propertyName;

            Title = new TextPropFilter.Condition(
                equals,
                does_not_equals,
                contains,
                does_not_contain,
                starts_with,
                ends_with,
                is_empty,
                is_not_empty);
        }

        [JsonProperty("title")]
        public TextPropFilter.Condition Title { get; set; }
    }

    public class RichTextFilter : PropertyFilter
    {
        public RichTextFilter(
            string propertyName,
            string equals = null,
            string does_not_equals = null,
            string contains = null,
            string does_not_contain = null,
            string starts_with = null,
            string ends_with = null,
            bool? is_empty = null,
            bool? is_not_empty = null)
        {
            Property = propertyName;

            RichText = new TextPropFilter.Condition(
                equals,
                does_not_equals,
                contains,
                does_not_contain,
                starts_with,
                ends_with,
                is_empty,
                is_not_empty);
        }

        [JsonProperty("rich_text")]
        public TextPropFilter.Condition RichText { get; set; }
    }

    public class UrlFilter : PropertyFilter
    {
        public UrlFilter(
            string propertyName,
            string equals = null,
            string does_not_equals = null,
            string contains = null,
            string does_not_contain = null,
            string starts_with = null,
            string ends_with = null,
            bool? is_empty = null,
            bool? is_not_empty = null)
        {
            Property = propertyName;

            URL = new TextPropFilter.Condition(
                equals,
                does_not_equals,
                contains,
                does_not_contain,
                starts_with,
                ends_with,
                is_empty,
                is_not_empty);
        }

        [JsonProperty("url")]
        public TextPropFilter.Condition URL { get; set; }
    }

    public class EmailFilter : PropertyFilter
    {
        public EmailFilter(
            string propertyName,
            string equals = null,
            string does_not_equals = null,
            string contains = null,
            string does_not_contain = null,
            string starts_with = null,
            string ends_with = null,
            bool? is_empty = null,
            bool? is_not_empty = null)
        {
            Property = propertyName;

            Email = new TextPropFilter.Condition(
                equals,
                does_not_equals,
                contains,
                does_not_contain,
                starts_with,
                ends_with,
                is_empty,
                is_not_empty);
        }

        [JsonProperty("email")]
        public TextPropFilter.Condition Email { get; set; }
    }

    public class PhoneNumberFilter : PropertyFilter
    {
        public PhoneNumberFilter(
            string propertyName,
            string equals = null,
            string does_not_equals = null,
            string contains = null,
            string does_not_contain = null,
            string starts_with = null,
            string ends_with = null,
            bool? is_empty = null,
            bool? is_not_empty = null)
        {
            Property = propertyName;

            PhoneNumber = new TextPropFilter.Condition(
                equals,
                does_not_equals,
                contains,
                does_not_contain,
                starts_with,
                ends_with,
                is_empty,
                is_not_empty);
        }

        [JsonProperty("phone_number")]
        public TextPropFilter.Condition PhoneNumber { get; set; }
    }
}
