using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace NotionAPIBlazor.Server.Notion.Models.Common.RichText
{
    [SuppressMessage("LangCodeNodeAPI", "UnusedMember.Global")]
    public enum RichTextType
    {
        [EnumMember(Value = "text")]
        Text,

        [EnumMember(Value = "mention")]
        Mention,

        [EnumMember(Value = "equation")]
        Equation
    }
}
