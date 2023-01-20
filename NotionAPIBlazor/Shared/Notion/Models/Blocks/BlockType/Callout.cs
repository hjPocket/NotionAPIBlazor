using NotionAPIBlazor.Shared.Notion.Models.Common;
using NotionAPIBlazor.Shared.Notion.Models.Common.File;
using NotionAPIBlazor.Shared.Notion.Models.Common.RichText;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionAPIBlazor.Shared.Notion.Models.Blocks.BlockType
{
    public class Callout
    {
        public List<RichText> rich_text { get; set; }

        public IconProperty icon { get; set; }

        public Color color { get; set; }

        public List<Block> blocks { get; set; }
    }
}
