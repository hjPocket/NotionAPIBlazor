using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionAPIBlazor.Shared.Notion.Models.Common.Parent
{
    public class ParentObject
    {
        public string type { get; set; }

        public string? database_id { get; set; }

        public string? page_id { get; set; }

        public string? block_id { get; set; }

        public string? workspace { get; set; }
    }
}
