using Newtonsoft.Json;
using JsonSubTypes;
using NotionAPIBlazor.Shared.Notion.Models.Common.Parent;

namespace NotionAPIBlazor.Shared.Notion.Models.Databases
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(PageParent), ParentType.PageId)]
    [JsonSubtypes.KnownSubType(typeof(BlockParent), ParentType.BlockId)]
    [JsonSubtypes.KnownSubType(typeof(WorkSpaceParent), ParentType.Workspace)]
    public interface IDatabaseParent : IParent
    {
    }
}
