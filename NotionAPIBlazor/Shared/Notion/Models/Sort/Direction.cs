using System.Runtime.Serialization;

namespace NotionAPIBlazor.Shared.Notion.Models.Sort
{
    public enum Direction
    {
        [EnumMember(Value = null)]
        Unknown,

        [EnumMember(Value = "ascending")]
        Ascending,

        [EnumMember(Value = "descending")]
        Descending,
    }
}
