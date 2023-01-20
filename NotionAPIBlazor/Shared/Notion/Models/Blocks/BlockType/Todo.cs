
using NotionAPIBlazor.Shared.Notion.Models.Common;
using NotionAPIBlazor.Shared.Notion.Models.Common.RichText;

namespace NotionAPIBlazor.Shared.Notion.Models.Blocks.BlockType
{
    public class Todo
    {
        public List<RichText> rich_text { get; set; }

        public bool? @checked { get; set; }

        public Color color {get;set;}

        public List<Block> children { get; set; }
    }
}
