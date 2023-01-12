using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace NotionAPIBlazor.Shared.Notion.Models.Common.RichText
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
