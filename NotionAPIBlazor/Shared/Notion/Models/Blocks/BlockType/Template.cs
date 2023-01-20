
using NotionAPIBlazor.Shared.Notion.Models.Common.RichText;

namespace NotionAPIBlazor.Shared.Notion.Models.Blocks.BlockType
{
    public class Template
    {
        public List<RichText> rich_text { get; set; }

        public List<Block> children { get; set; }
    }
}
