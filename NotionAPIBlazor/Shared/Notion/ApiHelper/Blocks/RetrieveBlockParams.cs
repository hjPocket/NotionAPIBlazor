
using NotionAPIBlazor.Shared.Notion.Models.Blocks;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Blocks
{
    public class RetrieveBlockParams
    {

    }

    public class RetrieveBlockType
    {
        public string BlockID { get; set; }

        public Block ReturnData { get; set; }
    }
}
