using Newtonsoft.Json;
using NotionAPIBlazor.Shared.Notion.Models.User;

namespace NotionAPIBlazor.Shared.Notion.Models.Common.RichText
{
    public class Mention
    {
        public string type { get; set; }

        public IDValue? database { get; set; }

        public DateValue? date { get; set; }

        public LinkPreviewValue? link_preview { get; set; }

        public IDValue? page { get; set; }

        public TemplateMentionValue? template_mention { get; set; }

        public PartialUser? user { get; set; }
    }

    public class IDValue
    {
        public string id { get; set; }
    }

    public class DateValue
    {
        public string? start { get; set; }

        public string? end { get; set; }
    }
    public class LinkPreviewValue
    {
        public string url { get; set; }
    }

    public class TemplateMentionValue
    {
        public string type { get; set; }

        public string? template_mention_date { get; set; }

        public string? template_mention_user { get; set; }
    }
}
