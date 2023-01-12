using System.Runtime.Serialization;

namespace NotionAPIBlazor.Shared.Notion.Models.Sort
{
    public enum Timestamp
    {
        [EnumMember(Value = null)]
        Unknown,

        [EnumMember(Value = "created_time")]
        CreatedTime,

        [EnumMember(Value = "last_edited_time")]
        LastEditedTime
    }
}
