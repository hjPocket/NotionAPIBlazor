
using NotionAPIBlazor.Shared.Notion.Models.Common.File;

namespace NotionAPIBlazor.Shared.Notion.Models.Blocks.BlockType
{
    public class CommonMediaType
    {
        public string type { get; set; }

        public ExternalObject external { get; set; }
    }
}
