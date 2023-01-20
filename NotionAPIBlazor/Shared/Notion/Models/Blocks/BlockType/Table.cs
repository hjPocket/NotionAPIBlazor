
using NotionAPIBlazor.Shared.Notion.Models.Common.RichText;

namespace NotionAPIBlazor.Shared.Notion.Models.Blocks.BlockType
{
    public class Table
    {
        public int table_width { get; set; }

        public bool has_column_header { get; set; }

        public bool has_row_header { get; set; }

        public List<TableRow> children { get; set; }
    }

    public class TableRow
    {
        public List<List<RichText>> cells { get; set; }
    }
}
