using System.Runtime.Serialization;

namespace NotionAPIBlazor.Shared.Notion.Models.Common.File
{
    public enum FileObjectValue
    {
        [EnumMember(Value = "external")]
        External,

        [EnumMember(Value = "file")]
        File
    }
}
