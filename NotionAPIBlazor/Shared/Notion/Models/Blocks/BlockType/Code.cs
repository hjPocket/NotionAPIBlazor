
using NotionAPIBlazor.Shared.Notion.Models.Common.RichText;

namespace NotionAPIBlazor.Shared.Notion.Models.Blocks.BlockType
{
    public class Code
    {
        public List<RichText> rich_text { get; set; }

        public List<RichText> caption { get; set; }

        public string language { get; set; }
    }
}
