using System.Runtime.Serialization;

namespace NotionAPIBlazor.Server.Notion.Models.Common.File
{
    public enum FileObjectValue
    {
        [EnumMember(Value = "external")]
        External,

        [EnumMember(Value = "file")]
        File
    }
}
