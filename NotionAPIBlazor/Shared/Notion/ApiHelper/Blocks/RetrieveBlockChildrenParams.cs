
using NotionAPIBlazor.Shared.Notion.ApiHelper.Interfaces;
using NotionAPIBlazor.Shared.Notion.Models.Blocks;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Blocks
{
    public class RetrieveBlockChildrenParams : IQueryParams
    {
        public string? StartCursor { get; set; }
        public int? PageSize { get; set; }
    }

    public class RetrieveBlockChildrenType
    {
        public string BlockID { get; set; }

        public RetrieveBlockChildrenParams? Data { get; set; } = null;

        public BlockPaginated<Block> ReturnData { get; set; }
    }
}
