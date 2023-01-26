
using NotionAPIBlazor.Shared.Notion.Models.Common.Parent;
using NotionAPIBlazor.Shared.Notion.Models.User;

namespace NotionAPIBlazor.Shared.Notion.Models.Blocks
{
    public class Block : BlockObject
    {
        public string @object { get; set; }

        public string id { get; set; }

        public ParentObject? parent { get; set; }

        public string? type { get; set; }

        public string? created_time { get; set; }

        public PartialUser? created_by { get; set; }

        public string? last_edited_time { get; set; }

        public PartialUser? last_edited_by { get; set; }

        public bool? archived { get; set; }

        public bool? has_children { get; set; }
    }
}
