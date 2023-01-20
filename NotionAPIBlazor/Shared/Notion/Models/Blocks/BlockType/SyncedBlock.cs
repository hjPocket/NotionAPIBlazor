
namespace NotionAPIBlazor.Shared.Notion.Models.Blocks.BlockType
{
    public class SyncedBlock
    {
        public SyncedFrom synced_from { get; set; } = null;

        public List<Block> children { get; set; }
    }

    public class SyncedFrom
    {
        public string type { get; set; }

        public string block_id { get; set; }
    }
}
