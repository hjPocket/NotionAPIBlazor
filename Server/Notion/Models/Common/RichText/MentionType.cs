using Newtonsoft.Json;
using NotionAPIBlazor.Server.Notion.Models.Databases;

namespace NotionAPIBlazor.Server.Notion.Models.Common.RichText
{
    public class MentionType : RichText
    {
        public override RichTextType Type => RichTextType.Mention;

        [JsonProperty("mention")]
        public Mention Mention { get; set; }
    }

    public class Mention
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("database")]
        public IDValue? Database { get; set; }

        [JsonProperty("date")]
        public DateValue? Date { get; set; }

        [JsonProperty("link_preview")]
        public LinkPreviewValue? LinkPreview { get; set; }

        [JsonProperty("page")]
        public IDValue? Page { get; set; }

        [JsonProperty("template_mention")]
        public TemplateMentionValue? TemplateMention { get; set; }

        [JsonProperty("user")]
        public PartialUser? User { get; set; }
    }

    public class IDValue
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class DateValue
    {
        [JsonProperty("start")]
        public DateTime? Start { get; set; }

        [JsonProperty("end")]
        public DateTime? End { get; set; }
    }
    public class LinkPreviewValue
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class TemplateMentionValue
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("template_mention_date")]
        public string? TDate { get; set; }

        [JsonProperty("template_mention_user")]
        public string? TUser { get; set; }
    }
}
