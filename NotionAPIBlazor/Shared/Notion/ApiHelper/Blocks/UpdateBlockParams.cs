
using NotionAPIBlazor.Shared.Notion.Models.Blocks;

namespace NotionAPIBlazor.Shared.Notion.ApiHelper.Blocks
{
    public class UpdateBlockParams : BlockObject
    {
        public bool Archived { get; set; }
    }

    public class UpdateBlockType
    {
        public string BlockID { get; set; }

        public UpdateBlockParams Data { get; set; }

        public Block ReturnData { get; set; }
    }
}
