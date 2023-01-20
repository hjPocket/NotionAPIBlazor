using NotionAPIBlazor.Shared.Notion.Models.Blocks.BlockType;
using NotionAPIBlazor.Shared.Notion.Models.Common;
using NotionAPIBlazor.Shared.Notion.Models.Common.Parent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionAPIBlazor.Shared.Notion.Models.Blocks
{
    public class Block
    {
        public string @object { get; set; }

        public string id { get; set; }

        public ParentObject parent { get; set; }

        public string type { get; set; }

        public string created_time { get; set; }

        public PartialUser created_by { get; set; }

        public string last_edited_time { get; set; }

        public PartialUser last_edited_by { get; set; }

        public bool archived { get; set; }

        public bool has_children { get; set; }


        //block type objects

        public CommonType? paragraph { get; set; }

        public Heading heading_1 { get; set; }

        public Heading heading_2 { get; set;}

        public Heading heading_3 { get; set; }

        public Callout callout { get; set; }

        public CommonType quote { get; set; }

        public CommonType bulleted_list_item { get; set; }

        public CommonType numbered_list_item { get; set; }

        public Todo to_do { get; set; }

        public CommonType toggle { get; set; }

        public Code code { get; set; }

        public ChildPage child_page { get; set; }

        public ChildPage child_database { get; set; }

        public Embed embed { get; set; }

        public CommonMediaType image { get; set; }

        public CommonMediaType video { get; set; }

        public CommonMediaType file { get; set; }

        public CommonMediaType pdf { get; set; }

        public Embed bookmark { get; set; }

        public Equation equation { get; set; }

        public object divider { get; set; }

        public TableOfContents table_of_contents { get; set; }

        public object breadcrumb { get; set; }

        public Column column_list { get; set; }

        public Column column { get; set; }

        public Embed link_preview { get; set; }

        public Template template { get; set; }

        public LinkToPage link_to_page { get; set; }

        public SyncedBlock synced_block { get; set; }

        public Table table { get; set; }
    }
}
