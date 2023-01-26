
using NotionAPIBlazor.Shared.Notion.Models.Blocks.BlockType;

namespace NotionAPIBlazor.Shared.Notion.Models.Blocks
{
    public class BlockObject
    {
        //block type objects
        public CommonType? paragraph { get; set; }

        public Heading? heading_1 { get; set; }

        public Heading? heading_2 { get; set; }

        public Heading? heading_3 { get; set; }

        public Callout? callout { get; set; }

        public CommonType? quote { get; set; }

        public CommonType? bulleted_list_item { get; set; }

        public CommonType? numbered_list_item { get; set; }

        public Todo? to_do { get; set; }

        public CommonType? toggle { get; set; }

        public Code? code { get; set; }

        public ChildPage? child_page { get; set; }

        public ChildPage? child_database { get; set; }

        public Embed? embed { get; set; }

        public CommonMediaType? image { get; set; }

        public CommonMediaType? video { get; set; }

        public CommonMediaType? file { get; set; }

        public CommonMediaType? pdf { get; set; }

        public Embed? bookmark { get; set; }

        public Equation? equation { get; set; }

        public object? divider { get; set; }

        public TableOfContents? table_of_contents { get; set; }

        public object? breadcrumb { get; set; }

        public Column? column_list { get; set; }

        public Column? column { get; set; }

        public Embed? link_preview { get; set; }

        public Template? template { get; set; }

        public LinkToPage? link_to_page { get; set; }

        public SyncedBlock? synced_block { get; set; }

        public Table? table { get; set; }
    }
}
