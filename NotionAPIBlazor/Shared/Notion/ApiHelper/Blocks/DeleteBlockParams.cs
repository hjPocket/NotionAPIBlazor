
using NotionAPIBlazor.Shared.Notion.Models.Blocks;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Blocks
{
    public class DeleteBlockParams
    {
    }

    public class DeleteBlockType
    {
        public string BlockID { get; set; }

        public Block ReturnData { get; set; }
    }
}
