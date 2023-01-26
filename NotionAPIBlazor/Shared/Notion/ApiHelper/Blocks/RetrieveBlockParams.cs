
using NotionAPIBlazor.Shared.Notion.ApiHelper.Blocks.Interfaces;
using NotionAPIBlazor.Shared.Notion.Models.Blocks;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Blocks
{
    public class RetrieveBlockParams : IRetrieveBlockParams
    {

    }

    public class RetrieveBlockType
    {
        public string BlockID { get; set; }

        public Block ReturnData { get; set; }
    }
}
