using Newtonsoft.Json;
using NotionAPIBlazor.Shared.Notion.Models.Common.RichText;

namespace NotionAPIBlazor.Shared.Notion.Models.Pages.Properties
{
    public class PageTitleConfig : PageProperty
    {
        public override PagePropertyType Type => PagePropertyType.Title;

        [JsonProperty("title")]
        public List<RichText> Title { get; set; }
    }
}
