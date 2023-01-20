using NotionAPIBlazor.Shared.Notion.Models.Common.RichText;

namespace NotionAPIBlazor.Shared.Notion.Models.Databases.Properties
{
    public class Property
    {
        public string type { get; set; }

        //type field의 value에 따라 바인딩될 objects
        public string id { get; set; }

        public string name { get;set; }

        public string? title { get; set; }

        public List<RichText>? rich_text { get; set; }

        public NumberObject? number { get; set; }

        public SelectObject? select { get; set; }

        public StatusObject? status { get; set; }

        public MultiSelectObject? multi_select { get; set; }

        public object? date { get; set; }
        public object? people { get; set; }
        public object? files { get; set; }
        public object? checkbox { get; set; }
        public object? url { get; set; }
        public object? email { get; set; }
        public object? phone_number { get; set; }

        public FormulaObject? formula { get; set; }

        public RelationObject? relation { get; set; }
        public object? created_time { get; set; }
        public object? created_by { get; set; }
        public object? last_edited { get; set; }
        public object? last_edited_by { get; set; }
    }
}
