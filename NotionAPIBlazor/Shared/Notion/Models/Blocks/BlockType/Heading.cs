using NotionAPIBlazor.Shared.Notion.Models.Common;
using NotionAPIBlazor.Shared.Notion.Models.Common.RichText;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionAPIBlazor.Shared.Notion.Models.Blocks.BlockType
{
    public class Heading
    {
        public List<RichText> rich_text { get; set; }

        public Color color { get; set; }

        public bool? is_toggleable { get; set; }
    }
}
