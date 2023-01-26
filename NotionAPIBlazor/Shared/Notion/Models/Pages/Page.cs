using Newtonsoft.Json;
using NotionAPIBlazor.Shared.Notion.Models.Common.File;
using NotionAPIBlazor.Shared.Notion.Models.Common.Parent;
using NotionAPIBlazor.Shared.Notion.Models.Pages.Properties;
using NotionAPIBlazor.Shared.Notion.Models.User;

namespace NotionAPIBlazor.Shared.Notion.Models.Pages
{
    public class Page
    {
        public string @object { get; set; }

        public string id { get; set; }

        public string created_time { get; set; }

        public PartialUser created_by { get; set; }

        public string last_edited_time { get; set; }

        public PartialUser last_edited_by { get; set; }

        public bool archived { get; set; }

        public IconProperty icon { get; set; }

        public IconProperty cover { get; set; }

        public IDictionary<string, PageProperty> properties { get; set; }

        public ParentObject parent { get; set; }

        public string url { get; set; }
    }
}
